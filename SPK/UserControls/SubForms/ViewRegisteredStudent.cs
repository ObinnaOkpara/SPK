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

namespace SPK.UserControls.SubForms
{
    public partial class ViewRegisteredStudent : UserControl
    {
        private IUnitOfWork _unitOfWork;
        private List<student> _studentList;
        public ViewRegisteredStudent()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork(new Model1());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _studentList = _unitOfWork.StudentRepository.FindAll().ToList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dGridStudents.DataSource = _studentList;
        }
    }
}
