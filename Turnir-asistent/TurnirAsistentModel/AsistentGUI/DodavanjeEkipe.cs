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
    public partial class DodavanjeEkipe : Form
    {
        private List<OsobaModel> dostupniIgraciEkipe = GlobalConfig.Connection.GetPeople_All();
        private List<OsobaModel> izabraniIgraciEkipe = new List<OsobaModel>();
        public DodavanjeEkipe()
        {
            InitializeComponent();

            //CreateSimpleData();

            WireUpLists();
        }

       
        private void CreateSimpleData()
        {
            dostupniIgraciEkipe.Add(new OsobaModel { Ime = "Eugen", Prezime = "Koštro" });
            dostupniIgraciEkipe.Add(new OsobaModel { Ime = "Tim", Prezime = "Corey" });

            izabraniIgraciEkipe.Add(new OsobaModel { Ime = "Jane", Prezime = "Smith" });
            izabraniIgraciEkipe.Add(new OsobaModel { Ime = "Bill", Prezime = "Jones" });

            
        }

        private void WireUpLists()
        {
            comboBox1.DataSource = null;

            comboBox1.DataSource = dostupniIgraciEkipe;
            comboBox1.DisplayMember = "PunoIme";

            lstIgrači.DataSource = null;

            lstIgrači.DataSource = izabraniIgraciEkipe;
            lstIgrači.DisplayMember = "PunoIme";
        }
        private void DodavanjeEkipe_Load(object sender, EventArgs e)
        {

        }

        private void lblDodajNovogIgraca_Click(object sender, EventArgs e)
        {

        }

        private void lblImeEkipe_Click(object sender, EventArgs e)
        {

        }

        private void btnIzradiIgrača_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                OsobaModel p = new OsobaModel();
                p.Ime = textBox2.Text;
                p.Prezime = textBox3.Text;
                p.EmailAdresa = textBox4.Text;
                p.BrojMobitela = textBox5.Text;

                p = GlobalConfig.Connection.IzradiOsobu(p);
                izabraniIgraciEkipe.Add(p);
                WireUpLists();

                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja.");
            }
        }

        private bool ValidateForm()
        {
            if(textBox2.Text.Length == 0)
            {
                return false;
            }
            if (textBox3.Text.Length == 0)
            {
                return false;
            }
            if (textBox4.Text.Length == 0)
            {
                return false;
            }
            if (textBox5.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void lstIgrači_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)comboBox1.SelectedItem;
            if (p != null)
            {
                dostupniIgraciEkipe.Remove(p);
                izabraniIgraciEkipe.Add(p);

                WireUpLists();
            }
        }

        private void btnMakniIzabrano_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)lstIgrači.SelectedItem;
            if(p != null)
            {
                izabraniIgraciEkipe.Remove(p);
                dostupniIgraciEkipe.Add(p);

                WireUpLists();
            }
        }

        private void btnStvoriEkipu_Click(object sender, EventArgs e)
        {
            EkipaModel t = new EkipaModel();

            t.ImeEkipe = textBox1.Text;
            t.ClanoviEkipe = izabraniIgraciEkipe;

            GlobalConfig.Connection.IzradiEkipu(t);

            // TODO - if we aren't closing this form after creation, reset the form
        }
    }
}
