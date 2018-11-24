using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SPK.UserControls.SubForms
{
    public partial class SchoolInfo : UserControl
    {
        string appPath = "";

        public SchoolInfo()
        {
            InitializeComponent();
            appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), @"spk\admin\");
        }

        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = opFile.SafeFileName;
                    string tic = DateTime.Now.Ticks.ToString();

                    var name = filename.Substring(0, filename.LastIndexOf('.'));
                    var ext = filename.Substring(filename.LastIndexOf('.'));

                    filename = name + tic + ext;

                    _pasportLocation = Path.Combine(appPath, filename);
                    string filePath = opFile.FileName;
                    File.Copy(filePath, _pasportLocation);
                    picStudentImage.Image = new Bitmap(_pasportLocation);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Unable to open file " + ex.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
    }
}
