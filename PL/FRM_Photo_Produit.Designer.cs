namespace GestionDeStock.PL
{
    partial class FRM_Photo_Produit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.produitImage = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.produitNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produitImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 2);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(489, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 471);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 471);
            this.panel4.TabIndex = 1;
            // 
            // produitImage
            // 
            this.produitImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produitImage.BackColor = System.Drawing.Color.Silver;
            this.produitImage.Location = new System.Drawing.Point(38, 79);
            this.produitImage.Name = "produitImage";
            this.produitImage.Size = new System.Drawing.Size(422, 362);
            this.produitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.produitImage.TabIndex = 2;
            this.produitImage.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btnQuitter.Location = new System.Drawing.Point(441, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(38, 36);
            this.btnQuitter.TabIndex = 44;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // produitNom
            // 
            this.produitNom.AutoSize = true;
            this.produitNom.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitNom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.produitNom.Location = new System.Drawing.Point(183, 14);
            this.produitNom.Name = "produitNom";
            this.produitNom.Size = new System.Drawing.Size(77, 25);
            this.produitNom.TabIndex = 45;
            this.produitNom.Text = "Image";
            // 
            // FRM_Photo_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(491, 473);
            this.Controls.Add(this.produitNom);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.produitImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Photo_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Photo_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.produitImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnQuitter;
        public System.Windows.Forms.PictureBox produitImage;
        public System.Windows.Forms.Label produitNom;
    }
}