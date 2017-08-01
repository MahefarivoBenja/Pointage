using MetroFramework.Forms;
using System;
using System.Data;
using UserTracking.Controllers.AffectationVigie;

namespace UserTracking.Views.Affectation
{
    public partial class V_DetailPers : MetroForm
    {
        private readonly AffectationVigie frmVigie;
        Controller.HexaToString stringInfo = new Controller.HexaToString();
        public V_DetailPers(AffectationVigie frmI)
        {
            InitializeComponent();
            frmVigie = frmI;
            frmI.Enabled = false;
            this.BringToFront();
            this.Owner = frmI;
            
        }


        public void PutDataInFrm(string value)
        {
            C_CrudDataAffectionVigie infoPers = new C_CrudDataAffectionVigie();
            string[] reelMatricule = System.Text.RegularExpressions.Regex.Split(value, "-");
            int matr = int.Parse(reelMatricule[0].ToString());
            System.Data.DataTable info = infoPers.ShowInfoPers(matr);
            string nomVigie = "Non défini";
            string operation = "Non définie";
            string infosup = "Non défini";
            string statut = "Non défini";
            int countDt = info.Rows.Count;
            if (countDt != 0)
            {
                foreach (DataRow dr in info.Rows)
                {
                    nomVigie = dr["nom"].ToString();
                    operation = (dr["operation"].ToString() == "") ? "Non définie": dr["operation"].ToString();
                    infosup = dr["matricule_sup"].ToString() + " - " + stringInfo.HexStringToString(dr["hexaprenom"].ToString()) + " (" + dr["fonctioncourante"] + ") ";
                    statut = "" + dr["verou"].ToString();
                }
            }

            detailmatr.Text = value;
            vigiepers.Text = nomVigie;
            operatpers.Text = operation;
            suppers.Text = infosup;
            state.Text = statut;
            this.Show();
        }

        private void V_DetailPers_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            frmVigie.Enabled = true;
            frmVigie.Activate();
        }
    }
}
