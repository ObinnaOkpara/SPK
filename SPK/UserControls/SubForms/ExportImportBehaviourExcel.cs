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
using OfficeOpenXml;
using System.IO;

namespace SPK.UserControls.SubForms
{
    public partial class ExportImportBehaviourExcel : UserControl
    {
        List<_class> Classes = new List<_class>();
        List<session> Sessions = new List<session>();
        List<behavioral> behaviorals = new List<behavioral>();

        public ExportImportBehaviourExcel()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                btnExport.Cursor = Cursors.WaitCursor;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnExport_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new Model1())
                {
                    List<student> students = db.students.Where(x => x._class == cBoxClass.Text).ToList();
                    if (students.Count<1)
                    {
                        MessageBox.Show("No student in the selected class, Try again.");
                        Cursor = Cursors.Arrow;
                        return;
                    }

                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        excel.Workbook.Worksheets.Add("Worksheet1");

                        var headerRow = new List<string[]>()
                        {
                            new string[] {"S/N", "Reg No", "Name", "Class", "Term", "Session", "Hand Writing",
                                "Musical Skills", "Sports", "Attentiveness", "Attitude to work", "Health", "Politeness"}
                        };

                        var bodyRow = new List<string[]>();

                        for (int i = 0; i < students.Count; i++)
                        {
                            var s = students[i];

                            bodyRow.Add(new string[]
                            {
                                (i+1).ToString(), s.reg_number, s.Fullname, cBoxClass.Text, cBoxTerm.Text, cBoxSession.Text,
                                "", "", "", "", "", "", ""
                            });
                        }
                        
                        string headerRange = "A1:" + char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                        string bodyRange = "A2:" + char.ConvertFromUtf32(headerRow[0].Length + 64) + (bodyRow.Count + 1).ToString();

                        var workSheet = excel.Workbook.Worksheets["Worksheet1"];
                        workSheet.Cells[headerRange].LoadFromArrays(headerRow);
                        workSheet.Cells[bodyRange].LoadFromArrays(bodyRow);

                        workSheet.Cells[headerRange].Style.Font.Bold = true;

                        var fPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), cBoxClass.Text + ".xlsx");
                        FileInfo excelFile = new FileInfo(fPath);
                        excel.SaveAs(excelFile);

                        MessageBox.Show("Excel file saved at : \n" + fPath);
                    }
                }

                Cursor = Cursors.Arrow;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new Model1())
            {
                Sessions = db.sessions.ToList();
                Classes = db.classes.ToList();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Classes.Count < 1)
            {
                MessageBox.Show("No Class in the Database. \n Please, add Class first.");
                return;
            }
            if (Sessions.Count < 1)
            {
                MessageBox.Show("No Session in the Database. \n Please, add Session first.");
                return;
            }

            cBoxClass.DataSource = Classes;
            cBoxClass.DisplayMember = "classes";

            cBoxSession.DataSource = Sessions;
            cBoxSession.DisplayMember = "sessions";

            cBoxClass.Cursor = Cursors.Arrow;
            cBoxSession.Cursor = Cursors.Arrow;
            btnExport.Cursor = Cursors.Arrow;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select CSV File";
            opFile.Filter = "Data files (*.csv)|*.csv|All files (*.*)|*.*";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
