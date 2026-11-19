namespace Diplom.Forms
{
    partial class UsersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(600, 50);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Text = "Управление пользователями";

            // dgvUsers
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(20, 70);
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(560, 200);
            this.dgvUsers.TabIndex = 1;

            // grpAdd
            this.grpAdd.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.grpAdd.Controls.Add(this.lblLogin);
            this.grpAdd.Controls.Add(this.txtLogin);
            this.grpAdd.Controls.Add(this.lblPassword);
            this.grpAdd.Controls.Add(this.txtPassword);
            this.grpAdd.Controls.Add(this.lblRole);
            this.grpAdd.Controls.Add(this.cmbRole);
            this.grpAdd.Controls.Add(this.btnAddUser);
            this.grpAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAdd.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.grpAdd.Location = new System.Drawing.Point(20, 290);
            this.grpAdd.Size = new System.Drawing.Size(560, 120);
            this.grpAdd.Text = "Добавить нового пользователя";

            // lblLogin
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogin.Location = new System.Drawing.Point(20, 30);
            this.lblLogin.Text = "Логин:";

            // txtLogin
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(20, 50);
            this.txtLogin.Size = new System.Drawing.Size(150, 23);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.Location = new System.Drawing.Point(190, 30);
            this.lblPassword.Text = "Пароль:";

            // txtPassword
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(190, 50);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 23);

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRole.Location = new System.Drawing.Point(360, 30);
            this.lblRole.Text = "Роль:";

            // cmbRole
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Items.AddRange(new object[] { "manager", "admin" });
            this.cmbRole.Location = new System.Drawing.Point(360, 50);
            this.cmbRole.Size = new System.Drawing.Size(150, 23);

            // btnAddUser
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.Location = new System.Drawing.Point(20, 80);
            this.btnAddUser.Size = new System.Drawing.Size(150, 30);
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);

            // btnDeleteUser
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.Location = new System.Drawing.Point(430, 285);
            this.btnDeleteUser.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteUser.Text = "Удалить выбранного";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(480, 430);
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // UsersForm
            this.BackColor = System.Drawing.Color.FromArgb(253, 245, 230);
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пользователи";

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}