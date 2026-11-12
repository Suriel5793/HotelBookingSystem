namespace Diplom.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem модельMmcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётПоказателейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеНомерамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бронированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеБронированиямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прогнозыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекомендацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внешниеФакторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеФакторамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

        // НОВОЕ ПОЛЕ ДЛЯ КНОПКИ СМЕНЫ ПОЛЬЗОВАТЕЛЯ
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.модельMmcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётПоказателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеНомерамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бронированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеБронированиямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прогнозыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекомендацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внешниеФакторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеФакторамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(179)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.модельMmcToolStripMenuItem,
            this.номераToolStripMenuItem,
            this.бронированияToolStripMenuItem,
            this.аналитикаToolStripMenuItem,
            this.прогнозыToolStripMenuItem,
            this.внешниеФакторыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // модельMmcToolStripMenuItem
            // 
            this.модельMmcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчётПоказателейToolStripMenuItem});
            this.модельMmcToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.модельMmcToolStripMenuItem.Name = "модельMmcToolStripMenuItem";
            this.модельMmcToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.модельMmcToolStripMenuItem.Text = "Модель M/M/c";
            // 
            // расчётПоказателейToolStripMenuItem
            // 
            this.расчётПоказателейToolStripMenuItem.Name = "расчётПоказателейToolStripMenuItem";
            this.расчётПоказателейToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.расчётПоказателейToolStripMenuItem.Text = "Расчёт показателей";
            this.расчётПоказателейToolStripMenuItem.Click += new System.EventHandler(this.расчётПоказателейToolStripMenuItem_Click);
            // 
            // номераToolStripMenuItem
            // 
            this.номераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеНомерамиToolStripMenuItem});
            this.номераToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.номераToolStripMenuItem.Name = "номераToolStripMenuItem";
            this.номераToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.номераToolStripMenuItem.Text = "Номера";
            // 
            // управлениеНомерамиToolStripMenuItem
            // 
            this.управлениеНомерамиToolStripMenuItem.Name = "управлениеНомерамиToolStripMenuItem";
            this.управлениеНомерамиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.управлениеНомерамиToolStripMenuItem.Text = "Управление";
            this.управлениеНомерамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеНомерамиToolStripMenuItem_Click);
            // 
            // бронированияToolStripMenuItem
            // 
            this.бронированияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеБронированиямиToolStripMenuItem});
            this.бронированияToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.бронированияToolStripMenuItem.Name = "бронированияToolStripMenuItem";
            this.бронированияToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.бронированияToolStripMenuItem.Text = "Бронирования";
            // 
            // управлениеБронированиямиToolStripMenuItem
            // 
            this.управлениеБронированиямиToolStripMenuItem.Name = "управлениеБронированиямиToolStripMenuItem";
            this.управлениеБронированиямиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.управлениеБронированиямиToolStripMenuItem.Text = "Управление";
            this.управлениеБронированиямиToolStripMenuItem.Click += new System.EventHandler(this.управлениеБронированиямиToolStripMenuItem_Click);
            // 
            // аналитикаToolStripMenuItem
            // 
            this.аналитикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиToolStripMenuItem});
            this.аналитикаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            this.аналитикаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.графикиToolStripMenuItem.Text = "Графики";
            this.графикиToolStripMenuItem.Click += new System.EventHandler(this.графикиToolStripMenuItem_Click);
            // 
            // прогнозыToolStripMenuItem
            // 
            this.прогнозыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рекомендацииToolStripMenuItem});
            this.прогнозыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.прогнозыToolStripMenuItem.Name = "прогнозыToolStripMenuItem";
            this.прогнозыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.прогнозыToolStripMenuItem.Text = "Прогнозы";
            // 
            // рекомендацииToolStripMenuItem
            // 
            this.рекомендацииToolStripMenuItem.Name = "рекомендацииToolStripMenuItem";
            this.рекомендацииToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.рекомендацииToolStripMenuItem.Text = "Рекомендации";
            this.рекомендацииToolStripMenuItem.Click += new System.EventHandler(this.рекомендацииToolStripMenuItem_Click);
            // 
            // внешниеФакторыToolStripMenuItem
            // 
            this.внешниеФакторыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеФакторамиToolStripMenuItem});
            this.внешниеФакторыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.внешниеФакторыToolStripMenuItem.Name = "внешниеФакторыToolStripMenuItem";
            this.внешниеФакторыToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.внешниеФакторыToolStripMenuItem.Text = "Внешние факторы";
            // 
            // управлениеФакторамиToolStripMenuItem
            // 
            this.управлениеФакторамиToolStripMenuItem.Name = "управлениеФакторамиToolStripMenuItem";
            this.управлениеФакторамиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.управлениеФакторамиToolStripMenuItem.Text = "Управление";
            this.управлениеФакторамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеФакторамиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзПрограммыToolStripMenuItem});
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 24);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Система управления бронированием отеля";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(327, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Оптимизация загрузки на основе модели M/M/c";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отель: Система управления бронированием";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}