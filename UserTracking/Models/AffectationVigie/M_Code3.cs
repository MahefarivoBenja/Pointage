using Npgsql;
using System;


namespace UserTracking.Models.AffectationVigie
{
    class M_Code3 : Model.M_Connection
    {
        System.Data.DataTable dt;
        NpgsqlConnection connection;
        public M_Code3()
        {
            dt = new System.Data.DataTable();
        }

        public System.Data.DataTable ListeCode3()
        {
            string sql = @"
                    SELECT DISTINCT idcommande
                        FROM commande
                        ORDER BY  idcommande";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, base.DbConnect());
                NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                base.CloseDbConnection();
                return dt;
            }
            catch (Exception exc)
            {
                base.CloseDbConnection();
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
                
            }
        }

    }
}
