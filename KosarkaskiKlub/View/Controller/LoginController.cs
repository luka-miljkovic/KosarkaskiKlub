using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class LoginController
    {
        internal bool Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom");
                return false;
            }
        }

        internal void Login(TextBox txtKorisnickoIme, TextBox txtLozinka, FrmLogin frmLogin)
        {
            if(!UserControlHelpers.EmptyFieldValidation(txtKorisnickoIme) |
                !UserControlHelpers.EmptyFieldValidation(txtLozinka))
            {
                return;     
            }
            try
            {
                Trener t = Communication.Communication.Instance.Login(txtKorisnickoIme.Text, txtLozinka.Text);
                if(t != null)
                {
                    MainCoordinator.Instance.Trener = t;
                    MessageBox.Show("Uspesno ste se prijavili");
                    MainCoordinator.Instance.OpenMainForm();
                    frmLogin.Dispose();
                }
                else
                {
                    throw new SystemNotFoundException();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ovde");
                //throw;
            }
        }
    }
}
