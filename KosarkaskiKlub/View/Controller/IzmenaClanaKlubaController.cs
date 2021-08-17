using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helpers;

namespace View.Controller
{
    public class IzmenaClanaKlubaController
    {
        ClanKluba clanKluba = new ClanKluba();
        internal void PretraziClana(TextBox txtImePrezime, DataGridView dgvClanoviKluba, TextBox txtImePrezimeIzmena, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtNazivSkole, ComboBox cmbGrupe)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime))
            {
                return;
            }
            dgvClanoviKluba.DataSource = Communication.Communication.Instance.PretreziClana($"ImePrezime = '{txtImePrezime.Text}'");

        }

        internal void PopuniPolja(DataGridView dgvClanoviKluba, TextBox txtImePrezimeIzmena, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtNazivSkole, ComboBox cmbGrupa)
        {
            if (dgvClanoviKluba.CurrentRow == null)
            {
                return;
            }

            clanKluba = (ClanKluba)dgvClanoviKluba.CurrentRow.DataBoundItem;
            txtImePrezimeIzmena.Text = clanKluba.ImePrezime;
            dtpDatumRodjenja.Value = clanKluba.DatumRodjenja;
            dtpDatumUpisa.Value = clanKluba.DatumUpisa;
            txtNazivSkole.Text = clanKluba.NazivSkole;
            cmbGrupa.DataSource = Communication.Communication.Instance.VratiGrupe();
        }

        internal void SacuvajIzmene(TextBox txtImePrezimeIzmena, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtNazivSkole, ComboBox cmbGrupa)
        {
            clanKluba.ImePrezime = txtImePrezimeIzmena.Text;
            clanKluba.DatumRodjenja = dtpDatumRodjenja.Value;
            clanKluba.DatumUpisa = dtpDatumUpisa.Value;
            clanKluba.NazivSkole = txtNazivSkole.Text;
            clanKluba.GrupaZaTreniranje = (GrupaZaTreniranje)cmbGrupa.SelectedItem;

            Communication.Communication.Instance.SacuvajIzmeneClana(clanKluba);
            MessageBox.Show("Izmene za clana su uspesno sacuvane");
        }
    }
}
