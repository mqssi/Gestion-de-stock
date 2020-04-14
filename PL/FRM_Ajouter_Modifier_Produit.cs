using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GestionDeStock.PL
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {


        private dbStockContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new dbStockContext();
            this.userProduit = User;
            // Afficher les catégories
            comboCategorie.DataSource = db.Categories.ToList();
            comboCategorie.DisplayMember = "Nom_Categorie";
            comboCategorie.ValueMember = "ID_CATEGORIE";
        }






        string testObligatoire()
        {

            if (txtNomProduit.Text == "Nom du Produit" || txtNomProduit.Text== "")
            {
                return "Entrez le nom du Produit";
            }

            if (txtQuantiteProduit.Text == "Quantité du Produit" || txtQuantiteProduit.Text == "")
            {
                return "Entrez la quantité du Produit";
            }


            if (txtPrixProduit.Text == "Prix" || txtPrixProduit.Text == "")
            {
                return "Entrez le Prix du Produit";
            }
            
            if(picProduit.Image == null)
            {
                return "Entrez l'image du produit";
            }
            if (comboCategorie.Text == "")
            {

                return "Entrez une catégorie de produit";
            }


            return null;

        }

        private void txtNomProduit_Enter(object sender, EventArgs e)
        {
            if (txtNomProduit.Text == "Nom du Produit")
            {
                txtNomProduit.Text = "";
                txtNomProduit.ForeColor = Color.White;

            }
        }

        private void txtNomProduit_Leave(object sender, EventArgs e)
        {

            if (txtNomProduit.Text == "")
            {
                txtNomProduit.Text = "Nom du Produit";
                txtNomProduit.ForeColor = Color.White;

            }


        }

        private void txtQuantiteProduit_Enter(object sender, EventArgs e)
        {
            if (txtQuantiteProduit.Text == "Quantité du Produit")
            {
                txtQuantiteProduit.Text = "";
                txtQuantiteProduit.ForeColor = Color.White;

            }
        }

        private void txtQuantiteProduit_Leave(object sender, EventArgs e)
        {
            if (txtQuantiteProduit.Text == "")
            {
                txtQuantiteProduit.Text = "Quantité du Produit";
                txtQuantiteProduit.ForeColor = Color.White;

            }

        }

        private void txtPrixProduit_Enter(object sender, EventArgs e)
        {

            if (txtPrixProduit.Text == "Prix")
            {
                txtPrixProduit.Text = "";
                txtPrixProduit.ForeColor = Color.White;

            }

        }

        private void txtPrixProduit_Leave(object sender, EventArgs e)
        {
            if (txtPrixProduit.Text == "")
            {
                txtPrixProduit.Text = "Prix";
                txtPrixProduit.ForeColor = Color.White;

            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            //Afficher Fichier Image
            OpenFileDialog OP = new OpenFileDialog();
            
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP"; // Pour afficher seulement les images

            if(OP.ShowDialog()==DialogResult.OK)
            {
                picProduit.Image = System.Drawing.Image.FromFile(OP.FileName);
                
            }
            

        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtNomProduit.Text = "Nom du Produit";txtNomProduit.ForeColor = Color.Silver;
            txtQuantiteProduit.Text = "Quantité du Produit"; txtQuantiteProduit.ForeColor = Color.Silver;
            txtPrixProduit.Text = "Prix"; txtPrixProduit.ForeColor = Color.Silver;
            comboCategorie.Text = null;
            picProduit.Image = null;
        }

        private void txtQuantiteProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) //code ascii des numéros
            {

                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {

                e.Handled = false;
            }
        }

        private void txtPrixProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) //code ascii des numéros
            {

                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {

                e.Handled = false;
            }
        }
        public int IDPRODUIT;

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testObligatoire()!=null)
            {

                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if(lblTitre.Text=="Ajouter Produit")
                {

                    BL.CLS_Produit clprod = new BL.CLS_Produit();
                    //convertire image en byte

                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray(); //Convertir image on format
                    if (clprod.ajouterProduit(txtNomProduit.Text, int.Parse(txtQuantiteProduit.Text),txtPrixProduit.Text, byteimageP, Convert.ToInt32(comboCategorie.SelectedValue)) ==true)
                    {
                        MessageBox.Show("Produit ajouté avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).actualiserDgv();
                    }
                    else
                    {

                        MessageBox.Show("Le Produit existe déja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }

                }
                else
                {

                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    BL.CLS_Produit clsProduit = new BL.CLS_Produit();
                    DialogResult RS = MessageBox.Show("Voulez-vous vraiment modifier ce produit?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {
                        clsProduit.modifierProduit(IDPRODUIT, txtNomProduit.Text, int.Parse(txtQuantiteProduit.Text), txtPrixProduit.Text, byteimageP, Convert.ToInt32(comboCategorie.SelectedValue));
                        MessageBox.Show("Produit modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).actualiserDgv();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                }
            }
        }
    }
}
