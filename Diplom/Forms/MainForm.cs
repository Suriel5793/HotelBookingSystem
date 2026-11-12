using Diplom.Forms;
using Diplom.Models;
using System;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void расчётПоказателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelInputForm();
            form.ShowDialog();
        }

        private void управлениеНомерамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RoomsForm();
            form.ShowDialog();
        }

        private void управлениеБронированиямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BookingsForm();
            form.ShowDialog();
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ChartsForm();
            form.ShowDialog();
        }

        private void рекомендацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ForecastForm();
            form.ShowDialog();
        }

        private void управлениеФакторамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ExternalFactorsForm();
            form.ShowDialog();
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "        НАДЕЮСЬ БУДУЩИЙ ДИПЛОМ\n" +
                "Тема: Разработка информационной системы для создания\n" +
                "и оптимизации модели управления бронированием\n" +
                "гостиничных номеров\n\n",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (DataStore.CurrentUser != null)
            {
                if (DataStore.CurrentUser.Role == "manager")
                {
                    this.номераToolStripMenuItem.Enabled = false; // Запрещаем менеджеру менять номера
                    this.Text = $"Отель: Управление (Менеджер: {DataStore.CurrentUser.Login})";
                }
                else
                {
                    this.Text = $"Отель: Управление (Администратор: {DataStore.CurrentUser.Login})";
                }
            }
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Смена пользователя",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataStore.CurrentUser = null;
                Application.Restart(); // Перезапуск программы для вызова формы входа
            }
        }
    }
}