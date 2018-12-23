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
    public partial class ViewAllResult : UserControl
    {

        List<results1> results;

        public ViewAllResult()
        {
            InitializeComponent();

        }

        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                try
                {
                    var _class = cBoxClass.Text;
                    var _session = cBoxSession.Text;
                    var _term = cBoxTerm.Text;
                    var _subj = cBoxSubject.Text;

                    Cursor = Cursors.WaitCursor;

                    using (var db = new Model1())
                    {
                        results = db.results1.Where(x => x._class == _class && x.session == _session && x.term == _term && x.subjects == _subj).ToList();

                        dGridStudents.DataSource = results;

                    }


                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("An error has occured. Please contact support");
                }
            }
        }

        private void btnDeleteAll_ClickEvent(object sender, EventArgs e)
        {
            if (dGridStudents.Rows.Count > 0)
            {
                using (var db = new Model1())
                {
                    try
                    {
                        var _class = cBoxClass.Text;
                        var _session = cBoxSession.Text;
                        var _term = cBoxTerm.Text;
                        var _subj = cBoxSubject.Text;
                        var listResult = db.results1.Where(x => x._class == _class && x.session == _session && x.term == _term && x.subjects == _subj);

                        db.results1.RemoveRange(listResult);

                        db.SaveChanges();

                        MessageBox.Show("Results deleted");

                    }
                    catch (Exception ex)
                    {

                        Utils.LogException(ex);
                        MessageBox.Show("An error has occured. Please contact support");
                    }
                }
            }
            else
            {
                MessageBox.Show("No results loaded. Please load results to delete");
            }
        }
    }
}
