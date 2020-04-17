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

        public void Actualiser_DetalCommande()
        {
            dgvDetailCommande.Rows.Clear();

            foreach(var L in BL.D_Commande.ListeDetail)
            {
                dgvDetailCommande.Rows.Add(L.Id, L.Nom, L.Quantite, L.Prix, L.Remise, L.Total);


            }


        }



        public void remplir_dgvProduit()
        {

            db = new dbStockContext();
            foreach(var l in db.Produits)
            {

                dgvProduit.Rows.Add(l.ID_PRODUIT, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);


            }


            for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {
                if ((int)dgvProduit.Rows[i].Cells[2].Value == 0)
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.Red;


                }
                else
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.LightBlue;


                }



            }

            dgvProduit.ClearSelection();


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

            txtNomC.Text = frmC.dgvClient.CurrentRow.Cells[1].Value.ToString();
            txtPrenomC.Text = frmC.dgvClient.CurrentRow.Cells[2].Value.ToString();
            txtTelephoneC.Text = frmC.dgvClient.CurrentRow.Cells[4].Value.ToString();
            txtMailC.Text = frmC.dgvClient.CurrentRow.Cells[5].Value.ToString();
            txtPaysC.Text = frmC.dgvClient.CurrentRow.Cells[6].Value.ToString();
            txtVilleC.Text = frmC.dgvClient.CurrentRow.Cells[7].Value.ToString();

        }

        private void dgvProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            
            
            if((int)dgvProduit.CurrentRow.Cells[2].Value == 0)
            {

                MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                frmp.lblId.Text = dgvProduit.CurrentRow.Cells[0].Value.ToString();
                frmp.lblNom.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
                frmp.lblStock.Text = dgvProduit.CurrentRow.Cells[2].Value.ToString();
                frmp.lblPrix.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.txtTotal.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.ShowDialog();

            }
            
            
            
        }
    }
}
