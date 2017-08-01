using Npgsql;
namespace Parametrage2.Model
{
    class M_Connection
    {
        public string ConString = "Server = 192.168.10.30; Port = 5432; User Id = si; Password =51P@vGD24$; Database = pointage;";
        /*public string ConString = "Server = 192.168.10.30; Port = 5432; User Id = si; Password =51P@vGD24$; Database = pointage;ClientEncoding =SQL_ASCII; Encoding = windows-1252";*/
        NpgsqlConnection connection;
        public NpgsqlConnection DbConnect()
        {
            try
            {
                connection = new NpgsqlConnection();
                connection.ConnectionString = ConString;
                connection.Open();
                return connection;
            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                throw;
            }
        }
        public void CloseDbConnection()
        {
            connection.Close();
        }
    }
}
