using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abschlusspruefung {
    interface IGeraet {
        string Bezeichnung { get; }
        double Wert { get; }
        bool Abschreiben();
    }
}
