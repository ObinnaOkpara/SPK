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
            _unitOfWork = new UnitOfWork(new Model1());

            dgridAdmin.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
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
    }
}
