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
            grupaZaTreningController.DodajTrening(txtRBTreninga, cmbDanTreninga, txtVremeOd, txtVremeDo, cmbSale, dgvTreninzi, this);
        }

        private void UCGrupaZaTreniranje_Load(object sender, EventArgs e)
        {
            cmbSale.DataSource = Communication.Communication.Instance.VratiSale();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grupaZaTreningController.ObrisiTrening(dgvTreninzi, this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            grupaZaTreningController.SacuvajNovuGurpu(txtNazivGrupe, cmbUzrast, this);
        }
    }
}
