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
    public class IzmenaTreningaController
    {
        Trening trening = new Trening();
        internal void Pretrazitreninge(DateTimePicker dtpDatumTreninga, DataGridView dgvTreninzi)
        {
            Trening trening = new Trening
            {
                GCondition = $"DatumTreninga='{dtpDatumTreninga.Value.Date}'"
            };

            List<Trening> listaTreninga = Communication.Communication.Instance.PretraziTreninge(trening);
            
            if(listaTreninga.Count == 0)
            {
                MessageBox.Show("Ne postoji ni jedan trening koji odgovara ovom kriterijumu");
            }
            else
            {
                dgvTreninzi.DataSource = listaTreninga;
                MessageBox.Show("Prikaz treninga");
            }
        }

        internal void UcitajTrening(DataGridView dgvTreninzi, TextBox txtGrupa, TextBox txtVremeOd, TextBox txtVremeDo, DateTimePicker dtpDatumTreninga, TextBox txtDanTreninga, ComboBox cmbSale)
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
                    txtGrupa.Text = trening.GrupaZaTreniranje.ToString();
                    txtVremeOd.Text = trening.VremeOd;
                    txtVremeDo.Text = trening.VremeDo;
                    dtpDatumTreninga.Value = trening.DatumTreninga;
                    string dan = Convert.ToString(trening.DatumTreninga.DayOfWeek);
                    txtDanTreninga.Text = dan;
                    cmbSale.SelectedIndex = cmbSale.FindStringExact(trening.SalaZaTrening.ToString());
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
                !UserControlHelpers.ComboBoxValidation(cmbSale))
            {
                MessageBox.Show("Niste lepo popunili sva polja");
                return;
            }

            try
            {
                

                //GrupaZaTreniranje = (GrupaZaTreniranje)cmbGrupe.SelectedItem,
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
                //string dan = Convert.ToString(trening.DatumTreninga.DayOfWeek);
                //txtDanTreninga.Text = dan;
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

        internal void UcitajGrupe(ComboBox cmbGrupe)
        {
            cmbGrupe.DataSource = Communication.Communication.Instance.VratiGrupe();
            cmbGrupe.SelectedIndex = -1;
            cmbGrupe.Text = "Izaberite grupu";
        }

        internal void UcitajSale(ComboBox cmbSale)
        {
            cmbSale.DataSource = Communication.Communication.Instance.VratiSale();
            cmbSale.SelectedIndex = -1;
            cmbSale.Text = "Izaberite salu";
        }
    }
}
