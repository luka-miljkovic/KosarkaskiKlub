using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        internal void PretraziTreninge(TextBox txtDatumTreninga, DataGridView dgvTreninzi)
        {
            if (!UserControlHelpers.DateValidation(txtDatumTreninga))
            {
                return;
            }

            dgvTreninzi.DataSource = Communication.Communication.Instance.PretraziTreninge(txtDatumTreninga.Text);
        }

        internal void PrikaziClanove(DataGridView dgvTreninzi, DataGridView dgvClanovi)
        {
            if (dgvTreninzi.CurrentRow == null)
            {
                return;
            }
            Trening t = (Trening)dgvTreninzi.CurrentRow.DataBoundItem;
            List<ClanKluba> clanovi = Communication.Communication.Instance.PretreziClana($"GT.GrupaID = {t.GrupaZaTreniranje.GrupaId}");

            prisustva.Clear();

            foreach(ClanKluba clan in clanovi)
            {
                prisustva.Add(new Prisustvo
                {
                    ClanKluba = clan,
                    Trening = t,
                    Prisutan = false
                });
            }

            dgvClanovi.DataSource = prisustva;

        }

        internal void SacuvajPrisustva(DataGridView dgvClanovi)
        {
            Communication.Communication.Instance.SacuvajPrisustva(prisustva);
            MessageBox.Show("Prisustva su uspesno sacuvana!");
        }
    }
}
