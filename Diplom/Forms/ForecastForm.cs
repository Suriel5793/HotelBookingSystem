using System;
using System.Linq;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class ForecastForm : Form
    {
        private MmcCalculator _calculator;
        private RecommendationService _recommendationService;
        private DatabaseService _db;
        private double _realLambda;
        private double _realMu;
        private int _realC;
        private double _factorsImpact;
        private double _adjustedLambda;

        public ForecastForm()
        {
            InitializeComponent();
            _calculator = new MmcCalculator();
            _recommendationService = new RecommendationService();
            _db = new DatabaseService();

            LoadRealData();
            LoadForecast();
        }

        private void LoadRealData()
        {
            _realLambda = _db.CalculateRealLambda();
            if (_realLambda <= 0) _realLambda = 5.87;

            _factorsImpact = _db.GetFactorsImpact(DateTime.Now.AddDays(7));
            _adjustedLambda = _realLambda * _factorsImpact;

            _realMu = _db.CalculateRealMu();
            if (_realMu <= 0) _realMu = 0.5;

            _realC = _db.GetRealRoomCount();
            if (_realC <= 0) _realC = 10;

            ShowFactorsInfo();
        }

        private void ShowFactorsInfo()
        {
            var activeFactors = _db.GetActiveFactors(DateTime.Now.AddDays(7));

            if (activeFactors.Count > 0 && _factorsImpact != 1.0)
            {
                string factorsText = "📊 Влияние внешних факторов:\n";
                foreach (var f in activeFactors)
                {
                    double impactPercent = (double)(f.ImpactCoefficient - 1) * 100;
                    string arrow = impactPercent > 0 ? "↑" : "↓";
                    factorsText += $"  {arrow} {f.Type}: {f.Value} — влияние {impactPercent:+0;-0;0}%\n";
                }
                factorsText += $"\n📈 Итоговый коэффициент влияния: {_factorsImpact:F2}";
                factorsText += $"\n📊 Скорректированный спрос: λ = {_realLambda:F2} → {_adjustedLambda:F2}";

                MessageBox.Show(factorsText, "Внешние факторы учтены в прогнозе",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadForecast()
        {
            lblCurrentParams.Text = $"λ = {_adjustedLambda:F2} (с учётом факторов: {_factorsImpact:F2}×), μ = {_realMu:F2}, c = {_realC}";

            var input = new QueueModel { Lambda = _adjustedLambda, Mu = _realMu, C = _realC };
            var result = _calculator.Calculate(input);

            if (!result.IsStable)
            {
                lblForecast.Text = "⚠️ СИСТЕМА НЕСТАБИЛЬНА!";
                lblForecast.ForeColor = System.Drawing.Color.FromArgb(220, 20, 60);

                var recommendations = _recommendationService.GenerateRecommendations(result, _adjustedLambda, _realMu, _realC);

                if (_factorsImpact > 1.2)
                {
                    recommendations.Add("\n📢 Рекомендация по внешним факторам:");
                    recommendations.Add("  • В ближайшее время ожидается повышенный спрос из-за событий/праздников");
                    recommendations.Add("  • Рекомендуется временно повысить цены на 15-20%");
                }
                else if (_factorsImpact < 0.8)
                {
                    recommendations.Add("\n📢 Рекомендация по внешним факторам:");
                    recommendations.Add("  • Ожидается снижение спроса (погода/сезон)");
                    recommendations.Add("  • Рекомендуется запустить акции и скидки");
                }

                lblRecommendations.Text = string.Join("\n", recommendations);
                lblRevenue.Text = "—";
                return;
            }

            double occupancyRate = (1 - result.P_reject) * 100;
            lblForecast.Text = $"Прогноз загрузки: {occupancyRate:F1}% (с учётом внешних факторов)";
            lblForecast.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);

            decimal avgPrice = GetAveragePrice();
            decimal expectedRevenue = _recommendationService.ForecastRevenue(_adjustedLambda, result.P_reject, avgPrice);
            lblRevenue.Text = $"{expectedRevenue:C0}";

            var recommendationsList = _recommendationService.GenerateRecommendations(result, _adjustedLambda, _realMu, _realC);

            if (_factorsImpact > 1.2)
            {
                recommendationsList.Add("\n📢 Учитывая внешние факторы (повышенный спрос):");
                recommendationsList.Add("  • Рекомендуется временно повысить цены на 15-20%");
                recommendationsList.Add("  • Включите динамическое ценообразование");
            }
            else if (_factorsImpact < 0.8)
            {
                recommendationsList.Add("\n📢 Учитывая внешние факторы (снижение спроса):");
                recommendationsList.Add("  • Рекомендуется запустить акции и скидки");
                recommendationsList.Add("  • Рассмотрите программы лояльности");
            }

            lblRecommendations.Text = string.Join("\n\n", recommendationsList);
        }

        private decimal GetAveragePrice()
        {
            try
            {
                var rooms = _db.GetAllRooms();
                if (rooms.Count > 0)
                    return rooms.Average(r => r.BasePricePerNight);
            }
            catch { }
            return 4000m;
        }

        private void BtnFindOptimalC_Click(object sender, EventArgs e)
        {
            int optimalC = _recommendationService.FindMinCForPReject(_adjustedLambda, _realMu, 0.05);

            if (optimalC > 0)
            {
                string message = $"Оптимальное количество номеров при Pотк ≤ 5%: {optimalC}\n\n" +
                                 $"Текущее количество: {_realC}\n" +
                                 $"С учётом внешних факторов λ = {_adjustedLambda:F2}\n\n";

                if (optimalC > _realC)
                    message += $"📈 Рекомендуется добавить {optimalC - _realC} номеров";
                else if (optimalC < _realC)
                    message += $"📉 Количество номеров можно уменьшить на {_realC - optimalC}";
                else
                    message += $"✓ Текущее количество оптимально";

                MessageBox.Show(message, "Рекомендация по количеству номеров",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не удалось найти оптимальное количество номеров.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
            LoadForecast();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}