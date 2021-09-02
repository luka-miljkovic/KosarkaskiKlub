using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class IzmenaClanaKlubaController
    {
        internal void PretraziClana(TextBox txtImePrezime, DataGridView dgvClanoviKluba, TextBox txtImePrezimeIzmena, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtNazivSkole, ComboBox cmbGrupe)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime))
            {
                MessageBox.Show("Niste popunili polje za pretrazivanje!");
                return;
            }

            try
            {
                dgvClanoviKluba.Refresh();
                ClanKluba clanKluba = new ClanKluba
                {
                    GCondition = $"CK.ImePrezime LIKE '{txtImePrezime.Text}%'"
                };

                List<ClanKluba> listaClanova = new List<ClanKluba>();

                listaClanova = Communication.Communication.Instance.PretreziClana(clanKluba);


                if (listaClanova == null || listaClanova.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedan clan kluba koji odgovara zadatoj vrednosti!");
                }
                else
                {
                    MessageBox.Show("Prikaz clanova kluba");
                    dgvClanoviKluba.DataSource = new BindingList<ClanKluba>(listaClanova);
                    dgvClanoviKluba.Columns["ClanKlubaId"].Visible = false;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SacuvajIzmene(TextBox txtId, TextBox txtImePrezimeIzmena, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtNazivSkole, ComboBox cmbGrupa, DataGridView dgvClanoviKluba, TextBox txtImePrezime)
        {
            ClanKluba clanKluba = new ClanKluba();

            if(dtpDatumRodjenja.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Datum rodjenja ne sme biti veci od danasnjeg dana");
                return;
            }

            if (!UserControlHelpers.EmptyFieldValidation(txtId))
            {
                txtId.BackColor = Color.White;
                MessageBox.Show("Niste izabrali clana kluba");
                return;
            }

            clanKluba.ClanKlubaId = Convert.ToInt32(txtId.Text);
            clanKluba.ImePrezime = txtImePrezimeIzmena.Text;
            clanKluba.DatumRodjenja = dtpDatumRodjenja.Value;
            clanKluba.DatumUpisa = dtpDatumUpisa.Value;
            clanKluba.NazivSkole = txtNazivSkole.Text;
            clanKluba.GrupaZaTreniranje = (GrupaZaTreniranje)cmbGrupa.SelectedItem;

            Communication.Communication.Instance.SacuvajIzmeneClana(clanKluba);
            MessageBox.Show("Izmene za clana su uspesno sacuvane");

            txtId.Clear();
            txtImePrezimeIzmena.Text = "";
            dtpDatumRodjenja.Value = DateTime.Now;
            dtpDatumUpisa.Value = DateTime.Now;
            txtNazivSkole.Text = "";
            cmbGrupa.SelectedIndex = -1;
            txtImePrezime.Text = "";
        }

        internal void UcitajGrupe(ComboBox cmbGrupa)
        {
            try
            {
                cmbGrupa.DataSource = Communication.Communication.Instance.VratiGrupe();
                cmbGrupa.SelectedIndex = -1;
                cmbGrupa.Text = "Izaberite grupu za treniranje";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void UcitajClanaKluba(DataGridView dgvClanoviKluba, TextBox txtId, TextBox txtImePrezimeIzmena, DateTimePicker dtpDatumRodjenja, DateTimePicker dtpDatumUpisa, TextBox txtNazivSkole, ComboBox cmbGrupa, Button btnSacuvaj)
        {
            try
            {
                DataGridViewRow selectedRow = dgvClanoviKluba.SelectedCells[0].OwningRow;
                ClanKluba clanKluba = new ClanKluba
                {
                    GCondition = $"ClanKlubaID={((ClanKluba)selectedRow.DataBoundItem).ClanKlubaId}"
                };
                clanKluba = Communication.Communication.Instance.UcitajClanaKluba(clanKluba);
                if(clanKluba == null)
                {
                    MessageBox.Show("Nije moguce ucitati clana kluba");
                }
                else
                {
                    txtId.Text = Convert.ToString(clanKluba.ClanKlubaId);
                    txtImePrezimeIzmena.Text = clanKluba.ImePrezime;
                    dtpDatumRodjenja.Value = clanKluba.DatumRodjenja;
                    dtpDatumUpisa.Value = clanKluba.DatumUpisa;
                    txtNazivSkole.Text = clanKluba.NazivSkole;
                    cmbGrupa.SelectedIndex = VratiIndexGrupe(clanKluba.GrupaZaTreniranje);

                   if(clanKluba.GrupaZaTreniranje.Trener.TrenerId != MainCoordinator.Instance.Trener.TrenerId)
                    {
                        MessageBox.Show("Ne mozete vrsiti izmene za clana koji nije u vasoj grupi");
                        btnSacuvaj.Enabled = false;
                        txtImePrezimeIzmena.Enabled = false;
                        dtpDatumRodjenja.Enabled = false;
                        dtpDatumUpisa.Enabled = false;
                        txtNazivSkole.Enabled = false;
                        cmbGrupa.Enabled = false;

                    }
                }
            }
            catch (SystemOperationException ex )
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        private int VratiIndexGrupe(GrupaZaTreniranje grupaZaTreniranje)
        {
            List<GrupaZaTreniranje> lista = Communication.Communication.Instance.VratiGrupe();
            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].GrupaId == grupaZaTreniranje.GrupaId)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
