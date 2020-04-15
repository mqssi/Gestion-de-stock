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
    public partial class FRM_Ajouter_Modifier_Categorie : Form
    {



        private UserControl usercat;

        
        
        public FRM_Ajouter_Modifier_Categorie(UserControl usercategorie)
        {
            InitializeComponent();
            this.usercat = usercategorie;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCategorie_Enter(object sender, EventArgs e)
        {



            if (txtCategorie.Text == "Nom de catégorie")
            {
                txtCategorie.Text = "";
                txtCategorie.ForeColor = Color.White;

            }



        }


        public int idCategorie;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            BL.CLS_Categorie clCat = new BL.CLS_Categorie();

            if (txtCategorie.Text == "" || txtCategorie.Text == "Nom de Categorie")
            {
                MessageBox.Show("Entrer nom de categorie", "Ajouter categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                if(lblTitre.Text=="Ajouter Categorie")
                {

                    if (clCat.Ajouter_categorie(txtCategorie.Text) == false)
                    {

                        MessageBox.Show("La catégorie existe déja", "Ajouter categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        MessageBox.Show("Catégorie ajoutée avec succès", "Ajouter categorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as USER_Liste_Categorie).remplirDataGrid();
                    }


                }
                if(lblTitre.Text=="Modifier Categorie")
                {

                    clCat.Modifier_Categorie(idCategorie, txtCategorie.Text);
                    DialogResult DR = MessageBox.Show("Voulez-vous vraiment modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        clCat.Modifier_Categorie(idCategorie, txtCategorie.Text);
                        MessageBox.Show("Categorie Modifiée avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as USER_Liste_Categorie).remplirDataGrid();

                    }
                    else
                    {
                        MessageBox.Show("Modifcation annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    
                  

                }

            }





        }
    }
}
