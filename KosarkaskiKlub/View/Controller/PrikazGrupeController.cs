using Domen;
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
    public class PrikazGrupeController
    {
        internal void PretraziTreninge(TextBox txtNaziv, DataGridView dgvGrupe)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtNaziv))
            {
                MessageBox.Show("Niste lepo uneli kriterijum pretrage");
                return;
            }

            try
            {
                GrupaZaTreniranje grupa = new GrupaZaTreniranje
                {
                    GCondition = $"NazivGrupe LIKE'{txtNaziv.Text}%'"
                };
                List<GrupaZaTreniranje> listaGrupa = Communication.Communication.Instance.PretraziGrupe(grupa);
                dgvGrupe.DataSource = listaGrupa;
                dgvGrupe.Columns["GrupaId"].Visible = false;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void UcitajGrupu(DataGridView dgvGrupe, DataGridView dgvClanovi, DataGridView dgvTreninzi, TextBox txtIdGrupe, TextBox txtNaziv, TextBox txtDatumFormiranja, TextBox txtUzrast, TextBox txtTrener)
        {
            try
            {
                DataGridViewRow selectedRow = dgvGrupe.SelectedCells[0].OwningRow;

                GrupaZaTreniranje grupa = new GrupaZaTreniranje
                {
                    GCondition = $"GrupaID={((GrupaZaTreniranje)selectedRow.DataBoundItem).GrupaId}"
                };

                grupa = Communication.Communication.Instance.UcitajGrupu(grupa);
                if (grupa == null)
                {
                    MessageBox.Show("Nije moguce ucitati grupu");
                    return;
                }
                else
                {
                    txtIdGrupe.Text = Convert.ToString(grupa.GrupaId);
                    txtNaziv.Text = grupa.NazivGrupe;
                    txtDatumFormiranja.Text = $"{Convert.ToString(grupa.DatumFormiranja.Day)}.{Convert.ToString(grupa.DatumFormiranja.Month)}.{Convert.ToString(grupa.DatumFormiranja.Year)}.";
                    txtUzrast.Text = grupa.UzrastGrupe;
                    txtTrener.Text = grupa.Trener.ImePrezime;

                    ClanKluba clanKluba = new ClanKluba
                    {
                        GCondition = $"GrupaZaTreniranjeID = {grupa.GrupaId}"
                    };
                    List<ClanKluba> clanovi = Communication.Communication.Instance.PretreziClana(clanKluba);
                    dgvClanovi.DataSource = clanovi;
                    dgvClanovi.Columns["ClanKlubaId"].Visible = false;
                    dgvClanovi.Columns["GrupaZaTreniranje"].Visible = false;

                    Trening trening = new Trening
                    {
                        GCondition = $"GrupaZaTreniranjeID = {grupa.GrupaId}"
                    };
                    List<Trening> treninzi = Communication.Communication.Instance.PretraziTreninge(trening);
                    dgvTreninzi.DataSource = treninzi;
                    dgvTreninzi.Columns["TreningId"].Visible = false;
                    dgvTreninzi.Columns["GrupaZaTReniranje"].Visible = false;

                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
