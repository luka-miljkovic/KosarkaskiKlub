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
using View.Helpers;

namespace View.UserControls
{
    public partial class UCPrikazGrupeZaTreniranje : UserControl
    {
        PrikazGrupeController prikazTreningaController;
        public UCPrikazGrupeZaTreniranje(Controller.PrikazGrupeController prikazTreningaController)
        {
            InitializeComponent();
            this.prikazTreningaController = prikazTreningaController;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            prikazTreningaController.PretraziTreninge(txtNaziv, dgvGrupe);
        }

        private void dgvGrupe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            prikazTreningaController.UcitajGrupu(dgvGrupe, dgvClanovi, dgvTreninzi, txtIdGrupe, txtNazivGrupe, txtDatumFormiranja, txtUzrast, txtTrener);
        }

        private void UCPrikazGrupeZaTreniranje_Load(object sender, EventArgs e)
        {
            

        }
    }
}
