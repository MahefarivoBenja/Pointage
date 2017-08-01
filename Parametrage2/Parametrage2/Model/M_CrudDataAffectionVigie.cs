using Npgsql;
using System;
using System.Data;

namespace Parametrage2.Model
{
    class M_CrudDataAffectionVigie
    {
        System.Data.DataTable dt;
        M_Connection connection;
        public M_CrudDataAffectionVigie()
        {
            dt = new System.Data.DataTable();
            connection = new M_Connection();
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
                string ip="";
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
                   
                    if ( k == 0)
                    {
                        sClause += matricule.ToString();
                        sql += "VALUES ("+ matricule + ", '"+ operation + "', '"+ verou + "', "+ idVigie + ","+ matriculeSup + " , '"+ ip + "', 1)";
                    }
                    else
                    {
                        sql += ",("+ matricule + ", '"+ operation +"', '"+ verou + "', "+ idVigie + ","+ matriculeSup + " , '"+ ip +"', 1)";
                        sClause += ","+matricule.ToString();
                    }
                     k++;
                     i--;
                }
                sMatricule += "SELECT matricule, operation, verou, vigie, dateaffectation, matricule_sup, ip, '"+ ip + "',"+ matriculeSup + " FROM vigie_par_affectation ";
                sMatricule += " where matricule in (" + sClause + ")";
                sqlTrace += insert_trace + " " + sMatricule;
                sqlDelete += "("+ sClause + ")";
                
                NpgsqlCommand insert = new NpgsqlCommand(sql, connection.DbConnect());
                NpgsqlCommand queryTrace = new NpgsqlCommand(sqlTrace, connection.DbConnect());
                NpgsqlCommand queryDelete = new NpgsqlCommand(sqlDelete, connection.DbConnect());

                queryTrace.ExecuteNonQuery();
                queryDelete.ExecuteNonQuery(); 
                insert.ExecuteNonQuery();
                connection.CloseDbConnection();
            }
            catch(Exception exc)
            {
                connection.CloseDbConnection();
                System.Windows.Forms.MessageBox.Show("Insert Data Vigie :"+exc.Message);
            }
            
        }
        public DataTable ShowInfoPers(int matricule)
        {
            string sql = @"
                select vi,op,infosup,statut from (
                    SELECT id_affectation, matricule, operation, verou, vigie, dateaffectation, 
                           matricule_sup, ip, flag,
                           case when vigie = 0 then 'Non défini' else (SELECT nom FROM vigie_nom where id = vigie) end as vi,
                           case when operation ='' then 'Non définie' else  operation end as op,
                           case when matricule is  null then 'Non défini' else 
	                    (select  matricule || ' - ' || prenompersonnel || ' (' || fonctioncourante || ')' from personnel where matricule = matricule_sup )end as infosup,
	                    case when verou  <>'' then verou else 'Non défini' end as statut
                      FROM vigie_par_affectation where 
                      matricule = "+matricule+") as infopers";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection.DbConnect());
            try
            {
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
