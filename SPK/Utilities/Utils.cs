using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK.Utilities
{
    public static class Utils
    {

        public static void LogException(Exception ex)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"SPKlog");

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }


            using (StreamWriter writer = new StreamWriter(Path.Combine(filePath,"log.txt"), true))
            {
                writer.WriteLine("-------------------------------------------------------");
                writer.WriteLine("Date : " + DateTime.Now.ToString());
                writer.WriteLine();

                while (ex != null)
                {
                    writer.WriteLine(ex.GetType().FullName);
                    writer.WriteLine("Message : " + ex.Message);
                    writer.WriteLine("StackTrace : " + ex.StackTrace);

                    ex = ex.InnerException;
                }
            }
        }

        public static void fitFormToScreen(Form form, int h, int w)
            {

                //scale the form to the current screen resolution
                form.Height = (int)((float)form.Height * ((float)Screen.PrimaryScreen.Bounds.Size.Height / (float)h));
                form.Width = (int)((float)form.Width * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

                //here font is scaled like width
                form.Font = new Font(form.Font.FontFamily, form.Font.Size * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

                foreach (Control item in form.Controls)
                {
                    fitControlsToScreen(item, h, w);
                }

            }

            static void fitControlsToScreen(Control cntrl, int h, int w)
            {
                if (Screen.PrimaryScreen.Bounds.Size.Height != h)
                {

                    cntrl.Height = (int)((float)cntrl.Height * ((float)Screen.PrimaryScreen.Bounds.Size.Height / (float)h));
                    cntrl.Top = (int)((float)cntrl.Top * ((float)Screen.PrimaryScreen.Bounds.Size.Height / (float)h));

                }
                if (Screen.PrimaryScreen.Bounds.Size.Width != w)
                {

                    cntrl.Width = (int)((float)cntrl.Width * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));
                    cntrl.Left = (int)((float)cntrl.Left * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

                    cntrl.Font = new Font(cntrl.Font.FontFamily, cntrl.Font.Size * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

                }

                foreach (Control item in cntrl.Controls)
                {
                    fitControlsToScreen(item, h, w);
                }
            }
      
    }
}
