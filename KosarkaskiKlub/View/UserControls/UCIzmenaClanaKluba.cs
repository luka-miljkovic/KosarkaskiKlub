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
using Domen;

namespace View.UserControls
{
    public partial class UCIzmenaClanaKluba : UserControl
    {
        IzmenaClanaKlubaController izmenaClanaKlubaController;
        public UCIzmenaClanaKluba(Controller.IzmenaClanaKlubaController izmenaClanaKlubaController)
        {
            InitializeComponent();
            this.izmenaClanaKlubaController = izmenaClanaKlubaController;
            this.txtImePrezime.Text = "Luka Miljkovic";
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            izmenaClanaKlubaController.PretraziClana(txtImePrezime, dgvClanoviKluba, txtImePrezimeIzmena, dtpDatumRodjenja, dtpDatumUpisa, txtNazivSkole, cmbGrupa);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            izmenaClanaKlubaController.PopuniPolja(dgvClanoviKluba, txtImePrezimeIzmena, dtpDatumRodjenja, dtpDatumUpisa, txtNazivSkole, cmbGrupa);
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            izmenaClanaKlubaController.SacuvajIzmene(txtImePrezimeIzmena, dtpDatumRodjenja, dtpDatumUpisa, txtNazivSkole, cmbGrupa);
        }
    }
}
