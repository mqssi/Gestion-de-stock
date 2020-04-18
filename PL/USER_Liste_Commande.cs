using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace GestionDeStock.PL
{
    public partial class USER_Liste_Commande : UserControl
    {

        private static USER_Liste_Commande UserCommande;
        private dbStockContext db;


        public static USER_Liste_Commande Instance
        {

            get
            {
                if(UserCommande == null)
                {

                    UserCommande = new USER_Liste_Commande();
                }

                return UserCommande;

            }



        }
        
        
        
        
        public USER_Liste_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void RemplirData()
        {


            dgvCommande.Rows.Clear();
            Client c = new Client();
            string NomPrenom;

            foreach(var LC in db.Commandes)
            {

                c = db.Clients.Single(s => s.ID_CLIENT == LC.ID_CLIENT);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dgvCommande.Rows.Add(LC.ID_COMMANDE, LC.Date_Commande, NomPrenom, LC.Total_HT, LC.TVA, LC.Total_TTC);




            }


        }


        private void bntAjoutclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Detail_Commande frmC = new PL.FRM_Detail_Commande(this);
            frmC.ShowDialog();


        }

        private void USER_Liste_Commande_Load(object sender, EventArgs e)
        {
            RemplirData();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {

            var listecommande = db.Commandes.ToList();
            if (dgvCommande.Rows.Count != 0)
            {

                listecommande = listecommande.Where(s => s.Date_Commande.Date >= dateD.Value.Date && s.Date_Commande.Date <= dateF.Value.Date).ToList();


                dgvCommande.Rows.Clear();
                Client c = new Client();
                string NomPrenom;

                foreach (var LC in listecommande)
                {

                    c = db.Clients.Single(s => s.ID_CLIENT == LC.ID_CLIENT);
                    NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                    dgvCommande.Rows.Add(LC.ID_COMMANDE, LC.Date_Commande, NomPrenom, LC.Total_HT, LC.TVA, LC.Total_TTC);




                }





            }


        }
    }
}
