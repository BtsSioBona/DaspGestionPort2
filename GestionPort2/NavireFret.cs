using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPort2 {
    class NavireFret : ToutNavire {
        private string libelleFret;
        private int qteFret;
        public int NbFret;
        private static int nbNavireFret;

        public NavireFret(string noLloyds, string nomNavire, string pavillon, int longueur, int largeur, int tirantEau, string libelleFret, int qteFret) : base(noLloyds, nomNavire, pavillon, longueur, largeur, tirantEau) {
            this.libelleFret = libelleFret;
            this.qteFret = qteFret;
        }
        public string LibelleFret { get; set; }
        public int QteFret { get; set; }
        public static int NbNavireFret { get; set; }
        
    }
}
