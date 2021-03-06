using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;
using View.UserControls;

namespace View
{
    public partial class FrmMain : Form
    {
        MainController mainController = new MainController();

        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(Controller.MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            pnlMain.BackgroundImage = null;
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void unosNoveGrupeZaTreniranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void upisNovogClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void evidencijaClanarineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void unesiPrisustvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void izmenaČlanaKlubaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void izmenaTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void unosNoveGrupeZaTreniranjeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainController.OpenUCGrupaZaTreniranje(this);
        }

        private void izmenaTreningaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainController.OpenUCIzmenaTreninga(this);
        }

        private void unosNovogČlanaKlubaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCClanKluba(this);
        }

        private void evidencijaPlaćanjaČlanarineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCEvidencijaClanarine(this);
        }

        private void izmenaČlanaKlunbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCIzmenaClanaKluba(this);
        }

        private void evidencijaPrisustvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUnosPrisustva(this);
        }

        private void prikazGrupeZaTreniranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCPrikazGrupe(this);
        }
    }
}
