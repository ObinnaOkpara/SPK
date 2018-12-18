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
            try
            {
                if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
                {
                    var _class = cBoxClass.Text;
                    var _session = cBoxSession.Text;
                    var _term = cBoxTerm.Text;

                    using (var db = new Model1())
                    {
                        var positions = db.positions.Where(x => x._class == _class && x.session == _session && x.term == _term).ToList();

                        if (positions == null)
                        {
                            MessageBox.Show("No Found.");
                            return;
                        }

                        dgridPResults.DataSource = positions;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An Error Occured. Please, Contact Support.");
            }
            
        }

        private void btnDelete_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
                {
                    var rtn = MessageBox.Show("Are you sure you want to delete these data?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rtn != DialogResult.Yes)
                    {
                        return;
                    }

                    var _class = cBoxClass.Text;
                    var _session = cBoxSession.Text;
                    var _term = cBoxTerm.Text;

                    using (var db = new Model1())
                    {
                        var positions = db.positions.Where(x => x._class == _class && x.session == _session && x.term == _term);

                        if (positions == null)
                        {
                            MessageBox.Show("No Found.");
                            return;
                        }
                        else
                        {
                            db.positions.RemoveRange(positions);
                            db.SaveChanges();
                        }

                        dgridPResults.DataSource = new position();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An Error Occured. Please, Contact Support.");
            }
        }
    }
}
