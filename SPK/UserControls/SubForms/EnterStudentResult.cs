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
        private List<student> students;
        private List<_class> _Classes;
        private List<subject> subjects;
        private List<session> sessions;
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
                students = _unitOfWork.StudentRepository.FindAll().Where(x => x._class == cBoxClass.Text).ToList();

                dgridStudents.DataSource = students;
            }
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                sessions = _unitOfWork.SessionRepository.FindAll().ToList();
                subjects = _unitOfWork.SubjectsRepository.FindAll().ToList();
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
            cBoxClass.DataSource = _Classes;
            cBoxSession.DataSource = sessions;
            cBoxSubject.DataSource = subjects;
            
        }
    }
}
