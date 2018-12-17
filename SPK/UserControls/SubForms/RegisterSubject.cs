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
    public partial class RegisterSubject : UserControl
    {
        List<_class> Classes = new List<_class>();
        List<session> Sessions = new List<session>();
        List<school_subjects> Subjects = new List<school_subjects>();

        public RegisterSubject()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                cBoxSubject.Cursor = Cursors.WaitCursor;
                btnSearch.Cursor = Cursors.WaitCursor;

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
                    Subjects = db.school_subjects.ToList();
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
            cBoxClass.Cursor = Cursors.Arrow;
            cBoxSession.Cursor = Cursors.Arrow;
            cBoxSubject.Cursor = Cursors.Arrow;
            btnSearch.Cursor = Cursors.Arrow;

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
            if (Subjects.Count < 1)
            {
                MessageBox.Show("No Subject in the Database. \n Please, add Subject first.");
                return;
            }

            cBoxClass.DataSource = Classes;
            cBoxClass.DisplayMember = "classes";

            cBoxSession.DataSource = Sessions;
            cBoxSession.DisplayMember = "sessions";

            cBoxSubject.DataSource = Subjects;
            cBoxSubject.DisplayMember = "subjects";
        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            if(ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    using (var db = new Model1())
                    {
                        var Students = db.students.Where(x => x._class == cBoxClass.Text);
                        var Reg = new List<subject>();

                        foreach (var s in Students)
                        {
                            var stuReg = new subject()
                            {
                                name = s.Fullname,
                                reg_number = s.reg_number,
                                session = cBoxSession.Text,
                                subjects = cBoxSubject.Text,
                                term = cBoxTerm.Text,
                                _class = cBoxClass.Text,
                            };

                            Reg.Add(stuReg);
                        }

                        dGridStudReg.DataSource = Reg;
                    }
                }
                catch(Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
                finally
                {
                    Cursor = Cursors.Arrow;
                }
            }
        }

        private void dGridStudReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridStudReg.RowCount > 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    if (dGridStudReg.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        var result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            var row = dGridStudReg.Rows[e.RowIndex];

                            dGridStudReg.Rows.Remove(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
                finally
                {
                    Cursor = Cursors.Arrow;
                }
            }
            else MessageBox.Show("No Student Loaded. Please Select Class, Subject, Term and Session and click Load first.");
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (dGridStudReg.RowCount > 0)
            {
                Cursor = Cursors.WaitCursor;

                try
                {
                    using (var db = new Model1())
                    {
                        var subs = new List<subject>();

                        foreach (DataGridViewRow row in dGridStudReg.Rows)
                        {
                            subs.Add(new subject()
                            {
                                registration_date = DateTime.Now.Date.ToString("d"),
                                registration_time = DateTime.Now,
                                reg_number = row.Cells[1].Value.ToString(),
                                name = row.Cells[0].Value.ToString(),
                                subjects = row.Cells[3].Value.ToString(),
                                term = row.Cells[4].Value.ToString(),
                                _class = row.Cells[2].Value.ToString(),
                                session = row.Cells[5].Value.ToString(),
                            });
                        }
                        db.subjects.AddRange(subs);
                        db.SaveChanges();
                        MessageBox.Show("Subjects Registered successfully.");
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
