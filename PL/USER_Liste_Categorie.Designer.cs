﻿namespace GestionDeStock.PL
{
    partial class USER_Liste_Categorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntAjoutclient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnImprimerTout = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgvCategorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAjoutclient
            // 
            this.bntAjoutclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntAjoutclient.FlatAppearance.BorderSize = 0;
            this.bntAjoutclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAjoutclient.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAjoutclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntAjoutclient.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.bntAjoutclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAjoutclient.Location = new System.Drawing.Point(16, 17);
            this.bntAjoutclient.Name = "bntAjoutclient";
            this.bntAjoutclient.Size = new System.Drawing.Size(350, 70);
            this.bntAjoutclient.TabIndex = 1;
            this.bntAjoutclient.Text = "Ajouter";
            this.bntAjoutclient.UseVisualStyleBackColor = false;
            this.bntAjoutclient.Click += new System.EventHandler(this.bntAjoutclient_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(400, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 2);
            this.panel3.TabIndex = 17;
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.Color.DimGray;
            this.txtRechercher.Location = new System.Drawing.Point(400, 36);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(879, 39);
            this.txtRechercher.TabIndex = 16;
            this.txtRechercher.Text = "Rechercher";
            this.txtRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            this.txtRechercher.Enter += new System.EventHandler(this.txtRechercher_Enter);
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
            this.btnImprimerTout.Location = new System.Drawing.Point(216, 542);
            this.btnImprimerTout.Name = "btnImprimerTout";
            this.btnImprimerTout.Size = new System.Drawing.Size(350, 48);
            this.btnImprimerTout.TabIndex = 21;
            this.btnImprimerTout.Text = "Tout imprimer";
            this.btnImprimerTout.UseVisualStyleBackColor = false;
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
            this.btnExcel.Location = new System.Drawing.Point(899, 542);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(350, 48);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "Sauvegarde Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // dgvCategorie
            // 
            this.dgvCategorie.AllowUserToAddRows = false;
            this.dgvCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column5,
            this.Modifier,
            this.Supprimer});
            this.dgvCategorie.EnableHeadersVisualStyles = false;
            this.dgvCategorie.Location = new System.Drawing.Point(3, 139);
            this.dgvCategorie.Name = "dgvCategorie";
            this.dgvCategorie.RowHeadersVisible = false;
            this.dgvCategorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategorie.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategorie.Size = new System.Drawing.Size(1405, 327);
            this.dgvCategorie.TabIndex = 23;
            this.dgvCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorie_CellContentClick);
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
            // Column5
            // 
            this.Column5.HeaderText = "Catégorie";
            this.Column5.Name = "Column5";
            // 
            // Modifier
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Lime;
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle6;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle7;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // USER_Liste_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCategorie);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnImprimerTout);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.bntAjoutclient);
            this.Name = "USER_Liste_Categorie";
            this.Size = new System.Drawing.Size(1411, 605);
            this.Load += new System.EventHandler(this.USER_Liste_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAjoutclient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnImprimerTout;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvCategorie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
