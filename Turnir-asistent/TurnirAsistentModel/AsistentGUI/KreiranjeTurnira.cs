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
using TurnirAsistentModel.Models;

namespace AsistentGUI
{
    public partial class Kreiranjeturnira : Form
    {
        List<EkipaModel> dostupneEkipe = GlobalConfig.Connection.GetEkipa_All();
        List<EkipaModel> izabraneEkipe = new List<EkipaModel>();
        List<NagradaModel> izabraneNagrade = new List<NagradaModel>();
        public Kreiranjeturnira()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = dostupneEkipe;
            comboBox1.DisplayMember = "ImeEkipe";

            lstTimoviIgraci.DataSource = null;
            lstTimoviIgraci.DataSource = izabraneEkipe;
            lstTimoviIgraci.DisplayMember = "ImeEkipe";

            lstNagrade.DataSource = null;
            lstNagrade.DataSource = izabraneNagrade;
            lstNagrade.DisplayMember = "NazivMjesta";
        }

        private void lblNapraviturnir_Click(object sender, EventArgs e)
        {

        }

        private void KreiranjeTurnira_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajEkipu_Click(object sender, EventArgs e)
        {


            EkipaModel t = (EkipaModel)comboBox1.SelectedItem;

            if (t != null)
            {
                dostupneEkipe.Remove(t);
                izabraneEkipe.Add(t);

                WireUpLists();
            }
        }

        private void btnKreirajTurnir_Click(object sender, EventArgs e)
        {
            decimal kotizacija = 0;
            bool dobraKotizacija = decimal.TryParse(txtKotizacija.Text, out kotizacija);

            if (!dobraKotizacija)
            {
                MessageBox.Show("Morate upisati dobru kotizaciju!",
                    "Netočna kotizacija!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            TurnirModel tm = new TurnirModel();
            tm.NazivTurnira = txtNazivTurnira.Text;
            tm.Kotizacija = kotizacija;

            tm.Nagrade = izabraneNagrade;
            tm.PrijavljeniTimovi = izabraneEkipe;

            GlobalConfig.Connection.KreiranjeTurnira(tm);
        }
    }
}
