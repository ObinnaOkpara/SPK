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
    public partial class ViewPublishedResult : UserControl
    {
        List<_class> _listClass = new List<_class>();
        List<session> _listSession = new List<session>();
        public ViewPublishedResult()
        {
            InitializeComponent();


            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {

                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                cBoxTerm.Cursor = Cursors.WaitCursor;
                btnSearch.Cursor = Cursors.WaitCursor;


                backgroundWorker1.RunWorkerAsync();
            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                _listSession = db.sessions.ToList();
                _listClass = db.classes.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_listClass.Count < 1)
            {
                MessageBox.Show("No Class in the Database. \n Please, add Class first.");
                return;
            }
            if (_listSession.Count < 1)
            {
                MessageBox.Show("No Session in the Database. \n Please, add Session first.");
                return;
            }

            cBoxClass.DataSource = _listClass;
            cBoxSession.DataSource = _listSession;

            cBoxClass.Cursor = Cursors.Arrow;
            cBoxSession.Cursor = Cursors.Arrow;
            btnSearch.Cursor = Cursors.Arrow;
        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this,errorProvider1))
            {
                var _class = cBoxClass.Text;
                var _session = cBoxSession.Text;
                var _term = cBoxTerm.Text;


            }
        }
    }
}
