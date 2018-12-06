using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.Services.Interfaces;
using DB.Services.DataRepository;
using DB;

namespace SPK.UserControls.SubForms
{
    public partial class ViewAdmins : UserControl
    {
        public IUnitOfWork _unitOfWork;
        private List<user> _ListAdmins;
        public ViewAdmins()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                _unitOfWork = new UnitOfWork(new Model1());

                dgridAdmin.Cursor = Cursors.WaitCursor;
                backgroundWorker1.RunWorkerAsync();

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _ListAdmins = _unitOfWork.UserRepository.FindAll().ToList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgridAdmin.Cursor = Cursors.Arrow;
            dgridAdmin.DataSource = _ListAdmins;
        }

        private void dgridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];

                if (btn.Text == "Delete")
                {

                    var _id = (int)senderGrid.CurrentRow.Cells[0].Value;
                    var name = (string)senderGrid.CurrentRow.Cells[1].Value;

                    var result = MessageBox.Show("Do you want to delete " + name, "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var ad = _unitOfWork.UserRepository.FindById(_id).Result;
                        _unitOfWork.UserRepository.Remove(ad);

                        _unitOfWork.Save();

                        MessageBox.Show("Deleted");

                        dgridAdmin.DataSource = _unitOfWork.UserRepository.FindAll().ToList();
                    }                   

                }
            }
        }
    }
}
