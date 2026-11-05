namespace Diplom.Forms
{
    partial class ModelInputForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.Label lblMu;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.TextBox txtMu;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblRho;
        private System.Windows.Forms.Label lblRhoValue;
        private System.Windows.Forms.Label lblStability;
        private System.Windows.Forms.Label lblStabilityValue;
        private System.Windows.Forms.Label lblP0;
        private System.Windows.Forms.Label lblP0Value;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblLValue;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblWValue;
        private System.Windows.Forms.Label lblLq;
        private System.Windows.Forms.Label lblLqValue;
        private System.Windows.Forms.Label lblWq;
        private System.Windows.Forms.Label lblWqValue;
        private System.Windows.Forms.Label lblPReject;
        private System.Windows.Forms.Label lblPRejectValue;
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblLambda = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.lblMu = new System.Windows.Forms.Label();
            this.txtMu = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblRho = new System.Windows.Forms.Label();
            this.lblRhoValue = new System.Windows.Forms.Label();
            this.lblStability = new System.Windows.Forms.Label();
            this.lblStabilityValue = new System.Windows.Forms.Label();
            this.lblP0 = new System.Windows.Forms.Label();
            this.lblP0Value = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblLValue = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblWValue = new System.Windows.Forms.Label();
            this.lblLq = new System.Windows.Forms.Label();
            this.lblLqValue = new System.Windows.Forms.Label();
            this.lblWq = new System.Windows.Forms.Label();
            this.lblWqValue = new System.Windows.Forms.Label();
            this.lblPReject = new System.Windows.Forms.Label();
            this.lblPRejectValue = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.grpInput.Controls.Add(this.lblLambda);
            this.grpInput.Controls.Add(this.txtLambda);
            this.grpInput.Controls.Add(this.lblMu);
            this.grpInput.Controls.Add(this.txtMu);
            this.grpInput.Controls.Add(this.lblC);
            this.grpInput.Controls.Add(this.txtC);
            this.grpInput.Controls.Add(this.btnCalculate);
            this.grpInput.Controls.Add(this.btnClear);
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.grpInput.Location = new System.Drawing.Point(20, 65);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(320, 236);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Входные параметры";
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLambda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblLambda.Location = new System.Drawing.Point(11, 34);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(146, 15);
            this.lblLambda.TabIndex = 0;
            this.lblLambda.Text = "λ (бронирований в день):";
            // 
            // txtLambda
            // 
            this.txtLambda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtLambda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLambda.Location = new System.Drawing.Point(190, 32);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(110, 23);
            this.txtLambda.TabIndex = 1;
            // 
            // lblMu
            // 
            this.lblMu.AutoSize = true;
            this.lblMu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblMu.Location = new System.Drawing.Point(11, 67);
            this.lblMu.Name = "lblMu";
            this.lblMu.Size = new System.Drawing.Size(173, 15);
            this.lblMu.TabIndex = 2;
            this.lblMu.Text = "μ (выселений обслуживания):";
            // 
            // txtMu
            // 
            this.txtMu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtMu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMu.Location = new System.Drawing.Point(190, 65);
            this.txtMu.Name = "txtMu";
            this.txtMu.Size = new System.Drawing.Size(110, 23);
            this.txtMu.TabIndex = 3;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblC.Location = new System.Drawing.Point(11, 100);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(143, 15);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "c (количество номеров):";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtC.Location = new System.Drawing.Point(190, 98);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(110, 23);
            this.txtC.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnCalculate.Location = new System.Drawing.Point(20, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 40);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnClear.Location = new System.Drawing.Point(120, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // grpResults
            // 
            this.grpResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.grpResults.Controls.Add(this.lblRho);
            this.grpResults.Controls.Add(this.lblRhoValue);
            this.grpResults.Controls.Add(this.lblStability);
            this.grpResults.Controls.Add(this.lblStabilityValue);
            this.grpResults.Controls.Add(this.lblP0);
            this.grpResults.Controls.Add(this.lblP0Value);
            this.grpResults.Controls.Add(this.lblL);
            this.grpResults.Controls.Add(this.lblLValue);
            this.grpResults.Controls.Add(this.lblW);
            this.grpResults.Controls.Add(this.lblWValue);
            this.grpResults.Controls.Add(this.lblLq);
            this.grpResults.Controls.Add(this.lblLqValue);
            this.grpResults.Controls.Add(this.lblWq);
            this.grpResults.Controls.Add(this.lblWqValue);
            this.grpResults.Controls.Add(this.lblPReject);
            this.grpResults.Controls.Add(this.lblPRejectValue);
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.grpResults.Location = new System.Drawing.Point(360, 65);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(370, 320);
            this.grpResults.TabIndex = 2;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Результаты расчёта";
            // 
            // lblRho
            // 
            this.lblRho.AutoSize = true;
            this.lblRho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblRho.Location = new System.Drawing.Point(20, 30);
            this.lblRho.Name = "lblRho";
            this.lblRho.Size = new System.Drawing.Size(155, 15);
            this.lblRho.TabIndex = 0;
            this.lblRho.Text = "Коэффициент загрузки (ρ):";
            // 
            // lblRhoValue
            // 
            this.lblRhoValue.AutoSize = true;
            this.lblRhoValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRhoValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblRhoValue.Location = new System.Drawing.Point(200, 30);
            this.lblRhoValue.Name = "lblRhoValue";
            this.lblRhoValue.Size = new System.Drawing.Size(19, 15);
            this.lblRhoValue.TabIndex = 1;
            this.lblRhoValue.Text = "—";
            // 
            // lblStability
            // 
            this.lblStability.AutoSize = true;
            this.lblStability.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblStability.Location = new System.Drawing.Point(20, 55);
            this.lblStability.Name = "lblStability";
            this.lblStability.Size = new System.Drawing.Size(138, 15);
            this.lblStability.TabIndex = 2;
            this.lblStability.Text = "Стабильность системы:";
            // 
            // lblStabilityValue
            // 
            this.lblStabilityValue.AutoSize = true;
            this.lblStabilityValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStabilityValue.Location = new System.Drawing.Point(200, 55);
            this.lblStabilityValue.Name = "lblStabilityValue";
            this.lblStabilityValue.Size = new System.Drawing.Size(19, 15);
            this.lblStabilityValue.TabIndex = 3;
            this.lblStabilityValue.Text = "—";
            // 
            // lblP0
            // 
            this.lblP0.AutoSize = true;
            this.lblP0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblP0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblP0.Location = new System.Drawing.Point(22, 84);
            this.lblP0.Name = "lblP0";
            this.lblP0.Size = new System.Drawing.Size(215, 15);
            this.lblP0.TabIndex = 4;
            this.lblP0.Text = "Вероятность свободной системы (P₀):";
            // 
            // lblP0Value
            // 
            this.lblP0Value.AutoSize = true;
            this.lblP0Value.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblP0Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblP0Value.Location = new System.Drawing.Point(243, 84);
            this.lblP0Value.Name = "lblP0Value";
            this.lblP0Value.Size = new System.Drawing.Size(19, 15);
            this.lblP0Value.TabIndex = 5;
            this.lblP0Value.Text = "—";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblL.Location = new System.Drawing.Point(20, 115);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(149, 15);
            this.lblL.TabIndex = 6;
            this.lblL.Text = "Среднее число заявок (L):";
            // 
            // lblLValue
            // 
            this.lblLValue.AutoSize = true;
            this.lblLValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblLValue.Location = new System.Drawing.Point(200, 115);
            this.lblLValue.Name = "lblLValue";
            this.lblLValue.Size = new System.Drawing.Size(19, 15);
            this.lblLValue.TabIndex = 7;
            this.lblLValue.Text = "—";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblW.Location = new System.Drawing.Point(20, 145);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(172, 15);
            this.lblW.TabIndex = 8;
            this.lblW.Text = "Среднее время в системе (W):";
            // 
            // lblWValue
            // 
            this.lblWValue.AutoSize = true;
            this.lblWValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblWValue.Location = new System.Drawing.Point(200, 145);
            this.lblWValue.Name = "lblWValue";
            this.lblWValue.Size = new System.Drawing.Size(19, 15);
            this.lblWValue.TabIndex = 9;
            this.lblWValue.Text = "—";
            // 
            // lblLq
            // 
            this.lblLq.AutoSize = true;
            this.lblLq.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblLq.Location = new System.Drawing.Point(20, 175);
            this.lblLq.Name = "lblLq";
            this.lblLq.Size = new System.Drawing.Size(165, 15);
            this.lblLq.TabIndex = 10;
            this.lblLq.Text = "Средняя длина очереди (Lq):";
            // 
            // lblLqValue
            // 
            this.lblLqValue.AutoSize = true;
            this.lblLqValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblLqValue.Location = new System.Drawing.Point(200, 175);
            this.lblLqValue.Name = "lblLqValue";
            this.lblLqValue.Size = new System.Drawing.Size(19, 15);
            this.lblLqValue.TabIndex = 11;
            this.lblLqValue.Text = "—";
            // 
            // lblWq
            // 
            this.lblWq.AutoSize = true;
            this.lblWq.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblWq.Location = new System.Drawing.Point(20, 205);
            this.lblWq.Name = "lblWq";
            this.lblWq.Size = new System.Drawing.Size(180, 15);
            this.lblWq.TabIndex = 12;
            this.lblWq.Text = "Среднее время в очереди (Wq):";
            // 
            // lblWqValue
            // 
            this.lblWqValue.AutoSize = true;
            this.lblWqValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblWqValue.Location = new System.Drawing.Point(200, 205);
            this.lblWqValue.Name = "lblWqValue";
            this.lblWqValue.Size = new System.Drawing.Size(19, 15);
            this.lblWqValue.TabIndex = 13;
            this.lblWqValue.Text = "—";
            // 
            // lblPReject
            // 
            this.lblPReject.AutoSize = true;
            this.lblPReject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblPReject.Location = new System.Drawing.Point(20, 235);
            this.lblPReject.Name = "lblPReject";
            this.lblPReject.Size = new System.Drawing.Size(169, 15);
            this.lblPReject.TabIndex = 14;
            this.lblPReject.Text = "Вероятность отказа (Pотк, %):";
            // 
            // lblPRejectValue
            // 
            this.lblPRejectValue.AutoSize = true;
            this.lblPRejectValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPRejectValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblPRejectValue.Location = new System.Drawing.Point(200, 235);
            this.lblPRejectValue.Name = "lblPRejectValue";
            this.lblPRejectValue.Size = new System.Drawing.Size(19, 15);
            this.lblPRejectValue.TabIndex = 15;
            this.lblPRejectValue.Text = "—";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(755, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(279, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Расчёт модели M/M/c (СМО)";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnClose.Location = new System.Drawing.Point(650, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnHelp.Location = new System.Drawing.Point(550, 400);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(80, 30);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "❓ Справка";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // ModelInputForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(755, 455);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModelInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчёт модели M/M/c";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}