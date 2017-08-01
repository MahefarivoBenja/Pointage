using UserTracking.Models.AffectationVigie;

namespace UserTracking.Controllers.AffectationVigie
{
    class C_PopulateGrid
    {
        // table = populate.RechercheRapide(arrayMatricule, agentOperation, nonAffecte);
        public System.Data.DataTable Getata()
        {
            
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
