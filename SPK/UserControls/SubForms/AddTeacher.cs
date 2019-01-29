using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using DB.Services.Interfaces;
using SPK.Utilities;
using DB.Services.DataRepository;

namespace SPK.UserControls.SubForms
{
    public partial class AddTeacher : UserControl
    {
        List<school_subjects> subjects = new List<school_subjects>();

        private IUnitOfWork _unitOfWork;
        public AddTeacher()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
            _unitOfWork = new UnitOfWork(new Model1());

            backgroundWorker1.RunWorkerAsync();
            cBoxSubject.Cursor = Cursors.WaitCursor;

            }

        }

        private teacher CreateTeacher()
        {
            var t = new teacher()
            {
                date_registered = DateTime.Today.ToString("d"),
                email = _txtEmail.Text,
                firstname = _txtFirstname.Text,
                lastname = _txtSurname.Text + " " + txtOthernames.Text,
                address = txtAddress.Text,
                country = cBoxCountry.Text,
                password = _txtPassword.Text,
                phone = _txtPhone.Text,
                dob = Convert.ToString(dtpDoB.Value.Date.Day),
                employment_date = dtpDoE.Text,
                sex = cBoxSex.Text,
                time_registered = DateTime.Now,
                username = _txtUsername.Text,
                lga = _txtLGA.Text,
                mob = dtpDoB.Value.Date.Month.ToString("MMMM"),
                yob = dtpDoB.Value.Date.Year.ToString(),
                state = cBoxState.Text,
                status="Active",
                subject_to_teach = cBoxSubject.Text,
                teacher_position = _txtPosition.Text
            };
            return t;
        }

        private async void btnSave_ClickEventAsync(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1)
                && ValidateFomControls.CheckPassword(_txtPassword.Text, _txtConfirmPassword.Text) 
                && ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                try
                {
                    var teacher = CreateTeacher();

                    if (teacher != null)
                    {
                        _unitOfWork = new UnitOfWork(new Model1());
                        _unitOfWork.TeacherRepository.Add(teacher);
                        await _unitOfWork.Save();
                        _unitOfWork.Dispose();
                        MessageBox.Show("Teacher added");
                    }
                    else
                    {
                        ArgumentNullException ex = new ArgumentNullException("Teacher object", "Teacher object is null");
                        Utils.LogException(ex);
                        MessageBox.Show("Error occured. Contact support");
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("An error occured. Please contact support");
                }
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    subjects = db.school_subjects.ToList();
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured. Please contact support");
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxSubject.DataSource = subjects;
            cBoxSubject.DisplayMember = "subjects";

            cBoxSubject.Cursor = Cursors.Arrow;
        }
    }
}
