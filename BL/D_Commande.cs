using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    public class D_Commande
    {
        public static List<D_Commande> ListeDetail = new List<D_Commande>();

        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public string Prix { get; set; }

        public string Remise { get; set; }

        public string Total { get; set; }


    }
}
