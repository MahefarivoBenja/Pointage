using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using MetroFramework.Forms;
using System.Windows.Forms;
using Parametrage2.Controller;


namespace Parametrage2
{
    public partial class AffectationVigie : Form
    {
        private ContextMenu rightClickGrid = new ContextMenu();
        C_ManipulateData getIp = new C_ManipulateData();
        HexaToString stringInfo = new HexaToString();
        private string infoPers ;

        public static AffectationVigie formI;

        public void Testc()
        {
            
           
        }
        public AffectationVigie()
        {
            string AffecterMsg = "Permet d'enregistrer/ ou de modifier l'élément coché"; 
            formI = this;
            
            rightClickGrid.MenuItems.Add("Voir en détail", new EventHandler(ClickItem));
            SetFont();
            PopulateFiltreMatricule();
            PopulateAgentNonAffecte();
            PopulateAgentOperation();
            LoadGridAffectation();
            PopulateOperatation();
            PopulateVigie();
            populate(nonaffecte);
            populate(agentoperation);
            
            
            ShowToolTip(affectation, AffecterMsg);
            InitializeComponent();
        }


        public void ShowToolTip(Control c,string msg)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(c, msg);
        }
        public void LoadGridAffectation()
        {
            //Creating checkbox column for DataGridView:
            C_PopulateGrid populate = new C_PopulateGrid();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            C_ManipulateData useData = new C_ManipulateData();
            
            
            GridVigieAffection.AllowUserToAddRows = false;
            //filtre_matricule
            
            
            chk.HeaderText = "Cocher\n"; 
            chk.Name = "chk";
            chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            chk.ThreeState = false;

           
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Verouiller \n";


            //Adding Item to ComBoxColumn:
            changetout.Items.Add("NON");
            changetout.Items.Add("OUI");


            
            combo.Items.Add("OUI");
            combo.Items.Add("NON");
            combo.FlatStyle = FlatStyle.Flat;

            GridVigieAffection.Columns.Insert(0, chk);
            GridVigieAffection.Columns.Add("", "Information personnelle\n");
            GridVigieAffection.Columns.Insert(2, combo);



            //Assign Width For Columns:

            GridVigieAffection.Columns[0].Width = 70;
            GridVigieAffection.Columns[1].Width = 575;
            GridVigieAffection.Columns[2].Width = 110;


            //Color and Font Design For DataGridView:
            Color color2 = System.Drawing.ColorTranslator.FromHtml("#34B4E4");
            GridVigieAffection.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            GridVigieAffection.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            GridVigieAffection.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            changetout.BackColor = color2;
            changetout.ForeColor = Color.White;
            pictureBox1.BackColor = color2;
            tmpcombo.BackColor = color2;
            tmpcombo.ForeColor = Color.White;

            GridVigieAffection.ColumnHeadersDefaultCellStyle.BackColor = color2;
            GridVigieAffection.EnableHeadersVisualStyles = false;
            
           FillGrid();
        }

        
        private void FillGrid()
        {
            try
            {
                Application.UseWaitCursor = true;

                C_PopulateGrid populate = new C_PopulateGrid();
                GridVigieAffection.Refresh();
                GridVigieAffection.AllowUserToAddRows = false;
                DataTable table = new DataTable();
                table = populate.Getata();
                int nbList = table.Rows.Count;
                int i = 0;
                infodata.Show();
               
                foreach (DataRow dr in table.Rows)
                {
                    string test = dr["matricule"] + " - " + stringInfo.HexStringToString(dr["hexaprenom"].ToString()) + " (" + dr["fonctioncourante"] + ") ";
                    string etaverou = dr["etatverou"].ToString();
                    //add a row int datagridview before fill
                    GridVigieAffection.Rows.Add();
                    //fill the first cell value ot ith row of datagridview
                    int tocheck = int.Parse(dr["tocheck"].ToString());
                    if(tocheck == 1)
                    {
                        GridVigieAffection.Rows[i].Cells[0].Value = true;
                    }
                    else
                    {
                        GridVigieAffection.Rows[i].Cells[0].Value = false;
                    }
                   
                    GridVigieAffection.Rows[i].Cells[1].Value = test;
                    //here for combobx column (cast the column as datagridviewcombobox column)
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)GridVigieAffection.Rows[i].Cells[2];
                    //then assign the value of cell                
                    cell.Value = etaverou;
                   
                    infodata.Hide();
                    i++;
                }
                
                Application.UseWaitCursor = false;
                if (i < 12)
                {
                    changetout.Location = new Point(670, 205);
                    pictureBox1.Location = new Point(665,205);
                    tmpcombo.Location = new Point(665, 205);
                }
                else
                {
                    changetout.Location = new Point(653, 205);
                    pictureBox1.Location = new Point(650, 205);
                    tmpcombo.Location = new Point(650, 205);
                }
                

            }

