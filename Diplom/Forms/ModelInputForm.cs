using System;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class ModelInputForm : Form
    {
        private readonly MmcCalculator _calculator;

        public ModelInputForm()
        {
            InitializeComponent();
            _calculator = new MmcCalculator();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtLambda.Text, out double lambda) || lambda <= 0)
                {
                    MessageBox.Show("Введите корректное значение λ (положительное число)", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtMu.Text, out double mu) || mu <= 0)
                {
                    MessageBox.Show("Введите корректное значение μ (положительное число)", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtC.Text, out int c) || c <= 0)
                {
                    MessageBox.Show("Введите корректное значение c (положительное целое число)", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var inputModel = new QueueModel { Lambda = lambda, Mu = mu, C = c };
                var result = _calculator.Calculate(inputModel);

                DataStore.LastLambda = lambda;
                DataStore.LastMu = mu;
                DataStore.LastC = c;

                DisplayResults(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расчёте: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResults(QueueModel result)
        {
            var invariant = System.Globalization.CultureInfo.InvariantCulture;

            lblRhoValue.Text = result.Rho.ToString("0.0000", invariant);

            if (!result.IsStable)
            {
                lblStabilityValue.Text = "⚠️ НЕСТАБИЛЬНА (ρ ≥ 1)";
                lblStabilityValue.ForeColor = System.Drawing.Color.FromArgb(220, 20, 60);
                lblP0Value.Text = "—";
                lblLValue.Text = "—";
                lblWValue.Text = "—";
                lblLqValue.Text = "—";
                lblWqValue.Text = "—";
                lblPRejectValue.Text = "—";
                return;
            }

            lblStabilityValue.Text = "✅ СТАБИЛЬНА";
            lblStabilityValue.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);

            lblP0Value.Text = result.P0.ToString();
            lblLValue.Text = result.L.ToString("0.00", invariant);
            lblWValue.Text = $"{result.W.ToString("0.00", invariant)} дн. ({(result.W * 24).ToString("0.0", invariant)} ч.)";
            lblLqValue.Text = result.Lq.ToString("0.00", invariant);
            lblWqValue.Text = $"{result.Wq.ToString("0.00", invariant)} дн. ({(result.Wq * 24).ToString("0.0", invariant)} ч.)";
            lblPRejectValue.Text = (result.P_reject * 100).ToString("0.00", invariant) + "%";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtLambda.Clear();
            txtMu.Clear();
            txtC.Clear();

            lblRhoValue.Text = "—";
            lblStabilityValue.Text = "—";
            lblP0Value.Text = "—";
            lblLValue.Text = "—";
            lblWValue.Text = "—";
            lblLqValue.Text = "—";
            lblWqValue.Text = "—";
            lblPRejectValue.Text = "—";

            txtLambda.Focus();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}