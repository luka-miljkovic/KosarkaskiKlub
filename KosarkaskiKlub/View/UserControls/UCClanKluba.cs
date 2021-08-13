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
            clanKlubaController.UcitajGrupe(cmbGrupa);
            txtImePrezime.Text = "Luka Miljkovic";
            txtDatumRodjenja.Text = "12.12.2020";
            txtSatumUpisa.Text = "12.12.2020";
            txtSkola.Text = "CK";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            clanKlubaController.SacuvajClanaKluba(txtImePrezime, txtDatumRodjenja, txtSatumUpisa, txtSkola, cmbGrupa);
        }
    }
}
