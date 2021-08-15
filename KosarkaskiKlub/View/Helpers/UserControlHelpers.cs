using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Helpers
{
    public static class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool DateValidation(TextBox txt)
        {
            if(string.IsNullOrWhiteSpace(txt.Text) ||
                !DateTime.TryParseExact(txt.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        internal static bool DoubleValidation(TextBox txtIznos)
        {
            if(!double.TryParse(txtIznos.Text, out double _))
            {
                txtIznos.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txtIznos.BackColor = Color.White;
                return true;
            }
        }

        public static bool IntValidation(TextBox txt)
        {
            if(!int.TryParse(txt.Text, out int _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
    }
}
