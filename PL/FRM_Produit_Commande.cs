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


        public Form frmDetail;

        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmDetail = frm;

        }
        
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

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {


            int Quant, Re;
            if (txtQuantite.Text != "")
            {
                Quant = int.Parse(txtQuantite.Text);

            }
            else
            {
                Quant = 1;

            }
            if(txtRemise.Text!="")
            {

                Re = int.Parse(txtRemise.Text);
            }
            else
            {

                Re = 0;
            }



            BL.D_Commande DETAIL = new BL.D_Commande
            {
                Id = int.Parse(lblId.Text),
                Nom = lblNom.Text,
                Quantite = Quant,
                Prix = lblPrix.Text,
                Remise = Re.ToString(),
                Total = txtTotal.Text,

            };
            //ajout liste
            if(lblVendreP.Text =="Vendre Produit")
            {


                if (BL.D_Commande.ListeDetail.SingleOrDefault(s => s.Id == DETAIL.Id) != null)
                {

                    MessageBox.Show("Produit déja existant dans la commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {

                    BL.D_Commande.ListeDetail.Add(DETAIL);

                }


            }
            else
            {//Modifier
                DialogResult PR = MessageBox.Show("Voulez vous vraiment modifier?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(PR==DialogResult.Yes)
                {
                    int index = BL.D_Commande.ListeDetail.FindIndex(s => s.Id == int.Parse(lblId.Text));
                    BL.D_Commande.ListeDetail[index] = DETAIL;
                    MessageBox.Show("Modification réalisée avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {

                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

            }

            
            
            //actualisation datagrid
            (frmDetail as FRM_Detail_Commande).Actualiser_DetalCommande();



        }
    }
}
