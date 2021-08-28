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

        internal void SacuvajUplatu(DateTimePicker dtpDatumUplate, ComboBox cmbMesec, TextBox txtGodina, TextBox txtIznos, DataGridView dgvClanKluba, DataGridView dgvClanarine)
        {
            if(!UserControlHelpers.ComboBoxValidation(cmbMesec) |
                !UserControlHelpers.IntValidation(txtGodina) |
                !UserControlHelpers.DoubleValidation(txtIznos)/* |
                dgvClanKluba.CurrentRow != null*/)
            {
                return;
            }

            Clanarina clanarina = new Clanarina
            {
                ClanKluba = (ClanKluba)dgvClanKluba.CurrentRow.DataBoundItem,
                Mesec = (string)cmbMesec.SelectedItem,
                Godina = Convert.ToInt32(txtGodina.Text),
                DatumIsplate = dtpDatumUplate.Value.Date,
                Iznos = Double.Parse(txtIznos.Text, System.Globalization.NumberStyles.AllowDecimalPoint)
            };

            clanarina.GCondition = $"ClanKlubaID={clanarina.ClanKluba.ClanKlubaId} and Mesec='{clanarina.Mesec}' and Godina={clanarina.Godina}";

            List<Clanarina> lista = Communication.Communication.Instance.VratiClanarine(clanarina);

            if(lista == null || lista.Count == 0)
            {
                Communication.Communication.Instance.EvidentirajPlacanjeClanarine(clanarina);
                MessageBox.Show("Clanarina je uspesno evidentirana");
            }
            else
            {
                MessageBox.Show("Vec ste uneli clanarinu");
            }

            dtpDatumUplate.Value = DateTime.Now;
            cmbMesec.SelectedIndex = -1;
            txtGodina.Text = "";
            txtIznos.Text = "";
            dgvClanarine.DataSource = null;
        }

        internal void UcitajClana(DataGridView dgvClanoviKluba, DataGridView dgvClanarine, TextBox txtIdClanaKluba, TextBox txtImePrezime, Button btnSacuvajUplatu)
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

                    Clanarina clanarina = new Clanarina
                    {
                        GCondition = $"ClanKlubaID={clanKluba.ClanKlubaId}"
                    };

                    dgvClanarine.DataSource = new List<Clanarina>();
                    List<Clanarina> listaClanarina = Communication.Communication.Instance.VratiClanarine(clanarina);
                    dgvClanarine.Columns["ClanKluba"].Visible = false;
                    dgvClanarine.Columns["ClanarinaId"].Visible = false;
                    dgvClanarine.DataSource = listaClanarina;

                    if (clanKluba.GrupaZaTreniranje.Trener.TrenerId != MainCoordinator.Instance.Trener.TrenerId)
                    {
                        MessageBox.Show("Ne mozete vrsiti izmene za clana koji nije u vasoj grupi");
                        btnSacuvajUplatu.Enabled = false;
  

                    }

                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
