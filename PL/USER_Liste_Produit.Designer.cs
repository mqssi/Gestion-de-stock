namespace GestionDeStock.PL
{
    partial class USER_Liste_Produit
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboRechercher = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuprimmerProduit = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.bntAjouterProduit = new System.Windows.Forms.Button();
            this.btnAfficherPhoto = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImprimerTout = new System.Windows.Forms.Button();
            this.bntImprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProduit.EnableHeadersVisualStyles = false;
            this.dgvProduit.Location = new System.Drawing.Point(3, 189);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduit.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduit.Size = new System.Drawing.Size(1405, 327);
            this.dgvProduit.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Catégorie";
            this.Column5.Name = "Column5";
            // 
            // comboRechercher
            // 
            this.comboRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRechercher.FormattingEnabled = true;
            this.comboRechercher.Items.AddRange(new object[] {
            "Nom",
            "Quantité",
            "Prix",
            "Catégorie"});
            this.comboRechercher.Location = new System.Drawing.Point(371, 116);
            this.comboRechercher.Name = "comboRechercher";
            this.comboRechercher.Size = new System.Drawing.Size(295, 33);
            this.comboRechercher.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(785, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 3);
            this.panel3.TabIndex = 15;
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.Color.DimGray;
            this.txtRechercher.Location = new System.Drawing.Point(785, 110);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(237, 39);
            this.txtRechercher.TabIndex = 14;
            this.txtRechercher.Text = "Rechercher";
            this.txtRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRechercher.Enter += new System.EventHandler(this.txtRechercher_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(22, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 3);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(22, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 3);
            this.panel1.TabIndex = 12;
            // 
            // btnSuprimmerProduit
            // 
            this.btnSuprimmerProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuprimmerProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnSuprimmerProduit.FlatAppearance.BorderSize = 0;
            this.btnSuprimmerProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuprimmerProduit.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimmerProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuprimmerProduit.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnSuprimmerProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuprimmerProduit.Location = new System.Drawing.Point(642, 17);
            this.btnSuprimmerProduit.Name = "btnSuprimmerProduit";
            this.btnSuprimmerProduit.Size = new System.Drawing.Size(228, 52);
            this.btnSuprimmerProduit.TabIndex = 11;
            this.btnSuprimmerProduit.Text = "Supprimer";
            this.btnSuprimmerProduit.UseVisualStyleBackColor = false;
            this.btnSuprimmerProduit.Click += new System.EventHandler(this.btnSuprimmerProduit_Click);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifierProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnModifierProduit.FlatAppearance.BorderSize = 0;
            this.btnModifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierProduit.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifierProduit.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnModifierProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifierProduit.Location = new System.Drawing.Point(359, 17);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(233, 52);
            this.btnModifierProduit.TabIndex = 10;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = false;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // bntAjouterProduit
            // 
            this.bntAjouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntAjouterProduit.FlatAppearance.BorderSize = 0;
            this.bntAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAjouterProduit.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAjouterProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntAjouterProduit.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.bntAjouterProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAjouterProduit.Location = new System.Drawing.Point(69, 17);
            this.bntAjouterProduit.Name = "bntAjouterProduit";
            this.bntAjouterProduit.Size = new System.Drawing.Size(242, 52);
            this.bntAjouterProduit.TabIndex = 9;
            this.bntAjouterProduit.Text = "Ajouter";
            this.bntAjouterProduit.UseVisualStyleBackColor = false;
            this.bntAjouterProduit.Click += new System.EventHandler(this.bntAjouterProduit_Click);
            // 
            // btnAfficherPhoto
            // 
            this.btnAfficherPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAfficherPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnAfficherPhoto.FlatAppearance.BorderSize = 0;
            this.btnAfficherPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherPhoto.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherPhoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAfficherPhoto.Image = global::GestionDeStock.Properties.Resources.Pictures_icon;
            this.btnAfficherPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficherPhoto.Location = new System.Drawing.Point(928, 17);
            this.btnAfficherPhoto.Name = "btnAfficherPhoto";
            this.btnAfficherPhoto.Size = new System.Drawing.Size(259, 52);
            this.btnAfficherPhoto.TabIndex = 18;
            this.btnAfficherPhoto.Text = "Afficher Photo";
            this.btnAfficherPhoto.UseVisualStyleBackColor = false;
            this.btnAfficherPhoto.Click += new System.EventHandler(this.btnAfficherPhoto_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcel.Image = global::GestionDeStock.Properties.Resources.Excel_icon;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(999, 541);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(350, 48);
            this.btnExcel.TabIndex = 21;
            this.btnExcel.Text = "Sauvegarde Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnImprimerTout
            // 
            this.btnImprimerTout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimerTout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnImprimerTout.FlatAppearance.BorderSize = 0;
            this.btnImprimerTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerTout.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerTout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimerTout.Image = global::GestionDeStock.Properties.Resources.print_icon;
            this.btnImprimerTout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimerTout.Location = new System.Drawing.Point(520, 541);
            this.btnImprimerTout.Name = "btnImprimerTout";
            this.btnImprimerTout.Size = new System.Drawing.Size(350, 48);
            this.btnImprimerTout.TabIndex = 20;
            this.btnImprimerTout.Text = "Tout imprimer";
            this.btnImprimerTout.UseVisualStyleBackColor = false;
            // 
            // bntImprimer
            // 
            this.bntImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntImprimer.FlatAppearance.BorderSize = 0;
            this.bntImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntImprimer.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntImprimer.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.bntImprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntImprimer.Location = new System.Drawing.Point(32, 541);
            this.bntImprimer.Name = "bntImprimer";
            this.bntImprimer.Size = new System.Drawing.Size(350, 48);
            this.bntImprimer.TabIndex = 19;
            this.bntImprimer.Text = "Imprimer";
            this.bntImprimer.UseVisualStyleBackColor = false;
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnImprimerTout);
            this.Controls.Add(this.bntImprimer);
            this.Controls.Add(this.btnAfficherPhoto);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.comboRechercher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSuprimmerProduit);
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.bntAjouterProduit);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1411, 605);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.ComboBox comboRechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuprimmerProduit;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Button bntAjouterProduit;
        private System.Windows.Forms.Button btnAfficherPhoto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnImprimerTout;
        private System.Windows.Forms.Button bntImprimer;
    }
}
