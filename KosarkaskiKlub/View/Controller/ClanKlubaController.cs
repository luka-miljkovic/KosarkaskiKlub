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
            cmbGrupa.SelectedIndex = -1;
            cmbGrupa.Text = "Izaberite grupu za treniranje";
        }

        internal void SacuvajClanaKluba(TextBox txtImePrezime, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtSkola, ComboBox cmbGrupa)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime) |
                !UserControlHelpers.EmptyFieldValidation(txtSkola) |
                !UserControlHelpers.ComboBoxValidation(cmbGrupa))
            {
                return;
            }

            ClanKluba clanKluba = new ClanKluba
            {
                ImePrezime = txtImePrezime.Text,
                DatumRodjenja = dtpDatumRodjenja.Value.Date,
                //DatumRodjenja = Convert.ToDateTime($"{dtpDatumRodjenja.Value.Day}.{dtpDatumRodjenja.Value.Month}.{dtpDatumRodjenja.Value.Year}"),
                //DatumUpisa = dtpDatumUpisa.Value.Date,
                DatumUpisa = Convert.ToDateTime("12.12.2020"),
                NazivSkole = txtSkola.Text,
                GrupaZaTreniranje = (GrupaZaTreniranje)cmbGrupa.SelectedItem
            };

            Communication.Communication.Instance.SacuvajClana(clanKluba);
            MessageBox.Show("Clan je uspesno sacuvan!");
        }
                
    }
}
