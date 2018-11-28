using SPK.UserControls.Buttons;
using SPK.UserControls.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class frmMain : Form
    {

        bool _mousedown;
        Point startpt;

        public frmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        

        private void picMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimises the program
        }

        private void picMinimise_MouseHover(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.FromArgb(0, 125, 113);
        }

        private void btnSchInfo_ClickEvent(object sender, EventArgs e)
        {
            MenuSchoolInfo.Show(Cursor.Position);
        }

        private void picMinimise_MouseLeave(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnDashboard_ClickEvent(object sender, EventArgs e)
        {
            showUserControl(new Dashboard());
        }

        private void updateSchoolInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new SchoolInfo());
        }

        private void currentTermAndSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new CurrentTermNSession());
        }

        private void addNewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new AddNewSession());
        }

        private void btnStudents_ClickEvent(object sender, EventArgs e)
        {
            menuStudents.Show(Cursor.Position);
        }

        private void registerNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new NewStudent());
        }

        private void promoteClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new PromoteClass());
        }

        private void demoteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new PromoteDemoteStudent());
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewRegisteredStudent());
        }

        private void InputAttendancetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserControl(new ClassAttendance());
        }

        private void btnAttendance_ClickEvent(object sender, EventArgs e)
        {
            menuAttendance.Show(Cursor.Position);
        }

        private void ViewAttendanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewAttendance());
        }

        private void btnBehaviour_ClickEvent(object sender, EventArgs e)
        {
            menuBehaviour.Show(Cursor.Position);
        }

        private void SaveBehaviourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserControl(new uploadBehaviouralAnalysis());
        }

        private void ViewBehavioursToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewBehaviours());
        }

        private void btnClass_ClickEvent(object sender, EventArgs e)
        {
            showUserControl(new AddnViewClass());
        }

        private void AddSubjectClassToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserControl(new AddSubject());
        }

        private void registerStudentSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new RegisterSubject());
        }

        private void ViewSubjectsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewSubjects());
        }

        private void viewRegisteredSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewRegisteredStudent());
        }

        private void specifyJuniorSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new SpecifyJssSubject());
        }

        private void specifySeniorSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new SpecifySssSubject());
        }

        private void specifyNumberOfSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new SpecifySubjectNumber());
        }

        private void btnSubject_ClickEvent(object sender, EventArgs e)
        {
            menuSubject.Show(Cursor.Position);
        }

        private void schoolResumptionAndClosingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(new SaveSchoolStartnEndDate());
        }
        
        private void btnResult_ClickEvent(object sender, EventArgs e)
        {
            menuResult.Show(Cursor.Position);
        }

        private void UploadResultDirectlyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserControl(new EnterStudentResult());
        }

        private void ViewUploadedResultToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewAllResult());
        }

        private void PublishResultToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            showUserControl(new PublishUploadedResult());
        }

        private void ViewPublishedResultToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewPublishedResult());
        }

        private void btnFees_ClickEvent(object sender, EventArgs e)
        {
            showUserControl(new AllocateFees());
        }

        private void btnAdmin_ClickEvent(object sender, EventArgs e)
        {
            menuAdmin.Show(Cursor.Position);
        }

        private void AddAdminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserControl(new AddAdmin());
        }

        private void ViewAllAdminToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewAdmins());
        }
        
        private void AddPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserControl(new AddPrincipal());
        }

        private void ViewPrincipalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewAllPrincipal());
        }

        private void btnPrincipal_ClickEvent(object sender, EventArgs e)
        {
            menuPrincipal.Show(Cursor.Position);
        }

        private void btnTeachers_ClickEvent(object sender, EventArgs e)
        {
            menuTeacher.Show(Cursor.Position);
        }

        private void AddTeacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserControl(new AddTeacher());
        }

        private void TeachersandtheirClassesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showUserControl(new TeachertoClass());
        }

        private void ViewTeachersToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            showUserControl(new TeacherEmploymentStatus());
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.DarkRed;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mousedown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            startpt = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                var curpos = PointToScreen(e.Location);
                Location = new Point(curpos.X - startpt.X, curpos.Y - startpt.Y);
            }
        }
        
        private void showUserControl (Control ctrl)
        {
            Cursor = Cursors.WaitCursor;

            panContainer.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            panContainer.Controls.Add(ctrl);

            Cursor = Cursors.Arrow;
        }
    }
}
