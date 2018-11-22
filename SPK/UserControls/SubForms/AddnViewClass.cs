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
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (btn.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

                    var _id = (int)senderGrid.CurrentRow.Cells[0].Value;
                    using (var db = new Model1())
                    {
                        var c = new _class() { id = _id };
                        db.classes.Attach(c);
                        db.classes.Remove(c);
                        db.SaveChanges();

                        classes = db.classes.ToList();
                        dGridAllClass.DataSource = classes;

                    }
                }
            }
        }
    }
}
