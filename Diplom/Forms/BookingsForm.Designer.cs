namespace Diplom.Forms
{
    partial class BookingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelBooking;

        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbRoomId;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblGuestCount;
        private System.Windows.Forms.NumericUpDown numGuestCount;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ComboBox cmbBookingSource;
        private System.Windows.Forms.Label lblStatusBooking;
        private System.Windows.Forms.ComboBox cmbBookingStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
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
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbRoomId = new System.Windows.Forms.ComboBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.numGuestCount = new System.Windows.Forms.NumericUpDown();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbBookingSource = new System.Windows.Forms.ComboBox();
            this.lblStatusBooking = new System.Windows.Forms.Label();
            this.cmbBookingStatus = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestCount)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(20, 65);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(786, 350);
            this.dgvBookings.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnAdd.Location = new System.Drawing.Point(820, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 2;
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
            this.btnEdit.Location = new System.Drawing.Point(820, 106);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 3;
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
            this.btnDelete.Location = new System.Drawing.Point(820, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(820, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 645);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(135, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Всего бронирований: 0";
            // 
            // grpEdit
            // 
            this.grpEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.grpEdit.Controls.Add(this.lblRoom);
            this.grpEdit.Controls.Add(this.cmbRoomId);
            this.grpEdit.Controls.Add(this.lblCheckIn);
            this.grpEdit.Controls.Add(this.dtpCheckIn);
            this.grpEdit.Controls.Add(this.lblCheckOut);
            this.grpEdit.Controls.Add(this.dtpCheckOut);
            this.grpEdit.Controls.Add(this.lblGuestCount);
            this.grpEdit.Controls.Add(this.numGuestCount);
            this.grpEdit.Controls.Add(this.lblPhone);
            this.grpEdit.Controls.Add(this.txtCustomerPhone);
            this.grpEdit.Controls.Add(this.lblEmail);
            this.grpEdit.Controls.Add(this.txtCustomerEmail);
            this.grpEdit.Controls.Add(this.lblSource);
            this.grpEdit.Controls.Add(this.cmbBookingSource);
            this.grpEdit.Controls.Add(this.lblStatusBooking);
            this.grpEdit.Controls.Add(this.cmbBookingStatus);
            this.grpEdit.Controls.Add(this.lblNotes);
            this.grpEdit.Controls.Add(this.txtNotes);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Controls.Add(this.btnCancel);
            this.grpEdit.Enabled = false;
            this.grpEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.grpEdit.Location = new System.Drawing.Point(20, 430);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(910, 200);
            this.grpEdit.TabIndex = 6;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Редактирование бронирования";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblRoom.Location = new System.Drawing.Point(15, 28);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(48, 15);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Номер:";
            // 
            // cmbRoomId
            // 
            this.cmbRoomId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cmbRoomId.DisplayMember = "RoomNumber";
            this.cmbRoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoomId.Location = new System.Drawing.Point(100, 25);
            this.cmbRoomId.Name = "cmbRoomId";
            this.cmbRoomId.Size = new System.Drawing.Size(120, 23);
            this.cmbRoomId.TabIndex = 1;
            this.cmbRoomId.ValueMember = "RoomId";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblCheckIn.Location = new System.Drawing.Point(240, 28);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(72, 15);
            this.lblCheckIn.TabIndex = 2;
            this.lblCheckIn.Text = "Дата заезда:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.dtpCheckIn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dtpCheckIn.Location = new System.Drawing.Point(330, 25);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(130, 23);
            this.dtpCheckIn.TabIndex = 3;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblCheckOut.Location = new System.Drawing.Point(480, 28);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(76, 15);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Дата выезда:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.dtpCheckOut.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dtpCheckOut.Location = new System.Drawing.Point(575, 25);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(130, 23);
            this.dtpCheckOut.TabIndex = 5;
            // 
            // lblGuestCount
            // 
            this.lblGuestCount.AutoSize = true;
            this.lblGuestCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGuestCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblGuestCount.Location = new System.Drawing.Point(720, 28);
            this.lblGuestCount.Name = "lblGuestCount";
            this.lblGuestCount.Size = new System.Drawing.Size(88, 15);
            this.lblGuestCount.TabIndex = 6;
            this.lblGuestCount.Text = "Кол-во гостей:";
            // 
            // numGuestCount
            // 
            this.numGuestCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.numGuestCount.Location = new System.Drawing.Point(810, 25);
            this.numGuestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGuestCount.Name = "numGuestCount";
            this.numGuestCount.Size = new System.Drawing.Size(50, 23);
            this.numGuestCount.TabIndex = 7;
            this.numGuestCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblPhone.Location = new System.Drawing.Point(15, 65);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 15);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Телефон:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerPhone.Location = new System.Drawing.Point(100, 62);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(160, 23);
            this.txtCustomerPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblEmail.Location = new System.Drawing.Point(280, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerEmail.Location = new System.Drawing.Point(330, 62);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(160, 23);
            this.txtCustomerEmail.TabIndex = 11;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblSource.Location = new System.Drawing.Point(510, 65);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(64, 15);
            this.lblSource.TabIndex = 12;
            this.lblSource.Text = "Источник:";
            // 
            // cmbBookingSource
            // 
            this.cmbBookingSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cmbBookingSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBookingSource.Items.AddRange(new object[] {
            "Яндекс.Путешествия",
            "Туту.ру",
            "Прямой звонок",
            "Сайт отеля",
            "Booking.com",
            "Другое"});
            this.cmbBookingSource.Location = new System.Drawing.Point(585, 62);
            this.cmbBookingSource.Name = "cmbBookingSource";
            this.cmbBookingSource.Size = new System.Drawing.Size(140, 23);
            this.cmbBookingSource.TabIndex = 13;
            // 
            // lblStatusBooking
            // 
            this.lblStatusBooking.AutoSize = true;
            this.lblStatusBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblStatusBooking.Location = new System.Drawing.Point(740, 65);
            this.lblStatusBooking.Name = "lblStatusBooking";
            this.lblStatusBooking.Size = new System.Drawing.Size(46, 15);
            this.lblStatusBooking.TabIndex = 14;
            this.lblStatusBooking.Text = "Статус:";
            // 
            // cmbBookingStatus
            // 
            this.cmbBookingStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cmbBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBookingStatus.Items.AddRange(new object[] {
            "подтверждено",
            "отменено",
            "завершено",
            "не заехал"});
            this.cmbBookingStatus.Location = new System.Drawing.Point(795, 62);
            this.cmbBookingStatus.Name = "cmbBookingStatus";
            this.cmbBookingStatus.Size = new System.Drawing.Size(88, 23);
            this.cmbBookingStatus.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblNotes.Location = new System.Drawing.Point(15, 105);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(81, 15);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Примечание:";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(100, 102);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(600, 50);
            this.txtNotes.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnSave.Location = new System.Drawing.Point(243, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 18;
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
            this.btnCancel.Location = new System.Drawing.Point(350, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "❌ Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnCancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnCancelBooking.Location = new System.Drawing.Point(820, 188);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(110, 35);
            this.btnCancelBooking.TabIndex = 5;
            this.btnCancelBooking.Text = "❌ Отменить";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.BtnCancelBooking_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(295, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Управление бронированиями";
            // 
            // BookingsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(950, 690);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление бронированиями";
            this.Load += new System.EventHandler(this.BookingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestCount)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}