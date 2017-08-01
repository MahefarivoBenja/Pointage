namespace Parametrage2
{
    partial class AffectationVigie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffectationVigie));
            this.GridVigieAffection = new System.Windows.Forms.DataGridView();
            this.affectation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nom_vigie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filtre_matricule = new Parametrage2.Controller.CheckedComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.changetout = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmpcombo = new System.Windows.Forms.TextBox();
            this.recherche = new System.Windows.Forms.Button();
            this.nonaffecte = new System.Windows.Forms.ComboBox();
            this.agentoperation = new System.Windows.Forms.ComboBox();
            this.infodata = new System.Windows.Forms.Label();
            this.liste_operation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridVigieAffection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.GridVigieAffection.EnableHeadersVisualStyles = false;
            this.GridVigieAffection.Location = new System.Drawing.Point(15, 182);
            this.GridVigieAffection.Name = "GridVigieAffection";
            this.GridVigieAffection.Size = new System.Drawing.Size(755, 305);
            this.GridVigieAffection.TabIndex = 0;
            this.GridVigieAffection.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RightClick);
            this.GridVigieAffection.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TriggerGrid);
            // 
            // affectation
            // 
            this.affectation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.affectation.Location = new System.Drawing.Point(15, 506);
            this.affectation.Name = "affectation";
            this.affectation.Size = new System.Drawing.Size(755, 29);
            this.affectation.TabIndex = 3;
            this.affectation.Text = "Affecter à :";
            this.affectation.UseVisualStyleBackColor = true;
            this.affectation.Click += new System.EventHandler(this.InsertInDB);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom vigie :";
            // 
            // nom_vigie
            // 
            this.nom_vigie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom_vigie.Cursor = System.Windows.Forms.Cursors.Default;
            this.nom_vigie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nom_vigie.FormattingEnabled = true;
            this.nom_vigie.Location = new System.Drawing.Point(88, 550);
            this.nom_vigie.Name = "nom_vigie";
            this.nom_vigie.Size = new System.Drawing.Size(280, 21);
            this.nom_vigie.TabIndex = 5;
            this.nom_vigie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nom_vigie_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opération :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Matricule :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-365, -482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Recherche rapide :";
            // 
            // filtre_matricule
            // 
            this.filtre_matricule.CheckOnClick = true;
            this.filtre_matricule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filtre_matricule.DropDownHeight = 1;
            this.filtre_matricule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtre_matricule.FormattingEnabled = true;
            this.filtre_matricule.IntegralHeight = false;
            this.filtre_matricule.Location = new System.Drawing.Point(142, 47);
            this.filtre_matricule.Name = "filtre_matricule";
            this.filtre_matricule.Size = new System.Drawing.Size(628, 21);
            this.filtre_matricule.TabIndex = 6;
            this.filtre_matricule.ValueSeparator = ", ";
            this.filtre_matricule.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtre_matricule_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Agents affectés :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Agents opérations :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Réinitialiser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.reinit_Click);
            // 
            // changetout
            // 
            this.changetout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changetout.FormattingEnabled = true;
            this.changetout.Location = new System.Drawing.Point(658, 208);
            this.changetout.Name = "changetout";
            this.changetout.Size = new System.Drawing.Size(94, 21);
            this.changetout.TabIndex = 9;
            this.changetout.SelectedIndexChanged += new System.EventHandler(this.changetout_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(79, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(652, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 23);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tmpcombo
            // 
            this.tmpcombo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tmpcombo.Location = new System.Drawing.Point(655, 209);
            this.tmpcombo.Name = "tmpcombo";
            this.tmpcombo.Size = new System.Drawing.Size(82, 13);
            this.tmpcombo.TabIndex = 12;
            this.tmpcombo.Text = "--Choisir--";
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(142, 131);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(89, 28);
            this.recherche.TabIndex = 13;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.RechercheFiltre);
            // 
            // nonaffecte
            // 
            this.nonaffecte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nonaffecte.FormattingEnabled = true;
            this.nonaffecte.Location = new System.Drawing.Point(142, 90);
            this.nonaffecte.Name = "nonaffecte";
            this.nonaffecte.Size = new System.Drawing.Size(191, 21);
            this.nonaffecte.TabIndex = 14;
            // 
            // agentoperation
            // 
            this.agentoperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agentoperation.FormattingEnabled = true;
            this.agentoperation.Location = new System.Drawing.Point(526, 90);
            this.agentoperation.Name = "agentoperation";
            this.agentoperation.Size = new System.Drawing.Size(247, 21);
            this.agentoperation.TabIndex = 14;
            // 
            // infodata
            // 
            this.infodata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infodata.AutoSize = true;
            this.infodata.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.infodata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infodata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infodata.Location = new System.Drawing.Point(298, 235);
            this.infodata.Name = "infodata";
            this.infodata.Size = new System.Drawing.Size(154, 19);
            this.infodata.TabIndex = 16;
            this.infodata.Text = "Pas d\'enregistrement";
            this.infodata.Visible = false;
            // 
            // liste_operation
            // 
            this.liste_operation.AllowDrop = true;
            this.liste_operation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.liste_operation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.liste_operation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.liste_operation.DropDownHeight = 100;
            this.liste_operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.liste_operation.FormattingEnabled = true;
            this.liste_operation.IntegralHeight = false;
            this.liste_operation.Location = new System.Drawing.Point(486, 550);
            this.liste_operation.Name = "liste_operation";
            this.liste_operation.Size = new System.Drawing.Size(280, 21);
            this.liste_operation.TabIndex = 5;
            // 
            // AffectationVigie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 585);
            this.Controls.Add(this.liste_operation);
            this.Controls.Add(this.infodata);
            this.Controls.Add(this.agentoperation);
            this.Controls.Add(this.nonaffecte);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.tmpcombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.changetout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filtre_matricule);
            this.Controls.Add(this.nom_vigie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.affectation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GridVigieAffection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AffectationVigie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affectation vigie";
            this.Load += new System.EventHandler(this.AffectationVigie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVigieAffection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVigieAffection;
        private System.Windows.Forms.Button affectation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nom_vigie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Controller.CheckedComboBox filtre_matricule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox changetout;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tmpcombo;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.ComboBox nonaffecte;
        private System.Windows.Forms.ComboBox agentoperation;
        protected internal System.Windows.Forms.Label infodata;
        private System.Windows.Forms.ComboBox liste_operation;
    }
}

