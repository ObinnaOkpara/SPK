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

           
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                 _unitOfWork = new UnitOfWork(new Model1());
                backgroundWorker1.RunWorkerAsync();
                cBoxClass.Cursor = Cursors.WaitCursor;
                dGridStudents.Cursor = Cursors.WaitCursor;
            }


            

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    classes = db.classes.ToList();
                    fees_allo = db.fee_allocation.ToList();
                }

            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact Support");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxClass.DataSource = classes;
            cBoxClass.DisplayMember = "classes";

            dGridStudents.DataSource = fees_allo;

            cBoxClass.Cursor = Cursors.Arrow;
            dGridStudents.Cursor = Cursors.Arrow;
            //  cBoxClass.Invalidate();
        }

        //private void dGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    var senderGrid = (DataGridView)sender;
        //    var es = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];


        //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
        //    {
        //        var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];

        //        if (btn.Text == "Delete")
        //        {
        //            var _id = (int)senderGrid.CurrentRow.Cells["id"].Value;
        //            using (var db = new Model1())
        //            {
        //                var feee_allo = new fee_allocation() { id = _id };
        //                db.fee_allocation.Attach(feee_allo);
        //                db.fee_allocation.Remove(feee_allo);
        //                db.SaveChanges();

        //                fees_allo = db.fee_allocation.ToList();
        //                dGridStudents.DataSource = fees_allo;

        //            }
        //        }
        //        else if (btn.Text == "Edit")
        //        {
        //            btn.Text = "Update";
        //        }
        //    }

        //}

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1) &&
                ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                try
                {
                    var feea = CreateFeeAllocation();
                    using (var db = new Model1())
                    {
                        db.fee_allocation.Add(feea);
                        db.SaveChanges();
                        dGridStudents.DataSource = db.fee_allocation.ToList();
                        MessageBox.Show("New Fee Allocation Added");
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("An error occured. Contact Support");
                }
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

        private void dGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridStudents.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dGridStudents.SelectedRows) // foreach datagridview selected rows values  
                {
                    txtIDedit.Text = row.Cells[0].Value.ToString();
                    txteditclas.Text = row.Cells[1].Value.ToString();
                    txtedittype.Text = row.Cells[2].Value.ToString();
                    txtFeeedit.Text = row.Cells[3].Value.ToString();
                }
            }
        }

        private void btnUpdate_ClickEvent(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace( txtFeeedit.Text))
            {
                try
                {
                    using (var db = new Model1())
                    {
                        var id = Convert.ToInt32(txtIDedit.Text);
                        var feeallo = db.fee_allocation.Find(id);

                        if (feeallo != null)
                        {
                            feeallo.fee_amount = Convert.ToInt32(txtFeeedit.Text);
                            db.SaveChanges();
                            MessageBox.Show("Fees Updated");
                            dGridStudents.DataSource = db.fee_allocation.ToList();
                        }
                        else
                        {
                            MessageBox.Show("An error occured. Please contact support");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("An error occured. Please contact support");
                }
            }
            else
            {
                MessageBox.Show("Please input a value in the field");
            }
           
        }

        private void dGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var es = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];

                if (btn.Text == "Delete")
                {
                    if (senderGrid.CurrentRow != null)
                    {
                        var _id = (int)senderGrid.CurrentRow.Cells["id"].Value;

                        try
                        {

                            using (var db = new Model1())
                            {
                                var feee_allo = new fee_allocation() { id = _id };
                                db.fee_allocation.Attach(feee_allo);
                                db.fee_allocation.Remove(feee_allo);
                                db.SaveChanges();

                                fees_allo = db.fee_allocation.ToList();
                                MessageBox.Show("Deleted");
                                dGridStudents.DataSource = fees_allo;

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
        }

        //private void dGridStudents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //    {
        //        if (_cellformat == false)
        //        {
        //            foreach (DataGridViewRow Myrow in dGridStudents.Rows)
        //            {
        //                Myrow.Cells[5].Value = "Edit";

        //            }
        //        }
        //      //  

        //    }
    }
}

