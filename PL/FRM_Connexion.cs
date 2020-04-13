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
    public partial class FRM_Connexion : Form
    {

        private dbStockContext db;
        private Form frmmenu;
        //Classe connexion
        BL.CLS_Connexion C = new BL.CLS_Connexion();

        public FRM_Connexion( Form Menu)
        {
            this.frmmenu = Menu;
            InitializeComponent();
            //initialiser la base de données
            db = new dbStockContext();
        }





        // Vérif des champs obligatoires

        string testobligatoire()
        {
            if(txtNom.Text=="" || txtNom.Text == "Nom d'utilisateur")
            {
                return "Entrez votre nom";
            }
            if (txtmotdepasse.Text == "" || txtmotdepasse.Text == "Mot de Passe")
            {
                return "Entrez votre mot de passe";
            }
            return null;
        }


        private void btnquitter_Click(object sender, EventArgs e)
        {
            // Quitte le formulaire
            this.Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            //Vide le champ

            if(txtNom.Text == "Nom d'utilisateur")
            {

                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtmotdepasse_Enter(object sender, EventArgs e)
        {
            if (txtmotdepasse.Text == "Mot de Passe")
            {

                txtmotdepasse.Text = "";
                txtmotdepasse.UseSystemPasswordChar = false;
                txtmotdepasse.PasswordChar = '*';
                txtmotdepasse.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text=="")
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtmotdepasse_Leave(object sender, EventArgs e)
        {


            if (txtmotdepasse.Text == "")
            {
                txtmotdepasse.Text = "Mot de Passe";
                txtmotdepasse.UseSystemPasswordChar = true; // désactive le pwchar
                txtmotdepasse.ForeColor = Color.Silver;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
            {

                if(C.ConnexionValide(db,txtNom.Text, txtmotdepasse.Text)==true)//l'utilisateur existe
                {
                    MessageBox.Show("La connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_Menu).activerForm();
                    this.Close();
                }
                else // s'il n'existe pas
                {

                    MessageBox.Show("La connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            else
            {
                MessageBox.Show(testobligatoire(), "Entrée non valide", MessageBoxButtons.OK, MessageBoxIcon.Error) ;

            }
        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
