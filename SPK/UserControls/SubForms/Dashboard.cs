using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPK.UserControls.Panels;
using DB;
using System.IO;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class Dashboard : UserControl
    {
        private Image _ProfilePic { get; set;  } //= Properties.Resources.command;
        private string _School { get; set; } = "SCHOOL NAME";
        private string _Session { get; set; } = "Third Term - 2017/2018 Session";
        string _userType;


        public Image ProfilePic
        {
            get => _ProfilePic;
            set
            {
                _ProfilePic = value;
                NotifyPropertyChanged("ProfilePic");
            }
        }

        public string School
        {
            get { return _School; }
            set
            {
                _School = value;
                NotifyPropertyChanged("School");
            }
        }

        public string Session
        {
            get { return _Session; }
            set
            {
                _Session = value;
                NotifyPropertyChanged("Session");
            }
        }


        public Dashboard(string userType)
        {
            InitializeComponent();
            _userType = userType;
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    using (var db = new Model1())
                    {
                        var school = db.administratives.FirstOrDefault();

                        if (school != null)
                        {
                            School = school.school_name;
                            ProfilePic = Image.FromFile(Path.Combine(Properties.Settings.Default.ImagePath, school.school_logo));
                        }
                        var session = db.current_season.FirstOrDefault();

                        if (session != null)
                        {
                            Session = session.current_term + " - " + session.current_session + " Session";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                }
            }
        }


        private void NotifyPropertyChanged(string Property)
        {
            switch (Property)
            {
                case "ProfilePic":
                    picSchoolLogo.Image = _ProfilePic;
                    break;

                case "School":
                    lblSchool.Text = _School;
                    break;

                case "Session":
                    lblTermNSession.Text = _Session;
                    break;

                default:
                    break;
            }
        }
        
        private void panProfileCover_MouseHover(object sender, EventArgs e)
        {
            var pan = (ExtendedPanel)sender;
            var ctrl = pan.Parent;
            ctrl.ForeColor = Color.FromArgb(0, 125, 113);
        }

        private void panProfileCover_MouseLeave(object sender, EventArgs e)
        {
            var pan = (ExtendedPanel)sender;
            var ctrl = pan.Parent;
            ctrl.ForeColor = Color.FromArgb(0, 150, 136);
        }

        private void panProfileCover_Click(object sender, EventArgs e)
        {
            if (_userType == "principal")
            {
                showUserControl(new PrincipalProfile());
            }
            else
            {
                showUserControl(new AdminProfile());
            }
        }

        private void showUserControl(Control ctrl)
        {
            Parent.Controls.Add(ctrl);
            Dispose();
        }

        private void panStudentCover_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewRegisteredStudent());
        }

        private void panClassCover_Click(object sender, EventArgs e)
        {
            showUserControl(new AddnViewClass());
        }

        private void PanSubjectCover_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewSubjects());
        }

        private void panResultCover_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewAllResult());
        }

        private void panFeesCover_Click(object sender, EventArgs e)
        {
            showUserControl(new AllocateFees());
        }

        private void panStaffCover_Click(object sender, EventArgs e)
        {
            showUserControl(new TeacherEmploymentStatus());
        }

        private void panPasswordCover_Click(object sender, EventArgs e)
        {
            showUserControl(new PasswordReset());
        }
    }
}
