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
    public partial class PromoteClass : UserControl
    {
        List<_class> Classes = new List<_class>();

        public PromoteClass()
        {
            InitializeComponent();
            cboxToClass.Cursor = Cursors.WaitCursor;
            cboxFrom.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                Classes = db.classes.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cboxToClass.DataSource = Classes;
            cboxToClass.DisplayMember = "classes";
            cboxFrom.DataSource = Classes;
            cboxFrom.DisplayMember = "classes";
            cboxToClass.Cursor = Cursors.Arrow;
            cboxFrom.Cursor = Cursors.Arrow;
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if(Utilities.ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new Model1())
                {
                    var students = db.students.Where(x => x._class == cboxFrom.Text);
                    if (students.Count()<1)
                    {
                        MessageBox.Show("No student in this class.");
                    }
                    else
                    {
                        foreach (var s in students)
                        {
                            s._class = cboxToClass.Text;
                        }
                        db.SaveChanges();

                        MessageBox.Show("Students promoted successfully.");
                    }
                }

                Cursor = Cursors.Arrow ;
            }
        }
    }
}
