using Parametrage2.Model;
namespace Parametrage2.Controller
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
