using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Commande_DetailCommande
    {


        private dbStockContext db = new dbStockContext();
        private Commande clscmd;
        private Details_Commande clsD;

        public int IDCommande;
        public void Ajouter_Commande(DateTime dateCommande, int Idclient, string totalht, string tva, string ttc)
        {

            clscmd = new Commande();
            clscmd.Date_Commande = dateCommande;
            clscmd.ID_CLIENT = Idclient;
            clscmd.Total_HT = totalht;
            clscmd.TVA = tva;
            clscmd.Total_TTC = ttc;
            db.Commandes.Add(clscmd);
            db.SaveChanges();
            IDCommande = clscmd.ID_COMMANDE;

        }

        public void Ajouter_Detail(int idproduit,string Nomprod, int quantite, string prix, string remise, string total)
        {

            clsD = new Details_Commande();
            clsD.ID_COMMANDE = IDCommande;
            clsD.ID_PRODUIT = idproduit;
            clsD.Nom_Produit = Nomprod;
            clsD.Quantite = quantite;
            clsD.Prix = prix;
            clsD.Remise = remise;
            clsD.Total = total;
            db.Details_Commande.Add(clsD);
            db.SaveChanges();


        }
    }
}
