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
            using (var db = new Model1())
            {
                
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
