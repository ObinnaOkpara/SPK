using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPK.Utilities;
using DB;
using DB.Services.Interfaces;
using DB.Services.DataRepository;

namespace SPK.UserControls.SubForms
{
    public partial class EnterStudentResult : UserControl
    {
        private List<subject> regStudents;
        private List<_class> _Classes;
        private List<school_subjects> subjects;
        private current_season session;
        private IUnitOfWork _unitOfWork;



        public EnterStudentResult()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                _unitOfWork = new UnitOfWork(new Model1());
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                regStudents = _unitOfWork.SubjectsRepository.FindAll().Where(x => x._class == cBoxClass.Text && x.session== cBoxSession.Text && x.subjects == cBoxSubject.Text && x.term == cBoxTerm.Text).ToList();

                if (regStudents.Count<1)
                {
                    MessageBox.Show("No Registered Student Found.");
                    dgridStudents.DataSource = new List<subject>();
                    return;
                }
                dgridStudents.DataSource = regStudents;
            }
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {

            if (dgridStudents.RowCount > 0)
            {
                Cursor = Cursors.WaitCursor;
                
                try
                {
                    using (var db = new Model1())
                    {

                        var ca_ = cBoxClass.Text;
                        var ss_ = cBoxSession.Text;
                        var tr_ = cBoxTerm.Text;
                        var subj_ = cBoxSubject.Text;

                        if (db.results1.Any(x => x._class == ca_ && x.session == ss_ && x.term == tr_ && x.subjects == subj_))
                        {
                            MessageBox.Show("Result for this class already exists. Please delete the class result before updating");
                        }
                        else
                        {
                            try
                            {
                                 var rsltList = new List<results1>();
                                
                                //store students results 
                                foreach (DataGridViewRow row in dgridStudents.Rows)
                                {

                                    rsltList.Add(new results1
                                    {
                                        ca = Convert.ToInt32(row.Cells[2].Value),
                                        date_of_upload = DateTime.Now.Date.ToString("d"),
                                        exam = Convert.ToInt32(row.Cells[4].Value),
                                        name = row.Cells[0].Value.ToString(),
                                        project = Convert.ToInt32(row.Cells[3].Value),
                                        reg_number = row.Cells[1].Value.ToString(),
                                        session = ss_,
                                        subjects = subj_,
                                        term = tr_,
                                        _class = ca_,
                                        time_of_upload = DateTime.Now,
                                        subject_total = Convert.ToInt32(row.Cells[4].Value) + Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(row.Cells[2].Value),
                                       
                                    });
                                }

                                var subjRankList = rsltList.OrderByDescending(x => x.subject_total).ToList();

                                for (int i = 0; i < subjRankList.Count; i++)
                                {
                                    subjRankList[i].subject_rank = i + 1;
                                }

                                db.results1.AddRange(subjRankList);
                                db.SaveChanges();
                                
                               
                                MessageBox.Show("Students result saved");
                            }
                            catch (Exception ex)
                            {
                                Utils.LogException(ex);
                                MessageBox.Show("An error occured while updating the database. Please contact support");
                            }

                        }

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

        //private List<results1> convertDgridToList()
        //{

        //}

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    session = db.current_season.FirstOrDefault();
                }
                subjects = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
                // students = _unitOfWork.StudentRepository.FindAll().ToList();
                _Classes = _unitOfWork.dClassRepository.FindAll().ToList();

            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured. Please contact support");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (session==null)
            {
                MessageBox.Show("Please enter current session.");
            }
            else
            {
                cBoxSession.Items.Add(session.current_session);
            }
            cBoxClass.DataSource = _Classes;
            cBoxSubject.DataSource = subjects;
        }
    }
}
