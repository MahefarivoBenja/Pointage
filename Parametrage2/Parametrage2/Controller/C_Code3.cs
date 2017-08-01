using Parametrage2.Model;

namespace Parametrage2.Controller
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
