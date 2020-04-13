using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajout_Modifier_Client : Form
    {

        private UserControl usClient;
        
        
        public FRM_Ajout_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usClient = userC;
        }

        //TEST Obligatoires
        public string testObligatoire()
        {
            if(txtNom.Text=="" || txtNom.Text== "Nom du Client")
            {

                return "Entrez le nom du client.";
            }
            
            if (txtPrenom.Text == "" || txtPrenom.Text == "Prénom du Client")
            {

                return "Entrez le Prénom du client.";
            }
            
            if (txtAdresse.Text == "" || txtAdresse.Text == "Adresse du Client")
            {

                return "Entrez l'adresse du client.";
            }
            if (txtPays.Text == "" || txtPays.Text == "Pays du Client")
            {

                return "Entrez le Pays du client.";
            }

            if (txtTelephone.Text == "" || txtTelephone.Text == "Téléphone")
            {

                return "Entrez le téléphone du client.";
            }

            if (txtMail.Text == "" || txtMail.Text == "Mail Client")
            {

                return "Entrez le mail du client.";
            }
            if (txtVille.Text == "" || txtVille.Text == "Ville")
            {

                return "Entrez la ville du client.";
            }

            //vérif mail

            if (txtMail.Text!= "" || txtMail.Text!= "Mail Client")
            {

                try
                {
                    new MailAddress(txtMail.Text); // vérif mail, mettre le using system net mail
                }
                catch(Exception e)
                {

                    return "Email invalide.";
                }
            
            
            }

            return null;

        }





        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text=="Nom du Client")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;

            }

        }

        private void txtNom_Leave(object sender, EventArgs e)
        {

            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom du Client";
                txtNom.ForeColor = Color.Silver;

            }


        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Prénom du Client")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.White;

            }

        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {

            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Prénom du Client";
                txtPrenom.ForeColor = Color.Silver;

            }

        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {

            if (txtAdresse.Text == "Adresse Client")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.White;

            }


        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {


            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse Client";
                txtAdresse.ForeColor = Color.Silver;

            }

        }

        private void txtPays_Enter(object sender, EventArgs e)
        {
            if (txtPays.Text == "Pays du Client")
            {
                txtPays.Text = "";
                txtPays.ForeColor = Color.White;

            }

        }

        private void txtPays_Leave(object sender, EventArgs e)
        {
            if (txtPays.Text == "")
            {
                txtPays.Text = "Pays du Client";
                txtPays.ForeColor = Color.Silver;

            }

        }

        private void txtTelephone_Enter(object sender, EventArgs e)
        {

            if (txtTelephone.Text == "Téléphone")
            {
                txtTelephone.Text = "";
                txtTelephone.ForeColor = Color.White;

            }

        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "")
            {
                txtTelephone.Text = "Téléphone";
                txtTelephone.ForeColor = Color.Silver;

            }

        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Mail Client")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White;

            }

        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Mail Client";
                txtMail.ForeColor = Color.Silver;

            }


        }

        private void txtVille_Enter(object sender, EventArgs e)
        {
            if (txtVille.Text == "Ville")
            {
                txtVille.Text = "";
                txtVille.ForeColor = Color.White;

            }


        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            if (txtVille.Text == "")
            {
                txtVille.Text = "Ville";
                txtVille.ForeColor = Color.Silver;

            }

        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {

            //txtbox numérique
            if(e.KeyChar<48 || e.KeyChar > 57) //code ascii des numéros
            {

                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {

                e.Handled= false;
            }

        }


        public int IDselect;


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (testObligatoire() != null)
            {

                MessageBox.Show(testObligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else if(lblTitre.Text=="Ajouter Client")
            {

                BL.CLS_Client clclient = new BL.CLS_Client();

                if (clclient.Ajouter_Client(txtNom.Text, txtPrenom.Text, txtAdresse.Text,txtTelephone.Text, txtMail.Text, txtPays.Text, txtVille.Text)==true)
                {
                    MessageBox.Show("Client ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usClient as USER_Liste_Client).ActualiserDatagrid();

                }
                else
                {

                    MessageBox.Show("Nom et Prénom de client déja existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else // si lblTitre = " Modifier Client"
            {
                BL.CLS_Client clClient = new BL.CLS_Client();


                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier le client", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {

                    clClient.ModifierClient(IDselect, txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTelephone.Text, txtMail.Text, txtPays.Text, txtVille.Text);


                    //Pour actualiser la grille
                    (usClient as USER_Liste_Client).ActualiserDatagrid();
                    MessageBox.Show("Client Modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            
            }


        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //Vider les txtbox
            txtNom.Text = "Nom du Client";txtNom.ForeColor = Color.Silver;
            txtVille.Text = "Ville";txtVille.ForeColor = Color.Silver;
            txtMail.Text = "Mail Client";txtMail.ForeColor = Color.Silver;
            txtTelephone.Text = "Téléphone";txtTelephone.ForeColor = Color.Silver;
            txtPays.Text = "Pays du Client";txtPays.ForeColor = Color.Silver;
            txtAdresse.Text = "Adresse Client";txtAdresse.ForeColor = Color.Silver;
            txtPrenom.Text = "Prénom du Client";txtPrenom.ForeColor = Color.Silver;

        }
    }
}
