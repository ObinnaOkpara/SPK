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
    public partial class AllocateFees : UserControl
    {
        public AllocateFees()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime )
            {
               
                Task.Run(() =>
                {
                    using (var db = new Model1())
                    {
                        cBoxClass.DataSource = db.classes.ToList();
                        cBoxClass.DisplayMember = "classes";
                        cBoxClass.Invalidate();
                    }
                    MessageBox.Show("Started");

                    MessageBox.Show("Done");

                });
            }

        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
           
        }
    }
}
