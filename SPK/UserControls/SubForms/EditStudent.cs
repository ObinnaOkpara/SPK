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
using DB.Services.DataRepository;
using SPK.Utilities;
using System.IO;
using System.Globalization;

namespace SPK.UserControls.SubForms
{
    public partial class EditStudent : UserControl
    {
        student Student;
        int _id;
        private UnitOfWork _unitOfWork;

        string _pasportLocation;
        public EditStudent(int? id)
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                if (id != null)
                {
                    Cursor = Cursors.WaitCursor;
                    _id = (int)id;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            using (var db = new Model1())
            {
                Student = db.students.Find(_id);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Arrow;

            txtStudentAddress.Text = Student.address;
            txtCity.Text = Student.city;

            txtStudentPhone.Text = Student.contact_phone;
            // date_of_reg = DateTime.Today.ToString("dd/MMM/yyyy"),
            var month = DateTime.ParseExact(Student.mob, "MMMM", CultureInfo.InvariantCulture).Month.ToString();

            dtpDoB.Value = DateTime.Parse(Student.dob+ "/" + month + "/" + Student.yob);
            
            txtFatherName.Text = Student.father_name;
            txtFatherOccupation.Text = Student.father_occupation;
            txtFatherPhone.Text = Student.father_phone;
            txtFirstname.Text = Student.firstname;
            cBoxSex.Text = Student.gender;
            txtPassword.Text = Student.gen_password;
            txtHealth.Text = Student.health_conditions;
            txtSurname.Text = Student.lastname;
            txtPrevClass.Text = Student.last_class_passed;
            txtMotherName.Text = Student.mother_name;
            txtMotherOccupation.Text = Student.mother_occupation;
            txtMotherPhone.Text = Student.mother_phone;
            txtLGA.Text = Student.lga;
            cBoxCountry.Text = Student.nationality;
            txtStudentOtherContact.Text = Student.nearest_contact1;
            txtOthernames.Text = Student.othername;
            picStudentImage.ImageLocation = Student.passport;
            txtPrevSchool.Text = Student.previous_school;
            txtRegNumber.Text = Student.reg_number;
            txtSponsorRelationship.Text = Student.relationship;
            txtSponsorAddress.Text = Student.sponsor_address;
            txtSponsorName.Text = Student.sponsor_name;
            txtSponsorOccupation.Text = Student.sponsor_occupation;
            txtSponsorPhone.Text = Student.sponsor_phone;
            cBoxState.Text = Student.state;
            //time_of_reg = DateTime.Now.ToLocalTime(),
            txtCurClass.Text = Student._class;
        }

        private async void btnSave_ClickEventAsync(object sender, EventArgs e)
        {

            try
            {
                _unitOfWork = new UnitOfWork(new Model1());

                var _student = _unitOfWork.StudentRepository.FindById(_id).Result;


                _student.address = txtStudentAddress.Text;
                    _student.city = txtCity.Text;

                    _student.contact_phone = txtStudentPhone.Text;
                    _student.date_of_reg = DateTime.Today.ToString("dd/MMM/yyyy");
                    _student.dob = dtpDoB.Value.Day.ToString();
                    _student.father_name = txtFatherName.Text;
                    _student.father_occupation = txtFatherOccupation.Text;
                   _student.father_phone = txtFatherPhone.Text;
                   _student.firstname = txtFirstname.Text;
                    _student.gender = cBoxSex.Text;
                   _student.gen_password = txtPassword.Text;
                   _student.health_conditions = txtHealth.Text;
                   _student.lastname = txtSurname.Text;
                  _student.last_class_passed = txtPrevClass.Text;
                   _student.mother_name = txtMotherName.Text;
                   _student.mother_occupation = txtMotherOccupation.Text;
                   _student.mother_phone = txtMotherPhone.Text;
                   _student.lga = txtLGA.Text;
                   _student.nationality = cBoxCountry.Text;
                   _student.nearest_contact1 = txtStudentOtherContact.Text;
                   _student.othername = txtOthernames.Text;
                   _student.passport = _pasportLocation;
                   _student.previous_school = txtPrevSchool.Text;
                   _student.reg_number = txtRegNumber.Text;
                   _student.relationship = txtSponsorRelationship.Text;
                   _student.sponsor_address = txtSponsorAddress.Text;
                  _student.sponsor_name = txtSponsorName.Text;
                  _student.sponsor_occupation = txtSponsorOccupation.Text;
                  _student.sponsor_phone = txtSponsorPhone.Text;
                   _student.state = cBoxState.Text;
                    _student.time_of_reg = DateTime.Now.ToLocalTime();
                  _student._class = txtCurClass.Text;
                   _student.mob = dtpDoB.Value.Month.ToString();
                  _student.yob = dtpDoB.Value.Year.ToString();
                
                await _unitOfWork.Save();

                MessageBox.Show("Student succesfully updated");
                var x = Parent.FindForm();
                x.Close();
                //ClearTextboxes();
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support.");
            }
        }

        private void btnUploadStudentImage_Click(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), @"spk\image\");
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

                    if (filename != null)
                    {
                        var name = filename.Substring(0, filename.LastIndexOf('.'));
                        var ext = filename.Substring(filename.LastIndexOf('.'));

                        filename = name + tic + ext;
                    }

                    _pasportLocation = "image/" + filename;
                    string filePath = opFile.FileName;
                    File.Copy(filePath, Path.Combine(appPath, filename));
                    var nfile = Path.Combine(appPath, filename);
                    picStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    picStudentImage.Image = new Bitmap(nfile);
                }
                catch (Exception ex)
                {
                    Utilities.Utils.LogException(ex);
                    MessageBox.Show("Unable to open file ");
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
    }
}
