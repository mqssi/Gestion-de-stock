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

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {

            if (txtQuantite.Text != "")
            {


               
                int quantite = int.Parse(txtQuantite.Text);
                int prix = int.Parse(lblPrix.Text);
                if (int.Parse(txtQuantite.Text) > int.Parse(lblStock.Text))
                {
                    MessageBox.Show("Il y en a seulement " + int.Parse(lblStock.Text) + " en stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantite.Text = "";
                    txtTotal.Text = lblPrix.Text;
                }
                else
                {
                    //Calcule total
                    txtTotal.Text = (quantite * prix).ToString();

                }


                    
                    
                    

            }
            else
            {


                txtTotal.Text = lblPrix.Text;
            }




        }

        private void txtRemise_TextChanged(object sender, EventArgs e)
        {

            if (txtRemise.Text != "")
            {
                int quantite;

                if (txtQuantite.Text != "")
                {
                    quantite = int.Parse(txtQuantite.Text);

                }
                else
                {

                    quantite = 1;
                }
                
             
                int prix = int.Parse(lblPrix.Text);
                int total = quantite * prix;
                int remise = int.Parse(txtRemise.Text);
                txtTotal.Text = (total - (total * remise / 100)).ToString();
            }
            else
            {



                int quantite;

                if (txtQuantite.Text != "")
                {
                    quantite = int.Parse(txtQuantite.Text);

                }
                else
                {

                    quantite = 1;
                }




                int prix = int.Parse(lblPrix.Text);
                txtTotal.Text= (quantite * prix).ToString();

            }


        }
    }
}
