using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace SPK.Utilities
{
    public static class ValidateTextboxes
    {
       public static bool Check(string first_password, string second_password, ControlCollection control, ErrorProvider ep)
        {
            if (string.Equals(first_password, second_password))
            {
                var txtboxes = control.OfType<TextBox>().Where(box => box.Name.StartsWith("_"));

                foreach (var tbox in txtboxes)
                {
                    if (string.IsNullOrWhiteSpace(tbox.Text))
                    {
                        ep.SetError(tbox, "Please fill the required field");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Password not the same");
                return false;
            }

            return true;
        }
        
    }
}
