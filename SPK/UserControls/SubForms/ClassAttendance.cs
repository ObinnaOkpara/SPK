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
    public partial class ClassAttendance : UserControl
    {
        string selectedClass = "";
        List<_class> Classes = new List<_class>();
        current_season current_Season = new current_season();
        List<student> Students = new List<student>();

        int bgAction = 1;
        public ClassAttendance()
        {
            InitializeComponent();


            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                cBoxTerm.Cursor = Cursors.WaitCursor;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bgAction==1)
            {
                using (var db = new Model1())
                {
                    current_Season = db.current_season.FirstOrDefault();
                    Classes = db.classes.ToList();
                }
            }
            else if (bgAction==2)
            {
                using (var db = new Model1())
                {
                    Students = db.students.Where(x=>x._class == selectedClass).ToList();
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bgAction == 1)
            {
                if (Classes.Count<1)
                {
                    MessageBox.Show("No Class in the Database. \n Please, add Class first.");
                    return;
                }
                if (current_Season == null)
                {
                    MessageBox.Show("Current Session and Term has not been added. \n Please click on School Information and Add Term and Session.");
                    return;
                }

                cBoxClass.DataSource = Classes;
                cBoxClass.DisplayMember = "classes";

                cBoxSession.Items.Add(current_Season.current_session);
                cBoxTerm.Items.Add(current_Season.current_term);

                cBoxClass.Cursor = Cursors.Arrow;
                cBoxSession.Cursor = Cursors.Arrow;
                cBoxTerm.Cursor = Cursors.Arrow;
            }
            else if (bgAction == 2)
            {
                if (Students.Count < 1)
                {
                    MessageBox.Show("This class has no student. \n Please, add Student first.");
                    return;
                }

                dGridClassMembers.DataSource = Students;

                btnShow.Cursor = Cursors.Arrow;
                dGridClassMembers.Cursor = Cursors.Arrow;

            }
        }

        private void btnShow_ClickEvent(object sender, EventArgs e)
        {
            bgAction = 2;

            if (string.IsNullOrWhiteSpace(cBoxClass.Text))
            {
                MessageBox.Show("Select a class first.");
                return;
            }

            selectedClass = cBoxClass.Text;
            btnShow.Cursor = Cursors.WaitCursor;
            dGridClassMembers.Cursor = Cursors.WaitCursor;

            backgroundWorker1.RunWorkerAsync();
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            var AttendanceList = new List<student_attendance>();

            if (string.IsNullOrWhiteSpace(cBoxSession.Text) && string.IsNullOrWhiteSpace(cBoxTerm.Text) )
            {
                MessageBox.Show("Please select Session and Term first.", "An Error Occured.");
                return;
            }
            if (dGridClassMembers.Rows.Count < 1)
            {
                MessageBox.Show("No Students Loaded. \n Make sure there are students in the selected class.", "An Error Occured.");
                return;
            }

            var r = MessageBox.Show("Make sure you have selected the attendance status for the displayed students. \n Click 'OK' to proceed.",
                "Save Attendance?", MessageBoxButtons.OKCancel);

            Cursor = Cursors.WaitCursor;

            if (r != DialogResult.OK) return;

            foreach (DataGridViewRow row in dGridClassMembers.Rows)
            {
                var attendance = new student_attendance()
                {
                    date = dtpDate.Text,
                    name = (string)row.Cells[1].Value,
                    reg_number = (string)row.Cells[0].Value,
                    roll_call = (string)row.Cells[3].Value,
                    session = cBoxSession.Text,
                    term = cBoxTerm.Text,
                    _class = (string)row.Cells[2].Value,
                };

                AttendanceList.Add(attendance);
            }

            using (var db = new Model1())
            {
                db.student_attendance.AddRange(AttendanceList);
                db.SaveChangesAsync();
            }

            MessageBox.Show("Saved Successfully.");

            Students = new List<student>();
            dGridClassMembers.DataSource = Students;

            Cursor = Cursors.Arrow;
        }
    }
}
