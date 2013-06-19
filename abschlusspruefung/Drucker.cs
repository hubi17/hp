using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abschlusspruefung {
    [Serializable]
    class Drucker : IGeraet {
        private string bezeichnung;
        private double wert;
        private int seiten_minute;

        public Drucker(string Bezeichnung, double Wert, int Seiten_Minute) {
            bezeichnung = Bezeichnung;
            wert = Wert;
            seiten_minute = Seiten_Minute;
        }

        public int Seiten_Minute { get { return seiten_minute; } }

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
