namespace abschlusspruefung {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnGeraetHinzufuegen = new System.Windows.Forms.Button();
            this.btnAbschreiben = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLaden = new System.Windows.Forms.Button();
            this.btnComboboxLaden = new System.Windows.Forms.Button();
            this.gbxNeuesGeraet = new System.Windows.Forms.GroupBox();
            this.rbtnPC = new System.Windows.Forms.RadioButton();
            this.rbtnDrucker = new System.Windows.Forms.RadioButton();
            this.tbxBezeichnung = new System.Windows.Forms.TextBox();
            this.tbxWert = new System.Windows.Forms.TextBox();
            this.tbxMisc = new System.Windows.Forms.TextBox();
            this.gbxAnzeige = new System.Windows.Forms.GroupBox();
            this.cbxGeraet = new System.Windows.Forms.ComboBox();
            this.lbxGeraete = new System.Windows.Forms.ListBox();
            this.gbxNeuesGeraet.SuspendLayout();
            this.gbxAnzeige.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeraetHinzufuegen
            // 
            this.btnGeraetHinzufuegen.Location = new System.Drawing.Point(12, 12);
            this.btnGeraetHinzufuegen.Name = "btnGeraetHinzufuegen";
            this.btnGeraetHinzufuegen.Size = new System.Drawing.Size(156, 36);
            this.btnGeraetHinzufuegen.TabIndex = 0;
            this.btnGeraetHinzufuegen.Text = "Neues Geraet hinzufuegen";
            this.btnGeraetHinzufuegen.UseVisualStyleBackColor = true;
            this.btnGeraetHinzufuegen.Click += new System.EventHandler(this.btnGeraetHinzufuegen_Click);
            // 
            // btnAbschreiben
            // 
            this.btnAbschreiben.Location = new System.Drawing.Point(12, 54);
            this.btnAbschreiben.Name = "btnAbschreiben";
            this.btnAbschreiben.Size = new System.Drawing.Size(156, 36);
            this.btnAbschreiben.TabIndex = 1;
            this.btnAbschreiben.Text = "Geraete abschreiben";
            this.btnAbschreiben.UseVisualStyleBackColor = true;
            this.btnAbschreiben.Click += new System.EventHandler(this.btnAbschreiben_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(12, 96);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(156, 36);
            this.btnSpeichern.TabIndex = 2;
            this.btnSpeichern.Text = "Raum speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLaden
            // 
            this.btnLaden.Location = new System.Drawing.Point(12, 138);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(156, 36);
            this.btnLaden.TabIndex = 3;
            this.btnLaden.Text = "Raum laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            this.btnLaden.Click += new System.EventHandler(this.btnLaden_Click);
            // 
            // btnComboboxLaden
            // 
            this.btnComboboxLaden.Location = new System.Drawing.Point(12, 180);
            this.btnComboboxLaden.Name = "btnComboboxLaden";
            this.btnComboboxLaden.Size = new System.Drawing.Size(156, 36);
            this.btnComboboxLaden.TabIndex = 4;
            this.btnComboboxLaden.Text = "ComboBox mit Geraetebezeichnung laden";
            this.btnComboboxLaden.UseVisualStyleBackColor = true;
            this.btnComboboxLaden.Click += new System.EventHandler(this.btnComboboxLaden_Click);
            // 
            // gbxNeuesGeraet
            // 
            this.gbxNeuesGeraet.Controls.Add(this.tbxMisc);
            this.gbxNeuesGeraet.Controls.Add(this.tbxWert);
            this.gbxNeuesGeraet.Controls.Add(this.tbxBezeichnung);
            this.gbxNeuesGeraet.Controls.Add(this.rbtnDrucker);
            this.gbxNeuesGeraet.Controls.Add(this.rbtnPC);
            this.gbxNeuesGeraet.Location = new System.Drawing.Point(377, 12);
            this.gbxNeuesGeraet.Name = "gbxNeuesGeraet";
            this.gbxNeuesGeraet.Size = new System.Drawing.Size(375, 162);
            this.gbxNeuesGeraet.TabIndex = 5;
            this.gbxNeuesGeraet.TabStop = false;
            this.gbxNeuesGeraet.Text = "Neues Geraet hinzufuegen";
            // 
            // rbtnPC
            // 
            this.rbtnPC.AutoSize = true;
            this.rbtnPC.Location = new System.Drawing.Point(7, 20);
            this.rbtnPC.Name = "rbtnPC";
            this.rbtnPC.Size = new System.Drawing.Size(39, 17);
            this.rbtnPC.TabIndex = 0;
            this.rbtnPC.TabStop = true;
            this.rbtnPC.Text = "PC";
            this.rbtnPC.UseVisualStyleBackColor = true;
            // 
            // rbtnDrucker
            // 
            this.rbtnDrucker.AutoSize = true;
            this.rbtnDrucker.Location = new System.Drawing.Point(7, 44);
            this.rbtnDrucker.Name = "rbtnDrucker";
            this.rbtnDrucker.Size = new System.Drawing.Size(63, 17);
            this.rbtnDrucker.TabIndex = 1;
            this.rbtnDrucker.TabStop = true;
            this.rbtnDrucker.Text = "Drucker";
            this.rbtnDrucker.UseVisualStyleBackColor = true;
            // 
            // tbxBezeichnung
            // 
            this.tbxBezeichnung.Location = new System.Drawing.Point(7, 68);
            this.tbxBezeichnung.Name = "tbxBezeichnung";
            this.tbxBezeichnung.Size = new System.Drawing.Size(362, 20);
            this.tbxBezeichnung.TabIndex = 2;
            // 
            // tbxWert
            // 
            this.tbxWert.Location = new System.Drawing.Point(7, 95);
            this.tbxWert.Name = "tbxWert";
            this.tbxWert.Size = new System.Drawing.Size(362, 20);
            this.tbxWert.TabIndex = 3;
            // 
            // tbxMisc
            // 
            this.tbxMisc.Location = new System.Drawing.Point(7, 122);
            this.tbxMisc.Name = "tbxMisc";
            this.tbxMisc.Size = new System.Drawing.Size(362, 20);
            this.tbxMisc.TabIndex = 4;
            // 
            // gbxAnzeige
            // 
            this.gbxAnzeige.Controls.Add(this.lbxGeraete);
            this.gbxAnzeige.Controls.Add(this.cbxGeraet);
            this.gbxAnzeige.Location = new System.Drawing.Point(384, 181);
            this.gbxAnzeige.Name = "gbxAnzeige";
            this.gbxAnzeige.Size = new System.Drawing.Size(362, 232);
            this.gbxAnzeige.TabIndex = 6;
            this.gbxAnzeige.TabStop = false;
            this.gbxAnzeige.Text = "Geraet anzeigen";
            // 
            // cbxGeraet
            // 
            this.cbxGeraet.FormattingEnabled = true;
            this.cbxGeraet.Location = new System.Drawing.Point(7, 20);
            this.cbxGeraet.Name = "cbxGeraet";
            this.cbxGeraet.Size = new System.Drawing.Size(349, 21);
            this.cbxGeraet.TabIndex = 0;
            this.cbxGeraet.SelectedIndexChanged += new System.EventHandler(this.cbxGeraet_SelectedIndexChanged);
            // 
            // lbxGeraete
            // 
            this.lbxGeraete.FormattingEnabled = true;
            this.lbxGeraete.Location = new System.Drawing.Point(7, 48);
            this.lbxGeraete.Name = "lbxGeraete";
            this.lbxGeraete.Size = new System.Drawing.Size(349, 173);
            this.lbxGeraete.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 425);
            this.Controls.Add(this.gbxAnzeige);
            this.Controls.Add(this.gbxNeuesGeraet);
            this.Controls.Add(this.btnComboboxLaden);
            this.Controls.Add(this.btnLaden);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnAbschreiben);
            this.Controls.Add(this.btnGeraetHinzufuegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxNeuesGeraet.ResumeLayout(false);
            this.gbxNeuesGeraet.PerformLayout();
            this.gbxAnzeige.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeraetHinzufuegen;
        private System.Windows.Forms.Button btnAbschreiben;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.Button btnComboboxLaden;
        private System.Windows.Forms.GroupBox gbxNeuesGeraet;
        private System.Windows.Forms.TextBox tbxWert;
        private System.Windows.Forms.TextBox tbxBezeichnung;
        private System.Windows.Forms.RadioButton rbtnDrucker;
        private System.Windows.Forms.RadioButton rbtnPC;
        private System.Windows.Forms.TextBox tbxMisc;
        private System.Windows.Forms.GroupBox gbxAnzeige;
        private System.Windows.Forms.ListBox lbxGeraete;
        private System.Windows.Forms.ComboBox cbxGeraet;
    }
}

