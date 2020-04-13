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

        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Rechercher")
            {
                txtRechercher.Text = "";

                txtRechercher.ForeColor = Color.Black;
            }
        }
    }
}