            catch (Exception exc)
            {
                
                MessageBox.Show("Charging GridVigieAffection error 1:" + exc.Message);
            }

        }

        private void clearGrid(DataGridView view)
        {
            for (int row = 0; row < view.Rows.Count; ++row)
            {
                bool isEmpty = true;
                for (int col = 0; col < view.Columns.Count; ++col)
                {
                    object value = view.Rows[row].Cells[col].Value;
                    
                    if (value != null && value.ToString().Length > 0)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (isEmpty)
                {
                    // deincrement (after the call) since we are removing the row
                    view.Rows.RemoveAt(row--);
                }

            }
        }
        public void RemoveDuplicate(DataGridView grv)
        {
            for (int currentRow = 0; currentRow < grv.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = grv.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow < grv.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = grv.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        grv.Rows.Remove(row);
                        otherRow--;
                    }
                }
            }
        }
        public void ClearAllGrid(DataGridView view)
        {
            for (int row = 0; row < view.Rows.Count; ++row)
            {
                view.Rows.RemoveAt(row--);
            }
        }


        public void PopulateOperatation()
        {
            try
            {
                C_Code3 operation = new C_Code3();
                DataTable listeCode = new DataTable();
                int i = 0;
                listeCode = operation.Gedata();
                List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
                data.Add(new KeyValuePair<int, string>(0, "--Choisir--"));

                foreach (DataRow dr in listeCode.Rows)
                {
                    i++;
                    string idcommande = dr["idcommande"].ToString();
                    data.Add(new KeyValuePair<int, string>(i, idcommande));
                }
                liste_operation.DataSource = null;
                liste_operation.Items.Clear();

                liste_operation.DataSource = new BindingSource(data, null);
                liste_operation.DisplayMember = "Value";
                liste_operation.ValueMember = "Key";
                liste_operation.Font = new Font("Calibri", 11, FontStyle.Regular);

                


            }
            catch (Exception exc)
            {
                MessageBox.Show("Loading operation error : " + exc.Message);
            }
        }



        public void PopulateVigie()
        {
            try
            {
                C_NomVigie vigie = new C_NomVigie();
                DataTable listeVigie = vigie.Getadata();
                List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
                data.Add(new KeyValuePair<int, string>(0, "--Choisir--"));
                foreach (DataRow dr in listeVigie.Rows)
                {
                    string nomVigie = dr["nom"].ToString();
                    int id = int.Parse(dr["id"].ToString());
                    data.Add(new KeyValuePair<int, string>(id, nomVigie));
                    
                }
                nom_vigie.DataSource = null;
                nom_vigie.Items.Clear();

                nom_vigie.DataSource = new BindingSource(data, null);
                nom_vigie.DisplayMember = "Value";
                nom_vigie.ValueMember = "Key";
                nom_vigie.Font = new Font("Calibri", 11, FontStyle.Regular);
            }
                
            catch (Exception exc)
            {
                MessageBox.Show("Vigie : " + exc.Message);
            }
        }
    


        private void nom_vigie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TriggerGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)//set your checkbox column index instead of 2
            {
               /* if (Convert.ToBoolean(GridVigieAffection.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == true)
                {
                    string info = GridVigieAffection.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //  
                    //MessageBox.Show(""+info);
                    if (checkBox1.Checked == true)
                    {
                        checkBox1.Checked = false;
                    }
                }*/

            }
        }

        private void PopulateFiltreMatricule() 
        {
            try
            {
                C_PopulateGrid listeMatr = new C_PopulateGrid();
                DataTable listeM = new DataTable();
                listeM = listeMatr.GetFiltreMatricule();
                filtre_matricule.Text = "--Choisir--";

                foreach (DataRow dr in listeM.Rows)
                {
                    int iMatr = 0;
                    string matricule = dr["matricule"].ToString();
                    string info = dr["matricule"] + " - " + stringInfo.HexStringToString(dr["hexaprenom"].ToString()) + " (" + dr["fonctioncourante"] + ") ";
                    iMatr = int.Parse(matricule);
                    CCBoxItem item = new CCBoxItem(info, iMatr);
                    filtre_matricule.Items.Add(item.Names.ToString());

                }


                filtre_matricule.Font = new Font("Calibri", 11, FontStyle.Regular);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Populate Filtre Matricule : " + exc.Message);
            }
        }
        private void PopulateAgentNonAffecte()
        {
            try
            {
                C_Code3 operation = new C_Code3();
                DataTable listeCode = new DataTable();
                int i = 0;
                listeCode = operation.Gedata();
                
                foreach (DataRow dr in listeCode.Rows)
                {
                    string code3 = dr["idcommande"].ToString();
                    CCBoxItem item = new CCBoxItem(code3, i);
                    
                    i++;
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Populate Agent Non Affecte : " + exc.Message);
            }
        }
        // agent_operation
        private void PopulateAgentOperation()
        {
            try
            {
                C_Code3 operation = new C_Code3();
                DataTable listeCode = new DataTable();
                int i = 0;
                listeCode = operation.Gedata();
                
                foreach (DataRow dr in listeCode.Rows)
                {
                    string code3 = dr["idcommande"].ToString();
                    CCBoxItem item = new CCBoxItem(code3, i);
                    i++;
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Populate Agent Operation : " + exc.Message);
            }
        }
        private void SetFont()
        {
            
            label2.Font = new Font("Calibri", 10, FontStyle.Regular);
            label3.Font = new Font("Calibri", 10, FontStyle.Regular);
            label4.Font = new Font("Calibri", 10, FontStyle.Regular);
            label6.Font = new Font("Calibri", 10, FontStyle.Regular);
            label7.Font = new Font("Calibri", 10, FontStyle.Regular);
            affectation.Font = new Font("Calibri", 10, FontStyle.Regular);
            button2.Font = new Font("Calibri", 10, FontStyle.Regular);
            changetout.Font = new Font("Calibri", 10, FontStyle.Regular);
            tmpcombo.Font = new Font("Calibri", 11, FontStyle.Regular);
            

        }
        private void Rechercher(object sender, EventArgs e)
        {
            C_ManipulateData useData = new C_ManipulateData();

            string matricule = null;
            string matriculeFinal = null;

            matricule = filtre_matricule.Text.ToString();
            string[] listeMatricule = useData.ListeMatricule(matricule);
            matriculeFinal = string.Join(", ", listeMatricule);
            MessageBox.Show("" + matriculeFinal);

        }

        private void filtre_matricule_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void changetout_SelectedIndexChanged(object sender, EventArgs e)
        {
            string test = GridVigieAffection.Rows.Count.ToString();
            string allValue = changetout.Text;
            tmpcombo.Text = allValue;
            for (int i = 0; i < GridVigieAffection.Rows.Count; i++)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)GridVigieAffection.Rows[i].Cells[2];
                cell.Value = allValue;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    for (int i = 0; i < GridVigieAffection.Rows.Count; i++)
                    {
                        GridVigieAffection.Rows[i].Cells[0].Value = true;
                    }
                    GridVigieAffection.Rows[0].Cells[0].Value = true;
                    checkBox1.Checked = true;
                }
                else
                {
                    for (int i = 0; i < GridVigieAffection.Rows.Count; i++)
                    {
                        GridVigieAffection.Rows[i].Cells[0].Value = false;
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("All check box : " + exc.Message);
            }

        }

        private void GridVigieAffection_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridViewRow row = GridVigieAffection.SelectedRows[0];
            }
        }

        private void InsertInDB(object sender, EventArgs e)
        {
            try
            {
                C_CrudDataAffectionVigie crud = new C_CrudDataAffectionVigie();
                C_ManipulateData useData = new C_ManipulateData();
                this.Enabled = false;
                string ip = getIp.GetLocalIpAddress();
                string operation = liste_operation.Text;
                int i = 0;
                KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)nom_vigie.SelectedItem;
                int idVigie = int.Parse(selectedPair.Key.ToString());
                int countGrid = GridVigieAffection.Rows.Count;
                string[,] arrayInsert = new string[countGrid, 6];
                if (idVigie == 0)
                {
                    
                    MessageBox.Show("Merci de choisir un \"vigie\"", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); //For triangle Warnin);
                    this.Enabled = true;

                }
                else
                {
                    foreach (DataGridViewRow row in GridVigieAffection.Rows)
                    {
                        string checkBox = row.Cells[0].Value.ToString();

                        string tempMatricule = row.Cells[1].Value.ToString();
                        string[] reelMatricule = System.Text.RegularExpressions.Regex.Split(tempMatricule, "-");
                        string imatr = reelMatricule[0].ToString();
                        string verou = row.Cells[2].Value.ToString();
                        string matriculeSup = MySession.Matricule;

                        if (verou == "--Choisir--")
                        {
                            verou = "";
                        }
                        if (operation == "--Choisir--")
                        {
                            operation = "";
                        }
                        if (checkBox == "True")
                        {
                            //(string matricule, string verou, int nomVigie, string operation, string ip, string matriculeSup)
                            arrayInsert[i, 0] = imatr;
                            arrayInsert[i, 1] = verou;
                            arrayInsert[i, 2] = idVigie.ToString();
                            arrayInsert[i, 3] = operation;
                            arrayInsert[i, 4] = ip;
                            arrayInsert[i, 5] = matriculeSup;
                            i++;
                            //crud.InsertDataVigie(imatr, verou, idVigie, operation, ip,  matriculeSup);
                        }
                    }
                    if (i == 0)
                    {
                        
                        MessageBox.Show("Merci de cocher au moins un matricule");
                        this.Enabled = true;
                    }
                    else
                    {
                        int contArray = arrayInsert.Length;
                        crud.InsertDataVigie(arrayInsert, i);
                        this.Enabled = true;
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Insert DB : " + exc.Message);
                affectation.Enabled = true;
            }
        }

        private void AffectationVigie_Load(object sender, EventArgs e)
        {
            
        }
       /* protected override void OnPaintBackground(PaintEventArgs e)
        {
            //nom_vigie
            base.OnPaintBackground(e);
            Rectangle rc = new Rectangle(filtre_matricule.Left - 1, filtre_matricule.Top - 1,
              filtre_matricule.Size.Width + 1, filtre_matricule.Size.Height + 1);

            Rectangle rcx = new Rectangle(agent_non_affecte.Left - 1, agent_non_affecte.Top - 1,
             filtre_matricule.Size.Width + 2, agent_non_affecte.Size.Height + 1);

            Rectangle rci = new Rectangle(agent_operation.Left - 1, agent_operation.Top - 1,
             filtre_matricule.Size.Width + 2, agent_operation.Size.Height + 1);

            Rectangle rct = new Rectangle(liste_operation.Left - 1, liste_operation.Top - 1,
             liste_operation.Size.Width + 1, agent_operation.Size.Height + 1);

            Rectangle rcv = new Rectangle(nom_vigie.Left - 1, nom_vigie.Top - 1,
             nom_vigie.Size.Width + 1, nom_vigie.Size.Height + 1);


            e.Graphics.DrawRectangle(Pens.LightSlateGray, rci);
            e.Graphics.DrawRectangle(Pens.LightSlateGray, rcx);
            e.Graphics.DrawRectangle(Pens.LightSlateGray, rc);
            e.Graphics.DrawRectangle(Pens.LightSlateGray, rct);
            e.Graphics.DrawRectangle(Pens.LightSlateGray, rcv);
        }*/

        private void reinit_Click(object sender, EventArgs e)
        {
            C_ManipulateData useData = new C_ManipulateData();
            useData.ResetFiltre(filtre_matricule);
            populate(nonaffecte);
            populate(agentoperation);
        }

        private void RightClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    int currentMouseOverRow = GridVigieAffection.HitTest(e.X, e.Y).RowIndex;
                    var relativeMousePosition = GridVigieAffection.PointToClient(Cursor.Position);
                    rightClickGrid.Show(GridVigieAffection, relativeMousePosition);
                    string info = GridVigieAffection.Rows[e.RowIndex].Cells[1].Value.ToString();
                    infoPers = info; /*userListtracking*/

                }
            }
            catch (Exception exc)
            {
               MessageBox.Show("Show detail error :" + exc.Message);
            }
              
        }
        private void ClickItem(object sender, EventArgs e)
        {
            try
            {
                /*V_DetailPers detailPers = new V_DetailPers(this);
                string value = infoPers;
                detailPers.PutDataInFrm(value);
                infoPers = "";*/
            }
            catch(Exception exc)
            {
                MessageBox.Show("Click Item error :" + exc.Message);
            }
        }
        private void populate(ComboBox str)
        {
            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            data.Add(new KeyValuePair<int, string>(0, "--Choisir--"));
            data.Add(new KeyValuePair<int, string>(1, "OUI"));
            data.Add(new KeyValuePair<int, string>(2, "NON"));

            // Clear the combobox
            str.DataSource = null;
            str.Items.Clear();

            // Bind the combobox
            str.DataSource = new BindingSource(data, null);
            str.DisplayMember = "Value";
            str.ValueMember = "Key";

            //Set font combobox
            str.Font = new Font("Calibri", 11, FontStyle.Regular);
        }
        private void rechercheRapide(object sender, EventArgs e)
        {

        }

        private void RechercheFiltre(object sender, EventArgs e)
        {
            try
            {
                Application.UseWaitCursor = true;
                C_ManipulateData listMatricule = new C_ManipulateData();
                C_PopulateGrid populate = new C_PopulateGrid();
                DataTable table = new DataTable();
                
                string [] arrayMatricule;
                int i = 0;

                string agentOperation = agentoperation.SelectedValue.ToString();
                string filtreMatricule = filtre_matricule.Text;
                string nonAffecte = nonaffecte.SelectedValue.ToString();
                infodata.Show();
                arrayMatricule = listMatricule.ListeMatricule(filtreMatricule);
                ClearAllGrid(GridVigieAffection);
                GridVigieAffection.Refresh();
                GridVigieAffection.AllowUserToAddRows = false;
                table = populate.RechercheRapide(arrayMatricule, agentOperation, nonAffecte);

                int nbList = table.Rows.Count;
                
                foreach (DataRow dr in table.Rows)
                {
                    string test = dr["matricule"] + " - " + stringInfo.HexStringToString(dr["hexaprenom"].ToString()) + " (" + dr["fonctioncourante"] + ") ";
                    string etaverou = dr["etatverou"].ToString();
                    infodata.Hide();
                    GridVigieAffection.Rows.Add();
                    
                    int tocheck = int.Parse(dr["tocheck"].ToString());
                    if (tocheck == 1)
                    {
                        GridVigieAffection.Rows[i].Cells[0].Value = true;
                    }
                    else
                    {
                        GridVigieAffection.Rows[i].Cells[0].Value = false;
                    }
                    
                    GridVigieAffection.Rows[i].Cells[1].Value = test;

                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)GridVigieAffection.Rows[i].Cells[2];
                    
                    cell.Value = etaverou;
                    i++;
                }
                tmpcombo.Text = "--Choisir--";
                if (i < 12)
                {
                    changetout.Location = new Point(670, 205);
                    pictureBox1.Location = new Point(665, 205);
                    tmpcombo.Location = new Point(665, 205);
                }
                else
                {
                    changetout.Location = new Point(653, 205);
                    pictureBox1.Location = new Point(650, 205);
                    tmpcombo.Location = new Point(650, 205);
                }
                clearGrid(GridVigieAffection);
                RemoveDuplicate(GridVigieAffection);
               Application.UseWaitCursor = false;
            }
            catch(Exception exc)
            {
                Application.UseWaitCursor = false;
                MessageBox.Show("Recherche Filtre" + exc.Message);
            }
        }

       
    }
    
}
