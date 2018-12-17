using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.Services.Interfaces;
using System.IO;
using DB;
using DB.Services.DataRepository;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class NewStudent : UserControl
    {
        private IUnitOfWork _unitOfWork;
        int term_code;
        int last_id;
        string school_name = "SJSS";
        string gen_pwd = "sjs";
        string _pasportLocation;
        public NewStudent()
        {
            InitializeComponent();
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
                    picStudentImage.Image = new Bitmap(_pasportLocation);
                }
                catch (Exception ex)
                {
                    Utilities.Utils.LogException(ex);
                    MessageBox.Show("Unable to open file " );
                }
            }
            else
            {
                opFile.Dispose();
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _unitOfWork = new UnitOfWork(new Model1());
                var newStudent = new student
                {
                    address = txtStudentAddress.Text,
                    city = txtCity.Text,

                    contact_phone = txtStudentPhone.Text,
                    date_of_reg = DateTime.Today.ToShortDateString(),
                    dob = dtpDoB.Value.Day.ToString(),
                    father_name = txtFatherName.Text,
                    father_occupation = txtFatherOccupation.Text,
                    father_phone = txtFatherPhone.Text,
                    firstname = txtFirstname.Text,
                    gender = cBoxSex.Text,
                    gen_password = gen_pwd,
                    health_conditions = txtHealth.Text,
                    lastname = txtSurname.Text,
                    last_class_passed = txtPrevClass.Text,
                    mother_name = txtMotherName.Text,
                    mother_occupation = txtMotherOccupation.Text,
                    mother_phone = txtMotherPhone.Text,
                    lga = txtLGA.Text,
                    nationality = cBoxCountry.Text,
                    nearest_contact1 = txtStudentOtherContact.Text,
                    othername = txtOthernames.Text,
                    passport = _pasportLocation,
                    previous_school = txtPrevSchool.Text,
                    reg_number = GetRegNumber(),
                    relationship = txtSponsorRelationship.Text,
                    sponsor_address = txtSponsorAddress.Text,
                    sponsor_name = txtSponsorName.Text,
                    sponsor_occupation = txtSponsorOccupation.Text,
                    sponsor_phone = txtSponsorPhone.Text,
                    state = cBoxState.Text,
                    time_of_reg = DateTime.Now.ToLocalTime(),
                    _class = txtCurClass.Text,
                    mob = dtpDoB.Value.Month.ToString(),
                    yob = dtpDoB.Value.Year.ToString(),


                };

                _unitOfWork.StudentRepository.Add(newStudent);
                await _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support.");
            }
          

        }

        string GetRegNumber()
        {
            
            using (var db = new Model1())
            {
                var curr_season = db.current_season.FirstOrDefault();
                string session;
                last_id = db.students.Last().id;

                if (curr_season != null)
                {

                    session = curr_season.current_session;
                    var term = curr_season.current_term;

                    var session_of_reg = session.Substring(0, 4);

                    if (term == "First Term")
                    {
                        term_code = 1;
                    }
                    else if (term == "Second Term")
                    {
                        term_code = 2;
                    }
                    else if (term == "Third Term")
                    {
                        term_code = 3;
                    }
                    return session + term_code + school_name + last_id.ToString("000");
                }
                return null;


            }
        }

        private void btnSave_Load(object sender, EventArgs e)
        {

        }
    }
}
