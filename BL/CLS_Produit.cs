using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
   public class CLS_Produit
    {
        private dbStockContext db = new dbStockContext();
        private Produit PR;

        public bool ajouterProduit(string NomPR, int QuantitePR, string PrixPR, byte[] ImagePR, int IdcatergoriePR )
        {
            PR = new Produit();
            PR.Nom_Produit = NomPR;
            PR.Quantite_Produit = QuantitePR;
            PR.Prix_Produit = PrixPR;
            PR.Image_Produit = ImagePR;
            PR.ID_CATEGORIE = IdcatergoriePR;

            // vérif si le produit existe déja

            if(db.Produits.SingleOrDefault(a=>a.Nom_Produit==NomPR)==null) //n'existe pas
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;

            }
            else
            {

                return false;
            }


        }

        public void modifierProduit(int IdPR, string NomPR, int QuantitePR, string PrixPR, byte[] ImagePR, int IdcatergoriePR)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == IdPR); // si ID de produit = Mon ID
            if(PR!=null)// si existe
            {
                PR.Nom_Produit = NomPR;
                PR.Quantite_Produit = QuantitePR;
                PR.Prix_Produit = PrixPR;
                PR.Image_Produit = ImagePR;
                PR.ID_CATEGORIE = IdcatergoriePR;
                db.SaveChanges();



            }


        }


        public void supprimerProduit(int id)
        {

            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_PRODUIT== id);
            if (PR != null)
            {

                db.Produits.Remove(PR);
                db.SaveChanges();
            }

        }

    }
}
