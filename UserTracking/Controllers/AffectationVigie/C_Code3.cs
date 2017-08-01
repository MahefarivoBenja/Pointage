using UserTracking.Models.AffectationVigie;

namespace UserTracking.Controllers.AffectationVigie
{
    class C_Code3
    {
        public System.Data.DataTable Gedata()
        {
            M_Code3 conn = new M_Code3();
            return conn.ListeCode3();
        }
    }
}
