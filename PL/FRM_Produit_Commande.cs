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
    public partial class FRM_Produit_Commande : Form
    {
        public FRM_Produit_Commande()
        {
            InitializeComponent();
        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {

                e.Handled = true;
            }


        }
    }
}
