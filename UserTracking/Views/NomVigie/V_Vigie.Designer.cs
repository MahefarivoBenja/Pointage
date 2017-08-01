namespace UserTracking.Views.NomVigie
{
    partial class V_Vigie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Vigie));
            this.nomvigie = new System.Windows.Forms.TextBox();
            this.addVigie = new System.Windows.Forms.Button();
            this.recherchev = new System.Windows.Forms.Label();
            this.listevigie = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listevigie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomvigie
            // 
            this.nomvigie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomvigie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomvigie.Location = new System.Drawing.Point(90, 83);
            this.nomvigie.Name = "nomvigie";
            this.nomvigie.Size = new System.Drawing.Size(435, 23);
            this.nomvigie.TabIndex = 0;
            this.nomvigie.TextChanged += new System.EventHandler(this.VigieRapide);
            // 
            // addVigie
            // 
            this.addVigie.Location = new System.Drawing.Point(90, 112);
            this.addVigie.Name = "addVigie";
            this.addVigie.Size = new System.Drawing.Size(103, 24);
            this.addVigie.TabIndex = 1;
            this.addVigie.Text = "Ajouter";
            this.addVigie.UseVisualStyleBackColor = true;
            this.addVigie.Click += new System.EventHandler(this.AddNewVigie);
            // 
            // recherchev
            // 
            this.recherchev.AutoSize = true;
            this.recherchev.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherchev.Location = new System.Drawing.Point(10, 86);
            this.recherchev.Name = "recherchev";
            this.recherchev.Size = new System.Drawing.Size(72, 15);
            this.recherchev.TabIndex = 2;
            this.recherchev.Text = "Recherche : ";
            // 
            // listevigie
            // 
            this.listevigie.AllowUserToAddRows = false;
            this.listevigie.AllowUserToDeleteRows = false;
            this.listevigie.AllowUserToResizeColumns = false;
            this.listevigie.AllowUserToResizeRows = false;
            this.listevigie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listevigie.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.listevigie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listevigie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listevigie.Location = new System.Drawing.Point(13, 150);
            this.listevigie.Name = "listevigie";
            this.listevigie.Size = new System.Drawing.Size(510, 264);
            this.listevigie.TabIndex = 4;
            this.listevigie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listevigie_CellContentClick);
            this.listevigie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClickByMouse);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 75);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // V_Vigie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listevigie);
            this.Controls.Add(this.recherchev);
            this.Controls.Add(this.addVigie);
            this.Controls.Add(this.nomvigie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "V_Vigie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseNomVigie);
            ((System.ComponentModel.ISupportInitialize)(this.listevigie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomvigie;
        private System.Windows.Forms.Button addVigie;
        private System.Windows.Forms.Label recherchev;
        private System.Windows.Forms.DataGridView listevigie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}