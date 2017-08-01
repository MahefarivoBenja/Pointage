using System.Data;

namespace UserTracking.Controllers.NomVigie
{
    class C_NomVigie
    {
        public DataTable GetData(string whreVigie)
        {
            Models.NomVigie.M_NomVigie vigie = new Models.NomVigie.M_NomVigie();
            return vigie.ExecuteNreadQueries(whreVigie);
        }
        public int InsertVigie(string txt, int flag)
        {
            Models.NomVigie.M_NomVigie vigie = new Models.NomVigie.M_NomVigie();
            return vigie.InsertVigie(txt, flag);
        }
        public DataTable CheckNbrVigie()
        {
            Models.NomVigie.M_NomVigie check = new Models.NomVigie.M_NomVigie();
            return check.CheckNbrVigie();
        }
        public void UpdateVigieDB(string text1, int id,int etat)
        {
            Models.NomVigie.M_NomVigie update = new Models.NomVigie.M_NomVigie();
            update.UpdateVigieDB(text1, id,etat);
        }
    }
}
