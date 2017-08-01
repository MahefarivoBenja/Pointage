using Npgsql;
using System;
using UserTracking.Model;

namespace UserTracking.Models.AffectationVigie
{
    class M_NomVigie : M_Connection
    {
        System.Data.DataTable dt;
        public M_NomVigie()
        {
            dt = new System.Data.DataTable();
            
        }
        public System.Data.DataTable ListeVigie()
        {
            string matricule = Controllers.MySession.Matricule;
            string sql = @"
                SELECT id, nom
                FROM vigie_nom where matricule =" + matricule + " order  by nom asc";
            
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, base.DbConnect());
                NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }

        }
    }
}
