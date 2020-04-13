using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Connexion
    {
        //vérif connexion

        public bool ConnexionValide(dbStockContext db, string Nom, string Mot_de_passe)
        {

            Utilisateur U = new Utilisateur();//table utilisateur
            U.Nom_Utilisateur = Nom;
            U.Mot_De_Passe = Mot_de_passe;
            if (db.Utilisateurs.SingleOrDefault(s => s.Nom_Utilisateur == Nom && s.Mot_De_Passe == Mot_de_passe) != null) //Si le username & pw existent dans la bdd
            {
                return true;
            }
            else //s'ils n'existent pas
            { 
                return false;
            }
        }


    }
}
