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
    public partial class uploadBehaviouralAnalysis : UserControl
    {
        List<_class> Classes = new List<_class>();
        List<session> Sessions = new List<session>();
        List<behavioral> behaviorals = new List<behavioral>();

        public uploadBehaviouralAnalysis()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                btnSearch.Cursor = Cursors.WaitCursor;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                Cursor = Cursors.WaitCursor;

                try
                {
                    using (var db = new Model1())
                    {
                        List<student> students = db.students.Where(x => x._class == cBoxClass.Text).ToList();
                        behaviorals = new List<behavioral>();

                        foreach (var s in students)
                        {
                            behaviorals.Add(new behavioral()
                            {
                                name = s.Fullname,
                                reg_number = s.reg_number,
                                term = cBoxTerm.Text,
                                session = cBoxSession.Text,
                                _class = cBoxClass.Text,
                                attentiveness = "1",
                                attitude_to_work = "1",
                                hand_writting = "1",
                                health = "1",
                                musical_skills = "1",
                                politeness = "1",
                                sports = "1",
                            });
                        }
                        dGridStudentsBehaviour.DataSource = behaviorals;
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
                MessageBox.Show("Error occured. Please contact support.");
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
            btnSearch.Cursor = Cursors.Arrow;
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (dGridStudentsBehaviour.RowCount < 1)
            {
                Cursor = Cursors.WaitCursor;

                try
                {
                    using (var db = new Model1())
                    {
                        var bs = new List<behavioral>();

                        foreach (DataGridViewRow row in dGridStudentsBehaviour.Rows)
                        {
                            bs.Add(new behavioral()
                            {
                                date = DateTime.Now.Date.ToString("d"),
                                name = row.Cells[1].Value.ToString(),
                                reg_number = row.Cells[0].Value.ToString(),
                                term = row.Cells[3].Value.ToString(),
                                session = row.Cells[4].Value.ToString(),
                                _class = row.Cells[2].Value.ToString(),
                                attentiveness = row.Cells[8].Value.ToString(),
                                attitude_to_work = row.Cells[9].Value.ToString(),
                                hand_writting = row.Cells[5].Value.ToString(),
                                health = row.Cells[10].Value.ToString(),
                                musical_skills = row.Cells[6].Value.ToString(),
                                politeness = row.Cells[11].Value.ToString(),
                                sports = row.Cells[7].Value.ToString(),
                            });
                        }
                        db.behaviorals.AddRange(bs);
                        db.SaveChanges();
                        MessageBox.Show("Behaviours saved successfully.");
                    }

                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }


                Cursor = Cursors.Arrow;
            }
            else MessageBox.Show("No Student Loaded. Please Select Class, Term and Session and click Load first.");
        }
    }
}
