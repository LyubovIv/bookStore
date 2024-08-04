using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace clientChat
{
    public partial class LoginForm : Form
    {
        SqlConnection conn;
        string cs = null;
        int connectCount = 0;
        ChatForm Form;
        RegistrationForm RegistrationForm;
        public LoginForm()
        {
            InitializeComponent();
            conn = new SqlConnection();
            cs = ConfigurationManager.ConnectionStrings["AuthorizationConnString"].ConnectionString;
            conn.ConnectionString = cs;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    string query = "select * from [dbo].[Table] where [Login] = N'"
                        + login.Text.Trim() + "' and [Password] = N'"
                        + password.Text.Trim() + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        connectCount++;
                        string name = dt.Rows[0][2].ToString();

                        if (connectCount == 1)
                        {
                            Form = new ChatForm(name, this);
                        }
                        else Form.ChangeUser(name);

                        this.Hide();
                        Form.Show();

                        login.Clear();
                        password.Clear();
                    }
                    else MessageBox.Show("Ошибка. Проверьте корректность введнных даных");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка входа!");
                    connectCount--;
                }
            }
        }
        private bool isValid()
        {
            if (login.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Введите логин");
                return false;
            }
            else if (password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Введите пароль");
                return false;
            }
            return true;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrationForm = new RegistrationForm(this);
            
                this.Hide();
                RegistrationForm.Show();

                login.Clear();
                password.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка регистрации!");
            }
        }
        public bool AddNewUser(string log, string pas, string nick)
        {
            try
            {
            
                string query = "insert into [dbo].[Table]([Login],[Password],[UserName]) " +
                               "values (N'" + log + "',N'" + pas + "',N'" + nick + "')";

                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();

                return true;
            
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
