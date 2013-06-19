using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace abschlusspruefung {
    public partial class Form1 : Form {
        PC_Raum r208 = new PC_Raum();

        public Form1() {
            InitializeComponent();
        }

        private void btnGeraetHinzufuegen_Click(object sender, EventArgs e) {
            try {
                if (rbtnPC.Checked) {
                    r208.GeraetHinzufuegen(new PC(tbxBezeichnung.Text, Convert.ToDouble(tbxWert.Text), Convert.ToDouble(tbxMisc.Text)));
                } else {
                    r208.GeraetHinzufuegen(new Drucker(tbxBezeichnung.Text, Convert.ToDouble(tbxWert.Text), Convert.ToInt32(tbxMisc.Text)));
                }
                tbxBezeichnung.Clear();
                tbxWert.Clear();
                tbxMisc.Clear();
            } catch {
                MessageBox.Show("Fehler bei der Eingabe");
            }
        }

        private void btnAbschreiben_Click(object sender, EventArgs e) {
            foreach (IGeraet g in r208.Geraete) {
                g.Abschreiben();
            }
        }

        private void btnComboboxLaden_Click(object sender, EventArgs e) {
            foreach (IGeraet g in r208.Geraete) {
                cbxGeraet.Items.Add(g.Bezeichnung);
            }
        }

        private void cbxGeraet_SelectedIndexChanged(object sender, EventArgs e) {
            IGeraet g = r208.GibGeraet(cbxGeraet.SelectedIndex);
            if (g.GetType() == typeof(PC)) {
                lbxGeraete.Items.Add(g.Bezeichnung + " " + g.Wert + " EUR " + ((PC) g).Festplatte + " GB");
            } else {
                lbxGeraete.Items.Add(g.Bezeichnung + " " + g.Wert + " EUR " + ((Drucker) g).Seiten_Minute + " Seiten pro Minute");
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e) {
            FileStream vFS = new FileStream("PC_Raumdaten.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter vBF = new BinaryFormatter();
            vBF.Serialize(vFS, r208);
            vFS.Close();
            MessageBox.Show("gespeichert");
        }

        private void btnLaden_Click(object sender, EventArgs e) {
            FileStream vFS = new FileStream("PC_Raumdaten.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter vBF = new BinaryFormatter();
            r208 = (PC_Raum) vBF.Deserialize(vFS);
            vFS.Close();
            MessageBox.Show("geladen");
        }
    }
}
