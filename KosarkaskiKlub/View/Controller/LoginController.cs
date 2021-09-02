using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
            catch (SocketException)
            {
                MessageBox.Show("Greska prilikom povezivanja na server");
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
                Trener t = new Trener
                {
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text
                };
                t = Communication.Communication.Instance.Login(t);
                if(t != null)
                {
                    //if (t.VecUlogovan)
                    //{
                    //    MessageBox.Show("Vec ste ulogovani na sistem!");
                    //    return;
                    //}
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
