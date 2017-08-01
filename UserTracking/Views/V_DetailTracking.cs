using System.Windows.Forms;
using MetroFramework.Forms;
namespace UserTracking.Views
{
    public partial class V_DetailTracking : MetroForm
    {
        private readonly usertracking formBack;
        public V_DetailTracking(usertracking tracking)
        {
            formBack = tracking;
            this.BringToFront();
            tracking.Enabled = false;
            this.Owner = tracking;
            InitializeComponent();
        }
        public void PutData(string info,string operation,string duree)
        {
            
            string debut = string.Empty;
            string fin = string.Empty;
            string[] reelMatricule = System.Text.RegularExpressions.Regex.Split(info, "-");
            int matr = int.Parse(reelMatricule[0].ToString());
            
            System.Data.DataTable table = new System.Data.DataTable();
            Controller.C_ListUserTracking detail = new Controller.C_ListUserTracking();
            table = detail.GetDetailTrack(matr);
            
            t_matr.Text = info;
            t_op.Text = (operation == "") ? "Non définie" : operation;
            t_duree.Text = (duree == "") ? "0 heure" : duree +" heures";
            this.Show();

            try
            {
                table = detail.GetDetailTrack(matr);
                foreach (System.Data.DataRow dr in table.Rows)
                {
                    debut = dr["debut"].ToString();
                    fin = (dr["fin"].ToString() == "") ? "Non défini" : dr["fin"].ToString();
                }
                t_deb.Text = debut;
                t_fin.Text = fin;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
        }

        private void DetailTrackingClosing(object sender, FormClosingEventArgs e)
        {
            formBack.Enabled = true;
            formBack.Show();
        }
    }
}
