using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Helpers;

namespace View.Controller
{
    public class EvidencijaClanarineController
    {
        internal void PretraziClana(TextBox txtImePrezime, DataGridView dgvClanKluba)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImePrezime))
            {
                return;
            }

            dgvClanKluba.DataSource = Communication.Communication.Instance.PretreziClana(txtImePrezime.Text);
        }
    }
}
