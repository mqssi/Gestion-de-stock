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
    }
}
