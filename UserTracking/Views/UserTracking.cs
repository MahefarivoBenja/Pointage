using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UserTracking.Controller;
using UserTracking.Controllers;

namespace UserTracking
{
    public partial class usertracking : Form
    {
        public string info;
        public string operation;
        public string duree;
        DataTable table = new DataTable();
        private ContextMenu refreshGrid = new ContextMenu();
        HexaToString stringInfo = new HexaToString();
        DateTime localDate;
        int i = 1;
        
        public usertracking() /*Constructeur*/
        {

            string affecterMsg = "Cliquer pour visualiser l'utilisateur qui a besoin d'une assistance.";
            string brefresh = "Pour actualiser la liste";
            MySession.Matricule = "1798";
            MySession.Dept = "CC";
            Application.EnableVisualStyles();

            System.Diagnostics.Process[] pname = System.Diagnostics.Process.GetProcessesByName("UserTracking");
            
            if (MySession.Matricule == "")
            {
                MessageBox.Show("Pas de login enregistrer.\nMerci de reconnecter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }

            //outilsToolStripMenuItem
            InitializeComponent();
            
            refreshGrid.MenuItems.Add("Actualiser la liste", new EventHandler(ClickRefresh)); /*Menu dans clic droit*/
            refreshGrid.MenuItems.Add("Voir en détail", new EventHandler(DetailView));
            contentdept.Text = MySession.Dept;
            localDate = InitTime();
            string idNnom = SetVigie();
            string[] infoVigie = idNnom.Split('|');
            idvigie.Text = infoVigie[0].ToString();
            string vigieTest = infoVigie[0].ToString();
            idvigie.Hide();

            if (pname.Length > 1)
            {
                MessageBox.Show("L'outil est déjà lancé");
                Environment.Exit(1); 
            }
                
            if (vigieTest.Trim() =="")
            {
               return;
            }
            else
            {
                contentvigie.Text = infoVigie[1].ToString();
                nbrassist.BackColor = ColorTranslator.FromHtml("#e0218a");
                ShowToolTip(assistance, affecterMsg);/*Afficher info bulle*/
                ShowToolTip(refreshlist, brefresh);
                LoadTableTracking();
                InitRefreshTracking();
            }
            

            
        }

        public void ClearAllGrid(DataGridView view)
        {
            for (int row = 0; row < view.Rows.Count; ++row)
            {
                view.Rows.RemoveAt(row--);
            }
        }
        private void Timertracking_Tick(object sender, EventArgs e)
        {

            timertracking.Enabled = true;
            var culture = new System.Globalization.CultureInfo("fr-FR");
            this.contentheure.Text = localDate.ToString(culture);
            contentheure.Text = localDate.AddSeconds(i).ToString(culture);
            i++;
        }

        private void Usertracking_Load(object sender, EventArgs e)
        {
            timertracking.Enabled = true;
            TransparetBackground(departement);
            TransparetBackground(nomvigie);
            TransparetBackground(contentvigie);
            TransparetBackground(dateheure);
            TransparetBackground(contentheure);
            TransparetBackground(contentdept);
            TransparetBackground(recherche);

            this.timertracking.Interval = 1000;
            timertracking.Start();
        }
        public DateTime InitTime()
        {
            DateTime local;
            string jour = string.Empty;
            string mois = string.Empty;
            string annee = string.Empty;
            string heure = string.Empty;
            string minute = string.Empty;
            string seconde = string.Empty;
            string output = string.Empty;
            string error = string.Empty;

            try
            {
                C_Data timer = new C_Data();
                table = timer.GetTime();
                foreach (DataRow dr in table.Rows)
                {
                    jour = dr["jour"].ToString();
                    mois = dr["mois"].ToString();
                    annee = dr["annee"].ToString();
                    heure = dr["heure"].ToString();
                    minute = dr["minute"].ToString();
                    seconde = dr["seconde"].ToString();
                }
                
                local = new DateTime(int.Parse(annee), int.Parse(mois), int.Parse(jour), int.Parse(heure), int.Parse(minute), int.Parse(seconde));
                return local;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("Error InitTime :" + exc.Message);
                throw;
            }
        }

        private void Refresh_MouseHover(object sender, EventArgs e)
        {
            refresh2.Show();
        }

        private void Refresh2_MouseLeave(object sender, EventArgs e)
        {
            refresh2.Hide();
        }

        private void Refresh2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("..");
        }
        public string SetVigie()
        {
            DataTable listeVigie;
            string bandeauVigie = string.Empty;
            string idVigie = string.Empty;
            C_Data vigie = new C_Data();
            listeVigie = vigie.GetVigie();
            int i = 0;
            foreach (DataRow dr in listeVigie.Rows)
            {
               if( i > 0)
                {
                    bandeauVigie += "\n";
                    idVigie += ",";
                }
                bandeauVigie += dr["nom"].ToString();
                idVigie += dr["id"].ToString();
                i++;
            }
            return idVigie+'|'+bandeauVigie;
        }
        private void ClickRefresh(object sender, EventArgs e)
        {
            try
            {
                string where = string.Empty;
                string idNnom = SetVigie();
                string[] infoVigie = idNnom.Split('|');
                idvigie.Text = infoVigie[0].ToString();
                string vigieTest = infoVigie[0].ToString();
                contentvigie.Text =infoVigie[1].ToString();
                FillTableTracking(where);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Click Item error :" + exc.Message);
            }
        }
        private void DetailView(object sender, EventArgs e)
        {
            try
            {
                Views.V_DetailTracking detail = new Views.V_DetailTracking(this);
                detail.PutData(info,operation,duree);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Click Item error :" + exc.Message);
            }
        }
        public void LoadTableTracking()
        {
            string where = "load";

            userListtracking.AllowUserToAddRows = false;
            userListtracking.Columns.Add("headermatricule","Matricule");
            userListtracking.Columns.Add("headeroperation", "Opération");
            userListtracking.Columns.Add("headerduree", "Durée(h)");
            userListtracking.Columns.Add("statut", "Statut");
            userListtracking.Columns.Add("assistance", "Assistance");

            Color color2 = System.Drawing.ColorTranslator.FromHtml("#34B4E4");
            Color color1 = System.Drawing.ColorTranslator.FromHtml("#d7f1fe");
            userListtracking.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            userListtracking.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            userListtracking.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userListtracking.BackgroundColor = color1;
            userListtracking.ColumnHeadersDefaultCellStyle.BackColor = color2;
            userListtracking.EnableHeadersVisualStyles = false;

            FillTableTracking(where);
        }
        public void FillTableTracking(string where)
        {

            string clauseWhere = where;
            System.Data.DataTable table = new DataTable();
           C_ListUserTracking fillTableTracking = new C_ListUserTracking();
            load.Show();
            this.Enabled = false;
            where = where.Trim();
            string[] stringArrayUser = MyUserList(); 
            
            if (where == "load" || clauseWhere.Length == 0)
            {
                table = fillTableTracking.ListUserTracking(stringArrayUser);
            }
            else if(where == "find_assistance")
            {
                table = fillTableTracking.RechercheAssistance(where, stringArrayUser);
            }
            else if(where.Length >1)
            {
                table = fillTableTracking.RechercheRapide(where, stringArrayUser);
            }
            
            int nbListTracking = table.Rows.Count;
            int i = 0;
            int iAssistance = 0;
            ClearAllGrid(userListtracking);
            userListtracking.DataSource = null;
            
            foreach (DataRow dr in table.Rows)
            {
                string matricule = dr["matricule"].ToString();
                string hexaNom = stringInfo.HexStringToString(dr["hexaprenom"].ToString());
                string fonctioncourante = dr["fonctioncourante"].ToString();
                string operation = dr["id_commande"].ToString();
                string duree = dr["duree_temp"].ToString();
                string assistance = dr["assistance"].ToString();
                string type = dr["type"].ToString();
                userListtracking.Rows.Add();
                userListtracking.Rows[i].Cells[0].Value = matricule +" - "+ hexaNom +" ("+ fonctioncourante + ")";
                iAssistance += int.Parse(assistance);
                if(dr["date_fin"].ToString() == "" || dr["heure_fin"].ToString() == "")
                {
                    if(operation == "xxx" || operation == "")
                    {
                        userListtracking.Rows[i].Cells[3].Value = "en activité";
                        operation = "Aucune";
                    }
                    else
                    {
                        userListtracking.Rows[i].Cells[3].Value = "en cours";
                    }
                }
                else
                {
                    if (operation == "xxx" || operation == "" )
                    {
                        operation = "Aucune";
                        userListtracking.Rows[i].Cells[3].Value = "sortie";
                    }
                    else
                    {
                        userListtracking.Rows[i].Cells[3].Value = "en cours";
                    }
                }
               
                if (assistance == "0")
                {
                    userListtracking.Rows[i].Cells[4].Value = "Aucune demande";
                    userListtracking.Rows[i].Cells[4].Style.BackColor = Color.White;
                }
                 else
                 {
                    userListtracking.Rows[i].Cells[4].Value = "Besoin d'aide";
                    userListtracking.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                userListtracking.Rows[i].Cells[1].Value = operation;
                userListtracking.Rows[i].Cells[2].Value = duree;
                i += 1;
            }

            userListtracking.Cursor = Cursors.Hand;
            userListtracking.Columns[0].Width = 490;
            userListtracking.Columns[1].Width = 75;
            userListtracking.Columns[2].Width = 74;
            userListtracking.Columns[3].Width = 75;
            userListtracking.Columns[4].Width = 110;
            this.Enabled = true;
            if(iAssistance > 0)
            {
                assistance.BackColor = Color.Red;
            }
            else
            {
                assistance.BackColor = Color.SpringGreen;
            }
            load.Hide();
        }

        private void UserListtracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string tempAssist = userListtracking.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (e.ColumnIndex == senderGrid.Columns["assistance"].Index && e.RowIndex >= 0 && tempAssist != "Aucune demande")
            {
                var updateAssistance = MessageBox.Show("Voulez-vous vraiment continuer ?", "Finir l'assistance", MessageBoxButtons.YesNo);
                if (updateAssistance == DialogResult.Yes)
                {

                    string where = "";
                    info = userListtracking.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string[] reelMatricule = System.Text.RegularExpressions.Regex.Split(info, "-");
                    int matriculeAssistance = int.Parse(reelMatricule[0].ToString());
                    C_ListUserTracking update = new C_ListUserTracking();
                    update.UpdateAssistance(matriculeAssistance);
                    FillTableTracking( where);
                }
                else
                {
                    return;
                }
            }
        }
        public void InitRefreshTracking()
        {
            //timerassistance
            refreshtracking = new Timer();
            refreshtracking.Tick += new EventHandler(Refreshtracking_Tick);
            refreshtracking.Interval = 60000; // in miliseconds
            refreshtracking.Start();
        }

        private void Refreshtracking_Tick(object sender, EventArgs e)
        {
            string where = "";
            string idNnom = SetVigie();
            string[] infoVigie = idNnom.Split('|');
            idvigie.Text = infoVigie[0].ToString();
            string vigieTest = infoVigie[0].ToString();
            contentvigie.Text = infoVigie[1].ToString();
            FillTableTracking(where);
        }

        private void Assistance_Click(object sender, EventArgs e)
        {
            string where = "find_assistance";
            FillTableTracking(where);
        }
        public void ShowToolTip(Control c, string msg)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(c, msg);

        }

