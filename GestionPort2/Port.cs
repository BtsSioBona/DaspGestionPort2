﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPort2 {
    public class Port {
        private Collection<ToutNavire> TousLesNaviresPort;
        private string nomPort;
        private int nbNavireFret;
        private int nbNavirePassagers;
        //public string nomPort;
        public int NbNavireFret { get; }
        public int NbNavirePassagers { get; }
        public int NbNavresTotal { get; }
        public void AjouterNavire(NavireFret UnNavireFret) { 
            NavireFret navire = new NavireFret();
        }
        public void AjouterNavire(NavirePassager UnNavirePassager) {

        }
    }
}
