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

namespace View.Controller
{
    public class GrupaZaTreningController
    {
        BindingList<Trening> treninzi = new BindingList<Trening>();
        

        internal void UcitajSale(UCGrupaZaTreniranje uCGrupaZaTreniranje)
        {
            //uCGrupaZaTreniranje.com
        }

        internal void DodajTrening(TextBox txtRBTreninga, ComboBox cmbDanTreninga, TextBox txtVremeOd, TextBox txtVremeDo, ComboBox cmbSale, DataGridView dgvTreninzi, UCGrupaZaTreniranje uCGrupaZaTreniranje)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtVremeOd) |
                !UserControlHelpers.EmptyFieldValidation(txtVremeDo) |
                cmbDanTreninga.SelectedItem == null | 
                cmbSale.SelectedItem == null)
            {
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
                    danTreninga = "Monday";
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
                //TreningId = int.Parse(txtRBTreninga.Text),
                DanTreninga = danTreninga,
                VremeOd = (string)txtVremeOd.Text,
                VremeDo = (string)txtVremeDo.Text,
                SalaZaTrening = (SalaZaTrening)cmbSale.SelectedItem
            });
            dgvTreninzi.DataSource = uCGrupaZaTreniranje.listaTreninga;
        }

        internal void SacuvajNovuGurpu(TextBox txtNazivGrupe, ComboBox cmbUzrast, TextBox txtDatumOd, TextBox txtDatumDo, UCGrupaZaTreniranje uCGrupaZaTreniranje)
        {
            if(!UserControlHelpers.EmptyFieldValidation(txtNazivGrupe)|
                cmbUzrast.SelectedItem == null |
                !UserControlHelpers.DateValidation(txtDatumOd) |
                !UserControlHelpers.DateValidation(txtDatumDo) |
                uCGrupaZaTreniranje.listaTreninga.Count() == 0)
            {
                return;
            }
            GrupaZaTreniranje grupa = new GrupaZaTreniranje
            {
                NazivGrupe = txtNazivGrupe.Text,
                DatumFormiranja = DateTime.Now,
                UzrastGrupe = (string)cmbUzrast.SelectedItem,
                DatumOd = DateTime.Parse(txtDatumOd.Text),
                DatumDo = DateTime.Parse(txtDatumDo.Text),
                Treninzi = uCGrupaZaTreniranje.listaTreninga,
                Trener = MainCoordinator.Instance.Trener
            };
            Communication.Communication.Instance.SacuvajGrupu(grupa);
            MessageBox.Show("Grupa je uspesno sacuvana");

            
        }

        internal void ObrisiTrening(DataGridView dgvTreninzi, UCGrupaZaTreniranje uCGrupaZaTreniranje)
        {
            if(dgvTreninzi.CurrentRow != null)
            {
                uCGrupaZaTreniranje.listaTreninga.Remove((Trening)dgvTreninzi.CurrentRow.DataBoundItem);
            }
            
        }
    }
}
