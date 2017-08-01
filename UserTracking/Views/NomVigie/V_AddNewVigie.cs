using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace UserTracking.Views.NomVigie
{
    public partial class V_AddNewVigie : Form
    {
        private readonly V_Vigie vigiePreced;
        public int id = 0;

        
        public V_AddNewVigie(V_Vigie pass)
        {
            vigiePreced = pass;
            this.Owner = pass;
            pass.Enabled = false;
            InitializeComponent();
            Populate(on);
            this.Text = "Ajouter un vigie ";
            TransparetBackground(nmvigieadd);
            
        }

        public void UpdateVigie(string info, string statut, int idVigie)
        {
            id = idVigie;
            vigienom.Text = info;
            save.Text = "Modifier";
            on.Text = statut;
            this.Text = "Modifier un vigie ";
            this.Show();
        }
        private void CloseAddForm(object sender, FormClosingEventArgs e)
        {
            vigiePreced.Enabled = true;
            vigiePreced.Activate();
            vigiePreced.FillGridVigie();
        }
        private void Populate(ComboBox str)
        {
            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            data.Add(new KeyValuePair<int, string>(0, "Déscativer"));
            data.Add(new KeyValuePair<int, string>(1, "Activer"));

            // Clear the combobox
            str.DataSource = null;
            str.Items.Clear();

            // Bind the combobox
            str.DataSource = new BindingSource(data, null);
            str.DisplayMember = "Value";
            str.ValueMember = "Key";

            //Set font combobox
            str.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

        private void EnregistrerNom(object sender, System.EventArgs e)
        {
            string nom = vigienom.Text.ToString();
            System.Data.DataTable dt;
            int matrSession = int.Parse(Controllers.MySession.Matricule);
            int retour ;
            int check = 0;
            string etat = on.SelectedValue.ToString();
            
            
            Controllers.NomVigie.C_NomVigie insert = new Controllers.NomVigie.C_NomVigie();
          
            // 
            dt = insert.CheckNbrVigie();
            check = int.Parse(dt.Rows[0][0].ToString());
            if(check > 0 && etat == "1")
            {
                MessageBox.Show(check+"Vous ne pouvez pas activer deux vigies simultanément.");
                return;
            }
            else
            {
               
                if(id > 0)
                {
                    insert.UpdateVigieDB(nom, id, int.Parse(etat));
                }
                else
                {
                    retour = insert.InsertVigie(nom, int.Parse(etat));
                    if (retour == 1)
                    {
                        MessageBox.Show("Enregistement effectué");
                        vigienom.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Enregistement échoué.\n Merci de refaire.");
                    }
                }
            }
            
        }

        private void Annuler_Click(object sender, System.EventArgs e)
        {
            this.Close();
           
        }

        private void VigieRapide(object sender, System.EventArgs e)
        {
            MessageBox.Show("xx");

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
    }
}
