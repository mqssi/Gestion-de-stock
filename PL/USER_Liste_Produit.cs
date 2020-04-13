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




        public void actualiserDgv ()
        {
            db = new dbStockContext();
            dgvProduit.Rows.Clear();

            Categorie Cat = new Categorie();

            foreach(var Lis in db.Produits)
            {

                Cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == Lis.ID_CATEGORIE); // si le idcatergorie dans produit = idcatergorie dans categorie
                if (Cat != null) //s'il existe
                {
                    dgvProduit.Rows.Add(false, Lis.ID_PRODUIT, Lis.Nom_Produit, Lis.Quantite_Produit, Lis.Prix_Produit, Cat.Nom_Categorie); //cat.nom_categorie pour afficher le nom catergorie

                }

            }


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
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }

        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.lblTitre.Text = "Modifier Produit";
            frmProduit.btnActualiser.Visible = false;
            frmProduit.ShowDialog();

        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            actualiserDgv();
        }
    }
}
