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
    public partial class UCIzmenaTreninga : UserControl
    {
        IzmenaTreningaController izmenaTreningaController;
        public UCIzmenaTreninga(Controller.IzmenaTreningaController izmenaTreningaController)
        {
            InitializeComponent();
            this.izmenaTreningaController = izmenaTreningaController;
            this.dtpDatumTreningaIzbor.Value = Convert.ToDateTime("10.10.2020");
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            izmenaTreningaController.Pretrazitreninge(dtpDatumTreningaIzbor, txtGrupaPretraga, dgvTreninzi, cbDatum, cbNaziv);
        }

        private void dgvTreninzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            izmenaTreningaController.UcitajTrening(dgvTreninzi, txtGrupa, txtVremeOd, txtVremeDo, dtpDatumTreninga, txtDanTreninga, cmbSale, btnSacuvajIzmene);
        }

        private void UCIzmenaTreninga_Load(object sender, EventArgs e)
        {
            izmenaTreningaController.UcitajSale(cmbSale);
       }

        private void dtpDatumTreninga_ValueChanged(object sender, EventArgs e)
        {
            izmenaTreningaController.PostaviDanTreninga(dtpDatumTreninga, txtDanTreninga);
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            izmenaTreningaController.SacuvajIzmene(txtGrupa, txtVremeOd, txtVremeDo, dtpDatumTreninga, txtDanTreninga, cmbSale);

        }
    }
}
