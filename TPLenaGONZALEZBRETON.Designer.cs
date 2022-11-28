namespace TP_note
{
    partial class Produits
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
            this.tbxref = new System.Windows.Forms.TextBox();
            this.tbxprixht = new System.Windows.Forms.TextBox();
            this.rdtauxnormal = new System.Windows.Forms.RadioButton();
            this.rdreduit = new System.Windows.Forms.RadioButton();
            this.rd55 = new System.Windows.Forms.RadioButton();
            this.rdtauxparticulier = new System.Windows.Forms.RadioButton();
            this.lblref = new System.Windows.Forms.Label();
            this.lblprixht = new System.Windows.Forms.Label();
            this.lblTVA = new System.Windows.Forms.Label();
            this.grpboxrd = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblinfos = new System.Windows.Forms.Label();
            this.lstbensembleref = new System.Windows.Forms.ListBox();
            this.lblerrorref = new System.Windows.Forms.Label();
            this.lblerrorprix = new System.Windows.Forms.Label();
            this.grpboxrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxref
            // 
            this.tbxref.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxref.Location = new System.Drawing.Point(214, 22);
            this.tbxref.Name = "tbxref";
            this.tbxref.Size = new System.Drawing.Size(151, 22);
            this.tbxref.TabIndex = 1;
            this.tbxref.TextChanged += new System.EventHandler(this.txtbreferences_TextChanged);
            // 
            // tbxprixht
            // 
            this.tbxprixht.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxprixht.Location = new System.Drawing.Point(214, 77);
            this.tbxprixht.Name = "tbxprixht";
            this.tbxprixht.Size = new System.Drawing.Size(151, 22);
            this.tbxprixht.TabIndex = 3;
            // 
            // rdtauxnormal
            // 
            this.rdtauxnormal.AutoSize = true;
            this.rdtauxnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdtauxnormal.Location = new System.Drawing.Point(22, 21);
            this.rdtauxnormal.Name = "rdtauxnormal";
            this.rdtauxnormal.Size = new System.Drawing.Size(134, 20);
            this.rdtauxnormal.TabIndex = 4;
            this.rdtauxnormal.TabStop = true;
            this.rdtauxnormal.Text = "Taux Normal 20%";
            this.rdtauxnormal.UseVisualStyleBackColor = true;
            this.rdtauxnormal.CheckedChanged += new System.EventHandler(this.rdtauxnormal_CheckedChanged);
            // 
            // rdreduit
            // 
            this.rdreduit.AutoSize = true;
            this.rdreduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdreduit.Location = new System.Drawing.Point(22, 57);
            this.rdreduit.Name = "rdreduit";
            this.rdreduit.Size = new System.Drawing.Size(123, 20);
            this.rdreduit.TabIndex = 5;
            this.rdreduit.TabStop = true;
            this.rdreduit.Text = "Taux réduit 10%";
            this.rdreduit.UseVisualStyleBackColor = true;
            this.rdreduit.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd55
            // 
            this.rd55.AutoSize = true;
            this.rd55.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd55.Location = new System.Drawing.Point(22, 93);
            this.rd55.Name = "rd55";
            this.rd55.Size = new System.Drawing.Size(126, 20);
            this.rd55.TabIndex = 6;
            this.rd55.TabStop = true;
            this.rd55.Text = "Taux réduit 5.5%";
            this.rd55.UseVisualStyleBackColor = true;
            this.rd55.CheckedChanged += new System.EventHandler(this.rd55_CheckedChanged);
            // 
            // rdtauxparticulier
            // 
            this.rdtauxparticulier.AutoSize = true;
            this.rdtauxparticulier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdtauxparticulier.Location = new System.Drawing.Point(22, 133);
            this.rdtauxparticulier.Name = "rdtauxparticulier";
            this.rdtauxparticulier.Size = new System.Drawing.Size(151, 20);
            this.rdtauxparticulier.TabIndex = 7;
            this.rdtauxparticulier.TabStop = true;
            this.rdtauxparticulier.Text = "Taux particulier 2.1%";
            this.rdtauxparticulier.UseVisualStyleBackColor = true;
            this.rdtauxparticulier.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblref
            // 
            this.lblref.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblref.AutoSize = true;
            this.lblref.Location = new System.Drawing.Point(117, 25);
            this.lblref.Name = "lblref";
            this.lblref.Size = new System.Drawing.Size(77, 16);
            this.lblref.TabIndex = 8;
            this.lblref.Text = "Références";
            // 
            // lblprixht
            // 
            this.lblprixht.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprixht.AutoSize = true;
            this.lblprixht.Location = new System.Drawing.Point(117, 80);
            this.lblprixht.Name = "lblprixht";
            this.lblprixht.Size = new System.Drawing.Size(51, 16);
            this.lblprixht.TabIndex = 9;
            this.lblprixht.Text = "Prix HT";
            this.lblprixht.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTVA
            // 
            this.lblTVA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTVA.AutoSize = true;
            this.lblTVA.Location = new System.Drawing.Point(134, 125);
            this.lblTVA.Name = "lblTVA";
            this.lblTVA.Size = new System.Drawing.Size(34, 16);
            this.lblTVA.TabIndex = 10;
            this.lblTVA.Text = "TVA";
            // 
            // grpboxrd
            // 
            this.grpboxrd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpboxrd.Controls.Add(this.rdtauxnormal);
            this.grpboxrd.Controls.Add(this.rdreduit);
            this.grpboxrd.Controls.Add(this.rd55);
            this.grpboxrd.Controls.Add(this.rdtauxparticulier);
            this.grpboxrd.Location = new System.Drawing.Point(192, 125);
            this.grpboxrd.Name = "grpboxrd";
            this.grpboxrd.Size = new System.Drawing.Size(200, 182);
            this.grpboxrd.TabIndex = 11;
            this.grpboxrd.TabStop = false;
            this.grpboxrd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Location = new System.Drawing.Point(192, 325);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(200, 49);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblinfos
            // 
            this.lblinfos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblinfos.AutoSize = true;
            this.lblinfos.Location = new System.Drawing.Point(97, 397);
            this.lblinfos.Name = "lblinfos";
            this.lblinfos.Size = new System.Drawing.Size(239, 16);
            this.lblinfos.TabIndex = 13;
            this.lblinfos.Text = "Ici on affichera les infos du produit créé ";
            // 
            // lstbensembleref
            // 
            this.lstbensembleref.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstbensembleref.FormattingEnabled = true;
            this.lstbensembleref.ItemHeight = 16;
            this.lstbensembleref.Location = new System.Drawing.Point(555, 30);
            this.lstbensembleref.Name = "lstbensembleref";
            this.lstbensembleref.Size = new System.Drawing.Size(165, 324);
            this.lstbensembleref.TabIndex = 14;
            // 
            // lblerrorref
            // 
            this.lblerrorref.AutoSize = true;
            this.lblerrorref.ForeColor = System.Drawing.Color.Red;
            this.lblerrorref.Location = new System.Drawing.Point(211, 47);
            this.lblerrorref.Name = "lblerrorref";
            this.lblerrorref.Size = new System.Drawing.Size(0, 16);
            this.lblerrorref.TabIndex = 15;
            this.lblerrorref.Visible = false;
            this.lblerrorref.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblerrorprix
            // 
            this.lblerrorprix.AutoSize = true;
            this.lblerrorprix.ForeColor = System.Drawing.Color.Red;
            this.lblerrorprix.Location = new System.Drawing.Point(219, 102);
            this.lblerrorprix.Name = "lblerrorprix";
            this.lblerrorprix.Size = new System.Drawing.Size(0, 16);
            this.lblerrorprix.TabIndex = 16;
            this.lblerrorprix.Visible = false;
            this.lblerrorprix.Click += new System.EventHandler(this.lblerrorprix_Click);
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblerrorprix);
            this.Controls.Add(this.lblerrorref);
            this.Controls.Add(this.lstbensembleref);
            this.Controls.Add(this.lblinfos);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.grpboxrd);
            this.Controls.Add(this.lblTVA);
            this.Controls.Add(this.lblprixht);
            this.Controls.Add(this.lblref);
            this.Controls.Add(this.tbxprixht);
            this.Controls.Add(this.tbxref);
            this.Name = "Produits";
            this.Text = "Form1";
            this.grpboxrd.ResumeLayout(false);
            this.grpboxrd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxref;
        private System.Windows.Forms.TextBox tbxprixht;
        private System.Windows.Forms.RadioButton rdtauxnormal;
        private System.Windows.Forms.RadioButton rdreduit;
        private System.Windows.Forms.RadioButton rd55;
        private System.Windows.Forms.RadioButton rdtauxparticulier;
        private System.Windows.Forms.Label lblref;
        private System.Windows.Forms.Label lblprixht;
        private System.Windows.Forms.Label lblTVA;
        private System.Windows.Forms.GroupBox grpboxrd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblinfos;
        private System.Windows.Forms.ListBox lstbensembleref;
        private System.Windows.Forms.Label lblerrorref;
        private System.Windows.Forms.Label lblerrorprix;
    }
}

