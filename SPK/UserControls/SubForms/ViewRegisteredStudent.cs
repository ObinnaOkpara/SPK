using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.Services.Interfaces;
using DB;
using DB.Services.DataRepository;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class ViewRegisteredStudent : UserControl
    {
        private IUnitOfWork _unitOfWork;
        private List<student> _studentList;
        private List<school_subjects> _listSubject;
        private List<_class> _listClassess;
        private List<session> _listSessions;
        public ViewRegisteredStudent()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork(new Model1());

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

           // _studentList = _unitOfWork.StudentRepository.FindAll().ToList();
            _listSubject = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
            _listClassess = _unitOfWork.dClassRepository.FindAll().ToList();
            _listSessions = _unitOfWork.SessionRepository.FindAll().ToList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //  dGridStudents.DataSource = _studentList;
            cBoxSession.DataSource = _listSessions;
            cBoxClass.DataSource = _listClassess;
            cBoxSubject.DataSource = _listSubject;
        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this,errorProvider1))
            {
                var _class = cBoxClass.Text;
                var _subject = cBoxSubject.Text;
                var _term = cBoxTerm.Text;
                var _session = cBoxSession.Text;

                var subList = _unitOfWork.SubjectsRepository.FindAll().Where(
                    s => s._class == _class &&
                    s.subjects == _subject &&
                    s.term == _term &&
                    s.session == _session).ToList();

                if (subList.Any())
                {
                    dGridStudents.DataSource = subList;
                }
                else
                {
                    MessageBox.Show("No information to display");
                }

                
            }
        }
    }
}
