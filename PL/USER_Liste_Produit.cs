using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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





        // vérifier le nombre de lignes selectionnées

        public string SelectVerif()
        {
            int nbLigneSelect = 0;

            for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {

                if ((bool)dgvProduit.Rows[i].Cells[0].Value == true) //si une ligne est selectionnée
                {
                    nbLigneSelect++;
                }
            }
            if (nbLigneSelect == 0)
            {

                return "Selectionner Produit";
            }

            if (nbLigneSelect > 1)
            {

                return "Selectionner 1 seul produit.";
            }
            return null;


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
            Produit PR = new Produit();
            
            
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit(this);
                frmProduit.lblTitre.Text = "Modifier Produit";
                frmProduit.btnActualiser.Visible = false;
                for (int i = 0; i < dgvProduit.Rows.Count; i++) //verif de la ligne selectionnée
                {

                    if ((bool)dgvProduit.Rows[i].Cells[0].Value == true) // si ligne sectionnée
                    {

                        int MYIDSELECT = (int)dgvProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == MYIDSELECT); // vérif si id produit = id de la liste
                        if (PR != null) // if existe
                        {
                            frmProduit.comboCategorie.Text = dgvProduit.Rows[i].Cells[5].Value.ToString();
                            frmProduit.txtNomProduit.Text = dgvProduit.Rows[i].Cells[2].Value.ToString();
                            frmProduit.txtQuantiteProduit.Text = dgvProduit.Rows[i].Cells[3].Value.ToString();
                            frmProduit.txtPrixProduit.Text = dgvProduit.Rows[i].Cells[4].Value.ToString();
                            frmProduit.IDPRODUIT = (int)dgvProduit.Rows[i].Cells[1].Value;

                            MemoryStream MS = new MemoryStream(PR.Image_Produit);
                            frmProduit.picProduit.Image = Image.FromStream(MS);



                        }





                    }
                }

                
                frmProduit.ShowDialog();
            }
            


        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            actualiserDgv();
        }

        private void btnAfficherPhoto_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if (SelectVerif() != null)
            {

                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                for(int i=0; i<dgvProduit.Rows.Count; i++) //verif de la ligne selectionnée
                {

                    if ((bool)dgvProduit.Rows[i].Cells[0].Value==true) // si ligne sectionnée
                    {
                        int MYIDSELECT = (int)dgvProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == MYIDSELECT); // vérif si id produit = id de la liste
                        if(PR!=null) // if existe
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            MemoryStream MS = new MemoryStream(PR.Image_Produit); // pour convertir image de produit dans le picturebox ----- SYSTEM IO necessaire
                            frmP.produitImage.Image = Image.FromStream(MS);
                            frmP.produitNom.Text = dgvProduit.Rows[i].Cells[2].Value.ToString();
                            //Afficher formulaire
                            frmP.ShowDialog();
                        }
                    }

                }


            }

        }

        private void btnSuprimmerProduit_Click(object sender, EventArgs e)
        {
            if(SelectVerif()=="Selectionner Produit")// vérifier si le produit est selectionné
            {

                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult DR = MessageBox.Show("Voulez-vous vraiment supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {


                    //vérifier combien de ligne selectionner
                    for (int i = 0; i < dgvProduit.Rows.Count; i++)
                    {

                        if ((bool)dgvProduit.Rows[i].Cells[0].Value == true)
                        {

                            BL.CLS_Produit clproduit = new BL.CLS_Produit();
                            int idselect = (int)dgvProduit.Rows[i].Cells[1].Value;
                            clproduit.supprimerProduit(idselect);
                        }

                    }
                    //actualiser data
                    actualiserDgv();
                    MessageBox.Show("Produit supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);




                }
                else
                {

                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }



        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {

            db = new dbStockContext();
            var listeRecherche = db.Produits.ToList(); // listeRecherche = liste des clients
            Categorie cat = new Categorie();
            listeRecherche = listeRecherche.Where(s => s.Nom_Produit.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
              //  StringComparison.CurrentCultureIgnoreCase 1ère lettre majuscule ou minuscule 

                 

            //Vider la grille
            dgvProduit.Rows.Clear();
          
            
            // ajouter listeRechercher dans la dgvClient
            foreach (var l in listeRecherche)
            {
                cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == l.ID_CATEGORIE); // Affiche le nom de la catégorie
                dgvProduit.Rows.Add(false, l.ID_PRODUIT, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit, cat.Nom_Categorie);

            }



        }
    }
}
