using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace UserTracking.Views.NomVigie
{
    public partial class V_Vigie : Form
    {
        private readonly usertracking precedFodm;
        private ContextMenu editer = new ContextMenu();
        public int idVigie = 0;
        public string info;
        public string statut;
        public V_Vigie(usertracking tracking)
        {
            InitializeComponent();
            this.Owner = tracking;
            precedFodm = tracking;
            tracking.Enabled = false;
            TransparetBackground(recherchev);
           
            
        }
        public void ShowVigieForm()
        {
            this.Show();
            editer.MenuItems.Add("Editer cette ligne", new EventHandler(EditVige));
            precedFodm.Hide();
            LoadGidVigie();

        }
        private void EditVige(object sender, EventArgs e)
        {
            try
            {

                //V_AddNewVigie add = new V_AddNewVigie(this);

                V_AddNewVigie update = new V_AddNewVigie(this);
                update.UpdateVigie(info, statut,idVigie);
                /*add.Show();*/
                /*
                  Views.V_DetailTracking detail = new Views.V_DetailTracking(this);
                detail.PutData(info, operation, duree);
                 */

            }
            catch (Exception exc)
            {
                MessageBox.Show("Click Item error :" + exc.Message);
            }
        }
        private void CloseNomVigie(object sender, FormClosingEventArgs e)
        {
            precedFodm.Enabled = true;
            precedFodm.Show();
            precedFodm.Activate();
            
        }
        public void LoadGidVigie()
        {
            
            listevigie.AllowUserToAddRows = false;
            listevigie.Columns.Add("vigie", "Nom de vigie ");
            listevigie.Columns.Add("statut", "Statut");
            listevigie.Columns.Add("id", "id");
            Color color2 = System.Drawing.ColorTranslator.FromHtml("#34B4E4");
            listevigie.ColumnHeadersDefaultCellStyle.BackColor = color2;
            listevigie.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            listevigie.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            listevigie.EnableHeadersVisualStyles = false;
            /* Color color1 = System.Drawing.ColorTranslator.FromHtml("#d7f1fe");
             listevigie.BackgroundColor = color1;*/

            FillGridVigie();
        }
        public void FillGridVigie()
        {
            ClearAllGrid(listevigie);
            string whreVigie = nomvigie.Text.ToString();

            Controllers.NomVigie.C_NomVigie v = new Controllers.NomVigie.C_NomVigie();
            DataTable table = v.GetData(whreVigie);
            int i = 0;
           
            foreach (DataRow dr in table.Rows)
            {
                listevigie.Rows.Add();
                listevigie.Rows[i].Cells[0].Value = dr["nom"].ToString();
                listevigie.Rows[i].Cells[1].Value = dr["statut"].ToString();
                listevigie.Rows[i].Cells[2].Value = dr["id"].ToString();
                i += 1;
            }
            listevigie.Columns[0].Width = 400;
            listevigie.Columns[1].Width = 100;
            listevigie.Columns[2].Width = 10;
            listevigie.Columns[2].Visible = false;
        }

        private void AddNewVigie(object sender, EventArgs e)
        {

            V_AddNewVigie add = new V_AddNewVigie(this);
            add.Show();
        }
        public void ClearAllGrid(DataGridView view)
        {
            for (int row = 0; row < view.Rows.Count; ++row)
            {
                view.Rows.RemoveAt(row--);
            }
        }

        private void ClickByMouse(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    int currentMouseOverRow = listevigie.HitTest(e.X, e.Y).RowIndex;
                    var relativeMousePosition = listevigie.PointToClient(Cursor.Position);
                    editer.Show(listevigie, relativeMousePosition);
                    info = listevigie.Rows[e.RowIndex].Cells[0].Value.ToString();
                    statut = listevigie.Rows[e.RowIndex].Cells[1].Value.ToString();
                    idVigie = int.Parse(listevigie.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Show detail error :" + exc.Message);
            }
        }

        private void VigieRapide(object sender, EventArgs e)
        {
            FillGridVigie();
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

        private void listevigie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
