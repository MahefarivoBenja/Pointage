namespace UserTracking
{
    partial class usertracking
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usertracking));
            this.dateheure = new System.Windows.Forms.Label();
            this.departement = new System.Windows.Forms.Label();
            this.nomvigie = new System.Windows.Forms.Label();
            this.contentdept = new System.Windows.Forms.Label();
            this.contentheure = new System.Windows.Forms.Label();
            this.contentvigie = new System.Windows.Forms.Label();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeNomDunVigieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affecterUnAgentÀUnVigieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.timertracking = new System.Windows.Forms.Timer(this.components);
            this.recherche = new System.Windows.Forms.Label();
            this.rechercheuser = new System.Windows.Forms.TextBox();
            this.userListtracking = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.refresh2 = new System.Windows.Forms.PictureBox();
            this.idvigie = new System.Windows.Forms.TextBox();
            this.refreshtracking = new System.Windows.Forms.Timer(this.components);
            this.nbrassist = new System.Windows.Forms.Label();
            this.timerassistance = new System.Windows.Forms.Timer(this.components);
            this.load = new System.Windows.Forms.Label();
            this.assistance = new System.Windows.Forms.Button();
            this.refreshlist = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListtracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateheure
            // 
            this.dateheure.AutoSize = true;
            this.dateheure.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateheure.ForeColor = System.Drawing.Color.White;
            this.dateheure.Location = new System.Drawing.Point(615, 4);
            this.dateheure.Name = "dateheure";
            this.dateheure.Size = new System.Drawing.Size(91, 15);
            this.dateheure.TabIndex = 1;
            this.dateheure.Text = "Date et heure :";
            // 
            // departement
            // 
            this.departement.AutoSize = true;
            this.departement.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departement.ForeColor = System.Drawing.Color.White;
            this.departement.Location = new System.Drawing.Point(99, 4);
            this.departement.Name = "departement";
            this.departement.Size = new System.Drawing.Size(89, 15);
            this.departement.TabIndex = 1;
            this.departement.Text = "Département :";
            // 
            // nomvigie
            // 
            this.nomvigie.AutoSize = true;
            this.nomvigie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomvigie.ForeColor = System.Drawing.Color.White;
            this.nomvigie.Location = new System.Drawing.Point(399, 4);
            this.nomvigie.Name = "nomvigie";
            this.nomvigie.Size = new System.Drawing.Size(41, 15);
            this.nomvigie.TabIndex = 1;
            this.nomvigie.Text = "Vigie :";
            // 
            // contentdept
            // 
            this.contentdept.AutoSize = true;
            this.contentdept.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentdept.ForeColor = System.Drawing.Color.White;
            this.contentdept.Location = new System.Drawing.Point(194, 4);
            this.contentdept.Name = "contentdept";
            this.contentdept.Size = new System.Drawing.Size(83, 15);
            this.contentdept.TabIndex = 1;
            this.contentdept.Text = "chargement ...";
            // 
            // contentheure
            // 
            this.contentheure.AutoSize = true;
            this.contentheure.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentheure.ForeColor = System.Drawing.Color.White;
            this.contentheure.Location = new System.Drawing.Point(712, 4);
            this.contentheure.Name = "contentheure";
            this.contentheure.Size = new System.Drawing.Size(77, 15);
            this.contentheure.TabIndex = 1;
            this.contentheure.Text = "chargment ...";
            // 
            // contentvigie
            // 
            this.contentvigie.AutoSize = true;
            this.contentvigie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentvigie.ForeColor = System.Drawing.Color.White;
            this.contentvigie.Location = new System.Drawing.Point(446, 4);
            this.contentvigie.Name = "contentvigie";
            this.contentvigie.Size = new System.Drawing.Size(83, 15);
            this.contentvigie.TabIndex = 1;
            this.contentvigie.Text = "chargement ...";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeNomDunVigieToolStripMenuItem,
            this.affecterUnAgentÀUnVigieToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.outilsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.outilsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("outilsToolStripMenuItem.Image")));
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // gestionDeNomDunVigieToolStripMenuItem
            // 
            this.gestionDeNomDunVigieToolStripMenuItem.Name = "gestionDeNomDunVigieToolStripMenuItem";
            this.gestionDeNomDunVigieToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionDeNomDunVigieToolStripMenuItem.Text = "Gérer le nom d\'une vigie";
            this.gestionDeNomDunVigieToolStripMenuItem.Click += new System.EventHandler(this.NomVigie);
            // 
            // affecterUnAgentÀUnVigieToolStripMenuItem
            // 
            this.affecterUnAgentÀUnVigieToolStripMenuItem.Name = "affecterUnAgentÀUnVigieToolStripMenuItem";
            this.affecterUnAgentÀUnVigieToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.affecterUnAgentÀUnVigieToolStripMenuItem.Text = "Affecter un agent à une vigie";
            this.affecterUnAgentÀUnVigieToolStripMenuItem.Click += new System.EventHandler(this.AffectationVigie);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aideToolStripMenuItem.Image")));
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.aideToolStripMenuItem.Text = "Aide et support";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.Aide);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outilsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(845, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // timertracking
            // 
            this.timertracking.Enabled = true;
            this.timertracking.Tick += new System.EventHandler(this.Timertracking_Tick);
            // 
            // recherche
            // 
            this.recherche.AutoSize = true;
            this.recherche.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherche.Location = new System.Drawing.Point(448, 47);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(152, 15);
            this.recherche.TabIndex = 3;
            this.recherche.Text = "Recherche d\'un matricule :";
            // 
            // rechercheuser
            // 
            this.rechercheuser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheuser.Location = new System.Drawing.Point(606, 44);
            this.rechercheuser.Name = "rechercheuser";
            this.rechercheuser.Size = new System.Drawing.Size(151, 23);
            this.rechercheuser.TabIndex = 4;
            this.rechercheuser.TextChanged += new System.EventHandler(this.Rechercheuser_TextChanged);
            this.rechercheuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerOnly);
            // 
            // userListtracking
            // 
            this.userListtracking.AllowUserToAddRows = false;
            this.userListtracking.AllowUserToDeleteRows = false;
            this.userListtracking.AllowUserToResizeColumns = false;
            this.userListtracking.AllowUserToResizeRows = false;
            this.userListtracking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userListtracking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.userListtracking.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.userListtracking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userListtracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListtracking.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.userListtracking.Location = new System.Drawing.Point(10, 88);
            this.userListtracking.Name = "userListtracking";
            this.userListtracking.Size = new System.Drawing.Size(824, 632);
            this.userListtracking.TabIndex = 6;
            this.userListtracking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListtracking_CellContentClick);
            this.userListtracking.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RightClickTracking);
            // 
            // refresh
            // 
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(804, 688);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.TabIndex = 2;
            this.refresh.TabStop = false;
            this.refresh.MouseHover += new System.EventHandler(this.Refresh_MouseHover);
            // 
            // refresh2
            // 
            this.refresh2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.refresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh2.Image = ((System.Drawing.Image)(resources.GetObject("refresh2.Image")));
            this.refresh2.Location = new System.Drawing.Point(804, 688);
            this.refresh2.Name = "refresh2";
            this.refresh2.Size = new System.Drawing.Size(32, 32);
            this.refresh2.TabIndex = 2;
            this.refresh2.TabStop = false;
            this.refresh2.Visible = false;
            this.refresh2.Click += new System.EventHandler(this.Refresh2_Click);
            this.refresh2.MouseLeave += new System.EventHandler(this.Refresh2_MouseLeave);
            // 
            // idvigie
            // 
            this.idvigie.Enabled = false;
            this.idvigie.Location = new System.Drawing.Point(349, 22);
            this.idvigie.Name = "idvigie";
            this.idvigie.Size = new System.Drawing.Size(246, 20);
            this.idvigie.TabIndex = 7;
            // 
            // refreshtracking
            // 
            this.refreshtracking.Tick += new System.EventHandler(this.Refreshtracking_Tick);
            // 
            // nbrassist
            // 
            this.nbrassist.AutoSize = true;
            this.nbrassist.BackColor = System.Drawing.Color.Transparent;
            this.nbrassist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nbrassist.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrassist.ForeColor = System.Drawing.Color.White;
            this.nbrassist.Location = new System.Drawing.Point(816, 48);
            this.nbrassist.Name = "nbrassist";
            this.nbrassist.Size = new System.Drawing.Size(0, 14);
            this.nbrassist.TabIndex = 8;
            this.nbrassist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbrassist.Click += new System.EventHandler(this.Assistance_Click);
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.BackColor = System.Drawing.Color.White;
            this.load.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.Black;
            this.load.Location = new System.Drawing.Point(373, 261);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(130, 23);
            this.load.TabIndex = 9;
            this.load.Text = "Chargement ... ";
            this.load.Visible = false;
            // 
            // assistance
            // 
            this.assistance.BackColor = System.Drawing.Color.SpringGreen;
            this.assistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assistance.Location = new System.Drawing.Point(809, 43);
            this.assistance.Name = "assistance";
            this.assistance.Size = new System.Drawing.Size(24, 24);
            this.assistance.TabIndex = 10;
            this.assistance.UseVisualStyleBackColor = false;
            this.assistance.Click += new System.EventHandler(this.Assistance_Click);
            // 
            // refreshlist
            // 
            this.refreshlist.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshlist.Location = new System.Drawing.Point(780, 43);
            this.refreshlist.Name = "refreshlist";
            this.refreshlist.Size = new System.Drawing.Size(24, 24);
            this.refreshlist.TabIndex = 11;
            this.refreshlist.UseVisualStyleBackColor = false;
            this.refreshlist.Click += new System.EventHandler(this.ClickRefresh);
            // 
            // usertracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 726);
            this.Controls.Add(this.refreshlist);
            this.Controls.Add(this.assistance);
            this.Controls.Add(this.rechercheuser);
            this.Controls.Add(this.load);
            this.Controls.Add(this.nbrassist);
            this.Controls.Add(this.idvigie);
            this.Controls.Add(this.userListtracking);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.refresh2);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.contentheure);
            this.Controls.Add(this.contentvigie);
            this.Controls.Add(this.contentdept);
            this.Controls.Add(this.nomvigie);
            this.Controls.Add(this.departement);
            this.Controls.Add(this.dateheure);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "usertracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface de supervision";
            this.Load += new System.EventHandler(this.Usertracking_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListtracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateheure;
        private System.Windows.Forms.Label departement;
        private System.Windows.Forms.Label nomvigie;
        private System.Windows.Forms.Label contentdept;
        private System.Windows.Forms.Label contentheure;
        private System.Windows.Forms.Label contentvigie;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeNomDunVigieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affecterUnAgentÀUnVigieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Timer timertracking;
        private System.Windows.Forms.Label recherche;
        private System.Windows.Forms.TextBox rechercheuser;
        private System.Windows.Forms.DataGridView userListtracking;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.PictureBox refresh2;
        private System.Windows.Forms.TextBox idvigie;
        private System.Windows.Forms.Timer refreshtracking;
        private System.Windows.Forms.Label nbrassist;
        private System.Windows.Forms.Timer timerassistance;
        private System.Windows.Forms.Label load;
        private System.Windows.Forms.Button assistance;
        private System.Windows.Forms.Button refreshlist;
    }
}

