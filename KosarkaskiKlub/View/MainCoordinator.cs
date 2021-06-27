using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Controller;

namespace View
{
    public class MainCoordinator
    {
        private MainController mainController = new MainController();
        private LoginController loginController = new LoginController();
        private FrmLogin frmLogin;
        private FrmMain frmMain;

        private static MainCoordinator instance;
        private MainCoordinator() { }

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();                    
                }
                return instance;
            }
        }

        public Trener Trener { get; internal set; }

        public void OpenLoginForm()
        {
            frmLogin = new FrmLogin(loginController);
            frmLogin.Show();
        }

        public void OpenMainForm()
        {
            frmMain = new FrmMain(mainController);
            frmMain.Show();
        }
    }
}
