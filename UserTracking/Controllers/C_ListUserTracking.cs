using UserTracking.Model;
namespace UserTracking.Controller
{
    class C_ListUserTracking
    {
        public System.Data.DataTable ListUserTracking(string[] stringArrayUser)
        {
            M_ListUserTracking listUser = new M_ListUserTracking();
            return listUser.ListUserTracking(stringArrayUser);
        }
        public System.Data.DataTable RechercheRapide(string where, string[] stringArrayUser)
        {
            M_ListUserTracking listUser = new M_ListUserTracking();
            return listUser.RechercheRapide(where, stringArrayUser);
        }
        public System.Data.DataTable RechercheAssistance(string where, string[] stringArrayUser)
        {
            M_ListUserTracking listUser = new M_ListUserTracking();
            return listUser.RechercheAssistance(where, stringArrayUser);
        }
        public System.Data.DataTable GetDetailTrack(int matr)
        {
            M_ListUserTracking listUser = new M_ListUserTracking();
            return listUser.GetDetailTrack(matr);
        }
        
        public System.Data.DataTable MyUser(int matrSup, int vigie)
        {
            M_ListUserTracking listUser = new M_ListUserTracking();
            return listUser.MyUser(matrSup, vigie);
        }
        public void UpdateAssistance(int matricule)
        {
            M_ListUserTracking update = new M_ListUserTracking();
            update.UpdateAssistance(matricule);
        }
    }
}
