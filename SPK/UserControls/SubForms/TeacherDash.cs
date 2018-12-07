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
    public partial class TeacherDash : UserControl
    {
        public TeacherDash()
        {
            InitializeComponent();
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

        private void showUserControl(Control ctrl)
        {
            Parent.Controls.Add(ctrl);
            Dispose();
        }

        private void panProfileCover_Click(object sender, EventArgs e)
        {
            showUserControl(new TeacherProfile());
        }

        private void panStudentCover_Click(object sender, EventArgs e)
        {

        }
    }
}
