namespace Diplom.Forms
{
    partial class ChartsForm
    {
        private System.ComponentModel.IContainer components = null;
        private OxyPlot.WindowsForms.PlotView plotLvsC;
        private OxyPlot.WindowsForms.PlotView plotPRejectVsC;
        private OxyPlot.WindowsForms.PlotView plotWvsLambda;
        private OxyPlot.WindowsForms.PlotView plotProfitVsC;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;

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
            this.plotProfitVsC = new OxyPlot.WindowsForms.PlotView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
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

            // plotLvsC (Левый верхний)
            this.plotLvsC.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.plotLvsC.Location = new System.Drawing.Point(12, 60);
            this.plotLvsC.Name = "plotLvsC";
            this.plotLvsC.Size = new System.Drawing.Size(480, 320);
            this.plotLvsC.TabIndex = 2;

            // plotPRejectVsC (Правый верхний)
            this.plotPRejectVsC.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.plotPRejectVsC.Location = new System.Drawing.Point(508, 60);
            this.plotPRejectVsC.Name = "plotPRejectVsC";
            this.plotPRejectVsC.Size = new System.Drawing.Size(480, 320);
            this.plotPRejectVsC.TabIndex = 3;

            // plotWvsLambda (Левый нижний)
            this.plotWvsLambda.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.plotWvsLambda.Location = new System.Drawing.Point(12, 390);
            this.plotWvsLambda.Name = "plotWvsLambda";
            this.plotWvsLambda.Size = new System.Drawing.Size(480, 320);
            this.plotWvsLambda.TabIndex = 4;

            // plotProfitVsC (Правый нижний - НОВЫЙ)
            this.plotProfitVsC.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.plotProfitVsC.Location = new System.Drawing.Point(508, 390);
            this.plotProfitVsC.Name = "plotProfitVsC";
            this.plotProfitVsC.Size = new System.Drawing.Size(480, 320);
            this.plotProfitVsC.TabIndex = 5;

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.btnClose.Location = new System.Drawing.Point(888, 720);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // ChartsForm
            this.BackColor = System.Drawing.Color.FromArgb(253, 245, 230);
            this.ClientSize = new System.Drawing.Size(1000, 765);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.plotProfitVsC);
            this.Controls.Add(this.plotWvsLambda);
            this.Controls.Add(this.plotPRejectVsC);
            this.Controls.Add(this.plotLvsC);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аналитика - Графики";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}