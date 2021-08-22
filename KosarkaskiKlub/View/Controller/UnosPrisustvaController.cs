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
using View.Helpers;

namespace View.Controller
{
    public class UnosPrisustvaController
    {
        BindingList<Prisustvo> prisustva = new BindingList<Prisustvo>();

        internal void PretraziTreninge(DateTimePicker dtpDatumTreninga, DataGridView dgvTreninzi)
        {
            Trening trening = new Trening
            {
                GCondition = $"DatumTreninga='{dtpDatumTreninga.Value.Date}'"
            };

            List<Trening> listaTreninga = Communication.Communication.Instance.PretraziTreninge(trening);

            if (listaTreninga.Count == 0)
            {
                MessageBox.Show("Ne postoji ni jedan trening koji odgovara ovom kriterijumu");
            }
            else
            {
                dgvTreninzi.DataSource = listaTreninga;
                MessageBox.Show("Prikaz treninga");
            }
        }

        internal void PrikaziClanove(DataGridView dgvTreninzi, DataGridView dgvClanovi)
        {
            if (dgvTreninzi.CurrentRow == null)
            {
                return;
            }
            Trening t = (Trening)dgvTreninzi.CurrentRow.DataBoundItem;

            ClanKluba clanKluba = new ClanKluba
            {
                GCondition = $"GT.GrupaID = {t.GrupaZaTreniranje.GrupaId}"
            };

            List<ClanKluba> listaClanova = Communication.Communication.Instance.PretreziClana(clanKluba);

            if (listaClanova.Count == 0)
            {
                MessageBox.Show("Ne postoji ni jedan clan kluba koji odgovara zadatoj vrednosti!");
            }
            else
            {
                //dgvClanovi.DataSource = listaClanova;
                MessageBox.Show("Prikaz clanova kluba");
            }

            prisustva.Clear();

            foreach(ClanKluba clan in listaClanova)
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

        internal void SacuvajPrisustva(DataGridView dgvClanovi)
        {
            foreach(Prisustvo p in prisustva)
            {
                if(p.Prisutan == false && p.RazlogOdsustva == "")
                {
                    MessageBox.Show("Morate navesti razlog odsustva za clanove koji nisu prisutni na treningu");
                    return;
                }
            }
            Communication.Communication.Instance.SacuvajPrisustva(prisustva);
            MessageBox.Show("Prisustva su uspesno sacuvana!");
        }
    }
}
