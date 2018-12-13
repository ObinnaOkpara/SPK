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
using Microsoft.Reporting.WinForms;

namespace SPK
{
    public partial class frmSlipReport : Form
    {
        string appPath = "";
        int studentId;
        public frmSlipReport(int StudentId)
        {
            InitializeComponent();
            studentId = StudentId;
        }

        private void frmSlipReport_Load(object sender, EventArgs e)
        {
            appPath = Properties.Settings.Default.ImagePath;

            var sch = new administrative();
            var stu = new student();

            using (var db = new Model1())
            {
                sch =db.administratives.FirstOrDefault();
                stu =db.students.Find(studentId);
            }

            var p = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            
            if (sch != null)
            {
                var schLogo = Path.Combine(appPath, sch.school_logo);

                if (File.Exists(schLogo))
                {
                    p.Add(new ReportParameter("Schoollogo", schLogo));
                }
                else
                {
                    p.Add(new ReportParameter("Schoollogo", Path.Combine(Application.StartupPath, "noImageFound.png")));
                }

                p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Schoolname", sch.school_name));
                p.Add(new Microsoft.Reporting.WinForms.ReportParameter("Schoolmotto", sch.school_motto));
            }

            if (stu != null)
            {
                var stuPassport = Path.Combine(appPath, stu.passport);
                if (File.Exists(stuPassport))
                {
                    p.Add(new ReportParameter("Studentimg", stuPassport));
                }
                else
                {
                    p.Add(new ReportParameter("Studentimg", Path.Combine(Application.StartupPath, "noImageFound.png")));
                }

                p.Add(new ReportParameter("Surname", stu.lastname));
                p.Add(new ReportParameter("Firstname", stu.firstname));
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
            }

            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(p);

            this.reportViewer1.RefreshReport();
        }
    }
}
