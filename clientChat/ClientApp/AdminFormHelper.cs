using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace clientChat.ClientApp
{
    public static class AdminFormHelper
    {
        private static SqlConnection _connection;
        public static string Sql = "select * from [dbo].[Books]";
        private static string _cs = null;
        public static DataSet DataSet = null;
        public static SqlCommandBuilder CommandBuilder = null;
        public static SqlDataAdapter DataAdapter = null;
        public static LoginForm LoginForm = null;
        private static string _getAllBooks = null;

        public static void BuildConfiguration()
        {
            _connection = new SqlConnection(_cs);
            DataSet = new DataSet();
            DataAdapter = new SqlDataAdapter(Sql, _connection);
            CommandBuilder = new SqlCommandBuilder(DataAdapter);
        }

        // Скругление формы
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRng")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public static void LoginFormDbConnection(LoginForm loginForm)
        {
            _connection = new SqlConnection();
            _cs = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            _connection.ConnectionString = _cs;

            LoginForm = loginForm;
        }

        
        // Запасной метод
        public static string GetAllBooksFromDb()
        {
            _getAllBooks = "select * from [dbo].[Books]";

            return _getAllBooks;
        }
    }
}