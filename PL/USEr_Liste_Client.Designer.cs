namespace GestionDeStock.PL
{
    partial class USER_Liste_Client
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
            this.bntAjoutclient = new System.Windows.Forms.Button();
            this.btnModifclient = new System.Windows.Forms.Button();
            this.btnSuprimmerclient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
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
            this.bntAjoutclient.Location = new System.Drawing.Point(69, 31);
            this.bntAjoutclient.Name = "bntAjoutclient";
            this.bntAjoutclient.Size = new System.Drawing.Size(350, 70);
            this.bntAjoutclient.TabIndex = 0;
            this.bntAjoutclient.Text = "Ajouter";
            this.bntAjoutclient.UseVisualStyleBackColor = false;
            this.bntAjoutclient.Click += new System.EventHandler(this.bntAjoutclient_Click);
            // 
            // btnModifclient
            // 
            this.btnModifclient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnModifclient.FlatAppearance.BorderSize = 0;
            this.btnModifclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifclient.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifclient.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnModifclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifclient.Location = new System.Drawing.Point(557, 31);
            this.btnModifclient.Name = "btnModifclient";
            this.btnModifclient.Size = new System.Drawing.Size(350, 70);
            this.btnModifclient.TabIndex = 1;
            this.btnModifclient.Text = "Modifier";
            this.btnModifclient.UseVisualStyleBackColor = false;
            this.btnModifclient.Click += new System.EventHandler(this.btnModifclient_Click);
            // 
            // btnSuprimmerclient
            // 
            this.btnSuprimmerclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuprimmerclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnSuprimmerclient.FlatAppearance.BorderSize = 0;
            this.btnSuprimmerclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuprimmerclient.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimmerclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuprimmerclient.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnSuprimmerclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuprimmerclient.Location = new System.Drawing.Point(1036, 31);
            this.btnSuprimmerclient.Name = "btnSuprimmerclient";
            this.btnSuprimmerclient.Size = new System.Drawing.Size(350, 70);
            this.btnSuprimmerclient.TabIndex = 2;
            this.btnSuprimmerclient.Text = "Supprimer";
            this.btnSuprimmerclient.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(69, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 3);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(69, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 3);
            this.panel2.TabIndex = 4;
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.Color.DimGray;
            this.txtRechercher.Location = new System.Drawing.Point(785, 133);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(237, 39);
            this.txtRechercher.TabIndex = 5;
            this.txtRechercher.Text = "Rechercher";
            this.txtRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRechercher.Enter += new System.EventHandler(this.txtRechercher_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(785, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 3);
            this.panel3.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom ",
            "Prénom",
            "Téléphone",
            "Email",
            "Ville",
            "Pays"});
            this.comboBox1.Location = new System.Drawing.Point(371, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvClient.EnableHeadersVisualStyles = false;
            this.dgvClient.Location = new System.Drawing.Point(3, 203);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClient.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.Size = new System.Drawing.Size(1405, 399);
            this.dgvClient.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prénom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Téléphone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ville";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pays";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // USER_Liste_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSuprimmerclient);
            this.Controls.Add(this.btnModifclient);
            this.Controls.Add(this.bntAjoutclient);
            this.Name = "USER_Liste_Client";
            this.Size = new System.Drawing.Size(1411, 605);
            this.Load += new System.EventHandler(this.USER_Liste_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAjoutclient;
        private System.Windows.Forms.Button btnModifclient;
        private System.Windows.Forms.Button btnSuprimmerclient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
