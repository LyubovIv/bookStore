using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace clientChat
{
    public partial class AdminForm : Form
    {
        // Скругление формы
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRng")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        
        public AdminForm(LoginForm loginForm)
        {
            InitializeComponent();

            //скругление формы
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            ClientApp.AdminFormHelper.LoginFormDbConnection(loginForm);

            // ClientApp.AdminFormHelper.GetAllBooksFromDb();
            
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            try
            {
                ClientApp.AdminFormHelper.BuildConfiguration();
                DGVBooks.DataSource = null;
                ClientApp.AdminFormHelper.DataAdapter.Fill(ClientApp.AdminFormHelper.DataSet);
                DGVBooks.DataSource = ClientApp.AdminFormHelper.DataSet.Tables[0];
                ClientApp.AdminFormHelper.Sql = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Ошибка заполнения данных", ex.Message);
            }
        }

        private void buttonSaveBooks_Click(object sender, EventArgs e)
        {
            try
            {
                ClientApp.AdminFormHelper.DataAdapter.Update(ClientApp.AdminFormHelper.DataSet);
                MessageBox.Show(@"Обновление успешно");

                ClientApp.AdminFormHelper.Sql = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Ошибка", ex.Message);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientApp.AdminFormHelper.LoginForm.Close();
        }

        private void DGVBooks_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DGVBooks.RowsDefaultCellStyle.BackColor = Color.FromArgb(189, 224, 254);
            DGVBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}