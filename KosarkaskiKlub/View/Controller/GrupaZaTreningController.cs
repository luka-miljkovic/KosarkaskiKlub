using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;
using System.Windows.Forms;
using View.Helpers;
using View.Communication;
using View.Exceptions;
using System.Drawing;

namespace View.Controller
{
    public class GrupaZaTreningController
    {
        BindingList<Trening> treninzi = new BindingList<Trening>();
        

        internal void UcitajSale(ComboBox cmbSale)
        {
            try
            {
                cmbSale.DataSource = Communication.Communication.Instance.VratiSale();
                cmbSale.SelectedIndex = -1;
                cmbSale.Text = "Izaberite Salu";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void DodajTrening(ComboBox cmbDanTreninga, TextBox txtVremeOd, TextBox txtVremeDo, ComboBox cmbSale, DataGridView dgvTreninzi, UCGrupaZaTreniranje uCGrupaZaTreniranje)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtVremeOd) |
                !UserControlHelpers.EmptyFieldValidation(txtVremeDo) |
                !UserControlHelpers.TimeValidation(txtVremeOd) |
                !UserControlHelpers.TimeValidation(txtVremeDo) |
                !UserControlHelpers.ComboBoxValidation(cmbDanTreninga) |
                !UserControlHelpers.ComboBoxValidation(cmbSale))
            {
                MessageBox.Show("Niste uneli sva polja korektno");
                return;
            }

            string[] vremeOd = txtVremeOd.Text.Split(':');
            string[] vremeDo = txtVremeDo.Text.Split(':');
            int satOd = int.Parse(vremeOd[0]);
            int satDo = int.Parse(vremeDo[0]);
            int minOd = int.Parse(vremeOd[1]);
            int minDo = int.Parse(vremeDo[1]);

            if(satOd > satDo)
            {
                MessageBox.Show("Vreme pocetka treninga mora biti manje od vremena zavrsetka treninga");
                txtVremeOd.BackColor = Color.LightCoral;
                txtVremeDo.BackColor = Color.LightCoral;
                return;
            }
            if(satOd == satDo && minOd >= minDo)
            {
                MessageBox.Show("Vreme pocetka treninga mora biti manje od vremena zavrsetka treninga");
                txtVremeOd.BackColor = Color.LightCoral;
                txtVremeDo.BackColor = Color.LightCoral;
                return;
            }

            String danTreninga = "";
            switch (cmbDanTreninga.Text)
            {
                case "ponedeljak":
                    danTreninga = "Monday";
                    break;
                case "utorak":
                    danTreninga = "Tuesday";
                    break;
                case "sreda":
                    danTreninga = "Wednesday";
                    break;
                case "cetvrtak":
                    danTreninga = "Thursday";
                    break;
                case "petak":
                    danTreninga = "Friday";
                    break;
                case "subota":
                    danTreninga = "Saturday";
                    break;
                case "Nedelja":
                    danTreninga = "Sunday";
                    break;
                default:
                    break;
            }
            uCGrupaZaTreniranje.listaTreninga.Add(new Trening
            {
                DanTreninga = danTreninga,
                VremeOd = (string)txtVremeOd.Text,
                VremeDo = (string)txtVremeDo.Text,
                SalaZaTrening = (SalaZaTrening)cmbSale.SelectedItem
            });
            dgvTreninzi.DataSource = uCGrupaZaTreniranje.listaTreninga;
            dgvTreninzi.Columns["GrupaZaTreniranje"].Visible = false;
            dgvTreninzi.Columns["DatumTreninga"].Visible = false;
            dgvTreninzi.Columns["TreningId"].Visible = false;

            cmbDanTreninga.SelectedIndex = -1;
            txtVremeOd.Text = "";
            txtVremeDo.Text = "";
            cmbSale.SelectedIndex = -1;
            
        }

        internal void ObrisiTrening(DataGridView dgvTreninzi, UCGrupaZaTreniranje uCGrupaZaTreniranje, Button btnObrisiTrening)
        {
            if (dgvTreninzi.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvTreninzi.SelectedCells[0].OwningRow;

                uCGrupaZaTreniranje.listaTreninga.Remove((Trening)selectedRow.DataBoundItem);
            }
            //if (uCGrupaZaTreniranje.listaTreninga == null || uCGrupaZaTreniranje.listaTreninga.Count == 0)
            //{
            //    btnObrisiTrening.Enabled = false;
            //}
        }

        internal void SacuvajNovuGurpu(TextBox txtNazivGrupe, ComboBox cmbUzrast, DateTimePicker dtpDatumOd, DateTimePicker dtpDatumDo, UCGrupaZaTreniranje uCGrupaZaTreniranje)
        {

            if (!UserControlHelpers.EmptyFieldValidation(txtNazivGrupe)|
               !UserControlHelpers.ComboBoxValidation(cmbUzrast) |
                uCGrupaZaTreniranje.listaTreninga.Count() == 0)
            {
                MessageBox.Show("Niste lepo popunili sva polja!");
                return;
            }

            if(dtpDatumOd.Value.Date >= dtpDatumDo.Value.Date)
            {
                MessageBox.Show("Datum od kada pocinju treninzi mora biti manji od datuma kada se treninzi zavrsavaju!");
                return;
            }

            try
            {
                GrupaZaTreniranje grupa = new GrupaZaTreniranje
                {
                    NazivGrupe = txtNazivGrupe.Text,
                    DatumFormiranja = DateTime.Now,
                    UzrastGrupe = (string)cmbUzrast.SelectedItem,
                    DatumOd = dtpDatumOd.Value,
                    DatumDo = dtpDatumDo.Value,
                    Treninzi = uCGrupaZaTreniranje.listaTreninga,
                    Trener = MainCoordinator.Instance.Trener
                };
                Communication.Communication.Instance.SacuvajGrupu(grupa);
                MessageBox.Show("Nova grupa za treniranje je uspesno sacuvana");
                txtNazivGrupe.Text = "";
                dtpDatumOd.Value = DateTime.Now;
                dtpDatumDo.Value = DateTime.Now;
                cmbUzrast.SelectedIndex = -1;
                uCGrupaZaTreniranje.listaTreninga.Clear();
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Greska prilikom unosa nove grupe za treniranje");
            }

            
        }

        
    }
}
