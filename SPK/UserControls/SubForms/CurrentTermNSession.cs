using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPK.Utilities;
using DB;

namespace SPK.UserControls.SubForms
{
    public partial class CurrentTermNSession : UserControl
    {
        private List<session> sessions;
        public CurrentTermNSession()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this,errorProvider1))
            {
                var term = cBoxTerm.Text;
                var sess = cBoxSession.Text;

                try
                {
                    using (var db = new Model1())
                    {
                        var seas = db.current_season.FirstOrDefault();

                        if (seas != null)
                        {
                            seas.current_session = sess;
                            seas.current_term = term;
                            seas.date_declared = DateTime.Now.ToString("d");
                            seas.time_declared = DateTime.Today;

                            db.SaveChanges();

                            MessageBox.Show("Term And Session Updated");


                        }
                        else
                        {
                            MessageBox.Show("Term And Session not yet set");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error has occured. Please contact support");
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                sessions = db.sessions.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sessions != null)
            {
                cBoxSession.DataSource = sessions;
            }
        }
    }
}
