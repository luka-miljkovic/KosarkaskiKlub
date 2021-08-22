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
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin( )
        {
            InitializeComponent();
        }
        public FrmLogin(LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
        }

        

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Communication.Communication.Instance.Connect();
            //this.Text = "Uspesno povezan!";
            txtKorisnickoIme.Text = "miki";
            txtLozinka.Text = "miki";
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
            {
                loginController.Login(txtKorisnickoIme, txtLozinka, this);
                //MessageBox.Show("Uspesno se konektovao na server");
            }
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
