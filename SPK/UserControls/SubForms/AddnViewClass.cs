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
using DB.Services.Interfaces;

namespace SPK.UserControls.SubForms
{
    public partial class AddnViewClass : UserControl
    {
        List<_class> classes = new List<_class>();
        private IUnitOfWork _unitOfWork;
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
                try
                {
                    var _unitOfWork = new UnitOfWork(new Model1());
                    if (_unitOfWork.dClassRepository.CheckIfItExists(_txtClassName.Text.Trim()))
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
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Contact support");
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

        private async void dGridAllClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var es = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            try
            {

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];

                    if (btn.Text == "Delete")
                    {

                        var result = MessageBox.Show("Do you want to delete ", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            _unitOfWork = new UnitOfWork(new Model1());
                            var _idDel = (int)senderGrid.CurrentRow.Cells[0].Value;
                            var ss = await _unitOfWork.dClassRepository.FindById(_idDel);
                            _unitOfWork.dClassRepository.Remove(ss);

                           await _unitOfWork.Save();

                            MessageBox.Show("Deleted");
                            dGridAllClass.DataSource = _unitOfWork.dClassRepository.FindAll().ToList();

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured. Please contact support");
            }
        }
    }
}
