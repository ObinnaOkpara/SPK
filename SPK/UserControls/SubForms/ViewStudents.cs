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
    public partial class ViewStudents : UserControl
    {
        List<_class> _Classes;
        private UnitOfWork _unitOfWork;

        public ViewStudents()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                backgroundWorker1.RunWorkerAsync();
                cBoxClass.Cursor = Cursors.WaitCursor;
            }
        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                try
                {
                    using (var db = new Model1())
                    {
                        var cls = cBoxClass.Text;
                        dGridStudents.DataSource = db.students.Where(x => x._class == cls).ToList();
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    _Classes = db.classes.ToList();
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support.");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxClass.DataSource = _Classes;
            cBoxClass.Cursor = Cursors.Arrow;
        }

        private void dGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            var ss = _unitOfWork.StudentRepository.FindById(_idDel).Result;
                            _unitOfWork.StudentRepository.Remove(ss);

                            _unitOfWork.Save();

                            MessageBox.Show("Deleted");
                            dGridStudents.DataSource = _unitOfWork.StudentRepository.FindAll().ToList();

                        }


                    }
                    else if (btn.Text == "SLIP")
                    {
                        _unitOfWork = new UnitOfWork(new Model1());
                        var _idStudent = (int)senderGrid.CurrentRow.Cells[0].Value;

                        var slip = new frmSlipReport(_idStudent);

                        slip.Show();
                        
                    }
                    else if (btn.Text == "Edit")
                    {
                        _unitOfWork = new UnitOfWork(new Model1());
                        var _idStudent = (int)senderGrid.CurrentRow.Cells[0].Value;

                        var editfrm = new EditStudent(_idStudent);

                        var newform = new Form();
                        newform.Size = new Size(800, 580);
                        newform.StartPosition = FormStartPosition.CenterScreen;
                        
                        newform.Controls.Add(editfrm);

                        editfrm.Dock = DockStyle.Fill;

                        newform.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support.");
            }


        }
    }

}