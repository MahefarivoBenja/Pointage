using Npgsql;
using System.Data;

namespace UserTracking.Models.NomVigie
{
    class M_NomVigie : Model.M_Connection
    {
        DataTable dt = new DataTable();
        public DataTable ExecuteNreadQueries(string whreVigie)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT id, nom,case when statut = 1 then 'Activer' else 'Déscativer' end as statut FROM vigie_nom " +
                "where matricule = "+ Controllers.MySession.Matricule+"" +
                " and nom ilike '%" + whreVigie + "%' "+
                "order by id  desc", base.DbConnect());
            try
            {
                NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }

        }
        public int InsertVigie(string txt, int flag)
        {
            int retour;
            try
            {
                NpgsqlCommand insert = new NpgsqlCommand("INSERT INTO vigie_nom(nom,matricule,statut) VALUES (@txt,@matricule,@statut)", base.DbConnect());
                insert.Parameters.AddWithValue("txt", txt);
                insert.Parameters.AddWithValue("matricule", Controllers.MySession.Matricule);
                insert.Parameters.AddWithValue("statut", flag);
                retour = insert.ExecuteNonQuery();
                if (retour > 0)
                    return 1;
                else return 0;
            }
            catch (System.Exception exc)
            {
                
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return 0;
            }
        }
        public DataTable CheckNbrVigie()
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT count(*) as nb  FROM vigie_nom " +
                "where matricule = " + Controllers.MySession.Matricule + " and statut = 1" +
                " ", base.DbConnect());
            try
            {
                NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public void UpdateVigieDB(string text1, int id,int etat)
        {

            try
            {
                string value = text1.ToUpper();
                NpgsqlCommand updateDB = new NpgsqlCommand("UPDATE vigie_nom  SET nom =@value,statut=@etat  WHERE id = " + id, base.DbConnect());
                updateDB.Parameters.AddWithValue("value", value);
                updateDB.Parameters.AddWithValue("etat", etat);
                updateDB.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Mise à jour effectuée.");

            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);

            }
        }
    }
}
