using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientChat
{
    public partial class AdminUsersForm : Form
    {
        SqlConnection conn;
        string cs = null;
        DataSet set = null;
        SqlCommandBuilder cmdb = null;
        SqlDataAdapter da = null;
        string sql = null;
        LoginForm loginForm = null;

        //скругление формы
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        public AdminUsersForm(LoginForm lg)
        {
            InitializeComponent();

            //скругление формы
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            conn = new SqlConnection();
            cs = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            conn.ConnectionString = cs;

            loginForm = lg;

            sql = "select * from [dbo].[Managers]";
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            try
            {
                conn = new SqlConnection(cs);
                set = new DataSet();
                da = new SqlDataAdapter(sql, conn);
                DGVUsers.DataSource = null;
                cmdb = new SqlCommandBuilder(da);
                da.Fill(set);
                DGVUsers.DataSource = set.Tables[0];
                sql = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AdminUsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }

        private void buttonSaveUsers_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(set);
                MessageBox.Show("Обновление успешно");

                sql = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void DGVUsers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.DGVUsers.RowsDefaultCellStyle.BackColor = Color.FromArgb(189, 224, 254);
            this.DGVUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);

        }
    }
}
