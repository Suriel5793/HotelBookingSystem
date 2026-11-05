namespace Diplom.Forms
{
    partial class ExternalFactorsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFactors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblImpact;
        private System.Windows.Forms.NumericUpDown numImpact;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvFactors = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblImpact = new System.Windows.Forms.Label();
            this.numImpact = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImpact)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFactors
            // 
            this.dgvFactors.AllowUserToAddRows = false;
            this.dgvFactors.AllowUserToDeleteRows = false;
            this.dgvFactors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dgvFactors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Location = new System.Drawing.Point(20, 20);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.ReadOnly = true;
            this.dgvFactors.RowHeadersVisible = false;
            this.dgvFactors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactors.Size = new System.Drawing.Size(650, 350);
            this.dgvFactors.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnAdd.Location = new System.Drawing.Point(690, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "➕ Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnEdit.Location = new System.Drawing.Point(690, 65);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "✏ Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnDelete.Location = new System.Drawing.Point(690, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "🗑 Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnClose.Location = new System.Drawing.Point(690, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 385);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 15);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Всего факторов: 0";
            // 
            // grpEdit
            // 
            this.grpEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.grpEdit.Controls.Add(this.lblType);
            this.grpEdit.Controls.Add(this.cmbType);
            this.grpEdit.Controls.Add(this.lblDate);
            this.grpEdit.Controls.Add(this.dtpDate);
            this.grpEdit.Controls.Add(this.lblValue);
            this.grpEdit.Controls.Add(this.txtValue);
            this.grpEdit.Controls.Add(this.lblImpact);
            this.grpEdit.Controls.Add(this.numImpact);
            this.grpEdit.Controls.Add(this.lblDescription);
            this.grpEdit.Controls.Add(this.txtDescription);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Controls.Add(this.btnCancel);
            this.grpEdit.Enabled = false;
            this.grpEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.grpEdit.Location = new System.Drawing.Point(20, 390);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(780, 180);
            this.grpEdit.TabIndex = 4;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Редактирование фактора";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblType.Location = new System.Drawing.Point(15, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 15);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Тип:";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Items.AddRange(new object[] {
            "Городское событие",
            "Погода",
            "Курс валют",
            "Цены конкурентов",
            "Праздник",
            "Другое"});
            this.cmbType.Location = new System.Drawing.Point(100, 27);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 23);
            this.cmbType.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblDate.Location = new System.Drawing.Point(280, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Дата:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dtpDate.Location = new System.Drawing.Point(325, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(140, 23);
            this.dtpDate.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblValue.Location = new System.Drawing.Point(490, 30);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(63, 15);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Значение:";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Location = new System.Drawing.Point(560, 27);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(200, 23);
            this.txtValue.TabIndex = 5;
            // 
            // lblImpact
            // 
            this.lblImpact.AutoSize = true;
            this.lblImpact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblImpact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblImpact.Location = new System.Drawing.Point(8, 70);
            this.lblImpact.Name = "lblImpact";
            this.lblImpact.Size = new System.Drawing.Size(136, 15);
            this.lblImpact.TabIndex = 6;
            this.lblImpact.Text = "Коэффициент влияния:";
            // 
            // numImpact
            // 
            this.numImpact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.numImpact.DecimalPlaces = 3;
            this.numImpact.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numImpact.Location = new System.Drawing.Point(150, 67);
            this.numImpact.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numImpact.Name = "numImpact";
            this.numImpact.Size = new System.Drawing.Size(100, 23);
            this.numImpact.TabIndex = 7;
            this.numImpact.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblDescription.Location = new System.Drawing.Point(280, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(65, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Описание:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(350, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(410, 50);
            this.txtDescription.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnSave.Location = new System.Drawing.Point(150, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnCancel.Location = new System.Drawing.Point(260, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "❌ Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(832, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(339, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Управление внешними факторами";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.pnlContent.Controls.Add(this.dgvFactors);
            this.pnlContent.Controls.Add(this.btnAdd);
            this.pnlContent.Controls.Add(this.btnEdit);
            this.pnlContent.Controls.Add(this.btnDelete);
            this.pnlContent.Controls.Add(this.grpEdit);
            this.pnlContent.Controls.Add(this.lblStatus);
            this.pnlContent.Controls.Add(this.btnClose);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(832, 578);
            this.pnlContent.TabIndex = 1;
            // 
            // ExternalFactorsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(832, 628);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExternalFactorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внешние факторы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImpact)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}