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

namespace View
{
    public partial class FrmMain : Form
    {
        private MainController mainController;

        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        public void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void unosNoveGrupeZaTreniranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCGrupaZaTreniranje(this);
        }

        private void unesiNovogClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCClanKluba(this);
        }
    }
}
