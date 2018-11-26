using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class frmSlipReport : Form
    {
        string appPath = "";
        public frmSlipReport()
        {
            InitializeComponent();
        }

        private void frmSlipReport_Load(object sender, EventArgs e)
        {
            appPath = Properties.Settings.Default.ImagePath;

            var sch = new administrative();
            var stu = new student();

            using (var db = new Model1())
            {
                sch =db.administratives.FirstOrDefault();
                stu =db.students.FirstOrDefault();
            }

            var p = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            
            //p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Schoollogo", Path.Combine(appPath, sch.school_logo)));
            //p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Studentimg", Path.Combine(appPath, stu.passport)));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Schoollogo", @"C:\Users\User\OneDrive\""Visual Studio 2017""\Projects\SPK\SPK\Resources\command.jpeg"));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Studentimg", @"C:\Users\User\OneDrive\""Visual Studio 2017""\Projects\SPK\SPK\Resources\student5.jpeg"));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Schoolname", sch.school_name));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Schoolmotto", sch.school_motto));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Surname", stu.lastname));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Firstname", stu.firstname));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Othername", stu.othername));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Sex", stu.gender));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("State", stu.state));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Nationality", stu.nationality));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Fathername", stu.father_name));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Mothername", stu.mother_name));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Birthday", stu.dob));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Birthmonth", stu.mob));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Birthyear", stu.yob));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Studentphone", stu.contact_phone));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Contact1", stu.nearest_contact1));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Contact2", stu.nearest_contact2));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Contact3", stu.nearest_contact3));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Healthconditions", stu.health_conditions));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Address", stu.address));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Fatherphone", stu.father_phone));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Motherphone", stu.mother_phone));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Fatheroccupation", stu.father_occupation));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Motheroccupation", stu.mother_occupation));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Regnumber", stu.reg_number));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Password", stu.gen_password));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Class", stu._class));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Sponsorname", stu.sponsor_name));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Sponsorphone", stu.sponsor_phone));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Sponsorrelation", stu.relationship));
            p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Regdate", stu.reg_number));

            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(p);

            this.reportViewer1.RefreshReport();
        }
    }
}
