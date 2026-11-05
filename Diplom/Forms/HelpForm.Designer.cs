namespace Diplom.Forms
{
    partial class HelpForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.Label lblLambdaDesc;
        private System.Windows.Forms.Label lblMu;
        private System.Windows.Forms.Label lblMuDesc;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblCDesc;
        private System.Windows.Forms.Label lblRho;
        private System.Windows.Forms.Label lblRhoDesc;
        private System.Windows.Forms.Label lblP0;
        private System.Windows.Forms.Label lblP0Desc;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblLDesc;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblWDesc;
        private System.Windows.Forms.Label lblLq;
        private System.Windows.Forms.Label lblLqDesc;
        private System.Windows.Forms.Label lblWq;
        private System.Windows.Forms.Label lblWqDesc;
        private System.Windows.Forms.Label lblPReject;
        private System.Windows.Forms.Label lblPRejectDesc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;

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
            this.lblLambda = new System.Windows.Forms.Label();
            this.lblLambdaDesc = new System.Windows.Forms.Label();
            this.lblMu = new System.Windows.Forms.Label();
            this.lblMuDesc = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblCDesc = new System.Windows.Forms.Label();
            this.lblRho = new System.Windows.Forms.Label();
            this.lblRhoDesc = new System.Windows.Forms.Label();
            this.lblP0 = new System.Windows.Forms.Label();
            this.lblP0Desc = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblLDesc = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblWDesc = new System.Windows.Forms.Label();
            this.lblLq = new System.Windows.Forms.Label();
            this.lblLqDesc = new System.Windows.Forms.Label();
            this.lblWq = new System.Windows.Forms.Label();
            this.lblWqDesc = new System.Windows.Forms.Label();
            this.lblPReject = new System.Windows.Forms.Label();
            this.lblPRejectDesc = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 50);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Справка по модели M/M/c";

            // lblLambda
            this.lblLambda.AutoSize = true;
            this.lblLambda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLambda.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblLambda.Location = new System.Drawing.Point(20, 70);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(21, 19);
            this.lblLambda.TabIndex = 1;
            this.lblLambda.Text = "λ:";

            // lblLambdaDesc
            this.lblLambdaDesc.AutoSize = true;
            this.lblLambdaDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLambdaDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblLambdaDesc.Location = new System.Drawing.Point(120, 72);
            this.lblLambdaDesc.Name = "lblLambdaDesc";
            this.lblLambdaDesc.Size = new System.Drawing.Size(380, 15);
            this.lblLambdaDesc.TabIndex = 2;
            this.lblLambdaDesc.Text = "Интенсивность бронирований (сколько заявок поступает в день)";

            // lblMu
            this.lblMu.AutoSize = true;
            this.lblMu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMu.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblMu.Location = new System.Drawing.Point(20, 100);
            this.lblMu.Name = "lblMu";
            this.lblMu.Size = new System.Drawing.Size(28, 19);
            this.lblMu.TabIndex = 3;
            this.lblMu.Text = "μ:";

            // lblMuDesc
            this.lblMuDesc.AutoSize = true;
            this.lblMuDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMuDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblMuDesc.Location = new System.Drawing.Point(120, 102);
            this.lblMuDesc.Name = "lblMuDesc";
            this.lblMuDesc.Size = new System.Drawing.Size(395, 15);
            this.lblMuDesc.TabIndex = 4;
            this.lblMuDesc.Text = "Интенсивность обслуживания (сколько номеров освобождается в день)";

            // lblC
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblC.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblC.Location = new System.Drawing.Point(20, 130);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(19, 19);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "c:";

            // lblCDesc
            this.lblCDesc.AutoSize = true;
            this.lblCDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblCDesc.Location = new System.Drawing.Point(120, 132);
            this.lblCDesc.Name = "lblCDesc";
            this.lblCDesc.Size = new System.Drawing.Size(224, 15);
            this.lblCDesc.TabIndex = 6;
            this.lblCDesc.Text = "Количество номеров в отеле (каналов)";

            // lblRho
            this.lblRho.AutoSize = true;
            this.lblRho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRho.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblRho.Location = new System.Drawing.Point(20, 170);
            this.lblRho.Name = "lblRho";
            this.lblRho.Size = new System.Drawing.Size(26, 19);
            this.lblRho.TabIndex = 7;
            this.lblRho.Text = "ρ:";

            // lblRhoDesc
            this.lblRhoDesc.AutoSize = true;
            this.lblRhoDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRhoDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblRhoDesc.Location = new System.Drawing.Point(120, 172);
            this.lblRhoDesc.Name = "lblRhoDesc";
            this.lblRhoDesc.Size = new System.Drawing.Size(404, 15);
            this.lblRhoDesc.TabIndex = 8;
            this.lblRhoDesc.Text = "Коэффициент загрузки (если > 1 — очередь будет расти бесконечно)";

            // lblP0
            this.lblP0.AutoSize = true;
            this.lblP0.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblP0.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblP0.Location = new System.Drawing.Point(20, 200);
            this.lblP0.Name = "lblP0";
            this.lblP0.Size = new System.Drawing.Size(31, 19);
            this.lblP0.TabIndex = 9;
            this.lblP0.Text = "P₀:";

            // lblP0Desc
            this.lblP0Desc.AutoSize = true;
            this.lblP0Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblP0Desc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblP0Desc.Location = new System.Drawing.Point(120, 202);
            this.lblP0Desc.Name = "lblP0Desc";
            this.lblP0Desc.Size = new System.Drawing.Size(391, 15);
            this.lblP0Desc.TabIndex = 10;
            this.lblP0Desc.Text = "Вероятность того, что все номера свободны (0% до 100%)";

            // lblL
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblL.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblL.Location = new System.Drawing.Point(20, 230);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(21, 19);
            this.lblL.TabIndex = 11;
            this.lblL.Text = "L:";

            // lblLDesc
            this.lblLDesc.AutoSize = true;
            this.lblLDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblLDesc.Location = new System.Drawing.Point(120, 232);
            this.lblLDesc.Name = "lblLDesc";
            this.lblLDesc.Size = new System.Drawing.Size(338, 15);
            this.lblLDesc.TabIndex = 12;
            this.lblLDesc.Text = "Среднее количество гостей в отеле (в номерах + в очереди)";

            // lblW
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblW.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblW.Location = new System.Drawing.Point(20, 260);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(28, 19);
            this.lblW.TabIndex = 13;
            this.lblW.Text = "W:";

            // lblWDesc
            this.lblWDesc.AutoSize = true;
            this.lblWDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblWDesc.Location = new System.Drawing.Point(120, 262);
            this.lblWDesc.Name = "lblWDesc";
            this.lblWDesc.Size = new System.Drawing.Size(426, 15);
            this.lblWDesc.TabIndex = 14;
            this.lblWDesc.Text = "Среднее время от бронирования до выселения (включая ожидание)";

            // lblLq
            this.lblLq.AutoSize = true;
            this.lblLq.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLq.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblLq.Location = new System.Drawing.Point(20, 290);
            this.lblLq.Name = "lblLq";
            this.lblLq.Size = new System.Drawing.Size(31, 19);
            this.lblLq.TabIndex = 15;
            this.lblLq.Text = "Lq:";

            // lblLqDesc
            this.lblLqDesc.AutoSize = true;
            this.lblLqDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLqDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblLqDesc.Location = new System.Drawing.Point(120, 292);
            this.lblLqDesc.Name = "lblLqDesc";
            this.lblLqDesc.Size = new System.Drawing.Size(426, 15);
            this.lblLqDesc.TabIndex = 16;
            this.lblLqDesc.Text = "Среднее количество гостей, ожидающих свободный номер (очередь)";

            // lblWq
            this.lblWq.AutoSize = true;
            this.lblWq.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWq.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblWq.Location = new System.Drawing.Point(20, 320);
            this.lblWq.Name = "lblWq";
            this.lblWq.Size = new System.Drawing.Size(38, 19);
            this.lblWq.TabIndex = 17;
            this.lblWq.Text = "Wq:";

            // lblWqDesc
            this.lblWqDesc.AutoSize = true;
            this.lblWqDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWqDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblWqDesc.Location = new System.Drawing.Point(120, 322);
            this.lblWqDesc.Name = "lblWqDesc";
            this.lblWqDesc.Size = new System.Drawing.Size(390, 15);
            this.lblWqDesc.TabIndex = 18;
            this.lblWqDesc.Text = "Среднее время ожидания свободного номера (если все заняты)";

            // lblPReject
            this.lblPReject.AutoSize = true;
            this.lblPReject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPReject.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblPReject.Location = new System.Drawing.Point(20, 350);
            this.lblPReject.Name = "lblPReject";
            this.lblPReject.Size = new System.Drawing.Size(52, 19);
            this.lblPReject.TabIndex = 19;
            this.lblPReject.Text = "Pотк:";

            // lblPRejectDesc
            this.lblPRejectDesc.AutoSize = true;
            this.lblPRejectDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPRejectDesc.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblPRejectDesc.Location = new System.Drawing.Point(120, 352);
            this.lblPRejectDesc.Name = "lblPRejectDesc";
            this.lblPRejectDesc.Size = new System.Drawing.Size(392, 15);
            this.lblPRejectDesc.TabIndex = 20;
            this.lblPRejectDesc.Text = "Вероятность отказа (клиент не может забронировать номер)";

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.btnClose.Location = new System.Drawing.Point(480, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // HelpForm
            this.BackColor = System.Drawing.Color.FromArgb(253, 245, 230);
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPRejectDesc);
            this.Controls.Add(this.lblPReject);
            this.Controls.Add(this.lblWqDesc);
            this.Controls.Add(this.lblWq);
            this.Controls.Add(this.lblLqDesc);
            this.Controls.Add(this.lblLq);
            this.Controls.Add(this.lblWDesc);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblLDesc);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblP0Desc);
            this.Controls.Add(this.lblP0);
            this.Controls.Add(this.lblRhoDesc);
            this.Controls.Add(this.lblRho);
            this.Controls.Add(this.lblCDesc);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblMuDesc);
            this.Controls.Add(this.lblMu);
            this.Controls.Add(this.lblLambdaDesc);
            this.Controls.Add(this.lblLambda);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справка";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}