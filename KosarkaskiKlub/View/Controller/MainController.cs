using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.Controller
{
    public class MainController
    {
        internal void OpenUCGrupaZaTreniranje(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCGrupaZaTreniranje(new GrupaZaTreningController()));
        }

        internal void OpenUCClanKluba(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCClanKluba(new ClanKlubaController()));
        }
    }
}
