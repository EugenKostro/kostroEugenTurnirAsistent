namespace AsistentGUI
{
    partial class Kreiranjeturnira
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNapraviturnir = new System.Windows.Forms.Label();
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.lblKotizacija = new System.Windows.Forms.Label();
            this.lblOdaberiEkipu = new System.Windows.Forms.Label();
            this.lblEkipeIgraci = new System.Windows.Forms.Label();
            this.lblNagrade = new System.Windows.Forms.Label();
            this.txtKotizacija = new System.Windows.Forms.TextBox();
            this.txtNazivTurnira = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lnklblNapraviNovuEkipu = new System.Windows.Forms.LinkLabel();
            this.lstTimoviIgraci = new System.Windows.Forms.ListBox();
            this.lstNagrade = new System.Windows.Forms.ListBox();
            this.btnDodajEkipu = new System.Windows.Forms.Button();
            this.btnKreirajTurnir = new System.Windows.Forms.Button();
            this.btnKreirajNagradu = new System.Windows.Forms.Button();
            this.btnIzbrisiOdabrano2 = new System.Windows.Forms.Button();
            this.btnIzbrisiOdabrano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNapraviturnir
            // 
            this.lblNapraviturnir.AutoSize = true;
            this.lblNapraviturnir.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNapraviturnir.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNapraviturnir.Location = new System.Drawing.Point(2, 9);
            this.lblNapraviturnir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNapraviturnir.Name = "lblNapraviturnir";
            this.lblNapraviturnir.Size = new System.Drawing.Size(246, 46);
            this.lblNapraviturnir.TabIndex = 3;
            this.lblNapraviturnir.Text = "Napravi turnir";
            this.lblNapraviturnir.Click += new System.EventHandler(this.lblNapraviturnir_Click);
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTurnira.Location = new System.Drawing.Point(25, 77);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(160, 33);
            this.lblNazivTurnira.TabIndex = 4;
            this.lblNazivTurnira.Text = "Naziv turnira";
            // 
            // lblKotizacija
            // 
            this.lblKotizacija.AutoSize = true;
            this.lblKotizacija.BackColor = System.Drawing.Color.DarkCyan;
            this.lblKotizacija.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKotizacija.Location = new System.Drawing.Point(25, 194);
            this.lblKotizacija.Name = "lblKotizacija";
            this.lblKotizacija.Size = new System.Drawing.Size(128, 33);
            this.lblKotizacija.TabIndex = 5;
            this.lblKotizacija.Text = "Kotizacija";
            // 
            // lblOdaberiEkipu
            // 
            this.lblOdaberiEkipu.AutoSize = true;
            this.lblOdaberiEkipu.BackColor = System.Drawing.Color.DarkCyan;
            this.lblOdaberiEkipu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdaberiEkipu.Location = new System.Drawing.Point(25, 300);
            this.lblOdaberiEkipu.Name = "lblOdaberiEkipu";
            this.lblOdaberiEkipu.Size = new System.Drawing.Size(178, 33);
            this.lblOdaberiEkipu.TabIndex = 6;
            this.lblOdaberiEkipu.Text = "Odaberi Ekipu";
            // 
            // lblEkipeIgraci
            // 
            this.lblEkipeIgraci.AutoSize = true;
            this.lblEkipeIgraci.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEkipeIgraci.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEkipeIgraci.Location = new System.Drawing.Point(564, 58);
            this.lblEkipeIgraci.Name = "lblEkipeIgraci";
            this.lblEkipeIgraci.Size = new System.Drawing.Size(164, 33);
            this.lblEkipeIgraci.TabIndex = 7;
            this.lblEkipeIgraci.Text = "Ekipe / Igrači";
            // 
            // lblNagrade
            // 
            this.lblNagrade.AutoSize = true;
            this.lblNagrade.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNagrade.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNagrade.Location = new System.Drawing.Point(564, 247);
            this.lblNagrade.Name = "lblNagrade";
            this.lblNagrade.Size = new System.Drawing.Size(107, 33);
            this.lblNagrade.TabIndex = 8;
            this.lblNagrade.Text = "Nagrade";
            // 
            // txtKotizacija
            // 
            this.txtKotizacija.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKotizacija.Location = new System.Drawing.Point(177, 198);
            this.txtKotizacija.Name = "txtKotizacija";
            this.txtKotizacija.Size = new System.Drawing.Size(191, 30);
            this.txtKotizacija.TabIndex = 9;
            // 
            // txtNazivTurnira
            // 
            this.txtNazivTurnira.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivTurnira.Location = new System.Drawing.Point(25, 125);
            this.txtNazivTurnira.Name = "txtNazivTurnira";
            this.txtNazivTurnira.Size = new System.Drawing.Size(343, 30);
            this.txtNazivTurnira.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 361);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 30);
            this.comboBox1.TabIndex = 11;
            // 
            // lnklblNapraviNovuEkipu
            // 
            this.lnklblNapraviNovuEkipu.AutoSize = true;
            this.lnklblNapraviNovuEkipu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnklblNapraviNovuEkipu.LinkColor = System.Drawing.Color.Black;
            this.lnklblNapraviNovuEkipu.Location = new System.Drawing.Point(227, 308);
            this.lnklblNapraviNovuEkipu.Name = "lnklblNapraviNovuEkipu";
            this.lnklblNapraviNovuEkipu.Size = new System.Drawing.Size(202, 27);
            this.lnklblNapraviNovuEkipu.TabIndex = 12;
            this.lnklblNapraviNovuEkipu.TabStop = true;
            this.lnklblNapraviNovuEkipu.Text = "Napravi novu ekipu";
            // 
            // lstTimoviIgraci
            // 
            this.lstTimoviIgraci.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstTimoviIgraci.FormattingEnabled = true;
            this.lstTimoviIgraci.ItemHeight = 26;
            this.lstTimoviIgraci.Location = new System.Drawing.Point(570, 105);
            this.lstTimoviIgraci.Name = "lstTimoviIgraci";
            this.lstTimoviIgraci.Size = new System.Drawing.Size(384, 134);
            this.lstTimoviIgraci.TabIndex = 13;
            // 
            // lstNagrade
            // 
            this.lstNagrade.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstNagrade.FormattingEnabled = true;
            this.lstNagrade.ItemHeight = 26;
            this.lstNagrade.Location = new System.Drawing.Point(570, 300);
            this.lstNagrade.Name = "lstNagrade";
            this.lstNagrade.Size = new System.Drawing.Size(384, 134);
            this.lstNagrade.TabIndex = 14;
            // 
            // btnDodajEkipu
            // 
            this.btnDodajEkipu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajEkipu.Location = new System.Drawing.Point(76, 397);
            this.btnDodajEkipu.Name = "btnDodajEkipu";
            this.btnDodajEkipu.Size = new System.Drawing.Size(240, 38);
            this.btnDodajEkipu.TabIndex = 15;
            this.btnDodajEkipu.Text = "Dodaj ekipu";
            this.btnDodajEkipu.UseVisualStyleBackColor = true;
            this.btnDodajEkipu.Click += new System.EventHandler(this.btnDodajEkipu_Click);
            // 
            // btnKreirajTurnir
            // 
            this.btnKreirajTurnir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajTurnir.Location = new System.Drawing.Point(383, 507);
            this.btnKreirajTurnir.Name = "btnKreirajTurnir";
            this.btnKreirajTurnir.Size = new System.Drawing.Size(240, 38);
            this.btnKreirajTurnir.TabIndex = 16;
            this.btnKreirajTurnir.Text = "Kreiraj turnir";
            this.btnKreirajTurnir.UseVisualStyleBackColor = true;
            this.btnKreirajTurnir.Click += new System.EventHandler(this.btnKreirajTurnir_Click);
            // 
            // btnKreirajNagradu
            // 
            this.btnKreirajNagradu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajNagradu.Location = new System.Drawing.Point(570, 440);
            this.btnKreirajNagradu.Name = "btnKreirajNagradu";
            this.btnKreirajNagradu.Size = new System.Drawing.Size(240, 38);
            this.btnKreirajNagradu.TabIndex = 17;
            this.btnKreirajNagradu.Text = "Kreiraj nagradu";
            this.btnKreirajNagradu.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiOdabrano2
            // 
            this.btnIzbrisiOdabrano2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiOdabrano2.Location = new System.Drawing.Point(966, 300);
            this.btnIzbrisiOdabrano2.Name = "btnIzbrisiOdabrano2";
            this.btnIzbrisiOdabrano2.Size = new System.Drawing.Size(155, 105);
            this.btnIzbrisiOdabrano2.TabIndex = 18;
            this.btnIzbrisiOdabrano2.Text = "Izbriši odabrano";
            this.btnIzbrisiOdabrano2.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiOdabrano
            // 
            this.btnIzbrisiOdabrano.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiOdabrano.Location = new System.Drawing.Point(966, 105);
            this.btnIzbrisiOdabrano.Name = "btnIzbrisiOdabrano";
            this.btnIzbrisiOdabrano.Size = new System.Drawing.Size(155, 105);
            this.btnIzbrisiOdabrano.TabIndex = 19;
            this.btnIzbrisiOdabrano.Text = "Izbriši odabrano";
            this.btnIzbrisiOdabrano.UseVisualStyleBackColor = true;
            // 
            // Kreiranjeturnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1165, 557);
            this.Controls.Add(this.btnIzbrisiOdabrano);
            this.Controls.Add(this.btnIzbrisiOdabrano2);
            this.Controls.Add(this.btnKreirajNagradu);
            this.Controls.Add(this.btnKreirajTurnir);
            this.Controls.Add(this.btnDodajEkipu);
            this.Controls.Add(this.lstNagrade);
            this.Controls.Add(this.lstTimoviIgraci);
            this.Controls.Add(this.lnklblNapraviNovuEkipu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNazivTurnira);
            this.Controls.Add(this.txtKotizacija);
            this.Controls.Add(this.lblNagrade);
            this.Controls.Add(this.lblEkipeIgraci);
            this.Controls.Add(this.lblOdaberiEkipu);
            this.Controls.Add(this.lblKotizacija);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.lblNapraviturnir);
            this.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Kreiranjeturnira";
            this.Text = "Kreiranje turnira";
            this.Load += new System.EventHandler(this.KreiranjeTurnira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNapraviturnir;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.Label lblKotizacija;
        private System.Windows.Forms.Label lblOdaberiEkipu;
        private System.Windows.Forms.Label lblEkipeIgraci;
        private System.Windows.Forms.Label lblNagrade;
        private System.Windows.Forms.TextBox txtKotizacija;
        private System.Windows.Forms.TextBox txtNazivTurnira;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel lnklblNapraviNovuEkipu;
        private System.Windows.Forms.ListBox lstTimoviIgraci;
        private System.Windows.Forms.ListBox lstNagrade;
        private System.Windows.Forms.Button btnDodajEkipu;
        private System.Windows.Forms.Button btnKreirajTurnir;
        private System.Windows.Forms.Button btnKreirajNagradu;
        private System.Windows.Forms.Button btnIzbrisiOdabrano2;
        private System.Windows.Forms.Button btnIzbrisiOdabrano;
    }
}