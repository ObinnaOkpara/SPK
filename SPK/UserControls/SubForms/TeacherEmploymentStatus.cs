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
    public partial class TeacherEmploymentStatus : UserControl
    {
        List<teacher> _teachers = new List<teacher>();

        public TeacherEmploymentStatus()
        {
            InitializeComponent();

            dGridTeachers.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    _teachers = db.teachers.ToList();
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
            dGridTeachers.DataSource = _teachers;
            dGridTeachers.Cursor = Cursors.Arrow;
        }

        private void dGridTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (btn.Text == "Save Changes")
                {
                    var _id = (int)senderGrid.CurrentRow.Cells[0].Value;
                    var status = (string)senderGrid.CurrentRow.Cells[7].Value;
                    try
                    {
                        using (var db = new Model1())
                        {
                            var T = db.teachers.Find(_id);
                            T.status = status;
                            db.SaveChanges();

                            _teachers = db.teachers.ToList();
                            dGridTeachers.DataSource = _teachers;

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
