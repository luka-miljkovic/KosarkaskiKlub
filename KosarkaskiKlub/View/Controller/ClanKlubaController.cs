using Domen;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helpers;

namespace View.Controller
{
    public class ClanKlubaController
    {
        internal void UcitajGrupe(ComboBox cmbGrupa)
        {
            cmbGrupa.DataSource = Communication.Communication.Instance.VratiGrupe();
        }

        internal void SacuvajClanaKluba(TextBox txtImePrezime, TextBox txtDatumRodjenja, TextBox txtSatumUpisa, TextBox txtSkola, ComboBox cmbGrupa)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime) |
                !UserControlHelpers.EmptyFieldValidation(txtSkola) |
                !UserControlHelpers.DateValidation(txtDatumRodjenja) |
                !UserControlHelpers.DateValidation(txtSatumUpisa) |
                cmbGrupa.SelectedItem == null)
            {
                return;
            }

            ClanKluba clanKluba = new ClanKluba
            {
                ImePrezime = txtImePrezime.Text,
                DatumRodjenja = Convert.ToDateTime(txtDatumRodjenja.Text),
                DatumUpisa = Convert.ToDateTime(txtSatumUpisa.Text),
                NazivSkole = txtSkola.Text,
                GrupaZaTreniranje = (GrupaZaTreniranje)cmbGrupa.SelectedItem
            };

            Communication.Communication.Instance.SacuvajClana(clanKluba);
            MessageBox.Show("Clan je uspesno sacuvan!");
        }
                
    }
}
