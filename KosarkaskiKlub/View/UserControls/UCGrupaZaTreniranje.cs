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
    public partial class UCGrupaZaTreniranje : UserControl
    {
        private GrupaZaTreningController grupaZaTreningController;
        public BindingList<Trening> listaTreninga = new BindingList<Trening>();
        
        public UCGrupaZaTreniranje(Controller.GrupaZaTreningController grupaZaTreningController)
        {
            this.grupaZaTreningController = grupaZaTreningController;
            InitializeComponent();
            

            //grupaZaTreningController.InitForm(this);
        }

        private void btnDodajTrenong_Click(object sender, EventArgs e)
        {
        }

        private void UCGrupaZaTreniranje_Load(object sender, EventArgs e)
        {
            grupaZaTreningController.UcitajSale(cmbSale);

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            grupaZaTreningController.SacuvajNovuGurpu(txtNazivGrupe, cmbUzrast, dtpDatumOd, dtpDatumDo, this);
        }

        private void btnDodajTrening_Click(object sender, EventArgs e)
        {
            grupaZaTreningController.DodajTrening(cmbDanTreninga, txtVremeOd, txtVremeDo, cmbSale, dgvTreninzi, this);

        }

        private void btnObrisiTrening_Click(object sender, EventArgs e)
        {
            grupaZaTreningController.ObrisiTrening(dgvTreninzi, this, btnObrisiTrening);

        }

        private void dgvTreninzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnObrisiTrening.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