        private void Rechercheuser_TextChanged(object sender, EventArgs e)
        {
            string where = rechercheuser.Text.ToString();
            //string whereF = where.Trim();
            FillTableTracking(where);
        }

        private void Timerassistance_Tick(object sender, EventArgs e)
        {
           // MessageBox.Show("xxx");
        }

        private void NomVigie(object sender, EventArgs e)
        {
            Views.NomVigie.V_Vigie vigie = new Views.NomVigie.V_Vigie(this);
            vigie.ShowVigieForm();
        }

        private void AffectationVigie(object sender, EventArgs e)
        {
            Views.Affectation.AffectationVigie affectaction = new Views.Affectation.AffectationVigie(this);
            affectaction.ShowAffectationVigie();
        }

        private void Aide(object sender, EventArgs e)
        {
            
            MessageBox.Show("1111");
        }
        public void ShowLoad()
        {
            load.Show();
        }
        public void HideLoad()
        {
            load.Hide();
        }
        public void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }

        private void RightClickTracking(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    int currentMouseOverRow = userListtracking.HitTest(e.X, e.Y).RowIndex;
                    var relativeMousePosition = userListtracking.PointToClient(Cursor.Position);
                    refreshGrid.Show(userListtracking, relativeMousePosition);
                    info = userListtracking.Rows[e.RowIndex].Cells[0].Value.ToString();
                    operation = userListtracking.Rows[e.RowIndex].Cells[1].Value.ToString();
                    duree = userListtracking.Rows[e.RowIndex].Cells[2].Value.ToString();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Show detail error :" + exc.Message);
            }
        }
       public string[] MyUserList()
        {
            try
            {
                System.Data.DataTable listuser = new DataTable();
                C_ListUserTracking fillTableTracking = new C_ListUserTracking();
                
                listuser = fillTableTracking.MyUser(int.Parse(MySession.Matricule), int.Parse(idvigie.Text.ToString()));
                int k = 0;
                int nbUser = listuser.Rows.Count;
                string[] stringArrayUser = new string[nbUser];
                foreach (DataRow user in listuser.Rows)
                {
                    stringArrayUser[k] = user["matricule"].ToString();
                    k += 1;
                    
                }
                return stringArrayUser;
            }
            catch (Exception exc)
            {
                MessageBox.Show("My User List" + exc.Message);
                throw;
            }
            
        }

        private void IntegerOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
