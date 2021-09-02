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
    public partial class UCUnosPrisustva : UserControl
    {
        UnosPrisustvaController unosPrisustvaController;
        public UCUnosPrisustva(Controller.UnosPrisustvaController unosPrisustvaController)
        {
            InitializeComponent();
            this.unosPrisustvaController = unosPrisustvaController;
        }

        private void btnPretraziTreninge_Click(object sender, EventArgs e)
        {
            unosPrisustvaController.PretraziTreninge(dtpDatumTreninga, dgvTreninzi, txtNazivGrupe, cbDatum, cbNaziv);
        }

        private void btnSacuvajPrisustva_Click(object sender, EventArgs e)
        {
            unosPrisustvaController.SacuvajPrisustva(dgvClanovi, txtDatumTreninga, txtVremeDo, txtGrupa, lblPrisustvo);
        }

        private void dgvTreninzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unosPrisustvaController.UcitajTreningIPrisustva(dgvTreninzi, dgvClanovi, btnSacuvajPrisustva, txtDatumTreninga, txtVremeDo, txtGrupa, lblPrisustvo);
        }

        private void UCUnosPrisustva_Load(object sender, EventArgs e)
        {

        }

        private void txtDatumTreninga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVremeOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVremeDo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
