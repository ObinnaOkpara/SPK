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
using DB.Services.DataRepository;
using DB;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class AddSubject : UserControl
    {
        // private IUnitOfWork _unitOfWork;
        public AddSubject()
        {
            InitializeComponent();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1))
            {
                var _unitOfWork = new UnitOfWork(new Model1());
                var sch_subj = CreateSchoolSubject();
                if (!_unitOfWork.School_SubjectsRepository.CheckIfItExists(_txtSubject.Text))
                {
                    _unitOfWork.School_SubjectsRepository.Add(sch_subj);
                    _unitOfWork.Save();
                    _unitOfWork.Dispose();
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("Already Added");
                }
                
            }
        }

        private school_subjects CreateSchoolSubject()
        {
            var sch_subj = new school_subjects()
            {
                date_saved = DateTime.Today.ToString("d"),
                subjects = _txtSubject.Text
            };
            return sch_subj;
        }
    }
}
