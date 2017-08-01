using UserTracking.Model;

namespace UserTracking.Controller
{
    class C_Data
    {
        public System.Data.DataTable GetTime()
        {
            M_Data timer = new M_Data();
            return timer.GetTimeNow();
        }
        public System.Data.DataTable GetVigie()
        {
            M_Data vigie = new M_Data();
            return vigie.GetVigie();
        }
       
    }
}
