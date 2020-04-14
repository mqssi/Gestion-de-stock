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

                return "Selectionner le produit à afficher.";
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
    }
}
