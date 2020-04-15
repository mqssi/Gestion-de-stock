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
    public partial class USER_Liste_Categorie : UserControl
    {

        private static USER_Liste_Categorie usercatergorie;
        private dbStockContext db;
        
        public static USER_Liste_Categorie Instance
        {

            get
            {

                if(usercatergorie == null)
                {


                    usercatergorie = new USER_Liste_Categorie();
                
                }
                return usercatergorie;

            }


        }
        
        
        
        
        
        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db = new dbStockContext();
        
        }

        
        public void remplirDataGrid()
        {

            db = new dbStockContext();
            dgvCategorie.Rows.Clear();
            foreach (var Cat in db.Categories)
            {
                dgvCategorie.Rows.Add(false, Cat.ID_CATEGORIE, Cat.Nom_Categorie);


            }
        }
        
        
        
        private void txtRechercher_Enter(object sender, EventArgs e)
        {

                if (txtRechercher.Text == "Rechercher")
                {
                    txtRechercher.Text = "";

                    txtRechercher.ForeColor = Color.Black;
                }
            
        }

        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            remplirDataGrid();
            
        }

        private void bntAjoutclient_Click(object sender, EventArgs e)
        {

            PL.FRM_Ajouter_Modifier_Categorie frmCat = new PL.FRM_Ajouter_Modifier_Categorie(this);

            frmCat.ShowDialog();

        }

        private void dgvCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmCat = new PL.FRM_Ajouter_Modifier_Categorie(this);
            if (dgvCategorie.Columns[e.ColumnIndex].Name == "Modifier")
            {

                frmCat.idCategorie = (int)dgvCategorie.Rows[e.RowIndex].Cells[1].Value;
                // Affiche modification de catégorie
                frmCat.lblTitre.Text = "Modifier Categorie";
                frmCat.txtCategorie.Text = dgvCategorie.Rows[e.RowIndex].Cells[2].Value.ToString(); // e.rowindex est l'index de la ligne clické
                frmCat.ShowDialog();

            }



        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {

            var maliste = db.Categories.ToList();
            maliste = maliste.Where(s => s.Nom_Categorie.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvCategorie.Rows.Clear();
            foreach(var l in maliste)
            {

                dgvCategorie.Rows.Add(false, l.ID_CATEGORIE, l.Nom_Categorie);

            }

        }
    }
}
