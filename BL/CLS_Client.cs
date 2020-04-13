using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    public class CLS_Client
    {
        private dbStockContext db = new dbStockContext();
        private Client C; // table client
        public bool Ajouter_Client(string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
        {

            C = new Client();
            C.Nom_Client = Nom;
            C.Prenom_Client = Prenom;
            C.Adresse_Client = Adresse;
            C.Telephone_Client = Telephone;
            C.Email_Client = Email;
            C.Pays_Client = Pays;
            C.Ville_Client = Ville;

            // Verif si les champs existent dans la bdd

            if (db.Clients.SingleOrDefault(s => s.Nom_Client == Nom && C.Prenom_Client == Prenom) == null) // s'ils nexistent pas
            {

                db.Clients.Add(C);// ajouter dans la table client
                db.SaveChanges(); // save dans la bdd
                return true;
            }
            else // si les champs existent déja dans la BDD
            {

                return false;
            }



        }
        public void ModifierClient(int Id, string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
        {

            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_CLIENT == Id); // vérif si ID est déja dans la table
            if(C!=null) // existe
            {
                C.Nom_Client = Nom; //noveau nom de client
                C.Prenom_Client = Prenom;
                C.Adresse_Client = Adresse;
                C.Telephone_Client = Telephone;
                C.Email_Client = Email;
                C.Pays_Client = Pays;
                C.Ville_Client = Ville;
                db.SaveChanges();

            }
        }

        public void SupprimerClient(int id)
        {

            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_CLIENT == id);
            if (C != null) //existe
            {

                db.Clients.Remove(C); // pour delete le client
                db.SaveChanges();

            }

        }

    }
}
