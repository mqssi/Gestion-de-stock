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
    public partial class FRM_Client_Commande : Form
    {

        private dbStockContext db;
        
        
        
        public FRM_Client_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void FRM_Client_Commande_Load(object sender, EventArgs e)
        {


            foreach(var LC in db.Clients)
            {

                dgvClient.Rows.Add(LC.ID_CLIENT, LC.Nom_Client, LC.Prenom_Client, LC.Adresse_Client, LC.Telephone_Client, LC.Email_Client, LC.Pays_Client, LC.Ville_Client);


            }

        }

        private void dgvClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
