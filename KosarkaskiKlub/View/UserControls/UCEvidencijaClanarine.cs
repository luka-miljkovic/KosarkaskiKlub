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
    public partial class UCEvidencijaClanarine : UserControl
    {
        private EvidencijaClanarineController evidencijaClanarineController;


        public UCEvidencijaClanarine(EvidencijaClanarineController evidencijaClanarineController)
        {
            InitializeComponent();
            this.evidencijaClanarineController = evidencijaClanarineController;
            txtImePrezime.Text = "Luka Miljkovic";
            txtMesec.Text = "09";
            txtGodina.Text = "2020";
            txtDatumUplate.Text = "12.12.2020";
            txtIznos.Text = "2000.00";
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            evidencijaClanarineController.PretraziClana(txtImePrezime, dgvClanKluba);
        }

        private void btnSacuvajUplatu_Click(object sender, EventArgs e)
        {
            evidencijaClanarineController.SacuvajUplatu(txtDatumUplate, txtMesec, txtGodina, txtIznos, dgvClanKluba);
        }
    }
}
