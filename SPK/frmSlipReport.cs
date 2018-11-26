using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class frmSlipReport : Form
    {
        public frmSlipReport()
        {
            InitializeComponent();
        }

        private void frmSlipReport_Load(object sender, EventArgs e)
        {
            var schDset = new List<administrative>();
            var stuDset = new List<student>();

            using (var db = new Model1())
            {
                schDset.Add(db.administratives.FirstOrDefault());
                stuDset.Add(db.students.FirstOrDefault());
            }

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("schoolDataset", schDset));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("StudentDataset", stuDset));
            this.reportViewer1.RefreshReport();
        }
    }
}
