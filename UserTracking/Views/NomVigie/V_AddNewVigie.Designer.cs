namespace UserTracking.Views.NomVigie
{
    partial class V_AddNewVigie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AddNewVigie));
            this.nmvigieadd = new System.Windows.Forms.Label();
            this.vigienom = new System.Windows.Forms.TextBox();
            this.on = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nmvigieadd
            // 
            this.nmvigieadd.AutoSize = true;
            this.nmvigieadd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmvigieadd.Location = new System.Drawing.Point(7, 32);
            this.nmvigieadd.Name = "nmvigieadd";
            this.nmvigieadd.Size = new System.Drawing.Size(67, 15);
            this.nmvigieadd.TabIndex = 0;
            this.nmvigieadd.Text = "Nom vigie :";
            // 
            // vigienom
            // 
            this.vigienom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.vigienom.Location = new System.Drawing.Point(91, 32);
            this.vigienom.Name = "vigienom";
            this.vigienom.Size = new System.Drawing.Size(308, 20);
            this.vigienom.TabIndex = 1;
            // 
            // on
            // 
            this.on.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.on.FormattingEnabled = true;
            this.on.Location = new System.Drawing.Point(418, 32);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(126, 21);
            this.on.TabIndex = 2;
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Location = new System.Drawing.Point(91, 66);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(151, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Ajouter";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.EnregistrerNom);
            // 
            // annuler
            // 
            this.annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annuler.Location = new System.Drawing.Point(248, 66);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(151, 23);
            this.annuler.TabIndex = 3;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // V_AddNewVigie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 114);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.save);
            this.Controls.Add(this.on);
            this.Controls.Add(this.vigienom);
            this.Controls.Add(this.nmvigieadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "V_AddNewVigie";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAddForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox vigienom;
        private System.Windows.Forms.ComboBox on;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label nmvigieadd;
    }
}