namespace Diplom.Forms
{
    partial class ForecastForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentParams;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblRecommendationsTitle;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.Button btnFindOptimalC;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpParams;
        private System.Windows.Forms.GroupBox grpForecast;
        private System.Windows.Forms.GroupBox grpRecommendations;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpParams = new System.Windows.Forms.GroupBox();
            this.lblCurrentParams = new System.Windows.Forms.Label();
            this.grpForecast = new System.Windows.Forms.GroupBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.lblForecast = new System.Windows.Forms.Label();
            this.grpRecommendations = new System.Windows.Forms.GroupBox();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.lblRecommendationsTitle = new System.Windows.Forms.Label();
            this.btnFindOptimalC = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpParams.SuspendLayout();
            this.grpForecast.SuspendLayout();
            this.grpRecommendations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(750, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Прогноз загрузки и рекомендации";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.pnlContent.Controls.Add(this.grpParams);
            this.pnlContent.Controls.Add(this.grpForecast);
            this.pnlContent.Controls.Add(this.grpRecommendations);
            this.pnlContent.Controls.Add(this.btnFindOptimalC);
            this.pnlContent.Controls.Add(this.btnRefresh);
            this.pnlContent.Controls.Add(this.btnClose);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(750, 500);
            this.pnlContent.TabIndex = 1;
            // 
            // grpParams
            // 
            this.grpParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.grpParams.Controls.Add(this.lblCurrentParams);
            this.grpParams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.grpParams.Location = new System.Drawing.Point(20, 15);
            this.grpParams.Name = "grpParams";
            this.grpParams.Size = new System.Drawing.Size(710, 60);
            this.grpParams.TabIndex = 0;
            this.grpParams.TabStop = false;
            this.grpParams.Text = "Текущие параметры";
            // 
            // lblCurrentParams
            // 
            this.lblCurrentParams.AutoSize = true;
            this.lblCurrentParams.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblCurrentParams.Location = new System.Drawing.Point(15, 25);
            this.lblCurrentParams.Name = "lblCurrentParams";
            this.lblCurrentParams.Size = new System.Drawing.Size(157, 19);
            this.lblCurrentParams.TabIndex = 0;
            this.lblCurrentParams.Text = "λ = 45, μ = 0.5, c = 100";
            // 
            // grpForecast
            // 
            this.grpForecast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.grpForecast.Controls.Add(this.lblRevenue);
            this.grpForecast.Controls.Add(this.lblRevenueTitle);
            this.grpForecast.Controls.Add(this.lblForecast);
            this.grpForecast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpForecast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.grpForecast.Location = new System.Drawing.Point(20, 85);
            this.grpForecast.Name = "grpForecast";
            this.grpForecast.Size = new System.Drawing.Size(710, 100);
            this.grpForecast.TabIndex = 1;
            this.grpForecast.TabStop = false;
            this.grpForecast.Text = "Прогноз";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblRevenue.Location = new System.Drawing.Point(158, 58);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(57, 19);
            this.lblRevenue.TabIndex = 2;
            this.lblRevenue.Text = "— руб.";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(15, 58);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(138, 19);
            this.lblRevenueTitle.TabIndex = 1;
            this.lblRevenueTitle.Text = "Прогноз выручки:";
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblForecast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblForecast.Location = new System.Drawing.Point(15, 28);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(175, 21);
            this.lblForecast.TabIndex = 0;
            this.lblForecast.Text = "Прогноз загрузки: —";
            // 
            // grpRecommendations
            // 
            this.grpRecommendations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.grpRecommendations.Controls.Add(this.lblRecommendations);
            this.grpRecommendations.Controls.Add(this.lblRecommendationsTitle);
            this.grpRecommendations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpRecommendations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.grpRecommendations.Location = new System.Drawing.Point(20, 195);
            this.grpRecommendations.Name = "grpRecommendations";
            this.grpRecommendations.Size = new System.Drawing.Size(710, 200);
            this.grpRecommendations.TabIndex = 2;
            this.grpRecommendations.TabStop = false;
            this.grpRecommendations.Text = "Рекомендации";
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecommendations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblRecommendations.Location = new System.Drawing.Point(15, 50);
            this.lblRecommendations.MaximumSize = new System.Drawing.Size(680, 0);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(0, 15);
            this.lblRecommendations.TabIndex = 1;
            // 
            // lblRecommendationsTitle
            // 
            this.lblRecommendationsTitle.AutoSize = true;
            this.lblRecommendationsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecommendationsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblRecommendationsTitle.Location = new System.Drawing.Point(15, 25);
            this.lblRecommendationsTitle.Name = "lblRecommendationsTitle";
            this.lblRecommendationsTitle.Size = new System.Drawing.Size(91, 15);
            this.lblRecommendationsTitle.TabIndex = 0;
            this.lblRecommendationsTitle.Text = "Рекомендации:";
            // 
            // btnFindOptimalC
            // 
            this.btnFindOptimalC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnFindOptimalC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindOptimalC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindOptimalC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFindOptimalC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnFindOptimalC.Location = new System.Drawing.Point(20, 415);
            this.btnFindOptimalC.Name = "btnFindOptimalC";
            this.btnFindOptimalC.Size = new System.Drawing.Size(276, 35);
            this.btnFindOptimalC.TabIndex = 3;
            this.btnFindOptimalC.Text = "🔍 Найти оптимальное количество номеров";
            this.btnFindOptimalC.UseVisualStyleBackColor = false;
            this.btnFindOptimalC.Click += new System.EventHandler(this.BtnFindOptimalC_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnRefresh.Location = new System.Drawing.Point(313, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄 Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnClose.Location = new System.Drawing.Point(630, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ForecastForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ForecastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Прогнозы и рекомендации";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.grpParams.ResumeLayout(false);
            this.grpParams.PerformLayout();
            this.grpForecast.ResumeLayout(false);
            this.grpForecast.PerformLayout();
            this.grpRecommendations.ResumeLayout(false);
            this.grpRecommendations.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}