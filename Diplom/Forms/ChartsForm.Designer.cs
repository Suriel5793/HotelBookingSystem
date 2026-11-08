namespace Diplom.Forms
{
    partial class ChartsForm
    {
        private System.ComponentModel.IContainer components = null;
        private OxyPlot.WindowsForms.PlotView plotLvsC;
        private OxyPlot.WindowsForms.PlotView plotPRejectVsC;
        private OxyPlot.WindowsForms.PlotView plotWvsLambda;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblChart1Title;
        private System.Windows.Forms.Label lblChart2Title;
        private System.Windows.Forms.Label lblChart3Title;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.plotLvsC = new OxyPlot.WindowsForms.PlotView();
            this.plotPRejectVsC = new OxyPlot.WindowsForms.PlotView();
            this.plotWvsLambda = new OxyPlot.WindowsForms.PlotView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblChart1Title = new System.Windows.Forms.Label();
            this.lblChart2Title = new System.Windows.Forms.Label();
            this.lblChart3Title = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 50);
            this.pnlHeader.TabIndex = 0;

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(288, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Визуализация зависимости показателей";

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(253, 245, 230);
            this.pnlTop.Controls.Add(this.lblChart1Title);
            this.pnlTop.Controls.Add(this.lblChart2Title);
            this.pnlTop.Controls.Add(this.lblChart3Title);
            this.pnlTop.Location = new System.Drawing.Point(0, 50);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 30);
            this.pnlTop.TabIndex = 1;

            // lblChart1Title
            this.lblChart1Title.AutoSize = true;
            this.lblChart1Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChart1Title.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblChart1Title.Location = new System.Drawing.Point(200, 8);
            this.lblChart1Title.Name = "lblChart1Title";
            this.lblChart1Title.Size = new System.Drawing.Size(134, 15);
            this.lblChart1Title.TabIndex = 0;
            this.lblChart1Title.Text = "L(c) — среднее число заявок";

            // lblChart2Title
            this.lblChart2Title.AutoSize = true;
            this.lblChart2Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChart2Title.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblChart2Title.Location = new System.Drawing.Point(600, 8);
            this.lblChart2Title.Name = "lblChart2Title";
            this.lblChart2Title.Size = new System.Drawing.Size(185, 15);
            this.lblChart2Title.TabIndex = 1;
            this.lblChart2Title.Text = "Pотк(c) — вероятность отказа (%)";

            // lblChart3Title
            this.lblChart3Title.AutoSize = true;
            this.lblChart3Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChart3Title.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblChart3Title.Location = new System.Drawing.Point(420, 8);
            this.lblChart3Title.Name = "lblChart3Title";
            this.lblChart3Title.Size = new System.Drawing.Size(219, 15);
            this.lblChart3Title.TabIndex = 2;
            this.lblChart3Title.Text = "W(λ) — среднее время в системе (часы)";

            // plotLvsC
            this.plotLvsC.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.plotLvsC.Location = new System.Drawing.Point(20, 85);
            this.plotLvsC.Name = "plotLvsC";
            this.plotLvsC.Size = new System.Drawing.Size(460, 300);
            this.plotLvsC.TabIndex = 2;

            // plotPRejectVsC
            this.plotPRejectVsC.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.plotPRejectVsC.Location = new System.Drawing.Point(520, 85);
            this.plotPRejectVsC.Name = "plotPRejectVsC";
            this.plotPRejectVsC.Size = new System.Drawing.Size(460, 300);
            this.plotPRejectVsC.TabIndex = 3;

            // plotWvsLambda
            this.plotWvsLambda.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.plotWvsLambda.Location = new System.Drawing.Point(20, 410);
            this.plotWvsLambda.Name = "plotWvsLambda";
            this.plotWvsLambda.Size = new System.Drawing.Size(960, 300);
            this.plotWvsLambda.TabIndex = 4;

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.btnClose.Location = new System.Drawing.Point(880, 730);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // ChartsForm
            this.BackColor = System.Drawing.Color.FromArgb(253, 245, 230);
            this.ClientSize = new System.Drawing.Size(1000, 780);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.plotWvsLambda);
            this.Controls.Add(this.plotPRejectVsC);
            this.Controls.Add(this.plotLvsC);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аналитика - Графики";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}