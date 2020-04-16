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
    public partial class FRM_Detail_Commande : Form
    {

        private dbStockContext db;
        
        
        
        
        public FRM_Detail_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void remplir_dgvProduit()
        {

            db = new dbStockContext();
            foreach(var l in db.Produits)
            {

                dgvProduit.Rows.Add(l.ID_PRODUIT, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);


            }


        }



        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRechercher_Enter(object sender, EventArgs e)
        {

            if (txtRechercher.Text == "Rechercher")
            {
                txtRechercher.Text = "";

                txtRechercher.ForeColor = Color.Black;
            }



        }

        private void FRM_Detail_Commande_Load(object sender, EventArgs e)
        {
            remplir_dgvProduit();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {

            db = new dbStockContext();
            var listeRecherche = db.Produits.ToList(); // listeRecherche = liste des clients
            listeRecherche = listeRecherche.Where(s => s.Nom_Produit.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            //  StringComparison.CurrentCultureIgnoreCase 1ère lettre majuscule ou minuscule 
            //Vider la grille
            dgvProduit.Rows.Clear();

            // ajouter listeRechercher dans la dgvClient
            foreach (var l in listeRecherche)
            {
               
                dgvProduit.Rows.Add(l.ID_PRODUIT, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);

            }



        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande frmC = new PL.FRM_Client_Commande();
            frmC.ShowDialog();
        }
    }
}
