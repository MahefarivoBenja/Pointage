using System;
using Npgsql;
using System.Data;

namespace Parametrage2.Model
{
    class M_NomVigie
    {
        System.Data.DataTable dt;
        M_Connection connection;
        public M_NomVigie()
        {
            dt = new System.Data.DataTable();
            connection = new M_Connection();
        }
        public DataTable ListeVigie()
        {
            string matricule = Controller.MySession.Matricule;
            string sql = @"
                SELECT id, nom
                FROM vigie_nom where matricule ="+ matricule + " order  by nom asc";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection.DbConnect());
            try
            {
                NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                throw;
            }

        }
    }
}
