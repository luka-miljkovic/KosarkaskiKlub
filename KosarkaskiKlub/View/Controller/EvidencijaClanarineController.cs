using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class EvidencijaClanarineController
    {
        internal void PretraziClana(TextBox txtImePrezime, DataGridView dgvClanKluba)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime))
            {
                MessageBox.Show("Niste popunili polje za pretrazivanje!");
                return;
            }

            ClanKluba clanKluba = new ClanKluba
            {
                GCondition = $"CK.ImePrezime LIKE '{txtImePrezime.Text}%'"
            };

            List<ClanKluba> listaClanova = Communication.Communication.Instance.PretreziClana(clanKluba);

            if (listaClanova.Count == 0)
            {
                MessageBox.Show("Ne postoji ni jedan clan kluba koji odgovara zadatoj vrednosti!");
            }
            else
            {
                dgvClanKluba.DataSource = listaClanova;
                MessageBox.Show("Prikaz clanova kluba");
            }
        }

        internal void SacuvajUplatu(DateTimePicker dtpDatumUplate, TextBox txtMesec, TextBox txtGodina, TextBox txtIznos, DataGridView dgvClanKluba)
        {
            if(!UserControlHelpers.IntValidation(txtMesec) |
                !UserControlHelpers.IntValidation(txtGodina) |
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
                DatumIsplate = dtpDatumUplate.Value.Date,
                Iznos = Convert.ToDouble(txtIznos.Text)
            };

            Communication.Communication.Instance.EvidentirajPlacanjeClanarine(clanarina);
            MessageBox.Show("Clanarina je uspesno evidentirana");
        }

        internal void UcitajClana(DataGridView dgvClanoviKluba, TextBox txtIdClanaKluba, TextBox txtImePrezime)
        {
            try
            {
                DataGridViewRow selectedRow = dgvClanoviKluba.SelectedCells[0].OwningRow;

                ClanKluba clanKluba = new ClanKluba
                {
                    GCondition = $"ClanKlubaID={((ClanKluba)selectedRow.DataBoundItem).ClanKlubaId}"
                };
                clanKluba = Communication.Communication.Instance.UcitajClanaKluba(clanKluba);
                if (clanKluba == null)
                {
                    MessageBox.Show("Nije moguce ucitati clana kluba");
                }
                else
                {
                    txtIdClanaKluba.Text = Convert.ToString(clanKluba.ClanKlubaId);
                    txtImePrezime.Text = clanKluba.ImePrezime;
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
