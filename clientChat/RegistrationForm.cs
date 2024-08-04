using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientChat
{
    public partial class RegistrationForm : Form
    {
        LoginForm loginForm;
        public RegistrationForm(LoginForm lg)
        {
            InitializeComponent();
            loginForm = lg;
        }
        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (login.Text.TrimStart() == string.Empty || password.Text.TrimStart() == string.Empty || userName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Ошибка. Проверьте полноту заполненных данных");
            }
            else
            {
                bool res = loginForm.AddNewUser(login.Text, password.Text, userName.Text);
                if (res)
                {
                    MessageBox.Show("Регистрация успешна");
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка регистраци. Проверьте данные и попробуйте ещё раз");
                }
            }
        }
    }
}
