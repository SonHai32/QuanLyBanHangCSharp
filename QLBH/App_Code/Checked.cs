using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QLBH.App_Code
{
    class Checked
    {
        public bool isNull(String val)
        {
            return val == "" || val == null;
        }

        public bool isInteger(String num)
        {
            Regex intRegex = new Regex(@"^\d$");
            return intRegex.IsMatch(num);
        }

        public bool isRealNumber(String num)
        {
            Regex realNumRegex = new Regex(@"(([0-9]*)|([0-9]*\.[0-9]*))$");

            return realNumRegex.IsMatch(num);
        }

        public bool isInRange(int startIndex, int endIndex, String val)
        {
            return val.Length >= startIndex && val.Length <= endIndex;
        }

        public void showFormErrorMessage(TextBox textbox, String message)
        {
            /*textbox.BorderColorIdle = System.Drawing.Color.FromArgb(245, 66, 66);
            textbox.BorderColorHover = System.Drawing.Color.FromArgb(245, 66, 66);
            textbox.BorderColorActive = System.Drawing.Color.FromArgb(245, 66, 66);
            textbox.BorderColorDisabled = System.Drawing.Color.FromArgb(245, 66, 66);
            textbox.PlaceholderText = message;*/
        }

        public void setDefaultFormConfig(TextBox textbox)
        {
/*            textbox.BackColor = System.Drawing.Color.Transparent;
            textbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            textbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            textbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            textbox.BorderColorIdle = System.Drawing.Color.DarkGray;
*/
        }
    }
}

