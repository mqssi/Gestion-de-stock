using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(222, 592);
            pnlParamettrer.Visible = false;
        }


        //désactiver le formulaire
       public void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncategorie.Enabled = false;
            btncommande.Enabled = false;
            btnutilisateur.Enabled = false;
            btncopie.Enabled = false;
            btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            pnlBut.Enabled = false;

            btnconnecter.Enabled = true;
        }

      public void activerForm()
        {

            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncategorie.Enabled = true;
            btncommande.Enabled = true;
            btnutilisateur.Enabled = true;
            btncopie.Enabled = true;
            btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            pnlBut.Enabled = true;


            btnconnecter.Enabled = false;
            pnlParamettrer.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (panel1.Width== 222)
            {

                panel1.Size = new Size(68, 592);
            }
            else
            {
                panel1.Size = new Size(222, 592);

            }
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top;
            if (!pnlAfficher.Controls.Contains(USER_Liste_Produit.Instance))
            {
                pnlAfficher.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
                USER_Liste_Produit.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();

            }


        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            if (!pnlAfficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlAfficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Client.Instance.BringToFront();

            }
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
            if(!pnlAfficher.Controls.Contains(USER_Liste_Categorie.Instance))
            {

                pnlAfficher.Controls.Add(USER_Liste_Categorie.Instance);
                USER_Liste_Categorie.Instance.Dock = DockStyle.Fill;
                USER_Liste_Categorie.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Categorie.Instance.BringToFront();

            }


        }


        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnutilisateur.Top;
        }

        private void btnparamettre_Click(object sender, EventArgs e)
        {
            pnlParamettrer.Size = new Size(310, 262);
            pnlParamettrer.Visible = !pnlParamettrer.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmC = new FRM_Connexion(this); //this = FRM_Menu
            frmC.ShowDialog();
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            desactiverForm();

        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }

    }
}
