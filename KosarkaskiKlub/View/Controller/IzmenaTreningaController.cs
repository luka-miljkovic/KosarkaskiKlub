using Domen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class IzmenaTreningaController
    {
        Trening trening = null;
        internal void Pretrazitreninge(DateTimePicker dtpDatumTreninga, TextBox txtGrupaPretraga, DataGridView dgvTreninzi, CheckBox cbDatum, CheckBox cbNaziv)
        {
            if(!cbNaziv.Checked && !cbDatum.Checked)
            {
                MessageBox.Show("Niste cekirali ni jedan kriterijum pretrage");
                return; 
            }

            if(cbNaziv.Checked && !UserControlHelpers.EmptyFieldValidation(txtGrupaPretraga))
            {
                MessageBox.Show("Niste uneli naziv grupe");
                return;
            }

            Trening trening = new Trening();

            if(cbNaziv.Checked && cbDatum.Checked)
            {
                trening.GCondition = $"T.DatumTreninga='{dtpDatumTreninga.Value.Date}' and GT.NazivGrupe LIKE '{txtGrupaPretraga.Text}%'";
            }

            if (cbNaziv.Checked && !cbDatum.Checked)
            {
                trening.GCondition = $"GT.NazivGrupe LIKE '{txtGrupaPretraga.Text}%'";
            }

            if (!cbNaziv.Checked && cbDatum.Checked)
            {
                trening.GCondition = $"T.DatumTreninga='{dtpDatumTreninga.Value.Date}'";
            }

            List<Trening> listaTreninga = Communication.Communication.Instance.PretraziTreninge(trening);
            
            if(listaTreninga.Count == 0)
            {
                MessageBox.Show("Ne postoji ni jedan trening koji odgovara ovom kriterijumu");
            }
            else
            {
                dgvTreninzi.DataSource = listaTreninga;
                dgvTreninzi.Columns["TreningId"].Visible = false;
                MessageBox.Show("Prikaz treninga");
            }
        }

        internal void UcitajTrening(DataGridView dgvTreninzi,TextBox txttreningId, TextBox txtGrupa, TextBox txtVremeOd, TextBox txtVremeDo, DateTimePicker dtpDatumTreninga, TextBox txtDanTreninga, ComboBox cmbSale, Button btnSacuvajIzmene)
        {
            try
            {
                DataGridViewRow selectedRow = dgvTreninzi.SelectedCells[0].OwningRow;
                trening = new Trening
                {
                    GCondition = $"TreningID={((Trening)selectedRow.DataBoundItem).TreningId} " +
                    $"and GrupaZaTreniranjeID={((Trening)selectedRow.DataBoundItem).GrupaZaTreniranje.GrupaId}"
                };

                
                trening = Communication.Communication.Instance.UcitajTrening(trening);
                
                if(trening == null)
                {
                    MessageBox.Show("Trening se ne moze ucitati!");
                }
                else
                {
                    txttreningId.Text = Convert.ToString(trening.TreningId);
                    txtGrupa.Text = trening.GrupaZaTreniranje.ToString();
                    txtVremeOd.Text = trening.VremeOd;
                    txtVremeDo.Text = trening.VremeDo;
                    dtpDatumTreninga.Value = trening.DatumTreninga;
                    string dan = Convert.ToString(trening.DatumTreninga.DayOfWeek);
                    txtDanTreninga.Text = dan;
                    cmbSale.SelectedIndex = VratiIndexSale(trening.SalaZaTrening);

                    if(trening.GrupaZaTreniranje.Trener.TrenerId != MainCoordinator.Instance.Trener.TrenerId)
                    {
                        MessageBox.Show("Ne mozete vrsiti izmene za treninge koji ne pripadaju vasoj grupi");
                        btnSacuvajIzmene.Enabled = false;
                        txtVremeOd.Enabled = false;
                        txtVremeDo.Enabled = false;
                        dtpDatumTreninga.Enabled = false;
                        cmbSale.Enabled = false;

                    }
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SacuvajIzmene(TextBox txtGrupa, TextBox txtVremeOd, TextBox txtVremeDo, DateTimePicker dtpDatumTreninga, TextBox txtDanTreninga, ComboBox cmbSale)
        {
            if( !UserControlHelpers.EmptyFieldValidation(txtVremeOd) | 
                !UserControlHelpers.EmptyFieldValidation(txtVremeDo) |
                !UserControlHelpers.TimeValidation(txtVremeOd) |
                !UserControlHelpers.TimeValidation(txtVremeDo) |
                !UserControlHelpers.ComboBoxValidation(cmbSale))
            {
                MessageBox.Show("Niste lepo popunili sva polja");
                return;
            }

            string[] vremeOd = txtVremeOd.Text.Split(':');
            string[] vremeDo = txtVremeDo.Text.Split(':');
            int satOd = int.Parse(vremeOd[0]);
            int satDo = int.Parse(vremeDo[0]);
            int minOd = int.Parse(vremeOd[1]);
            int minDo = int.Parse(vremeDo[1]);

            if (satOd > satDo)
            {
                MessageBox.Show("Vreme pocetka treninga mora biti manje od vremena zavrsetka treninga");
                txtVremeOd.BackColor = Color.LightCoral;
                txtVremeDo.BackColor = Color.LightCoral;
                return;
            }
            if (satOd == satDo && minOd >= minDo)
            {
                MessageBox.Show("Vreme pocetka treninga mora biti manje od vremena zavrsetka treninga");
                txtVremeOd.BackColor = Color.LightCoral;
                txtVremeDo.BackColor = Color.LightCoral;
                return;
            }

            if (trening == null)
            {
                MessageBox.Show("Niste odabrali trening koji zelite da izmenite");
                return;
            }

            try
            {
                trening.VremeOd = (string)txtVremeOd.Text;
                trening.VremeDo = (string)txtVremeDo.Text;
                trening.DatumTreninga = dtpDatumTreninga.Value.Date;
                trening.DanTreninga = txtDanTreninga.Text;
                trening.SalaZaTrening = (SalaZaTrening)cmbSale.SelectedItem;
                
                Communication.Communication.Instance.SacuvajIZmeneTreninga(trening);
                MessageBox.Show("Izmene su uspesno sacuvane!");
                txtGrupa.Text = "";
                txtVremeOd.Text = "";
                txtVremeDo.Text = "";
                dtpDatumTreninga.Value = DateTime.Now;
                cmbSale.SelectedIndex = -1;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void PostaviDanTreninga(DateTimePicker dtpDatumTreninga, TextBox txtDanTreninga)
        {
            txtDanTreninga.Text = Convert.ToString(dtpDatumTreninga.Value.DayOfWeek);
        }

        internal void UcitajSale(ComboBox cmbSale)
        {
            try
            {
                cmbSale.DataSource = Communication.Communication.Instance.VratiSale();
                cmbSale.SelectedIndex = -1;
                cmbSale.Text = "Izaberite salu";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int VratiIndexSale(SalaZaTrening sala)
        {
            try
            {
                List<SalaZaTrening> lista = Communication.Communication.Instance.VratiSale();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].SalaZaTreningId == sala.SalaZaTreningId)
                    {
                        return i;
                    }
                }
                return -1;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
