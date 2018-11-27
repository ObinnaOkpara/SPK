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

namespace SPK.UserControls.SubForms
{
    public partial class ViewPublishedResult : UserControl
    {
        List<_class> _listClass = new List<_class>();
        List<session> _listSession = new List<session>();
        public ViewPublishedResult()
        {
            InitializeComponent();

            cBoxClass.Cursor = Cursors.WaitCursor;
            cBoxSession.Cursor = Cursors.WaitCursor;
            cBoxTerm.Cursor = Cursors.WaitCursor;
            btnSearch.Cursor = Cursors.WaitCursor;

            backgroundWorker1.RunWorkerAsync();

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
    }
}
