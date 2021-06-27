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
    }
}
