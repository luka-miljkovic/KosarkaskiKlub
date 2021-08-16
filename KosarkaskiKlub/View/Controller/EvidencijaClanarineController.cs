using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Helpers;

namespace View.Controller
{
    public class EvidencijaClanarineController
    {
        internal void PretraziClana(TextBox txtImePrezime, DataGridView dgvClanKluba)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime))
            {
                return;
            }

            dgvClanKluba.DataSource = Communication.Communication.Instance.PretreziClana($"ImePrezime = '{txtImePrezime.Text}'");
        }

        internal void SacuvajUplatu(TextBox txtDatumUplate, TextBox txtMesec, TextBox txtGodina, TextBox txtIznos, DataGridView dgvClanKluba)
        {
            if(!UserControlHelpers.IntValidation(txtMesec) |
                !UserControlHelpers.IntValidation(txtGodina) |
                !UserControlHelpers.DateValidation(txtDatumUplate) |
                !UserControlHelpers.DoubleValidation(txtIznos)/* |
                dgvClanKluba.CurrentRow != null*/)
            {
                return;
            }

            Clanarina clanarina = new Clanarina
            {
                ClanKluba = (ClanKluba)dgvClanKluba.CurrentRow.DataBoundItem,
                Mesec = Convert.ToInt32(txtMesec.Text),
                Godina = Convert.ToInt32(txtGodina.Text),
                DatumIsplate = Convert.ToDateTime(txtDatumUplate.Text),
                Iznos = Convert.ToDouble(txtIznos.Text)
            };

            Communication.Communication.Instance.EvidentirajPlacanjeClanarine(clanarina);
            MessageBox.Show("Clanarina je uspesno evidentirana");
        }
    }
}
