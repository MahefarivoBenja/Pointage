using System.IO;

namespace UserTracking.Model
{
    class M_ListUserTracking :M_Connection
    {
        System.Data.DataTable dt;
        public M_ListUserTracking()
        {
            dt = new System.Data.DataTable();
        }

       

        public System.Data.DataTable ListUserTracking(string[] stringArrayUser)
        {

            int i = 0;
            string sql = string.Empty;

            foreach (string matr in stringArrayUser)
            {
                int matricule = int.Parse(matr);
               
                if(i <= 0)
                {
                    sql = "" +
                       "select *from(" +
                       "" +
                       "SELECT id_cmd, pointage_commande.matricule,hexaprenom,fonctioncourante,id_commande, vigie, " +
                       "(date_debut || ' ' || heure_debut)::TIMESTAMP AS debut_timestamp, " +
                       "(date_fin || ' ' || heure_fin)::TIMESTAMP AS fin_timestamp," +
                       "CASE WHEN date_fin IS NULL OR date_fin IS NULL " +
                       "THEN round(((EXTRACT(EPOCH FROM (SELECT now_sdsi FROM sdsi_time) )-EXTRACT(EPOCH FROM (date_debut || ' '|| heure_debut)::TIMESTAMP) )/ 3600)::decimal,2) " +
                       "  " +
                       " ELSE case when duree_cmd is not null then round(duree_cmd::decimal,2) else round(duree_entree_sortie::decimal,2) end " +
                       " END AS duree_temp, duree_cmd, " +
                       "duree_entree_sortie, case when type is null then 100 else type end as type,date_fin,heure_fin, assistance " +
                       "FROM pointage_commande " +
                       "inner join personnel on personnel.matricule = pointage_commande.matricule " +
                       "WHERE pointage_commande.matricule = " + matr + " " +
                       "ORDER BY(date_debut || ' ' || heure_debut)::TIMESTAMP " +
                       "DESC LIMIT 1" +
                       ") as temp_"+ matr;
                    i += 1;
                }
                else
                {
                    sql += "    " +
                        "   UNION ALL   " +
                       "select *from(" +
                       "" +
                       "SELECT id_cmd, pointage_commande.matricule,hexaprenom,fonctioncourante,id_commande, vigie, " +
                       "(date_debut || ' ' || heure_debut)::TIMESTAMP AS debut_timestamp, " +
                       "(date_fin || ' ' || heure_fin)::TIMESTAMP AS fin_timestamp," +
                       "CASE WHEN date_fin IS NULL OR date_fin IS NULL " +
                       "THEN round(((EXTRACT(EPOCH FROM (SELECT now_sdsi FROM sdsi_time) )-EXTRACT(EPOCH FROM (date_debut || ' '|| heure_debut)::TIMESTAMP) )/ 3600)::decimal,2) " +
                       "     " +
                       "     ELSE case when duree_cmd is not null then round(duree_cmd::decimal,2) else round(duree_entree_sortie::decimal,2) end   " +
                       " END AS duree_temp, duree_cmd, " +
                       "duree_entree_sortie, case when type is null then 100 else type end as type,date_fin,heure_fin, assistance " +
                       "FROM pointage_commande " +
                       "inner join personnel on personnel.matricule = pointage_commande.matricule " +
                       "WHERE pointage_commande.matricule = "+ matricule + " " +
                       "ORDER BY(date_debut || ' ' || heure_debut)::TIMESTAMP " +
                       "DESC LIMIT 1" +
                       ") as temp_" + matr + "   ";
                    i += 1;
                }
            }

            //System.Windows.Forms.MessageBox.Show(sql);

            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
               base.CloseDbConnection();
                return dt;
            }
            catch (System.Exception exc)
            {
               base.CloseDbConnection();
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
        public System.Data.DataTable MyUser( int matrSup, int vigie)
        {
            string sql = "SELECT distinct matricule FROM vigie_par_affectation where matricule_sup = "+ matrSup + " AND vigie ="+vigie +" and flag = 1 order by matricule";
            
            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
        public System.Data.DataTable nbrAssistance()
        {
            string sql = "SELECT count(*) FROM public.pointage_commande where matricule in("+ Controllers.MySession.Matricule+") and assistance = 1";
            
            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
        public System.Data.DataTable RechercheRapide(string where, string[] stringArrayUser)/*pass array ,string*/
        {
            int i = 0;
            string sql = string.Empty;
            foreach (string matr in stringArrayUser)
            {
                int matricule = int.Parse(matr);
                if (i <= 0)
                {
                  sql = "select *from(" +
                    " SELECT id_cmd, pointage_commande.matricule,hexaprenom,fonctioncourante,id_commande, vigie, " +
                     "(date_debut || ' ' || heure_debut)::TIMESTAMP AS debut_timestamp, " +
                     "(date_fin || ' ' || heure_fin)::TIMESTAMP AS fin_timestamp, " +
                     "CASE WHEN date_fin IS NULL or date_fin IS NULL " +
                     "THEN round(((EXTRACT(EPOCH FROM (SELECT now_sdsi FROM sdsi_time) )-EXTRACT(EPOCH FROM(date_debut || ' ' || heure_debut)::TIMESTAMP) )/ 3600)::decimal,2) " +
                     "  " +
                     " ELSE case when duree_cmd is not null then round(duree_cmd::decimal,2) else round(duree_entree_sortie::decimal,2) end " +
                     "END AS duree_temp, duree_cmd,  " +
                     "duree_entree_sortie, case when type is null then 100 else type end as type,date_fin,heure_fin, assistance " +
                     "FROM pointage_commande " +
                     "inner join personnel on personnel.matricule = pointage_commande.matricule " +
                     "WHERE pointage_commande.matricule::text ilike '%" + where + "%' and pointage_commande.matricule = " + matr+
                     " ORDER BY(date_debut || ' ' || heure_debut)::TIMESTAMP " +
                     "DESC LIMIT 1 " +
                     ") as temp_"+matr;
                    i += 1;
                }
                else
                {
                    sql += "    " +
                        "   UNION ALL   " +
                        "select *from(" +
                    " SELECT id_cmd, pointage_commande.matricule,hexaprenom,fonctioncourante,id_commande, vigie, " +
                     "(date_debut || ' ' || heure_debut)::TIMESTAMP AS debut_timestamp, " +
                     "(date_fin || ' ' || heure_fin)::TIMESTAMP AS fin_timestamp, " +
                     "CASE WHEN date_fin IS NULL or date_fin IS NULL " +
                     "THEN round(((EXTRACT(EPOCH FROM (SELECT now_sdsi FROM sdsi_time) )-EXTRACT(EPOCH FROM(date_debut || ' ' || heure_debut)::TIMESTAMP) )/ 3600)::decimal,2) " +
                     "   " +
                     "ELSE case when duree_cmd is not null then round(duree_cmd::decimal,2) else round(duree_entree_sortie::decimal,2) end " +
                     "END AS duree_temp, duree_cmd,  " +
                     "duree_entree_sortie, case when type is null then 100 else type end as type,date_fin,heure_fin, assistance " +
                     "FROM pointage_commande " +
                     "inner join personnel on personnel.matricule = pointage_commande.matricule " +
                     "WHERE pointage_commande.matricule::text ilike '%" + where + "%' and pointage_commande.matricule = " + matr +
                     " ORDER BY(date_debut || ' ' || heure_debut)::TIMESTAMP " +
                     "DESC LIMIT 1 " +
                     ") as temp_" + matr+"  ";
                    i += 1;
                }
                //  System.Windows.Forms.MessageBox.Show(sql);
                /*StreamWriter OurStream;
                OurStream = File.CreateText("test.txt");
                OurStream.WriteLine("This is a line of text"+sql);
                OurStream.Close();*/
                
            }
                
            
            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
        public System.Data.DataTable RechercheAssistance(string where, string[] stringArrayUser)/*pass array ,string*/
        {
            int i = 0;
            string sql = string.Empty;
            foreach (string matr in stringArrayUser)
            {
                if( i<=0)
                {
                        sql = "select *from(    " +
                            "SELECT id_cmd, pointage_commande.matricule,hexaprenom,fonctioncourante,id_commande, vigie, " +
                    "(date_debut || ' ' || heure_debut)::TIMESTAMP AS debut_timestamp, " +
                    "(date_fin || ' ' || heure_fin)::TIMESTAMP AS fin_timestamp, " +
                    "CASE WHEN date_fin IS NULL or date_fin IS NULL " +
                    "THEN round(((EXTRACT(EPOCH FROM (SELECT now_sdsi FROM sdsi_time) )-EXTRACT(EPOCH FROM(date_debut || ' ' || heure_debut)::TIMESTAMP) )/ 3600)::decimal,2) " +
                    "   " +
                    "ELSE case when duree_cmd is not null then round(duree_cmd::decimal,2) else round(duree_entree_sortie::decimal,2) end " +
                    "END AS duree_temp, duree_cmd,  " +
                    "duree_entree_sortie, case when type is null then 100 else type end as type,date_fin,heure_fin, assistance " +
                    "FROM pointage_commande " +
                    "inner join personnel on personnel.matricule = pointage_commande.matricule " +
                    "WHERE assistance = 1 " +
                    "   and pointage_commande.matricule =" + matr +
                    " ORDER BY(date_debut || ' ' || heure_debut)::TIMESTAMP " +
                    "DESC LIMIT 1 " +
                   ") as temp_" + matr;
                    i += 1;
                }
                else
                {
                        sql += " " +
                        "  UNION ALL " +
                        "select *from(    " +
                            "SELECT id_cmd, pointage_commande.matricule,hexaprenom,fonctioncourante,id_commande, vigie, " +
                    "(date_debut || ' ' || heure_debut)::TIMESTAMP AS debut_timestamp, " +
                    "(date_fin || ' ' || heure_fin)::TIMESTAMP AS fin_timestamp, " +
                    "CASE WHEN date_fin IS NULL or date_fin IS NULL " +
                    "THEN round(((EXTRACT(EPOCH FROM (SELECT now_sdsi FROM sdsi_time) )-EXTRACT(EPOCH FROM(date_debut || ' ' || heure_debut)::TIMESTAMP) )/ 3600)::decimal,2) " +
                    "   " +
                    "ELSE case when duree_cmd is not null then round(duree_cmd::decimal,2) else round(duree_entree_sortie::decimal,2) end " +
                    "END AS duree_temp, duree_cmd,  " +
                    "duree_entree_sortie, case when type is null then 100 else type end as type,date_fin,heure_fin, assistance " +
                    "FROM pointage_commande " +
                    "inner join personnel on personnel.matricule = pointage_commande.matricule " +
                    "WHERE assistance = 1 " +
                    "   and pointage_commande.matricule =" + matr +
                    " ORDER BY(date_debut || ' ' || heure_debut)::TIMESTAMP " +
                    "DESC LIMIT 1 " +
                   ") as temp_" + matr;
                    i += 1;
                }
            }

            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
        public System.Data.DataTable GetDetailTrack(int matr)
        {
            
            string sql = "SELECT " +
                "(date_debut || ' ' || heure_debut)::TIMESTAMP as debut," +
                " (date_fin || ' ' || heure_fin)::TIMESTAMP  as fin   " +
                "FROM public.pointage_commande  where matricule ="  + matr+
                "ORDER BY(date_debut || ' ' || heure_debut)::TIMESTAMP   DESC" +
                " LIMIT 1";
            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
        public void UpdateAssistance(int matricule)
        {
            string sql = "UPDATE pointage_commande SET  assistance=0 WHERE matricule  = " + matricule;
            try
            {
                Npgsql.NpgsqlCommand updateAssistance = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                int aCheck = updateAssistance.ExecuteNonQuery();
                if(aCheck >0)
                {
                    System.Windows.Forms.MessageBox.Show("Mise à jour effectuée");
                }
            }
            catch (System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                System.Windows.Forms.MessageBox.Show("Mise à jour non effectuée");
            }
        }

    }
}
