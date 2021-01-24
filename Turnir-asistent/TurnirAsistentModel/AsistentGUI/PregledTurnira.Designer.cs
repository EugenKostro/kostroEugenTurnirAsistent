namespace AsistentGUI
{
    partial class PregledTurnira
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
            this.lblTurnir = new System.Windows.Forms.Label();
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.lblRunda = new System.Windows.Forms.Label();
            this.cmbRunde = new System.Windows.Forms.ComboBox();
            this.lstParovi = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPrvaEkipa = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtRezultatPrveEkipe = new System.Windows.Forms.TextBox();
            this.txtDrugeEkipe = new System.Windows.Forms.TextBox();
            this.lblRezultatDrugeEkipe = new System.Windows.Forms.Label();
            this.lblDrugaEkipa = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnSpremiRezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurnir
            // 
            this.lblTurnir.AutoSize = true;
            this.lblTurnir.BackColor = System.Drawing.Color.DarkCyan;
            this.lblTurnir.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurnir.Location = new System.Drawing.Point(63, 18);
            this.lblTurnir.Name = "lblTurnir";
            this.lblTurnir.Size = new System.Drawing.Size(130, 46);
            this.lblTurnir.TabIndex = 0;
            this.lblTurnir.Text = "Turnir:";
            this.lblTurnir.Click += new System.EventHandler(this.lblTurnir_Click);
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTurnira.Location = new System.Drawing.Point(235, 18);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(151, 46);
            this.lblNazivTurnira.TabIndex = 1;
            this.lblNazivTurnira.Text = "<naziv>";
            this.lblNazivTurnira.Click += new System.EventHandler(this.lblNazivTurnira_Click);
            // 
            // lblRunda
            // 
            this.lblRunda.AutoSize = true;
            this.lblRunda.BackColor = System.Drawing.Color.White;
            this.lblRunda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRunda.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRunda.Location = new System.Drawing.Point(64, 93);
            this.lblRunda.Name = "lblRunda";
            this.lblRunda.Size = new System.Drawing.Size(116, 41);
            this.lblRunda.TabIndex = 2;
            this.lblRunda.Text = "Runda:";
            this.lblRunda.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbRunde
            // 
            this.cmbRunde.FormattingEnabled = true;
            this.cmbRunde.Location = new System.Drawing.Point(235, 99);
            this.cmbRunde.Name = "cmbRunde";
            this.cmbRunde.Size = new System.Drawing.Size(196, 34);
            this.cmbRunde.TabIndex = 3;
            // 
            // lstParovi
            // 
            this.lstParovi.FormattingEnabled = true;
            this.lstParovi.ItemHeight = 26;
            this.lstParovi.Location = new System.Drawing.Point(64, 231);
            this.lstParovi.Name = "lstParovi";
            this.lstParovi.Size = new System.Drawing.Size(367, 264);
            this.lstParovi.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(63, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(303, 31);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Prikaži neodigrane utakmice";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lblPrvaEkipa
            // 
            this.lblPrvaEkipa.AutoSize = true;
            this.lblPrvaEkipa.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPrvaEkipa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrvaEkipa.Location = new System.Drawing.Point(484, 233);
            this.lblPrvaEkipa.Name = "lblPrvaEkipa";
            this.lblPrvaEkipa.Size = new System.Drawing.Size(159, 33);
            this.lblPrvaEkipa.TabIndex = 7;
            this.lblPrvaEkipa.Text = "<prvaEkipa>";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.BackColor = System.Drawing.Color.DarkCyan;
            this.lblRezultat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezultat.Location = new System.Drawing.Point(484, 284);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(116, 33);
            this.lblRezultat.TabIndex = 8;
            this.lblRezultat.Text = "Rezultat:";
            // 
            // txtRezultatPrveEkipe
            // 
            this.txtRezultatPrveEkipe.Location = new System.Drawing.Point(608, 285);
            this.txtRezultatPrveEkipe.Name = "txtRezultatPrveEkipe";
            this.txtRezultatPrveEkipe.Size = new System.Drawing.Size(108, 34);
            this.txtRezultatPrveEkipe.TabIndex = 9;
            // 
            // txtDrugeEkipe
            // 
            this.txtDrugeEkipe.Location = new System.Drawing.Point(608, 461);
            this.txtDrugeEkipe.Name = "txtDrugeEkipe";
            this.txtDrugeEkipe.Size = new System.Drawing.Size(108, 34);
            this.txtDrugeEkipe.TabIndex = 12;
            // 
            // lblRezultatDrugeEkipe
            // 
            this.lblRezultatDrugeEkipe.AutoSize = true;
            this.lblRezultatDrugeEkipe.BackColor = System.Drawing.Color.DarkCyan;
            this.lblRezultatDrugeEkipe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezultatDrugeEkipe.Location = new System.Drawing.Point(484, 460);
            this.lblRezultatDrugeEkipe.Name = "lblRezultatDrugeEkipe";
            this.lblRezultatDrugeEkipe.Size = new System.Drawing.Size(116, 33);
            this.lblRezultatDrugeEkipe.TabIndex = 11;
            this.lblRezultatDrugeEkipe.Text = "Rezultat:";
            // 
            // lblDrugaEkipa
            // 
            this.lblDrugaEkipa.AutoSize = true;
            this.lblDrugaEkipa.BackColor = System.Drawing.Color.DarkCyan;
            this.lblDrugaEkipa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDrugaEkipa.Location = new System.Drawing.Point(484, 409);
            this.lblDrugaEkipa.Name = "lblDrugaEkipa";
            this.lblDrugaEkipa.Size = new System.Drawing.Size(174, 33);
            this.lblDrugaEkipa.TabIndex = 10;
            this.lblDrugaEkipa.Text = "<drugaEkipa>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.BackColor = System.Drawing.Color.DarkCyan;
            this.lblVS.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVS.Location = new System.Drawing.Point(545, 338);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(82, 39);
            this.lblVS.TabIndex = 13;
            this.lblVS.Text = "-VS-";
            // 
            // btnSpremiRezultat
            // 
            this.btnSpremiRezultat.BackColor = System.Drawing.Color.White;
            this.btnSpremiRezultat.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSpremiRezultat.FlatAppearance.BorderSize = 2;
            this.btnSpremiRezultat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnSpremiRezultat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnSpremiRezultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiRezultat.Location = new System.Drawing.Point(771, 324);
            this.btnSpremiRezultat.Name = "btnSpremiRezultat";
            this.btnSpremiRezultat.Size = new System.Drawing.Size(161, 72);
            this.btnSpremiRezultat.TabIndex = 14;
            this.btnSpremiRezultat.Text = "Spremi";
            this.btnSpremiRezultat.UseVisualStyleBackColor = false;
            this.btnSpremiRezultat.Click += new System.EventHandler(this.btnSpremiRezultat_Click);
            // 
            // PregledTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1143, 552);
            this.Controls.Add(this.btnSpremiRezultat);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.txtDrugeEkipe);
            this.Controls.Add(this.lblRezultatDrugeEkipe);
            this.Controls.Add(this.lblDrugaEkipa);
            this.Controls.Add(this.txtRezultatPrveEkipe);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblPrvaEkipa);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lstParovi);
            this.Controls.Add(this.cmbRunde);
            this.Controls.Add(this.lblRunda);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.lblTurnir);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PregledTurnira";
            this.Text = "Pregled Turnira";
            this.Load += new System.EventHandler(this.PregledTurnira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnir;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.Label lblRunda;
        private System.Windows.Forms.ComboBox cmbRunde;
        private System.Windows.Forms.ListBox lstParovi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblPrvaEkipa;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtDrugeEkipe;
        private System.Windows.Forms.Label lblRezultatDrugeEkipe;
        private System.Windows.Forms.Label lblDrugaEkipa;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnSpremiRezultat;
    }
}

