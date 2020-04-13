using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class USER_Liste_Produit : UserControl
    {


        private static USER_Liste_Produit Userclient;
        private dbStockContext db;
        // créer instance pour le  usercontrol

        public static USER_Liste_Produit Instance
        {

            get
            {

                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Produit();
                }
                return Userclient;
            }

        }







        public USER_Liste_Produit()
        {
            InitializeComponent();

            db = new dbStockContext();
        }

        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Rechercher")
            {
                txtRechercher.Text = "";

                txtRechercher.ForeColor = Color.Black;
            }
        }

        private void bntAjouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit();
            frmProduit.ShowDialog();
        }

        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit();
            frmProduit.lblTitre.Text = "Modifier Produit";
            frmProduit.btnActualiser.Visible = false;
            frmProduit.ShowDialog();

        }
    }
}
