using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace abschlusspruefung {
    [Serializable]
    class PC_Raum {
        public ArrayList Geraete = new ArrayList();
        
        public PC_Raum() {
        }

        public int GeraetHinzufuegen(IGeraet NeuesGeraet) {
            Geraete.Add(NeuesGeraet);
            return Geraete.Count;
        }

        public IGeraet GibGeraet(int index) {
            if (index < Geraete.Count) {
                return (IGeraet) Geraete[index];
            } else {
                return null;
            }
        }

        public void Speichern(string Datei) {
        }

        public void Laden(string Datei) {
        }
    }
}
