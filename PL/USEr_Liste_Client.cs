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
    public partial class USER_Liste_Client : UserControl
    {

        private static USER_Liste_Client Userclient;
        private dbStockContext db;
        // créer instance pour le  usercontrol

        public static USER_Liste_Client Instance
        {

            get
            {

                if(Userclient==null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }

        }
        
        
        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
            //désactiver la fonction rechercher
            txtRechercher.Enabled = false;
        }

        // ajout dans DataGridView

        public void ActualiserDatagrid()
        {
            db = new dbStockContext();
            dgvClient.Rows.Clear(); // Vide la grille
            foreach(var S in db.Clients)
            {

                dgvClient.Rows.Add(false, S.ID_CLIENT, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Telephone_Client, S.Email_Client, S.Ville_Client, S.Pays_Client);
            }

        }

        // vérifier le nombre de lignes selectionnées

            public string SelectVerif()
        {
            int nbLigneSelect = 0;

            for(int i = 0; i<dgvClient.Rows.Count; i++)
            {

                if((bool) dgvClient.Rows[i].Cells[0].Value==true) //si une ligne est selectionnée
                {
                    nbLigneSelect++;
                }
            }
            if(nbLigneSelect == 0)
            {

                return "Selectionner le client à modifier.";
            }

            if (nbLigneSelect > 1)
            {

                return "Selectionner 1 seul client.";
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

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            ActualiserDatagrid();

        }

        private void bntAjoutclient_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de saisie
            PL.FRM_Ajout_Modifier_Client frmClient = new FRM_Ajout_Modifier_Client(this);
            frmClient.ShowDialog();
        }




        private void btnModifclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajout_Modifier_Client frmClient = new PL.FRM_Ajout_Modifier_Client(this);


            if (SelectVerif() == null)
            {
                
                
                for(int i = 0; i < dgvClient.Rows.Count; i++)
                {

                    if((bool)dgvClient.Rows[i].Cells[0].Value == true) // si le checkbox est vrai, affichez les infos dans le formulaire
                    {
                        frmClient.IDselect = (int)dgvClient.Rows[i].Cells[1].Value;
                        frmClient.txtNom.Text = dgvClient.Rows[i].Cells[2].Value.ToString();
                        frmClient.txtPrenom.Text = dgvClient.Rows[i].Cells[3].Value.ToString();
                        frmClient.txtAdresse.Text = dgvClient.Rows[i].Cells[4].Value.ToString();
                        frmClient.txtTelephone.Text = dgvClient.Rows[i].Cells[5].Value.ToString();
                        frmClient.txtMail.Text = dgvClient.Rows[i].Cells[6].Value.ToString();
                        frmClient.txtVille.Text = dgvClient.Rows[i].Cells[7].Value.ToString();
                        frmClient.txtPays.Text = dgvClient.Rows[i].Cells[8].Value.ToString();


                    }
                }
                
                
                
                frmClient.lblTitre.Text = "Modifier un Client";
                frmClient.btnActualiser.Visible = false;

                frmClient.ShowDialog();


            }
            else
            {

                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnSuprimmerclient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clClient = new BL.CLS_Client();
            
            
            // pour delete tous les clients selectionnés
            int select = 0;

            for (int i = 0; i < dgvClient.Rows.Count; i++)
            {

                if ((bool)dgvClient.Rows[i].Cells[0].Value == true)
                {

                    select++;
                }
            }


            if (select == 0)
            {
                MessageBox.Show("Aucun client selectionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                DialogResult R =  MessageBox.Show("Voulez-vous vraiment supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (R == DialogResult.Yes)
                {


                    //pour delete tous les clients modifiés

                    for (int i = 0; i < dgvClient.Rows.Count; i++)
                    {

                        if ((bool)dgvClient.Rows[i].Cells[0].Value == true)
                        {

                            clClient.SupprimerClient(int.Parse(dgvClient.Rows[i].Cells[1].Value.ToString())); //id client
                        }
                    }

                    //Actuliser la grille une fois le client supprimé
                    ActualiserDatagrid();

                    MessageBox.Show("Suppression effectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               


            }
        }





        private void comboRechercher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer le textbox recherche si j'ia choisi un champ

            txtRechercher.Enabled = true;
            txtRechercher.Text = "";
        }


        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {

            db = new dbStockContext();
            var listeRecherche = db.Clients.ToList(); // listeRecherche = liste des clients
            if(txtRechercher.Text!="")// Pas vide
            {

                switch (comboRechercher.Text)
                {


                    case "Nom":
                        listeRecherche = listeRecherche.Where(s => s.Nom_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        //  StringComparison.CurrentCultureIgnoreCase 1ère lettre majuscule ou minuscule 
                        // !=-1 dans la base de données
                        break;
                    case "Prénom":
                        listeRecherche = listeRecherche.Where(s => s.Prenom_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Téléphone":
                        listeRecherche = listeRecherche.Where(s => s.Telephone_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listeRecherche = listeRecherche.Where(s => s.Email_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listeRecherche = listeRecherche.Where(s => s.Ville_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listeRecherche = listeRecherche.Where(s => s.Pays_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                   

                }


            }
            
            //Vider la grille
            dgvClient.Rows.Clear();

            // ajouter listeRechercher dans la dgvClient
            foreach(var l in listeRecherche)
            {

                dgvClient.Rows.Add(false, l.ID_CLIENT, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Telephone_Client, l.Email_Client,  l.Ville_Client, l.Pays_Client);

            }

        }


    }
}
