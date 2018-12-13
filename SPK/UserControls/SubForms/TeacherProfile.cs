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

namespace SPK.UserControls.SubForms
{
    public partial class TeacherProfile : UserControl
    {
        public TeacherProfile()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                var tch = GetUser();
                if (tch != null)
                {
                    DisplayInfo(tch);
                }
            }
        }

        teacher GetUser()
        {
            return AuthorizedUser.AuthorizedUser<teacher>.CurrentUser;
        }

        void DisplayInfo(teacher teacher)
        {
            lblStatus.Text = teacher.status;
            lblUsername.Text = teacher.username;
            lblPhone.Text = teacher.phone;
            lblDoB.Text = teacher.dob;
            lblEmail.Text = teacher.email;
            lblAddress.Text = teacher.address;
            lblSex.Text = teacher.sex;
            lblNation.Text = teacher.country;
            lblState.Text = teacher.state;
            lblLGA.Text = teacher.lga;
            lblDoE.Text = teacher.employment_date;
            lblTeaching.Text = teacher.subject_to_teach;
            lblPosition.Text = teacher.teacher_position;
            lblDate.Text = teacher.date_registered;

        }
    }
}
