namespace UserTracking.Model
{
    class M_Data :M_Connection
    {

        System.Data.DataTable dt;
        
        public M_Data()
        {
            dt = new System.Data.DataTable();
            
        }
        public System.Data.DataTable GetTimeNow()
        {
            string sql = "SELECT *FROM datetimenow";
            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                base.CloseDbConnection();
                return dt;
            }
            catch(System.Exception exc)
            {
                base.CloseDbConnection();
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
        public System.Data.DataTable GetVigie()
        {
            string sql = "SELECT nom,id  FROM public.vigie_nom where   statut=1 and matricule =" + Controllers.MySession.Matricule; 
           
            try
            {
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(sql, base.DbConnect());
                Npgsql.NpgsqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                base.CloseDbConnection();
                return dt;
            }
            catch (System.Exception exc)
            {
                base.CloseDbConnection();
                System.Windows.Forms.MessageBox.Show(exc.Message);
                dt = null;
                return dt;
            }
        }
    }
}
