using Npgsql;
using System;
using UserTracking.Model;

namespace UserTracking.Models.AffectationVigie
{
    class M_CrudDataAffectionVigie : Model.M_Connection
    {
        System.Data.DataTable dt;
        public M_CrudDataAffectionVigie()
        {
            dt = new System.Data.DataTable();
        }

        public void InsertDataVigie(string[,] insertData, int i)
        {
            try
            {
                int matricule;
                int idVigie;
                int matriculeSup = 0;
                int k = 0;

                string operation;
                string ip = "";
                string verou;
                string sMatricule = "";
                string sClause = "";
                string sqlTrace = "";

                string insert_trace = "INSERT INTO vigie_par_affectation_trace( matricule, operation, verou, vigie, dateaffectation,matricule_sup, ip, ip_trace, matricule_trace)";
                string sql = "INSERT INTO vigie_par_affectation(matricule, operation, verou, vigie, matricule_sup, ip, flag)";
                string sqlDelete = "DELETE FROM vigie_par_affectation WHERE matricule in ";

                i--;
                while (i >= 0)
                {
                    verou = insertData[i, 1];
                    matricule = int.Parse(insertData[i, 0].ToString());
                    idVigie = int.Parse(insertData[i, 2].ToString());
                    operation = insertData[i, 3].ToString();
                    ip = insertData[i, 4].ToString();
                    matriculeSup = int.Parse(insertData[i, 5].ToString());

                    if (k == 0)
                    {
                        sClause += matricule.ToString();
                        sql += "VALUES (" + matricule + ", '" + operation + "', '" + verou + "', " + idVigie + "," + matriculeSup + " , '" + ip + "', 1)";
                    }
                    else
                    {
                        sql += ",(" + matricule + ", '" + operation + "', '" + verou + "', " + idVigie + "," + matriculeSup + " , '" + ip + "', 1)";
                        sClause += "," + matricule.ToString();
                    }
                    k++;
                    i--;
                }
                sMatricule += "SELECT matricule, operation, verou, vigie, dateaffectation, matricule_sup, ip, '" + ip + "'," + matriculeSup + " FROM vigie_par_affectation ";
                sMatricule += " where matricule in (" + sClause + ")";
                sqlTrace += insert_trace + " " + sMatricule;
                sqlDelete += "(" + sClause + ")";

                NpgsqlCommand insert = new NpgsqlCommand(sql, base.DbConnect());
                NpgsqlCommand queryTrace = new NpgsqlCommand(sqlTrace, base.DbConnect());
                NpgsqlCommand queryDelete = new NpgsqlCommand(sqlDelete, base.DbConnect());

                queryTrace.ExecuteNonQuery();
                queryDelete.ExecuteNonQuery();
                int aCheck = insert.ExecuteNonQuery();
                if(aCheck > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Enregistrement effectué ");
                }
                base.CloseDbConnection();
            }
            catch (Exception exc)
            {
                base.CloseDbConnection();
                System.Windows.Forms.MessageBox.Show("Insert Data Vigie :" + exc.Message);
            }

        }
        public System.Data.DataTable ShowInfoPers(int matricule)
        {
            string sql = @"
               select temp1.matricule_sup, hexaprenom,fonctioncourante,temp1.verou,temp1.vigie,vigie_nom.nom,temp1.operation from (
                    SELECT  infosup.matricule_sup,infosup.operation,infosup.verou,infosup.vigie 
                    FROM vigie_par_affectation infosup    
                    left join personnel on personnel.matricule = infosup.matricule_sup    
                    where infosup.matricule ="+matricule+" )  " +
                  " as temp1 left join personnel on temp1.matricule_sup = personnel.matricule    "+
                  " left join vigie_nom on vigie_nom.id = temp1.vigie";
            
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
