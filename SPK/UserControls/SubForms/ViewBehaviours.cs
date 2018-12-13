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
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                var class_ = cBoxClass.Text;
                var term_ = cBoxTerm.Text;
                var session_ = cBoxSession.Text;


                try
                {
                    using (var db = new Model1())
                    {
                        dGridBehaviour.Cursor = Cursors.WaitCursor;
                        var bhv = db.behaviorals.Where(x => x._class == class_ && x.term == term_ && x.session == session_).ToList();

                        if (bhv != null)
                        {
                            dGridBehaviour.DataSource = bhv;

                            dGridBehaviour.Cursor = Cursors.Arrow;
                        }
                        else
                        {
                            MessageBox.Show("No records found.");
                        }

                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("No records found.");
                }
            }


        }

        private void btnDelete_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                var class_ = cBoxClass.Text;
                var term_ = cBoxTerm.Text;
                var session_ = cBoxSession.Text;


                try
                {
                    using (var db = new Model1())
                    {

                        dGridBehaviour.Cursor = Cursors.WaitCursor;
                        var bhv = db.behaviorals.Where(x => x._class == class_ && x.term == term_ && x.session == session_);

                        if (bhv != null)
                        {

                            db.behaviorals.RemoveRange(bhv);
                            db.SaveChanges();

                            dGridBehaviour.Cursor = Cursors.Arrow;
                            MessageBox.Show("Records deleted");
                        }
                        else
                        {
                            MessageBox.Show("No records to delete.");
                        }

                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("An error ocurred. Please contact support");
                }
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
