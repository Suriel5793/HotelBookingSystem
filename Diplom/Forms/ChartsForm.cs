using System;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using Diplom.Models;
using Diplom.Services;
using OxyPlot.Annotations;

namespace Diplom.Forms
{
    public partial class ChartsForm : Form
    {
        private MmcCalculator _calculator;
        private DatabaseService _db;
        private double _realLambda;
        private double _realMu;
        private int _realC;

        public ChartsForm()
        {
            InitializeComponent();
            _calculator = new MmcCalculator();
            _db = new DatabaseService();

            LoadRealData();
            LoadCharts();
        }

        private void LoadRealData()
        {
            _realLambda = _db.CalculateRealLambda(DateTime.Now.AddDays(-30), DateTime.Now);
            if (_realLambda <= 0) _realLambda = DataStore.LastLambda > 0 ? DataStore.LastLambda : 5.87;

            _realMu = _db.CalculateRealMu();
            if (_realMu <= 0) _realMu = DataStore.LastMu > 0 ? DataStore.LastMu : 0.5;

            _realC = _db.GetRealRoomCount();
            if (_realC <= 0) _realC = DataStore.LastC > 0 ? DataStore.LastC : 10;

            this.Text = $"Аналитика — Графики (λ={_realLambda:F2}, μ={_realMu:F2}, c={_realC})";
        }

        private void LoadCharts()
        {
            PlotLvsC();
            PlotPRejectVsC();
            PlotWvsLambda();
        }

        private void PlotLvsC()
        {
            int minStableC = (int)Math.Ceiling(_realLambda / _realMu) + 1;
            int startC = Math.Max(1, minStableC - 10);
            int endC = minStableC + 50;

            var model = new PlotModel
            {
                Title = "Среднее число заявок (L) в зависимости от количества номеров",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Background = OxyColor.FromRgb(253, 245, 230),
                PlotAreaBorderColor = OxyColor.FromRgb(210, 180, 140)
            };

            var series = new LineSeries
            {
                Title = "L(c)",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColor.FromRgb(139, 69, 19),
                StrokeThickness = 3,
                Color = OxyColor.FromRgb(139, 69, 19),
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };

            for (int c = startC; c <= endC; c++)
            {
                double rho = _realLambda / (c * _realMu);
                if (rho >= 1) continue;

                var input = new QueueModel { Lambda = _realLambda, Mu = _realMu, C = c };
                var result = _calculator.Calculate(input);
                series.Points.Add(new DataPoint(c, result.L));
            }
            model.Series.Add(series);

            var currentLine = new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                X = _realC,
                Color = OxyColors.IndianRed,
                LineStyle = LineStyle.Dash,
                StrokeThickness = 2,
                Text = $"Текущее c = {_realC}",
                TextHorizontalAlignment = HorizontalAlignment.Right
            };
            model.Annotations.Add(currentLine);

            var xAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Количество номеров (c)", Minimum = startC, Maximum = endC };
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Среднее число заявок (L)", Minimum = 0 };
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            plotLvsC.Model = model;
        }

        private void PlotPRejectVsC()
        {
            int minStableC = (int)Math.Ceiling(_realLambda / _realMu) + 1;
            int startC = Math.Max(1, minStableC - 10);
            int endC = minStableC + 50;

            var model = new PlotModel
            {
                Title = "Вероятность отказа (Pотк) в зависимости от количества номеров",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Background = OxyColor.FromRgb(253, 245, 230),
                PlotAreaBorderColor = OxyColor.FromRgb(210, 180, 140)
            };

            var series = new LineSeries
            {
                Title = "Pотк(c), %",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColor.FromRgb(178, 34, 34),
                StrokeThickness = 3,
                Color = OxyColor.FromRgb(178, 34, 34),
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };

            for (int c = startC; c <= endC; c++)
            {
                double rho = _realLambda / (c * _realMu);
                if (rho >= 1) continue;

                var input = new QueueModel { Lambda = _realLambda, Mu = _realMu, C = c };
                var result = _calculator.Calculate(input);
                series.Points.Add(new DataPoint(c, result.P_reject * 100));
            }
            model.Series.Add(series);

            var limitLine = new LineAnnotation
            {
                Type = LineAnnotationType.Horizontal,
                Y = 5,
                Color = OxyColors.DarkRed,
                LineStyle = LineStyle.Dot,
                StrokeThickness = 2,
                Text = "Допустимый предел 5%",
                TextHorizontalAlignment = HorizontalAlignment.Right,
                TextVerticalAlignment = VerticalAlignment.Top
            };

            model.Annotations.Add(limitLine);

            var currentLine = new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                X = _realC,
                Color = OxyColors.IndianRed,
                LineStyle = LineStyle.Dash,
                StrokeThickness = 2,
                Text = $"Текущее c = {_realC}"
                TextHorizontalAlignment = HorizontalAlignment.Right
            };
            model.Annotations.Add(currentLine);

            var xAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Количество номеров (c)", Minimum = startC, Maximum = endC };
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Вероятность отказа (%)", Minimum = 0, Maximum = 100 };
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            plotPRejectVsC.Model = model;
        }

        private void PlotWvsLambda()
        {
            var model = new PlotModel
            {
                Title = "Среднее время в системе (W) в зависимости от спроса",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Background = OxyColor.FromRgb(253, 245, 230),
                PlotAreaBorderColor = OxyColor.FromRgb(210, 180, 140)
            };

            var series = new LineSeries
            {
                Title = "W(λ), часы",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColor.FromRgb(85, 107, 47),
                StrokeThickness = 3,
                Color = OxyColor.FromRgb(85, 107, 47),
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };

            double maxLambda = _realC * _realMu * 1.2;

            for (double lambda = 0.5; lambda <= maxLambda; lambda += 0.5)
            {
                var input = new QueueModel { Lambda = lambda, Mu = _realMu, C = _realC };
                var result = _calculator.Calculate(input);
                series.Points.Add(new DataPoint(lambda, result.W * 24));
            }
            model.Series.Add(series);

            var currentLine = new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                X = _realLambda,
                Color = OxyColors.IndianRed,
                LineStyle = LineStyle.Dash,
                StrokeThickness = 2,
                Text = $"Текущее λ = {_realLambda:F2}",
                TextHorizontalAlignment = HorizontalAlignment.Right
            };
            model.Annotations.Add(currentLine);

            var xAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Интенсивность бронирований λ (заявок/день)", Minimum = 0 };
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Время в системе W (часы)", Minimum = 0 };
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MajorGridlineColor = OxyColor.FromRgb(220, 220, 220);

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            plotWvsLambda.Model = model;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}