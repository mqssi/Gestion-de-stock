using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Categorie
    {

        private dbStockContext db = new dbStockContext();
        private Categorie cat;
        public bool Ajouter_categorie(string NomCat)
        {
            cat = new Categorie();
            cat.Nom_Categorie = NomCat;
            if(db.Categories.SingleOrDefault(s=>s.Nom_Categorie== NomCat) == null)
            {

                db.Categories.Add(cat);
                db.SaveChanges();
                return true;

            }
            else
            {
                return false;

            }

        }

        public void Modifier_Categorie(int idCat, string nomCat)
        {

            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idCat);
            if(cat!=null)
            {
                cat.Nom_Categorie = nomCat;
                db.SaveChanges();

            }

        }


        public void Supprimer_Categorie(int idCat)
        {

            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idCat);
            if (cat != null)
            {

                db.Categories.Remove(cat);
                db.SaveChanges();

            }
        }


    }
}
