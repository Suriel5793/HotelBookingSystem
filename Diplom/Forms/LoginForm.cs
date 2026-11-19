using System;
using System.Windows.Forms;
using Diplom.Services;
using Diplom.Models;

namespace Diplom.Forms
{
    public partial class LoginForm : Form
    {
        private DatabaseService _db;

        public LoginForm()
        {
            InitializeComponent();
            _db = new DatabaseService();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _db.AuthenticateUser(login, password);

            if (user != null)
            {
                DataStore.CurrentUser = user;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}