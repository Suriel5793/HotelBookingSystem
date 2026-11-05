using System;
using System.Windows.Forms;
using Diplom.Forms;

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
    }
}