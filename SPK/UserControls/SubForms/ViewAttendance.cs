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
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class ViewAttendance : UserControl
    {


        List<_class> Classes = new List<_class>();
        List<session> Sessions = new List<session>();

        public ViewAttendance()
        {
            // var s = new GridviewSerial.GridViewSerial();
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                btnShow.Cursor = Cursors.WaitCursor;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {


                    Sessions = db.sessions.ToList();
                    Classes = db.classes.ToList();


                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support." );
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Classes.Count < 1)
            {
                MessageBox.Show("No Class in the Database. \n Please, add Class first.");
                return;
            }
            if (Sessions.Count < 1)
            {
                MessageBox.Show("No Session in the Database. \n Please, add Session first.");
                return;
            }

            cBoxClass.DataSource = Classes;
            cBoxClass.DisplayMember = "classes";

            cBoxSession.DataSource = Sessions;
            cBoxSession.DisplayMember = "sessions";

            cBoxClass.Cursor = Cursors.Arrow;
            cBoxSession.Cursor = Cursors.Arrow;
            btnShow.Cursor = Cursors.Arrow;
        }

        private void btnShow_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    using (var db = new Model1())
                    {
                        List<student_attendance> attendances = db.student_attendance.Where(x => x.session == cBoxSession.Text &&
                        x.term == cBoxTerm.Text && x._class == cBoxClass.Text).ToList();

                        dGridAttendance.DataSource = attendances;

                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
                

                Cursor = Cursors.Arrow;
            }
        }
    }
}
