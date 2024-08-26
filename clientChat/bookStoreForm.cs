using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clientChat
{
    public partial class bookStoreForm : Form
    {
        SqlConnection BSConn;
        string cs = null;
        DataSet set = null;
        SqlCommandBuilder cmdb = null;
        SqlDataAdapter da = null;
        string sql = null;
        LoginForm loginForm = null;
        
        public bookStoreForm(LoginForm lg)
        {
            InitializeComponent();
            BSConn = new SqlConnection();
            cs = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            BSConn.ConnectionString = cs;
            loginForm = lg;

            sql = "select * from [dbo].[Books]";
            FillDataGridView();
        }
        private void books_Click(object sender, EventArgs e)
        {
            sql = "select * from [dbo].[Books]";
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            try
            {
                BSConn = new SqlConnection(cs);
                set = new DataSet();
                da = new SqlDataAdapter(sql, BSConn);
                dataGridView1.DataSource = null;
                cmdb = new SqlCommandBuilder(da);
                da.Fill(set);
                dataGridView1.DataSource = set.Tables[0];
                sql = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void listNewBooks()
        {
            sql = "select * from[dbo].[Books] where[Date] > (select dateadd(year, -1, (select getdate())))";
            FillDataGridView();
        }
        private void listTop3Sales()
        {
            sql = @"select top(3) [Name],[Author],[Publisher],sum([Quantity]) as [Sales]
                    from [dbo].[Books] as B, [dbo].[Sales] as S
                    where B.[Id] = S.[BookID]
                    group by [Name],[Author],[Publisher]
                    order by [Sales] desc";
            FillDataGridView();
        }
        private void listTopAuthors()
        {
            sql = @"select top(3) [Author],sum([Quantity]) as [Sales]
                    from [dbo].[Books] as B, [dbo].[Sales] as S
                    where B.[Id] = S.[BookID]
                    group by [Author]
                    order by [Sales] desc";
            FillDataGridView();
        }
        private void GenreDay()
        {
            sql = @"select top(3) T.[Genre], sum([Quantity]) as [Sales]
                    from (select [Genre],[DateOfSale],[Quantity]
		                from [dbo].[Books] as B, [dbo].[Sales] as S
		                where B.[Id] = S.[BookID] and datediff(day, [DateOfSale], (select getdate())) = 0) as T
                    group by [Genre]
                    order by [Sales] desc";
            FillDataGridView();
        }
        private void GenreWeek()
        {
            sql = @"select top(3) T.[Genre], sum([Quantity]) as [Sales]
                    from (select [Genre],[DateOfSale],[Quantity]
		                from [dbo].[Books] as B, [dbo].[Sales] as S
		                where B.[Id] = S.[BookID] and datediff(day, [DateOfSale], (select getdate())) <= 7) as T
                    group by [Genre]
                    order by [Sales] desc";
            FillDataGridView();
        }
        private void GenreMonth()
        {
            sql = @"select top(3) T.[Genre], sum([Quantity]) as [Sales]
                    from (select [Genre],[DateOfSale],[Quantity]
		                from [dbo].[Books] as B, [dbo].[Sales] as S
		                where B.[Id] = S.[BookID] and datediff(month, [DateOfSale], (select getdate())) = 0) as T
                    group by [Genre]
                    order by [Sales] desc";
            FillDataGridView();
        }
        private void GenreYear()
        {
            sql = @"select top(3) T.[Genre], sum([Quantity]) as [Sales]
                    from (select [Genre],[DateOfSale],[Quantity]
		                from [dbo].[Books] as B, [dbo].[Sales] as S
		                where B.[Id] = S.[BookID] and datediff(year, [DateOfSale], (select getdate())) = 0) as T
                    group by [Genre]
                    order by [Sales] desc";
            FillDataGridView();
        }

        private void showFiltr_Click(object sender, EventArgs e)
        {
            if (FiltrComboBox.Text == "Список новинок") 
            {
                listNewBooks();
            }
            else if (FiltrComboBox.Text == "Список самых продаваемых книг")
            {
                listTop3Sales();
            }
            else if(FiltrComboBox.Text == "Популярные авторы")
            {
                listTopAuthors();
            }
            else if (FiltrComboBox.Text == "Самый популярный жанр за день")
            {
                GenreDay();
            }
            else if (FiltrComboBox.Text == "Самый популярный жанр за неделю")
            {
                GenreWeek();
            }
            else if (FiltrComboBox.Text == "Самый популярный жанр за месяц")
            {
                GenreMonth();
            }
            else if (FiltrComboBox.Text == "Самый популярный жанр за год")
            {
                GenreYear();
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (comboBoxFindBy.Text == "автору")
            {
                string param = textParam.Text;
                sql = "SELECT * FROM [dbo].[Books] WHERE [Author] = N'" + param + "'";
                FillDataGridView();
            }
            else if (comboBoxFindBy.Text == "жанру")
            {
                string param = textParam.Text;
                sql = "SELECT * FROM [dbo].[Books] WHERE [Genre] = N'" + param + "'";
                FillDataGridView();
            }
            else if (comboBoxFindBy.Text == "имени")
            {
                string param = textParam.Text;
                sql = "SELECT * FROM [dbo].[Books] WHERE [Name] = N'" + param + "'";
                FillDataGridView();
            }
        }

        private void sell_Click(object sender, EventArgs e)
        {
            try
            {
                BSConn.Open();
                SqlCommand command = new SqlCommand("sp_sellBook", BSConn);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = dataGridView1.CurrentCell.Value.ToString()
                };
                command.Parameters.Add(idParam);

                SqlParameter qParam = new SqlParameter
                {
                    ParameterName = "@quantity",
                    Value = textBox2.Text
                };
                command.Parameters.Add(qParam);
                command.ExecuteNonQuery();
                BSConn.Close();
                MessageBox.Show("Продано");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void bookStoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
    }
}
