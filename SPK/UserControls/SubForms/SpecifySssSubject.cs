﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using DB.Services.Interfaces;
using DB.Services.DataRepository;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class SpecifySssSubject : UserControl
    {
        private List<sss> _listClass;
        private List<school_subjects> _listSubjects;
        private IUnitOfWork _unitOfWork;
        public SpecifySssSubject()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new Model1());

            dGridSubjecs.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _listSubjects = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
                using (var db = new Model1())
                {
                    _listClass = db.ssses.ToList();
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
            cBoxSubject.DataSource = _listSubjects;

            dGridSubjecs.DataSource = _listClass;
            dGridSubjecs.Cursor = Cursors.Arrow;
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                var subj = new sss()
                {
                    sss_subjects = cBoxSubject.Text,
                    upload_date = DateTime.Now.ToString("d"),
                    upload_time = DateTime.Now
                };
                try
                {
                    using (var db = new Model1())
                    {
                        var isExist = db.ssses.Any(x => x.sss_subjects == subj.sss_subjects);
                        if (!isExist)
                        {
                            db.ssses.Add(subj);
                            db.SaveChanges();

                            dGridSubjecs.DataSource = db.ssses.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Subject already exists");
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

        private void dGridSubjecs_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            var _idDel = (int)senderGrid.CurrentRow.Cells[0].Value;

                            using (var db = new Model1())
                            {

                                var ss = db.ssses.Find(_idDel);
                                db.ssses.Remove(ss);
                                db.SaveChanges();

                                MessageBox.Show("Subject Deleted");
                                dGridSubjecs.DataSource = db.ssses.ToList();
                            }



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
