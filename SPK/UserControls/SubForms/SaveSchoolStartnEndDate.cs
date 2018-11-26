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
    public partial class SaveSchoolStartnEndDate : UserControl
    {
        public SaveSchoolStartnEndDate()
        {
            InitializeComponent();
        }

        int CompareDates(string date1, string date2)
        {
            DateTime d1 = DateTime.Parse(date1);
            DateTime d2 = DateTime.Parse(date2);
            return DateTime.Compare(d1, d2);
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            var result = CompareDates(dateTimePicker1.Text, dateTimePicker2.Text);
            if (result > 0)
            {
                MessageBox.Show("Please make sure end of term is earlier than resumption of next term. Try again");
                return;
            }
            else if (result == 0)
            {
                MessageBox.Show("Please make sure both dates are not the same. Try again");
                return;
            }
            else
            {
                using (var db = new Model1())
                {
                    var dt = db.dates.FirstOrDefault();

                    if (dt != null)
                    {
                        dt.date_declared = DateTime.Now.ToString("d");
                        dt.next_term_begins = dateTimePicker2.Text;
                        dt.end_of_term = dateTimePicker1.Text;
                        dt.time_declared = DateTime.Now;

                        db.SaveChanges();
                        MessageBox.Show("Dates have been updated");
                    }
                    else
                    {
                        var newdate = new date()
                        {
                            date_declared = DateTime.Now.ToString("d"),
                            next_term_begins = dateTimePicker2.Text,
                            end_of_term = dateTimePicker1.Text,
                            time_declared = DateTime.Now
                        };
                        db.dates.Add(newdate);
                        db.SaveChanges();
                        MessageBox.Show("New Dates have been added");
                    }
                }

            }



        }
    }
}
