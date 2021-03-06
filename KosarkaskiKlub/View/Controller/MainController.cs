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

        internal void OpenUCEvidencijaClanarine(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCEvidencijaClanarine(new EvidencijaClanarineController()));
        }

        internal void OpenUCUnosPrisustva(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUnosPrisustva(new UnosPrisustvaController()));
        }

        internal void OpenUCIzmenaClanaKluba(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCIzmenaClanaKluba(new IzmenaClanaKlubaController()));
        }

        internal void OpenUCIzmenaTreninga(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCIzmenaTreninga(new IzmenaTreningaController()));
        }

        internal void OpenUCPrikazGrupe(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCPrikazGrupeZaTreniranje(new PrikazGrupeController()));
        }
    }
}
