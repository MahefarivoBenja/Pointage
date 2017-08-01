using UserTracking.Models.AffectationVigie;

namespace UserTracking.Controllers.AffectationVigie
{
    class C_CrudDataAffectionVigie
    {
        public void InsertDataVigie(string[,] arrayInsert, int i)
        {
            M_CrudDataAffectionVigie insert = new M_CrudDataAffectionVigie();
            insert.InsertDataVigie(arrayInsert, i);
        }//ShowInfoPers(int matricule)
        public System.Data.DataTable ShowInfoPers(int matricule)
        {
            M_CrudDataAffectionVigie infoPers = new M_CrudDataAffectionVigie();
            return infoPers.ShowInfoPers(matricule);
        }
    }
}
