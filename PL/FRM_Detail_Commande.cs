using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
        private UserControl userCommande;
        private dbStockContext db;
        
        
        
        
        public FRM_Detail_Commande(UserControl user)
        {
            InitializeComponent();
            db = new dbStockContext();
            userCommande = user;
        }

        public void Actualiser_DetailCommande()
        {

            float Totalht = 0, TVA = 0, Totalttc;

            if (txtTva.Text != "")
            {


                TVA = float.Parse(txtTva.Text);
            }
            
            
            dgvDetailCommande.Rows.Clear();
            foreach(var L in BL.D_Commande.ListeDetail)
            {
                dgvDetailCommande.Rows.Add(L.Id, L.Nom, L.Quantite, L.Prix, L.Remise, L.Total);
                Totalht = Totalht + float.Parse(L.Total);

            }
            txtTotalHT.Text = Totalht.ToString();
            //Calcule TotalTTC
            Totalttc = (Totalht + (Totalht * TVA / 100));
            //Affiche Total TTC
            txtTotalTTC.Text = Totalttc.ToString();

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
            //Vider liste
            BL.D_Commande.ListeDetail.Clear();
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

            IDClient = (int)frmC.dgvClient.CurrentRow.Cells[0].Value;
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

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frm = new FRM_Produit_Commande(this);
            Produit PR = new Produit();
            if (dgvDetailCommande.CurrentRow != null)
            {
                frm.lblVendreP.Text = "Modifier Produit";



                frm.lblId.Text = dgvDetailCommande.CurrentRow.Cells[0].Value.ToString();
                frm.lblNom.Text = dgvDetailCommande.CurrentRow.Cells[1].Value.ToString();
               

                int IDP = int.Parse(dgvDetailCommande.CurrentRow.Cells[0].Value.ToString());

                PR = db.Produits.Single(s => s.ID_PRODUIT == IDP);
                frm.lblStock.Text = PR.Quantite_Produit.ToString();


                frm.lblPrix.Text = dgvDetailCommande.CurrentRow.Cells[3].Value.ToString();
                frm.txtQuantite.Text = dgvDetailCommande.CurrentRow.Cells[2].Value.ToString();
                frm.txtRemise.Text = dgvDetailCommande.CurrentRow.Cells[4].Value.ToString();
                frm.txtTotal.Text = dgvDetailCommande.CurrentRow.Cells[5].Value.ToString();



                frm.ShowDialog();

            }



        }

        private void suprimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetailCommande.CurrentRow != null)
            {
                DialogResult PR = MessageBox.Show("Voulez vous vraiment supprimer?", "Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {


                    int index = BL.D_Commande.ListeDetail.FindIndex(s => s.Id == int.Parse(dgvDetailCommande.CurrentRow.Cells[0].Value.ToString()));
                    BL.D_Commande.ListeDetail.RemoveAt(index);
                    Actualiser_DetailCommande();
                    MessageBox.Show("Suppression réalisée avec succès", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                else
                {

                    MessageBox.Show("Suppresion annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void txtTva_TextChanged(object sender, EventArgs e)
        {
            //Calcule TTC


            Actualiser_DetailCommande();


        }

        public int IDClient;

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            BL.CLS_Commande_DetailCommande clsCommande = new BL.CLS_Commande_DetailCommande();
            if(dgvDetailCommande.Rows.Count == 0)
            {
                MessageBox.Show("Ajouter des Produits", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else

            {
                if(txtNomC.Text =="")
                {
                    MessageBox.Show("Ajouter un Client", "Client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    //Enrgistrer commande
                    clsCommande.Ajouter_Commande(commandeDate.Value, IDClient, txtTotalHT.Text, txtTva.Text, txtTotalTTC.Text);
                    foreach(var LD in BL.D_Commande.ListeDetail)
                    {

                        clsCommande.Ajouter_Detail(LD.Id, LD.Nom, LD.Quantite, LD.Prix, LD.Remise, LD.Total);


                    }
                    (userCommande as USER_Liste_Commande).RemplirData();
                    BL.D_Commande.ListeDetail.Clear();
                    Close();

                    MessageBox.Show("Commande ajouté avec succès", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }





            }








        }
    }
}
