using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Regex proveriDouble = new Regex(@"^[0-9]*[.][0-9]*$");

            if (!proveriDouble.IsMatch(txtIznos.Text))
            {
                txtIznos.Text = "Morate uneti decimalni broj";
                txtIznos.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txtIznos.BackColor = Color.White;
                return true;
            }
            //if (!double.TryParse(txtIznos.Text, out double _))
            //{
            //    txtIznos.Text = "Morate uneti decimalni broj";
            //    txtIznos.BackColor = Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    txtIznos.BackColor = Color.White;
            //    return true;
            //}

            
        }

        public static bool ComboBoxValidation(ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                cmb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cmb.BackColor = Color.White;
                return true;
            }
        }

        public static bool IntValidation(TextBox txt)
        {
            if(!int.TryParse(txt.Text, out int _))
            {
                txt.Text = "Morate uneti broj";
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool TimeValidation(TextBox txt)
        {
            Regex proveriVreme = new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");

            if (!proveriVreme.IsMatch(txt.Text))
            {
                txt.Text = "Zahtevan format: hh:mm";
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
