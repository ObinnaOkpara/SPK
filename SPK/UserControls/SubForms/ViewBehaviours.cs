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
    public partial class ViewBehaviours : UserControl
    {
        List<session> ListSessions = new List<session>();
        List<_class> ListClasses = new List<_class>();


        public ViewBehaviours()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                cBoxTerm.Cursor = Cursors.WaitCursor;

                backgroundWorker1.RunWorkerAsync();

            }
        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {

        }

        private void btnDelete_ClickEvent(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
