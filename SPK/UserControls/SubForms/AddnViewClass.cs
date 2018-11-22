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
using DB.Services.DataRepository;

namespace SPK.UserControls.SubForms
{
    public partial class AddnViewClass : UserControl
    {
        List<_class> classes = new List<_class>();

        public AddnViewClass()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                dGridAllClass.Cursor = Cursors.WaitCursor;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1))
            {

                var _unitOfWork = new UnitOfWork(new Model1());
                if( _unitOfWork.dClassRepository.CheckIfItExists(_txtClassName.Text.Trim()))
                {
                    MessageBox.Show("This class already exists.");
                    return;
                }

                var cl = new _class()
                {
                    classes = _txtClassName.Text.Trim(),
                    date_added = DateTime.Today.ToString("d"),
                    time_added = DateTime.Now
                };

                _unitOfWork.dClassRepository.Add(cl);
                _unitOfWork.Save();
                _unitOfWork.Dispose();
                MessageBox.Show("Class Added Successfully");

                using (var db = new Model1())
                {
                    classes = db.classes.ToList();
                    dGridAllClass.DataSource = classes;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                classes = db.classes.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dGridAllClass.DataSource = classes;
            dGridAllClass.Cursor = Cursors.Arrow;
        }

        private void dGridAllClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
