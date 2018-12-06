using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.Services.DataRepository;
using DB.Services.Interfaces;
using DB;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class ViewSubjects : UserControl
    {
        private IUnitOfWork _unitOfWork;
        private List<school_subjects> schsubList;
        private int _id;
        public ViewSubjects()
        {
            InitializeComponent();

            backgroundWorker1.RunWorkerAsync();
            dGridAllClass.Cursor = Cursors.WaitCursor;
        }

        void DisplayData()
        {
            _unitOfWork = new UnitOfWork(new Model1());

            dGridAllClass.DataSource = _unitOfWork.School_SubjectsRepository.FindAll().ToList();

            _unitOfWork.Dispose();
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1))
            {
                _unitOfWork = new UnitOfWork(new Model1());
                var ss = _unitOfWork.School_SubjectsRepository.FindById(_id).Result;

                ss.subjects = txtSubject.Text;
                _unitOfWork.Save();
                dGridAllClass.DataSource = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
                LoadSerial();
                _unitOfWork.Dispose();

                btnSave.Enabled = false;
                txtSubject.Text = string.Empty;
                txtSubject.Enabled = false;
                MessageBox.Show("Subject Updated");
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _unitOfWork = new UnitOfWork(new Model1());

            schsubList = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dGridAllClass.DataSource = schsubList;
            LoadSerial();
            dGridAllClass.Cursor = Cursors.Arrow;
        }

        private void LoadSerial()
        {
            int i = 1;
            foreach (DataGridViewRow row in dGridAllClass.Rows)
            {
                row.Cells["SNo"].Value = i; i++;
            }
        }

        private void dGridAllClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var es = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];

                if (btn.Text == "Edit")
                {
                    btnSave.Enabled = true;
                    txtSubject.Enabled = true;
                    txtSubject.Focus();


                    _id = (int)senderGrid.CurrentRow.Cells["id"].Value;

                    txtSubject.Text = (string)senderGrid.CurrentRow.Cells[2].Value;


                }
                else if (btn.Text == "Delete")
                {

                    var result = MessageBox.Show("Do you want to delete ", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _unitOfWork = new UnitOfWork(new Model1());
                        var _id = (int)senderGrid.CurrentRow.Cells["id"].Value;
                        var ss = _unitOfWork.School_SubjectsRepository.FindById(_id).Result;
                        _unitOfWork.School_SubjectsRepository.Remove(ss);

                        _unitOfWork.Save();

                        MessageBox.Show("Deleted");
                        dGridAllClass.DataSource = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
                        LoadSerial();
                    }
                    

                }
            }
        }
    }
}

