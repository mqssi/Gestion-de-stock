namespace GestionDeStock.PL
{
    partial class USER_Liste_Commande
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
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.bntAjoutclient = new System.Windows.Forms.Button();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.btnChercher = new System.Windows.Forms.Button();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommande
            // 
            this.dgvCommande.AllowUserToAddRows = false;
            this.dgvCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Date,
            this.Client,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCommande.EnableHeadersVisualStyles = false;
            this.dgvCommande.Location = new System.Drawing.Point(62, 176);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.RowHeadersVisible = false;
            this.dgvCommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCommande.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommande.Size = new System.Drawing.Size(1171, 327);
            this.dgvCommande.TabIndex = 29;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnImprimer.FlatAppearance.BorderSize = 0;
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimer.Image = global::GestionDeStock.Properties.Resources.print_icon;
            this.btnImprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimer.Location = new System.Drawing.Point(883, 571);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(350, 48);
            this.btnImprimer.TabIndex = 27;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
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
            this.bntAjoutclient.Location = new System.Drawing.Point(62, 49);
            this.bntAjoutclient.Name = "bntAjoutclient";
            this.bntAjoutclient.Size = new System.Drawing.Size(198, 61);
            this.bntAjoutclient.TabIndex = 24;
            this.bntAjoutclient.Text = "Ajouter";
            this.bntAjoutclient.UseVisualStyleBackColor = false;
            this.bntAjoutclient.Click += new System.EventHandler(this.bntAjoutclient_Click);
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateDebut.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.ForeColor = System.Drawing.Color.Green;
            this.lblDateDebut.Location = new System.Drawing.Point(445, 65);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(169, 32);
            this.lblDateDebut.TabIndex = 30;
            this.lblDateDebut.Text = "Date début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateFin.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDateFin.Location = new System.Drawing.Point(829, 65);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(123, 32);
            this.lblDateFin.TabIndex = 31;
            this.lblDateFin.Text = "Date fin";
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.SystemColors.Control;
            this.btnChercher.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnChercher.FlatAppearance.BorderSize = 0;
            this.btnChercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChercher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChercher.Image = global::GestionDeStock.Properties.Resources.search;
            this.btnChercher.Location = new System.Drawing.Point(1183, 38);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(64, 72);
            this.btnChercher.TabIndex = 45;
            this.btnChercher.UseVisualStyleBackColor = false;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // dateD
            // 
            this.dateD.Location = new System.Drawing.Point(425, 100);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(200, 20);
            this.dateD.TabIndex = 46;
            // 
            // dateF
            // 
            this.dateF.Location = new System.Drawing.Point(798, 100);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(182, 20);
            this.dateF.TabIndex = 47;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total HT";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TVA";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TotalTTC";
            this.Column4.Name = "Column4";
            // 
            // USER_Liste_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateF);
            this.Controls.Add(this.dateD);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.dgvCommande);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.bntAjoutclient);
            this.Name = "USER_Liste_Commande";
            this.Size = new System.Drawing.Size(1290, 706);
            this.Load += new System.EventHandler(this.USER_Liste_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button bntAjoutclient;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.DateTimePicker dateF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
