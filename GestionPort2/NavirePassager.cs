using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPort2 {
    class NavirePassager : ToutNavire {
        private int nbMaxiPassager;
        private int nbChambres;
        private int nbCouchettes;
        private static int nbNavirePassager;

        public NavirePassager(string noLloyds, string nomNavire, string pavillon, int longueur, int largeur, int tirantEau, int nbMaxiPassager, int nbChambres, int nbCouchettes) : base(noLloyds, nomNavire, pavillon, longueur, largeur, tirantEau) {
            this.nbMaxiPassager =nbMaxiPassager;
            this.nbChambres=  nbChambres;
            this.nbCouchettes = nbCouchettes;
        }
        public int NbMaxiPassager{ get; set; }
        public int NbChambres { get; set; }
        public int NbCouchettes{ get; set; }
        public static int NbNavirePassager{ get; set; }
    }
}
