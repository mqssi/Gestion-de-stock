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
        }







    }
}
