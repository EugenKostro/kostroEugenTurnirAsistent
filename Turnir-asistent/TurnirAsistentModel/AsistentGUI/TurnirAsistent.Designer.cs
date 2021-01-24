namespace AsistentGUI
{
    partial class TurnirAsistent
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
            this.lblTurnamentAsistent = new System.Windows.Forms.Label();
            this.lblUcitaj = new System.Windows.Forms.Label();
            this.btnUcitajTurnir = new System.Windows.Forms.Button();
            this.btnKreirajTurnir2 = new System.Windows.Forms.Button();
            this.cmbUcitaj = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTurnamentAsistent
            // 
            this.lblTurnamentAsistent.AutoSize = true;
            this.lblTurnamentAsistent.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurnamentAsistent.Location = new System.Drawing.Point(161, 33);
            this.lblTurnamentAsistent.Name = "lblTurnamentAsistent";
            this.lblTurnamentAsistent.Size = new System.Drawing.Size(331, 46);
            this.lblTurnamentAsistent.TabIndex = 0;
            this.lblTurnamentAsistent.Text = "Turnament Asistent";
            this.lblTurnamentAsistent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUcitaj
            // 
            this.lblUcitaj.AutoSize = true;
            this.lblUcitaj.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUcitaj.Location = new System.Drawing.Point(118, 116);
            this.lblUcitaj.Name = "lblUcitaj";
            this.lblUcitaj.Size = new System.Drawing.Size(429, 46);
            this.lblUcitaj.TabIndex = 1;
            this.lblUcitaj.Text = "Učitaj već postojeći turnir";
            this.lblUcitaj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUcitaj.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUcitajTurnir
            // 
            this.btnUcitajTurnir.Location = new System.Drawing.Point(204, 257);
            this.btnUcitajTurnir.Name = "btnUcitajTurnir";
            this.btnUcitajTurnir.Size = new System.Drawing.Size(251, 51);
            this.btnUcitajTurnir.TabIndex = 2;
            this.btnUcitajTurnir.Text = "Učitaj turnir";
            this.btnUcitajTurnir.UseVisualStyleBackColor = true;
            // 
            // btnKreirajTurnir2
            // 
            this.btnKreirajTurnir2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajTurnir2.Location = new System.Drawing.Point(126, 339);
            this.btnKreirajTurnir2.Name = "btnKreirajTurnir2";
            this.btnKreirajTurnir2.Size = new System.Drawing.Size(421, 111);
            this.btnKreirajTurnir2.TabIndex = 3;
            this.btnKreirajTurnir2.Text = "Kreiraj turnir";
            this.btnKreirajTurnir2.UseVisualStyleBackColor = true;
            // 
            // cmbUcitaj
            // 
            this.cmbUcitaj.FormattingEnabled = true;
            this.cmbUcitaj.Location = new System.Drawing.Point(126, 194);
            this.cmbUcitaj.Name = "cmbUcitaj";
            this.cmbUcitaj.Size = new System.Drawing.Size(421, 34);
            this.cmbUcitaj.TabIndex = 4;
            // 
            // TurnirAsistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(668, 542);
            this.Controls.Add(this.cmbUcitaj);
            this.Controls.Add(this.btnKreirajTurnir2);
            this.Controls.Add(this.btnUcitajTurnir);
            this.Controls.Add(this.lblUcitaj);
            this.Controls.Add(this.lblTurnamentAsistent);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TurnirAsistent";
            this.Text = "Turnir Asistent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnamentAsistent;
        private System.Windows.Forms.Label lblUcitaj;
        private System.Windows.Forms.Button btnUcitajTurnir;
        private System.Windows.Forms.Button btnKreirajTurnir2;
        private System.Windows.Forms.ComboBox cmbUcitaj;
    }
}