using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class UnosPrisustvaController
    {
        BindingList<Prisustvo> prisustva = new BindingList<Prisustvo>();

        internal void PretraziTreninge(DateTimePicker dtpDatumTreninga, DataGridView dgvTreninzi, TextBox txtNazivGrupe, CheckBox cbDatum, CheckBox cbNaziv)
        {
            if (!cbNaziv.Checked && !cbDatum.Checked)
            {
                MessageBox.Show("Niste cekirali ni jedan kriterijum pretrage");
                return;
            }

            if (cbNaziv.Checked && !UserControlHelpers.EmptyFieldValidation(txtNazivGrupe))
            {
                MessageBox.Show("Niste uneli naziv grupe");
                return;
            }

            Trening trening = new Trening();

            if (cbNaziv.Checked && cbDatum.Checked)
            {
                trening.GCondition = $"T.DatumTreninga='{dtpDatumTreninga.Value.Date}' and GT.NazivGrupe LIKE '{txtNazivGrupe.Text}%'";
            }

            if (cbNaziv.Checked && !cbDatum.Checked)
            {
                trening.GCondition = $"GT.NazivGrupe LIKE '{txtNazivGrupe.Text}%'";
            }

            if (!cbNaziv.Checked && cbDatum.Checked)
            {
                trening.GCondition = $"T.DatumTreninga='{dtpDatumTreninga.Value.Date}'";
            }
            

            List<Trening> listaTreninga = Communication.Communication.Instance.PretraziTreninge(trening);

            if (listaTreninga == null || listaTreninga.Count == 0)
            {
                MessageBox.Show("Ne postoji ni jedan trening koji odgovara ovom kriterijumu");
            }
            else
            {
                MessageBox.Show("Prikaz treninga");
                dgvTreninzi.DataSource = listaTreninga;
            }
        }

        internal void PrikaziClanove(DataGridView dgvTreninzi, DataGridView dgvClanovi, Button btnSacuvaj)
        {
            if (dgvTreninzi.CurrentRow == null)
            {
                MessageBox.Show("Niste selektovali trening");
                return;
            }
            DataGridViewRow selectedRow = dgvTreninzi.SelectedCells[0].OwningRow;
            Trening t = (Trening)selectedRow.DataBoundItem;

            if (t.GrupaZaTreniranje.Trener.TrenerId != MainCoordinator.Instance.Trener.TrenerId)
            {
                MessageBox.Show("Ne mozete uneti prisustva za treninge koji ne pripadaju vasoj grupi");
                return;

            }

            List<Prisustvo> vecPostoje = Communication.Communication.Instance.VratiPrisustva(new Prisustvo { Trening = t });

            if(vecPostoje == null || vecPostoje.Count == 0)
            {
                ClanKluba clanKluba = new ClanKluba
                {
                    GCondition = $"GT.GrupaID = {t.GrupaZaTreniranje.GrupaId} and CK.DatumUpisa < '{t.DatumTreninga}'"
                };

                List<ClanKluba> listaClanova = Communication.Communication.Instance.PretreziClana(clanKluba);

                if (listaClanova.Count == 0)
                {
                    MessageBox.Show("Ne postoji ni jedan clan kluba koji odgovara zadatoj vrednosti!");
                }
                else
                {
                    MessageBox.Show("Prikaz clanova kluba");
                }

                prisustva.Clear();

                foreach (ClanKluba clan in listaClanova)
                {
                    prisustva.Add(new Prisustvo
                    {
                        ClanKluba = clan,
                        Trening = t,
                        RazlogOdsustva = "",
                        Prisutan = false
                    });
                }

                dgvClanovi.DataSource = prisustva;
            }
            else
            {
                MessageBox.Show("Prisustva za ovaj trening su vec unesena");
                dgvClanovi.DataSource = vecPostoje;
                dgvClanovi.ReadOnly = true;
                dgvClanovi.Enabled = false;
                btnSacuvaj.Enabled = false;
            }

           

        }

        internal void SacuvajPrisustva(DataGridView dgvClanovi)
        {
            if (prisustva == null || prisustva.Count() == 0)
            {
                MessageBox.Show("Niste uneli prisustva");
                return;
            }
            
            foreach (Prisustvo p in prisustva)
            {
                if(p.Prisutan == false && p.RazlogOdsustva == "")
                {
                    MessageBox.Show("Morate navesti razlog odsustva za clanove koji nisu prisutni na treningu");
                    return;
                }
            }
            try
            {
                Communication.Communication.Instance.SacuvajPrisustva(prisustva);
                MessageBox.Show("Prisustva su uspesno sacuvana!");
                prisustva.Clear();
                

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
