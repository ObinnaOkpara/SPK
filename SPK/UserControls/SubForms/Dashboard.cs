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

namespace SPK.UserControls.SubForms
{
    public partial class Dashboard : UserControl
    {
        private Image _ProfilePic { get; set;  } //= Properties.Resources.command;
        private string _School { get; set; } = "SCHOOL NAME";
        private string _Session { get; set; } = "Third Term - 2017/2018 Session";

        public Image ProfilePic
        {
            get { return _ProfilePic; }
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


        public Dashboard()
        {
            InitializeComponent();
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
    }
}
