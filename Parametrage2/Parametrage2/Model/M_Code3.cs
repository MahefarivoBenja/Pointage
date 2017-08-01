using System;
using Npgsql;
using System.Data;

namespace Parametrage2.Model
{
    class M_Code3
    {
        System.Data.DataTable dt;
        M_Connection connection;

        public M_Code3()
        {
            dt = new System.Data.DataTable();
            connection = new M_Connection();
        }
       
        public DataTable ListeCode3()
        {
            string sql = @"
                    SELECT DISTINCT idcommande
                        FROM commande
                        ORDER BY  idcommande";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, connection.DbConnect());
                NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                connection.CloseDbConnection();
                return dt;
            }
            catch (Exception exc)
            {
                connection.CloseDbConnection();
                System.Windows.Forms.MessageBox.Show(exc.Message);
                throw;
            }
        }

    }
}
