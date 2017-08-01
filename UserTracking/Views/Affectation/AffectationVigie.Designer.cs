namespace UserTracking.Views.Affectation
{
    partial class AffectationVigie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffectationVigie));
            this.bg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtre_matricule = new UserTracking.Controllers.CheckedComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nonaffecte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agentoperation = new System.Windows.Forms.ComboBox();
            this.recherche = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GridVigieAffection = new System.Windows.Forms.DataGridView();
            this.affectation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nom_vigie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.liste_operation = new System.Windows.Forms.ComboBox();
            this.changetout = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmpcombo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVigieAffection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.Image = ((System.Drawing.Image)(resources.GetObject("bg.Image")));
            this.bg.Location = new System.Drawing.Point(-4, -4);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(783, 54);
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricule :";
            // 
            // filtre_matricule
            // 
            this.filtre_matricule.CheckOnClick = true;
            this.filtre_matricule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filtre_matricule.DropDownHeight = 1;
            this.filtre_matricule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtre_matricule.FormattingEnabled = true;
            this.filtre_matricule.IntegralHeight = false;
            this.filtre_matricule.Location = new System.Drawing.Point(102, 57);
            this.filtre_matricule.Name = "filtre_matricule";
            this.filtre_matricule.Size = new System.Drawing.Size(665, 21);
            this.filtre_matricule.TabIndex = 2;
            this.filtre_matricule.ValueSeparator = ", ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent affecté :";
            // 
            // nonaffecte
            // 
            this.nonaffecte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nonaffecte.FormattingEnabled = true;
            this.nonaffecte.Location = new System.Drawing.Point(102, 90);
            this.nonaffecte.Name = "nonaffecte";
            this.nonaffecte.Size = new System.Drawing.Size(121, 21);
            this.nonaffecte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Agent opération  :";
            // 
            // agentoperation
            // 
            this.agentoperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agentoperation.FormattingEnabled = true;
            this.agentoperation.Location = new System.Drawing.Point(356, 90);
            this.agentoperation.Name = "agentoperation";
            this.agentoperation.Size = new System.Drawing.Size(121, 21);
            this.agentoperation.TabIndex = 3;
            // 
            // recherche
            // 
            this.recherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recherche.Location = new System.Drawing.Point(511, 88);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(121, 28);
            this.recherche.TabIndex = 4;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.RechercheFiltre);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(646, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Réinitialiser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Reinit_Click);
            // 
            // GridVigieAffection
            // 
            this.GridVigieAffection.AllowUserToAddRows = false;
            this.GridVigieAffection.AllowUserToDeleteRows = false;
            this.GridVigieAffection.AllowUserToResizeColumns = false;
            this.GridVigieAffection.AllowUserToResizeRows = false;
            this.GridVigieAffection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVigieAffection.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridVigieAffection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridVigieAffection.ColumnHeadersHeight = 50;
            this.GridVigieAffection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridVigieAffection.Location = new System.Drawing.Point(16, 131);
            this.GridVigieAffection.Name = "GridVigieAffection";
            this.GridVigieAffection.Size = new System.Drawing.Size(755, 362);
            this.GridVigieAffection.TabIndex = 0;
            this.GridVigieAffection.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RightClick);
            // 
            // affectation
            // 
            this.affectation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.affectation.Location = new System.Drawing.Point(16, 505);
            this.affectation.Name = "affectation";
            this.affectation.Size = new System.Drawing.Size(755, 23);
            this.affectation.TabIndex = 5;
            this.affectation.Text = "Affecter à :";
            this.affectation.UseVisualStyleBackColor = true;
            this.affectation.Click += new System.EventHandler(this.InsertInDB);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom vigie :";
            // 
            // nom_vigie
            // 
            this.nom_vigie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nom_vigie.FormattingEnabled = true;
            this.nom_vigie.Location = new System.Drawing.Point(102, 541);
            this.nom_vigie.Name = "nom_vigie";
            this.nom_vigie.Size = new System.Drawing.Size(280, 21);
            this.nom_vigie.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Opération :";
            // 
            // liste_operation
            // 
            this.liste_operation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.liste_operation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.liste_operation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.liste_operation.DropDownWidth = 100;
            this.liste_operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.liste_operation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liste_operation.FormattingEnabled = true;
            this.liste_operation.Location = new System.Drawing.Point(491, 541);
            this.liste_operation.Name = "liste_operation";
            this.liste_operation.Size = new System.Drawing.Size(280, 23);
            this.liste_operation.TabIndex = 5;
            // 
            // changetout
            // 
            this.changetout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changetout.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetout.FormattingEnabled = true;
            this.changetout.Location = new System.Drawing.Point(658, 158);
            this.changetout.Name = "changetout";
            this.changetout.Size = new System.Drawing.Size(94, 23);
            this.changetout.TabIndex = 6;
            this.changetout.SelectedIndexChanged += new System.EventHandler(this.Changetout_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(654, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 25);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tmpcombo
            // 
            this.tmpcombo.AutoSize = true;
            this.tmpcombo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmpcombo.Location = new System.Drawing.Point(663, 161);
            this.tmpcombo.Name = "tmpcombo";
            this.tmpcombo.Size = new System.Drawing.Size(63, 15);
            this.tmpcombo.TabIndex = 8;
            this.tmpcombo.Text = "--Choisir--";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.CheckBox1_CheckStateChanged);
            // 
            // AffectationVigie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 575);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tmpcombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changetout);
            this.Controls.Add(this.affectation);
            this.Controls.Add(this.GridVigieAffection);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.agentoperation);
            this.Controls.Add(this.liste_operation);
            this.Controls.Add(this.nom_vigie);
            this.Controls.Add(this.nonaffecte);
            this.Controls.Add(this.filtre_matricule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AffectationVigie";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AffectationVigie_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVigieAffection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.Label label1;
        private Controllers.CheckedComboBox filtre_matricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nonaffecte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox agentoperation;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView GridVigieAffection;
        private System.Windows.Forms.Button affectation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox nom_vigie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox liste_operation;
        private System.Windows.Forms.ComboBox changetout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tmpcombo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}