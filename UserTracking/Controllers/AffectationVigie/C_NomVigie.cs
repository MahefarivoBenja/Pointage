using UserTracking.Models.AffectationVigie;

namespace UserTracking.Controllers.AffectationVigie
{
    class C_NomVigie
    {
        public System.Data.DataTable Getadata()
        {
            M_NomVigie conn = new M_NomVigie();
            return conn.ListeVigie();
        }
    }
}
