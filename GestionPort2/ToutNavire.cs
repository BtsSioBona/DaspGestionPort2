using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navire_interface
{
    public abstract class ToutNavire
    {
        protected string noLloyds;
        protected string nomNavire;
        protected string pavillon;
        protected int longueur;
        protected int largeur;
        protected int tirantEau;
        

        public ToutNavire(string noLloyds, string nomNavire, string pavillon, int longueur, int largeur, int tirantEau) {
            this.noLloyds = noLloyds;
            this.nomNavire = nomNavire;
            this.pavillon = pavillon;
            this.longueur = longueur;
            this.largeur = largeur;
            this.tirantEau = tirantEau;
        }

        public ToutNavire() {
        }

        public int NoLloyds { get; set; }
        public string NomNavire { get; set; }
        public string Pavillon { get; set; }
        public int Longueur { get; set; }
        public int Largeur { get; set; }
        public int TirantEau { get; set; }
        public static int NbToutNavires { get; set; }
    }
}
