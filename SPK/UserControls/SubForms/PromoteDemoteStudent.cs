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

namespace SPK.UserControls.SubForms
{
    public partial class PromoteDemoteStudent : UserControl
    {
        List<_class> Classes = new List<_class>();

        public PromoteDemoteStudent()
        {
            InitializeComponent();
            cboxToClass.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void _txtRegNumber_TextChanged(object sender, EventArgs e)
        {
            btnFind.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    Classes = db.classes.ToList();
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
            cboxToClass.DataSource = Classes;
            cboxToClass.DisplayMember = "classes";
            cboxToClass.Cursor = Cursors.Arrow;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    var stu = db.students.FirstOrDefault(x => x.reg_number == _txtRegNumber.Text);

                    if (stu == null) MessageBox.Show("No student was found with this reg number.");
                    else
                    {
                        _txtCurClass.Text = stu._class;
                        btnFind.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support.");
            }
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1) && ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                if (btnFind.Enabled)
                {
                    MessageBox.Show("Click Find to make sure the reg number exists first.");
                    return;
                }
                var rtn = MessageBox.Show($"Are you sure you want to move this student from {_txtCurClass.Text} to {cboxToClass.Text}?", "", MessageBoxButtons.YesNo);
                if (rtn == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new Model1())
                        {
                            var stu = db.students.FirstOrDefault(x => x.reg_number == _txtRegNumber.Text);

                            if (stu == null) MessageBox.Show("No student was found with this reg number.");
                            else
                            {
                                stu._class = cboxToClass.Text;
                                db.SaveChanges();
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
    }
}
