using Domen;
using Microsoft.Win32;
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
    public class ClanKlubaController
    {
        internal void UcitajGrupe(ComboBox cmbGrupa, Button btnSacuvaj)
        {
            GrupaZaTreniranje grupa = new GrupaZaTreniranje
            {
                GCondition = $"T.TrenerID={MainCoordinator.Instance.Trener.TrenerId}"
            };
            List<GrupaZaTreniranje> grupe = Communication.Communication.Instance.PretraziGrupe(grupa);
            if(grupe == null || grupe.Count == 0)
            {
                MessageBox.Show("Ne postoji grupa za treniranje koju vi vodite!");
                btnSacuvaj.Enabled = false;
                return;
            }
            else
            {
                cmbGrupa.DataSource = grupe;
                cmbGrupa.SelectedIndex = -1;
            }

        }

        internal void SacuvajClanaKluba(TextBox txtImePrezime, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtSkola, ComboBox cmbGrupa)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime) |
                !UserControlHelpers.EmptyFieldValidation(txtSkola) |
                !UserControlHelpers.ComboBoxValidation(cmbGrupa))
            {
                return;
            }

            if(dtpDatumRodjenja.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Datum rodjenja ne sme biti veci od danasnjeg dana");
                return;                                     
            }

            try
            {
                ClanKluba clanKluba = new ClanKluba
                {
                    ImePrezime = txtImePrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value.Date,
                    DatumUpisa = dtpDatumUpisa.Value.Date,
                    NazivSkole = txtSkola.Text,
                    GrupaZaTreniranje = (GrupaZaTreniranje)cmbGrupa.SelectedItem
                };

                Communication.Communication.Instance.SacuvajClana(clanKluba);
                MessageBox.Show("Clan je uspesno sacuvan!");
                txtImePrezime.Text = "";
                dtpDatumRodjenja.Value = DateTime.Now;
                dtpDatumUpisa.Value = DateTime.Now;
                txtSkola.Text = "";
                cmbGrupa.SelectedIndex = -1;

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
    }
}
