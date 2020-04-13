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
            //Example d'ajout de lignes
            dgvClient.Rows.Add();
            dgvClient.Rows[0].Cells[1].Value = "Trump";
            dgvClient.Rows[0].Cells[2].Value = "Donald";
            dgvClient.Rows[0].Cells[3].Value = "White House";
            dgvClient.Rows[0].Cells[4].Value = "030324598";
            dgvClient.Rows[0].Cells[5].Value = "Washinton";
            dgvClient.Rows[0].Cells[6].Value = "USA";
        }

        private void bntAjoutclient_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de saisie
            PL.FRM_Ajout_Modifier_Client frmClient = new FRM_Ajout_Modifier_Client();
            frmClient.ShowDialog();
        }

        private void btnModifclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajout_Modifier_Client frmClient = new PL.FRM_Ajout_Modifier_Client();

            frmClient.lblTitre.Text = "Modifier un Client";
            frmClient.btnActualiser.Visible = false;

            frmClient.ShowDialog();


        }
    }
}
