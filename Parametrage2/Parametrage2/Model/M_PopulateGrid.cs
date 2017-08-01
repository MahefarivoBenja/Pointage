using System;
using System.Data;
using Npgsql;

namespace Parametrage2.Model
{
    class M_PopulateGrid
    {
        System.Data.DataTable dt;
        M_Connection connection;
        public M_PopulateGrid()
        {
            dt = new System.Data.DataTable();
            connection = new M_Connection();
        }
        public DataTable ListUser()
        {
            string matricule = Controller.MySession.Matricule;
            string dept = Controller.MySession.Dept;

            string sql = @"
                 SELECT personnel.matricule,
                       info,
                        hexaprenom,fonctioncourante,
                       CASE
                           WHEN vg.matricule IS NOT NULL THEN 1
                           ELSE 0
                       END AS tocheck,
                       CASE
                           WHEN vg.verou <>'' THEN vg.verou
                           ELSE 'NON'
                       END AS etatverou
                FROM
                  (SELECT matricule,hexaprenom,fonctioncourante, matricule  AS info
                   FROM personnel
                   WHERE  deptcourant = '" + dept + "'";
            sql +="ORDER BY matricule) AS personnel LEFT JOIN vigie_par_affectation vg ON vg.matricule= personnel.matricule ORDER BY personnel.matricule ";
            /*string sql = @"SELECT idvigienom, nom FROM vigie_nom order by idvigienom  desc";*/

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
        public DataTable ListeRechercheRapide(string[] arrayMatricule, string agentOperation, string nonAffecte)
        {
            string matricule = String.Join(",", arrayMatricule);
            string sqlClause = "";
            string sqlClauseAff = "";
            string sqlClauseOp = "";
            if (matricule !="")
            {
                sqlClause += "AND personnel.matricule in(" + matricule + ")";
            }
            if (nonAffecte == "1" && matricule != "")
            {
                sqlClauseAff += "AND vg.matricule in (" + matricule + ")";
            }
            else if(nonAffecte == "2" && matricule != "")
            {
                sqlClauseAff += "AND personnel.matricule not in(select distinct matricule from vigie_par_affectation where matricule  in (" + matricule + "))";
                sqlClauseAff += "AND  personnel.matricule in (" + matricule + ")";
            }
            if (nonAffecte == "1" && matricule == "")
            {
                sqlClauseAff += "AND vg.vigie <> 0";
            }
            else if (nonAffecte == "2" && matricule == "")
            {
                sqlClauseAff += "AND personnel.matricule not in (select distinct matricule from vigie_par_affectation where vigie <> 0)";
            }
            if(agentOperation == "1")
            {
                sqlClauseOp += "AND personnel.matricule  in (select distinct matricule from vigie_par_affectation where operation <>'' )";
            }
            else if(agentOperation == "2")
            {
                sqlClauseOp += "AND personnel.matricule  in (select distinct matricule from vigie_par_affectation where operation ='' )";
            }


            string dept = Controller.MySession.Dept;
            string sql = @"
                 SELECT personnel.matricule,
                       info, hexaprenom,fonctioncourante,
                       CASE
                           WHEN vg.matricule IS NOT NULL THEN 1
                           ELSE 0
                       END AS tocheck,
                       CASE
                           WHEN vg.verou <>'' THEN vg.verou
                           ELSE 'NON'
                       END AS etatverou
                FROM
                  (SELECT matricule,hexaprenom,fonctioncourante,matricule AS info
                   FROM personnel
                   WHERE  deptcourant = '" + dept + "'";
            sql += "ORDER BY matricule) AS personnel LEFT JOIN vigie_par_affectation vg ON vg.matricule= personnel.matricule where 1=1";
            sql += sqlClause;
            sql += sqlClauseAff;
            sql += sqlClauseOp;
            sql += " ORDER BY personnel.matricule";
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
        public DataTable ListeMatricule()
        {
            string sql = @"
                  SELECT matricule,
                    hexaprenom,fonctioncourante,fonctioncourante AS info
                FROM personnel
                WHERE 
                  deptcourant = 'CC'
                ORDER BY matricule";
            /*string sql = @"SELECT idvigienom, nom FROM vigie_nom order by idvigienom  desc";*/

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
