using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abschlusspruefung {
    [Serializable]
    class PC : IGeraet {
        private string bezeichnung;
        private double wert;
        private double festplatte;

        public PC(string Bezeichnung, double Wert, double Festplatte) {
            bezeichnung = Bezeichnung;
            wert = Wert;
            festplatte = Festplatte;
        }

        public double Festplatte { get { return festplatte; } }

        public string Bezeichnung { get { return bezeichnung; } }

        public double Wert { get { return wert; } }

        public bool Abschreiben() {
            if (wert >= 100) {
                wert -= wert * 0.5;
                return false;
            } else {
                wert = 0;
                return true;
            }
        }
    }
}
