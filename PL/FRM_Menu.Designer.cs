namespace GestionDeStock.PL
{
    partial class FRM_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBut = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnutilisateur = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btncommande = new System.Windows.Forms.Button();
            this.btncategorie = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlParamettrer = new System.Windows.Forms.Panel();
            this.btndeconnecter = new System.Windows.Forms.Button();
            this.btnrestaurer = new System.Windows.Forms.Button();
            this.btncopie = new System.Windows.Forms.Button();
            this.btnconnecter = new System.Windows.Forms.Button();
            this.pnlAfficher = new System.Windows.Forms.Panel();
            this.btnparamettre = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlParamettrer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pnlBut);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnutilisateur);
            this.panel1.Controls.Add(this.btnproduit);
            this.panel1.Controls.Add(this.btncommande);
            this.panel1.Controls.Add(this.btncategorie);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 592);
            this.panel1.TabIndex = 0;
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.pnlBut.Location = new System.Drawing.Point(3, 77);
            this.pnlBut.Name = "pnlBut";
            this.pnlBut.Size = new System.Drawing.Size(10, 47);
            this.pnlBut.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::GestionDeStock.Properties.Resources.Menu_32;
            this.button3.Location = new System.Drawing.Point(175, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 34);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnutilisateur
            // 
            this.btnutilisateur.FlatAppearance.BorderSize = 0;
            this.btnutilisateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnutilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnutilisateur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnutilisateur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnutilisateur.Image = global::GestionDeStock.Properties.Resources.customer_service_icon;
            this.btnutilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnutilisateur.Location = new System.Drawing.Point(12, 412);
            this.btnutilisateur.Name = "btnutilisateur";
            this.btnutilisateur.Size = new System.Drawing.Size(216, 47);
            this.btnutilisateur.TabIndex = 8;
            this.btnutilisateur.Text = "  Utilisateur";
            this.btnutilisateur.UseVisualStyleBackColor = true;
            this.btnutilisateur.Click += new System.EventHandler(this.btnutilisateur_Click);
            // 
            // btnproduit
            // 
            this.btnproduit.FlatAppearance.BorderSize = 0;
            this.btnproduit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnproduit.Image = global::GestionDeStock.Properties.Resources.shop_cart_add_icon;
            this.btnproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.Location = new System.Drawing.Point(12, 153);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Size = new System.Drawing.Size(216, 47);
            this.btnproduit.TabIndex = 7;
            this.btnproduit.Text = "  Produit";
            this.btnproduit.UseVisualStyleBackColor = true;
            this.btnproduit.Click += new System.EventHandler(this.btnproduit_Click);
            // 
            // btncommande
            // 
            this.btncommande.FlatAppearance.BorderSize = 0;
            this.btncommande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btncommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncommande.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommande.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncommande.Image = global::GestionDeStock.Properties.Resources.shopping_icon;
            this.btncommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncommande.Location = new System.Drawing.Point(12, 310);
            this.btncommande.Name = "btncommande";
            this.btncommande.Size = new System.Drawing.Size(216, 47);
            this.btncommande.TabIndex = 6;
            this.btncommande.Text = "  Commande";
            this.btncommande.UseVisualStyleBackColor = true;
            this.btncommande.Click += new System.EventHandler(this.btncommande_Click);
            // 
            // btncategorie
            // 
            this.btncategorie.FlatAppearance.BorderSize = 0;
            this.btncategorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btncategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncategorie.Image = global::GestionDeStock.Properties.Resources.Categorie;
            this.btncategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorie.Location = new System.Drawing.Point(12, 232);
            this.btncategorie.Name = "btncategorie";
            this.btncategorie.Size = new System.Drawing.Size(216, 47);
            this.btncategorie.TabIndex = 5;
            this.btncategorie.Text = "  Categorie";
            this.btncategorie.UseVisualStyleBackColor = true;
            this.btncategorie.Click += new System.EventHandler(this.btncategorie_Click);
            // 
            // btnclient
            // 
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclient.Image = global::GestionDeStock.Properties.Resources.Office_Client_Male_Light_icon;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(12, 77);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(216, 47);
            this.btnclient.TabIndex = 4;
            this.btnclient.Text = "  Client";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 16);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlParamettrer);
            this.panel3.Controls.Add(this.pnlAfficher);
            this.panel3.Controls.Add(this.btnparamettre);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(222, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 576);
            this.panel3.TabIndex = 2;
            // 
            // pnlParamettrer
            // 
            this.pnlParamettrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlParamettrer.Controls.Add(this.btndeconnecter);
            this.pnlParamettrer.Controls.Add(this.btnrestaurer);
            this.pnlParamettrer.Controls.Add(this.btncopie);
            this.pnlParamettrer.Controls.Add(this.btnconnecter);
            this.pnlParamettrer.Location = new System.Drawing.Point(56, 0);
            this.pnlParamettrer.Name = "pnlParamettrer";
            this.pnlParamettrer.Size = new System.Drawing.Size(314, 263);
            this.pnlParamettrer.TabIndex = 9;
            // 
            // btndeconnecter
            // 
            this.btndeconnecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btndeconnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btndeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeconnecter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeconnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeconnecter.Image = global::GestionDeStock.Properties.Resources.Deconnecte;
            this.btndeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeconnecter.Location = new System.Drawing.Point(3, 196);
            this.btndeconnecter.Name = "btndeconnecter";
            this.btndeconnecter.Size = new System.Drawing.Size(303, 58);
            this.btndeconnecter.TabIndex = 3;
            this.btndeconnecter.Text = "Se Déconnecter";
            this.btndeconnecter.UseVisualStyleBackColor = true;
            this.btndeconnecter.Click += new System.EventHandler(this.btndeconnecter_Click);
            // 
            // btnrestaurer
            // 
            this.btnrestaurer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnrestaurer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnrestaurer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestaurer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestaurer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrestaurer.Image = global::GestionDeStock.Properties.Resources.Download;
            this.btnrestaurer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrestaurer.Location = new System.Drawing.Point(4, 132);
            this.btnrestaurer.Name = "btnrestaurer";
            this.btnrestaurer.Size = new System.Drawing.Size(303, 58);
            this.btnrestaurer.TabIndex = 2;
            this.btnrestaurer.Text = "Restaurer une copie enregistrée";
            this.btnrestaurer.UseVisualStyleBackColor = true;
            // 
            // btncopie
            // 
            this.btncopie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btncopie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btncopie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncopie.Image = global::GestionDeStock.Properties.Resources.Copier;
            this.btncopie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncopie.Location = new System.Drawing.Point(3, 68);
            this.btncopie.Name = "btncopie";
            this.btncopie.Size = new System.Drawing.Size(303, 58);
            this.btncopie.TabIndex = 1;
            this.btncopie.Text = "Créer une copie de l\'application";
            this.btncopie.UseVisualStyleBackColor = true;
            // 
            // btnconnecter
            // 
            this.btnconnecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnconnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconnecter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconnecter.Image = global::GestionDeStock.Properties.Resources.Connected_16;
            this.btnconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconnecter.Location = new System.Drawing.Point(3, 3);
            this.btnconnecter.Name = "btnconnecter";
            this.btnconnecter.Size = new System.Drawing.Size(303, 58);
            this.btnconnecter.TabIndex = 0;
            this.btnconnecter.Text = "Se Connecter";
            this.btnconnecter.UseVisualStyleBackColor = true;
            this.btnconnecter.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlAfficher
            // 
            this.pnlAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAfficher.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAfficher.Location = new System.Drawing.Point(0, 44);
            this.pnlAfficher.Name = "pnlAfficher";
            this.pnlAfficher.Size = new System.Drawing.Size(889, 532);
            this.pnlAfficher.TabIndex = 10;
            // 
            // btnparamettre
            // 
            this.btnparamettre.FlatAppearance.BorderSize = 0;
            this.btnparamettre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparamettre.Image = global::GestionDeStock.Properties.Resources.Settings_32;
            this.btnparamettre.Location = new System.Drawing.Point(6, 4);
            this.btnparamettre.Name = "btnparamettre";
            this.btnparamettre.Size = new System.Drawing.Size(44, 34);
            this.btnparamettre.TabIndex = 8;
            this.btnparamettre.UseVisualStyleBackColor = true;
            this.btnparamettre.Click += new System.EventHandler(this.btnparamettre_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GestionDeStock.Properties.Resources.Subtract_32;
            this.button2.Location = new System.Drawing.Point(794, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 34);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestionDeStock.Properties.Resources.Shutdown_32;
            this.button1.Location = new System.Drawing.Point(844, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 34);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 592);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Menu";
            this.Text = "FRM_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlParamettrer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnutilisateur;
        private System.Windows.Forms.Button btnproduit;
        private System.Windows.Forms.Button btncommande;
        private System.Windows.Forms.Button btncategorie;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlParamettrer;
        private System.Windows.Forms.Button btndeconnecter;
        private System.Windows.Forms.Button btnrestaurer;
        private System.Windows.Forms.Button btncopie;
        private System.Windows.Forms.Button btnconnecter;
        private System.Windows.Forms.Button btnparamettre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlAfficher;
    }
}