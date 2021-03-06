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
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            evidencijaClanarineController.PretraziClana(txtImePrezime, dgvClanKluba);
        }

        private void btnSacuvajUplatu_Click(object sender, EventArgs e)
        {
            evidencijaClanarineController.SacuvajUplatu(dtpDatumUplate, cmbMesec, txtGodina, txtIznos, dgvClanKluba, dgvClanarine);
        }

        private void dgvClanKluba_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            evidencijaClanarineController.UcitajClana(dgvClanKluba, dgvClanarine, txtIdClanaKluba, txtImePrezimeClana, btnSacuvajUplatu);
        }

        private void UCEvidencijaClanarine_Load(object sender, EventArgs e)
        {

        }
    }
}
