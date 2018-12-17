using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPK.Utilities;
using DB;

namespace SPK.UserControls.SubForms
{
    public partial class SpecifySubjectNumber : UserControl
    {
        int? _jssnumber;
        int? _sssnumber;
        public SpecifySubjectNumber()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnSaveJss_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                try
                {

                using (var db = new Model1())
                {
                    var jssnum = db.jss_subject_number.FirstOrDefault();

                    if (jssnum != null)
                    {
                        jssnum.number_of_subject = Convert.ToInt32(cBoxNum.Text);
                        db.SaveChanges();
                        lblJSSNum.Text = string.Format("JSS Students must offer {0} subjects", cBoxNum.Text);
                        MessageBox.Show("Jss Subject Number updated");
                        cBoxNum.SelectedIndex = -1;
                    }
                    else
                    {
                        var _jnum = new jss_subject_number()
                        {
                            declared_date = DateTime.Now.ToString("d"),
                            declared_time = DateTime.Now,
                            number_of_subject = Convert.ToInt32(cBoxNum.Text)

                        };

                        
                        db.jss_subject_number.Add(_jnum);
                        db.SaveChanges();
                        lblJSSNum.Text = string.Format("JSS Students must offer {0} subjects", cBoxNum.Text);
                        MessageBox.Show("Jss Subject Number added");
                        cBoxNum.SelectedIndex = -1;
                    }
                }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
            }
        }

        private void btnSaveSss_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                try
                {
                    using (var db = new Model1())
                    {
                        var sssnum = db.sss_subject_number.FirstOrDefault();

                        if (sssnum != null)
                        {
                            sssnum.number_of_subject = Convert.ToInt32(cBoxNum.Text);
                            db.SaveChanges();
                            lblSSSnum.Text = string.Format("SSS Students must offer {0} subjects", cBoxNum.Text);
                            MessageBox.Show("SSS Subject Number updated");
                            cBoxNum.SelectedIndex = -1;
                        }
                        else
                        {
                            var _ssnum = new sss_subject_number()
                            {
                                declared_date = DateTime.Now.ToString("d"),
                                declared_time = DateTime.Now,
                                number_of_subject = Convert.ToInt32(cBoxNum.Text)

                            };

                            db.sss_subject_number.Add(_ssnum);
                            db.SaveChanges();
                            lblSSSnum.Text = string.Format("SSS Students must offer {0} subjects", cBoxNum.Text);
                            MessageBox.Show("SSS Subject Number added");
                            cBoxNum.SelectedIndex = -1;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    var _jss = db.jss_subject_number.FirstOrDefault();
                    var _sss = db.sss_subject_number.FirstOrDefault();
                    if (_jss != null)
                    {
                        _jssnumber = _jss.number_of_subject;
                    }

                    if (_sss != null)
                    {
                        _sssnumber = _sss.number_of_subject;
                    }
                    
                    

                }

            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support.");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_jssnumber == null)
            {
                lblJSSNum.Text = "JSS Students must offer 0 subjects";
            }
            else
            {
                lblJSSNum.Text = string.Format("JSS Students must offer {0} subjects", _jssnumber);
            }

            if (_sssnumber == null)
            {
                lblSSSnum.Text = "SSS Students must offer 0 subjects";
            }
            else
            {
                lblSSSnum.Text = string.Format("SSS Students must offer {0} subjects", _sssnumber);
            }
        }
    }
}
