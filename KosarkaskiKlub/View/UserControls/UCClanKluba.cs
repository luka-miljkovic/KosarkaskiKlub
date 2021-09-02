using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View.UserControls
{
    public partial class UCClanKluba : UserControl
    {
        private ClanKlubaController clanKlubaController;


        public UCClanKluba(ClanKlubaController clanKlubaController)
        {
            InitializeComponent();
            this.clanKlubaController = clanKlubaController;
            clanKlubaController.UcitajGrupe(cmbGrupa, btnSacuvaj);
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            clanKlubaController.SacuvajClanaKluba(txtImePrezime, dtpDatumRodjenja, dtpDatumUpisa, txtSkola, cmbGrupa);
        }

        private void UCClanKluba_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Novi clan kluba je uspesno sacuvan");
            //MessageBox.Show("Greska prilikom unosa novog clana");

            //MessageBox.Show("Podaci o izabranom clanu kluba");
            //MessageBox.Show("Ne postoji ni jedan clan kluba koji odgovara zadatoj vrednosti");
            //MessageBox.Show("Trenutno nije moguce ucitati clana kluba");

            //MessageBox.Show("Clan kluba je izmenjen");
            //MessageBox.Show("Pamcenje izmena clana kluba nije uspelo");
            //MessageBox.Show("Podaci o izabranom clanu kluba i njegovim placenim clanarinama");
            //MessageBox.Show("Placanje clanarine je uspesno evidentirano");
            //MessageBox.Show("Podaci o izabranom clanu kluba. Ucitani clan kluba nije platio ni jednu clanarinu do sada.");
            //MessageBox.Show("Greska prilikom evidentiranja clanarine. Promena nije sacuvana");
            //MessageBox.Show("Prikaz clanova za koje je potrebno da unesete prisustva");
            //MessageBox.Show("Nova prisustva su uspesno sacuvana");
            //MessageBox.Show("Vec ste uneli prisustva za odabrani trening");
            //MessageBox.Show("Greska prilikom evidencije prisustva. Promena nije sacuvana");

        }
    }
}
