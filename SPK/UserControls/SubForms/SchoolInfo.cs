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
using SPK.Utilities;
using DB;

namespace SPK.UserControls.SubForms
{
    public partial class SchoolInfo : UserControl
    {
        string appPath = "";
        string _logoLocation = "";
        string _stampLocation = "";
        administrative adm = new administrative();

        public SchoolInfo()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            Cursor = Cursors.WaitCursor;
            appPath = Properties.Settings.Default.ImagePath;

        }

        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = opFile.SafeFileName;
                    string tic = DateTime.Now.Ticks.ToString();

                    var name = filename.Substring(0, filename.LastIndexOf('.'));
                    var ext = filename.Substring(filename.LastIndexOf('.'));

                    filename = name + tic + ext;

                    _logoLocation = "admin/"  + filename;
                    string filePath = opFile.FileName;
                    File.Copy(filePath, Path.Combine(appPath, _logoLocation));
                    picLogo.Image = new Bitmap(filePath);
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Unable to open file " );
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void btnUploadStamp_Click(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = opFile.SafeFileName;
                    string tic = DateTime.Now.Ticks.ToString();

                    var name = filename.Substring(0, filename.LastIndexOf('.'));
                    var ext = filename.Substring(filename.LastIndexOf('.'));

                    filename = name + tic + ext;

                    _stampLocation = "admin/" + filename;
                    string filePath = opFile.FileName;
                    File.Copy(filePath, Path.Combine(appPath, _stampLocation));
                    picStamp.Image = new Bitmap(filePath);
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Unable to open file ");
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFomControls.CheckTextboxes(this, errorProvider1))
                {
                    if (string.IsNullOrWhiteSpace(_logoLocation) || string.IsNullOrWhiteSpace(_stampLocation))
                    {
                        MessageBox.Show("Please Enter the School Logo and Stamp.");
                        return;
                    }
                    var admin = new administrative()
                    {
                        school_logo = _logoLocation,
                        school_motto = _stampLocation,
                        school_name = _txtName.Text,
                        school_stamp = _txtAddress.Text,
                        upload_date = DateTime.Now.Date.ToString("d"),
                        upload_time = DateTime.Now,
                    };
                    using (var db = new Model1())
                    {
                        if (db.administratives.Count()<1) db.administratives.Add(admin);
                        else
                        {
                            var cur = db.administratives.First();
                            cur.school_logo = _logoLocation;
                            cur.school_motto = _stampLocation;
                            cur.school_name = _txtName.Text;
                            cur.school_stamp = _txtAddress.Text;
                            cur.upload_date = DateTime.Now.Date.ToString("d");
                            cur.upload_time = DateTime.Now;
                        }

                        db.SaveChanges();
                    }
                    MessageBox.Show("Scho0l Info was saved successfully.");
                }

            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured.\n" );
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                adm = db.administratives.FirstOrDefault();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (adm !=null)
            {
                _txtAddress.Text = adm.school_motto;
                _txtName.Text = adm.school_name;
                picLogo.ImageLocation = Path.Combine(appPath, adm.school_logo);
                picStamp.ImageLocation = Path.Combine(appPath, adm.school_stamp);
                _logoLocation = adm.school_logo;
                _stampLocation = adm.school_stamp;
            }

            Cursor = Cursors.Arrow;
        }
    }
}
