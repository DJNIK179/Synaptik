using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Синаптик
{
    public struct Authorization
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAvtoriz : Form
    {
        public static Avtoriz avtoriz = new Avtoriz();
        public FormAvtoriz()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == " ")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Avtoriz avtoriz in Program.Sinaptik.Avtoriz)
                {
                    if (textBoxLogin.Text == avtoriz.Login && textBoxPassword.Text == avtoriz.Password)
                    {
                        key = true;
                        avtoriz.Login = avtoriz.Login;
                        avtoriz.Password = avtoriz.Password;
                        avtoriz.Type = avtoriz.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                    this.Hide();
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
