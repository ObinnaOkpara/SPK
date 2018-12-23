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

namespace SPK.UserControls.SubForms
{
    public partial class PublishUploadedResult : UserControl
    {
        List<_class> _Classes;
        List<session> sessions;
        public PublishUploadedResult()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnPublish_ClickEvent(object sender, EventArgs e)
        {
            if (true)//ValidateFomControls.CheckComboBoxes(this,)
            {
                int? number_of_subjects = 0;
                var clss_ = cBoxClass.Text;
                var term_ = cBoxTerm.Text;
                var sess_ = cBoxSession.Text;

                if (clss_.Contains("JSS"))
                {
                    using (var db = new Model1())
                    {
                        var jss_subjects = db.jss_subject_number.FirstOrDefault();

                        if (jss_subjects != null)
                        {
                            number_of_subjects = jss_subjects.number_of_subject;
                        }

                    }
                }
                else if (clss_.Contains("SSS"))
                {

                    using (var db = new Model1())
                    {
                        var sss_subjects = db.sss_subject_number.FirstOrDefault();

                        if (sss_subjects != null)
                        {
                            number_of_subjects = sss_subjects.number_of_subject;
                        }
                    }
                }


                using (var db = new Model1())
                {
                    var studList = db.students.Where(x => x._class == clss_).ToList();

                    if (studList != null)
                    {
                        foreach (var std in studList)
                        {
                            var reg_number = std.reg_number;

                            //get a single student result list in a session and term
                            var resultList = db.results1.Where(x => x.reg_number == reg_number && x._class == clss_ && x.session == sess_).ToList();

                            if (resultList != null)
                            {
                                var rslt = resultList.First();
                                int student_id = rslt.id;
                                string student_reg_number = rslt.reg_number; ;
                                string student_name = rslt.name;
                                string student_class = rslt._class;
                                string result_term_pub = rslt.term;
                                string result_session_pub = rslt.session;
                                int? get_subjects_total = 0;


                                get_subjects_total = resultList.Sum(x => x.subject_total);

                                var students_subjects_average = get_subjects_total / number_of_subjects;


                                var posList = db.positions.Where
                                    (x => x._class == clss_ && x.reg_number == reg_number
                                    && x.term == term_ && x.session == sess_).ToList();

                                if (posList != null)
                                {
                                    MessageBox.Show("This result has already been published");
                                }
                                else
                                {
                                    var pst = new position()
                                    {
                                        reg_number = student_reg_number,
                                        name = student_name,
                                        _class = student_class,
                                        term = result_term_pub,
                                        session = result_session_pub,
                                        students_sub_total = get_subjects_total,
                                        students_sub_average = students_subjects_average,
                                        upload_date = DateTime.Now.ToString("d"),
                                        upload_time = DateTime.Now

                                    };

                                    db.positions.Add(pst);
                                    db.SaveChanges();


                                    var pstList2 = db.positions.Where
                                        (x => x._class == student_class
                                        && x.term == result_term_pub
                                        && x.session == result_session_pub)
                                        .OrderByDescending(x => x.students_sub_average).ToList();

                                    if (pstList2 != null)
                                    {
                                        for (int i = 0; i < pstList2.Count; i++)
                                        {
                                            var student_reg_no = pstList2[i].reg_number;
                                            var sub_avg = pstList2[i].students_sub_average;
                                            var sub_avg_class = pstList2[i]._class;
                                            var sub_avg_term = pstList2[i].term;

                                            var sub_avg_session = pstList2[i].session;

                                            var pstn = db.positions.Where(x => x.reg_number == student_reg_no && x._class == sub_avg_class && x.term == sub_avg_term && x.session == sub_avg_session).FirstOrDefault();

                                            if (pstn != null)
                                            {
                                                try
                                                {

                                                    pstn.class_position = i + 1;
                                                    db.SaveChanges();

                                                    MessageBox.Show("Result Publishing Successful");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Utils.LogException(ex);

                                                    MessageBox.Show("Result Publishing Failed!");

                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("No result records available for ranking!");
                                            }
                                        }
                                    }

                                }
                            }
                        }



                    }
                    else
                    {
                        MessageBox.Show("No Students Have been registered into " + clss_);
                    }

                }

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                _Classes = db.classes.ToList();
                sessions = db.sessions.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxClass.DataSource = _Classes;
            cBoxSession.DataSource = sessions;
        }
    }
}
