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
using DB.Services.Interfaces;
using DB.Services.DataRepository;

namespace SPK.UserControls.SubForms
{
    public partial class AllocateFees : UserControl
    {
        List<_class> classes = new List<_class>();
        List<fee_allocation> fees_allo = new List<fee_allocation>();

        private IUnitOfWork _unitOfWork;
        public AllocateFees()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new Model1());
            //if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)


            backgroundWorker1.RunWorkerAsync();
            cBoxClass.Cursor = Cursors.WaitCursor;

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                classes = db.classes.ToList();
                fees_allo = db.fee_allocation.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxClass.DataSource = classes;
            cBoxClass.DisplayMember = "classes";

            dGridStudents.DataSource = fees_allo;

            cBoxClass.Cursor = Cursors.Arrow;
            //  cBoxClass.Invalidate();
        }

        private void dGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (btn.Text == "Delete")
                {
                    var _id = (int)senderGrid.CurrentRow.Cells["id"].Value;
                    using (var db = new Model1())
                    {
                        var feee_allo = new fee_allocation() { id = _id };
                        db.fee_allocation.Attach(feee_allo);
                        db.fee_allocation.Remove(feee_allo);
                        db.SaveChanges();

                        fees_allo = db.fee_allocation.ToList();
                        dGridStudents.DataSource = fees_allo;

                    }
                }
                else if(btn.Text == "Edit")
                {
                    var _id = (int)senderGrid.CurrentRow.Cells["id"].Value;
                    using (var db = new Model1())
                    {
                       
                        var feee_allo = new fee_allocation() { id = _id };
                        db.fee_allocation.Attach(feee_allo);
                        db.fee_allocation.Remove(feee_allo);
                        db.SaveChanges();

                        fees_allo = db.fee_allocation.ToList();
                        dGridStudents.DataSource = fees_allo;

                    }
                }
            }
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1) &&
                ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {

            }

        }

        private fee_allocation CreateFeeAllocation()
        {
            var feeallo = new fee_allocation()
            {
                allocate_class = cBoxClass.Text,
                date_allocated = DateTime.Today.ToString("d"),
                fee_amount = Convert.ToInt32(txtFee.Text),
                student_type = cBoxType.Text
            };
            return feeallo;
        }
    }
}

