using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnirAsistentModel;
using TurnirAsistentModel.DataAccess;
using TurnirAsistentModel.Models;

namespace AsistentGUI
{
    public partial class DodavanjeNagrada : Form
    {
        public DodavanjeNagrada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzradiNagradu_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) 
            {
                NagradaModel model = new NagradaModel(txtMjesto.Text, txtNazivMjesta.Text, txtKolicinaNagrade.Text, txtPostotakNagrade.Text );

                GlobalConfig.Connection.NapraviNagradu(model);

                txtMjesto.Text = "";
                txtNazivMjesta.Text = "";
                txtKolicinaNagrade.Text = "0";
                txtPostotakNagrade.Text = "0";
            }
            else
            {
                MessageBox.Show("Ova forma ima nepravilne podatke. Molim ves provjerite i probajte opet.");
            }
        

        }

        private bool ValidateForm()
        {
            bool output = true;
            int mjesto = 0;
            bool mjestoValidNumber = int.TryParse(txtMjesto.Text, out mjesto);

            if (mjestoValidNumber == false)
            {
                output = false;
            }   
            if (mjesto < 1)
            {
                output = false;
            }
            if (txtNazivMjesta.Text.Length == 0)
            {
                output = false;
            }
            decimal kolicinaNagrade = 0;
            int postotakNagrade = 0;

            bool kolicinaNagradeValid = decimal.TryParse(txtKolicinaNagrade.Text, out kolicinaNagrade);
            bool postotakNagradeValid = int.TryParse(txtPostotakNagrade.Text, out postotakNagrade);

            if(kolicinaNagradeValid == false || postotakNagradeValid == false)
            {
                output = false;
            } 
            if(kolicinaNagrade <= 0 && postotakNagrade <= 0){
                output = false;
            }
            if(kolicinaNagrade < 0 || postotakNagrade > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
