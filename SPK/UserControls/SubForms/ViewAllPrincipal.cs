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
using DB.Services.Interfaces;
using DB.Services.DataRepository;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class ViewAllPrincipal : UserControl
    {
        public List<principal> _principalList;
        private IUnitOfWork _unitOfWork; 
        public ViewAllPrincipal()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork(new Model1());
            backgroundWorker1.RunWorkerAsync();           
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            _principalList = _unitOfWork.PrincipalRepository.FindAll().ToList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dGridPrincipals.DataSource = _principalList;
        }

        private void dGridPrincipals_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Utils.LoadSerial(dGridPrincipals);
        }

        private void dGridPrincipals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                var name = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString() + " " 
                    + senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                var result = MessageBox.Show("Do you want to delete " + name,"Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var pr = _unitOfWork.PrincipalRepository.FindById(id).Result;
                    _unitOfWork.PrincipalRepository.Remove(pr);
                    _unitOfWork.Save();
                     MessageBox.Show("Deleted");
                }

            
                //TODO - Button Clicked - Execute Code Here
            }
            
        }
    }
}
