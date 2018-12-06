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
using DB.Services.Interfaces;
using DB.Services.DataRepository;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class SpecifySssSubject : UserControl
    {
        private List<sss> _listClass;
        private List<school_subjects> _listSubjects;
        private IUnitOfWork _unitOfWork;
        public SpecifySssSubject()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new Model1());

            dGridSubjecs.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _listSubjects = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
            using (var db = new Model1())
            {
                _listClass = db.ssses.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxSubject.DataSource = _listSubjects;

            dGridSubjecs.DataSource = _listClass;
            dGridSubjecs.Cursor = Cursors.Arrow;
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this,errorProvider1))
            {
                var subj = new sss()
                {
                    sss_subjects = cBoxSubject.Text,
                    upload_date = DateTime.Now.ToString("d"),
                    upload_time = DateTime.Now
                };

                using (var db = new Model1())
                {
                    var isExist = db.ssses.Any(x => x.sss_subjects == subj.sss_subjects);
                    if (!isExist)
                    {
                        db.ssses.Add(subj);
                        db.SaveChanges();

                        dGridSubjecs.DataSource = db.ssses.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Subject already exists");
                    }
                                        
                }
            }
        }
    }
}
