using Parametrage2.Model;
namespace Parametrage2.Controller
{
    class C_PopulateGrid
    {
        // table = populate.RechercheRapide(arrayMatricule, agentOperation, nonAffecte);
        public System.Data.DataTable Getata()
        {
            MySession.Matricule = "1798";
            MySession.Dept = "CC";
            M_PopulateGrid conn = new M_PopulateGrid();
            return conn.ListUser();
        }
        public System.Data.DataTable RechercheRapide(string[] arrayMatricule, string agentOperation, string nonAffecte)
        {
            M_PopulateGrid conn = new M_PopulateGrid();
            return conn.ListeRechercheRapide(arrayMatricule, agentOperation, nonAffecte);
        }
        public System.Data.DataTable GetFiltreMatricule()
        {
            M_PopulateGrid conn = new M_PopulateGrid();
            return conn.ListeMatricule();
        }
    }
}
