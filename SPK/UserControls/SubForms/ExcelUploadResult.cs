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
using DB.Services.DataRepository;
using DB.Services.Interfaces;
using SPK.Utilities;
using OfficeOpenXml;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace SPK.UserControls.SubForms
{
    public partial class ExcelUploadResult : UserControl
    {
        private List<student> students;
        private List<_class> _Classes;
        private List<subject> subjects;
        private List<session> sessions;

        private IUnitOfWork _unitOfWork;

        string fullFileName = "";

        public ExcelUploadResult()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSession.Cursor = Cursors.WaitCursor;
                cBoxSubject.Cursor = Cursors.WaitCursor;

                _unitOfWork = new UnitOfWork(new Model1());

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                sessions = _unitOfWork.SessionRepository.FindAll().ToList();
                subjects = _unitOfWork.SubjectsRepository.FindAll().ToList();
                _Classes = _unitOfWork.dClassRepository.FindAll().ToList();

            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured. Please contact support");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxClass.DataSource = _Classes;
            cBoxSession.DataSource = sessions;
            cBoxSubject.DataSource = subjects;
            
            cBoxClass.Cursor = Cursors.Arrow;
            cBoxSession.Cursor = Cursors.Arrow;
            cBoxSubject.Cursor = Cursors.Arrow;
        }

        private void btnExport_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                Cursor = Cursors.WaitCursor;

                try
                {
                    using (var db = new Model1())
                    {
                        List<student> students = db.students.Where(x => x._class == cBoxClass.Text).ToList();
                        if (students.Count < 1)
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
                            new string[] {"S/N", "Class", "Term", "Session", "Reg No", "Name", "Subject",
                                "1ST CA", "2ND CA", "Exam score"}
                        };

                            var bodyRow = new List<string[]>();

                            for (int i = 0; i < students.Count; i++)
                            {
                                var s = students[i];

                                bodyRow.Add(new string[]
                                {
                                (i+1).ToString(), cBoxClass.Text, cBoxTerm.Text, cBoxSession.Text, s.reg_number, s.Fullname,
                                cBoxSubject.Text, "", "", ""
                                });
                            }

                            string headerRange = "A1:" + char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                            string bodyRange = "A2:" + char.ConvertFromUtf32(headerRow[0].Length + 64) + (bodyRow.Count + 1).ToString();

                            var workSheet = excel.Workbook.Worksheets["Worksheet1"];
                            workSheet.Cells[headerRange].LoadFromArrays(headerRow);
                            workSheet.Cells[bodyRange].LoadFromArrays(bodyRow);

                            workSheet.Cells[headerRange].Style.Font.Bold = true;

                            var fPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), cBoxClass.Text + cBoxSubject.Text + "Resullt.xlsx");
                            FileInfo excelFile = new FileInfo(fPath);
                            excel.SaveAs(excelFile);

                            MessageBox.Show("Excel file saved at : \n" + fPath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }


                Cursor = Cursors.Arrow;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var opFile = new OpenFileDialog();
                opFile.Title = "Select CSV File";
                opFile.Filter = "Data files (*.csv)|*.csv";

                if (opFile.ShowDialog() == DialogResult.OK)
                {
                    fullFileName = opFile.FileName;
                    txtFilename.Text = opFile.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured. \n");
            }
            Cursor = Cursors.Arrow;
        }

        private void btnImport_ClickEvent(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (string.IsNullOrWhiteSpace(txtFilename.Text))
                {
                    MessageBox.Show("Click 'Browse' to select file first.");
                    Cursor = Cursors.Arrow;
                    return;
                }

                if (fullFileName.EndsWith(".csv"))
                {
                    List<results1> results = new List<results1>();
                    using (TextFieldParser csvParser = new TextFieldParser(fullFileName))
                    {
                        var text = File.ReadAllText(fullFileName);

                        if (text.Contains(';') && !text.Contains(',')) csvParser.SetDelimiters(new string[] { ";" });
                        else csvParser.SetDelimiters(new string[] { "," });

                        csvParser.CommentTokens = new string[] { "#" };
                        csvParser.HasFieldsEnclosedInQuotes = true;

                        // Skip the row with the column names
                        string[] fields = csvParser.ReadFields();

                        Debug.Assert(fields != null, nameof(fields) + " != null");

                        if (fields.Length != 10)
                        {
                            MessageBox.Show("Invalid Format. Check the file and try again.");
                            Cursor = Cursors.Arrow;
                            return;
                        }

                        if (fields[9] != "Exam score")
                        {
                            MessageBox.Show("Invalid Format. Check the file and try again.");
                            Cursor = Cursors.Arrow;
                            return;
                        }

                        while (!csvParser.EndOfData)
                        {
                            // Read current line fields, pointer moves to the next line.
                            fields = csvParser.ReadFields();

                            if (fields.Any(x => string.IsNullOrWhiteSpace(x)))
                            {
                                MessageBox.Show("Some fields are not filled. Fill them and try again.");
                                Cursor = Cursors.Arrow;
                                return;
                            }
                            try
                            {
                                results.Add(new results1()
                                {
                                    _class = fields[1],
                                    term = fields[2],
                                    session = fields[3],
                                    reg_number = fields[4],
                                    name = fields[5],
                                    subjects = fields[6],
                                    ca = Convert.ToInt32(fields[7]),
                                    project = Convert.ToInt32(fields[8]),
                                    exam = Convert.ToInt32(fields[9]),
                                    date_of_upload = DateTime.Now.Date.ToString("d"),
                                    time_of_upload = DateTime.Now,
                                    subject_total = Convert.ToInt32(fields[7]) + Convert.ToInt32(fields[8]) + Convert.ToInt32(fields[9]),
                                });
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Import Failed. One or more data not formatted properly.");
                                Utils.LogException(ex);
                                return;
                            }
                        }

                        var sortedResult = results.OrderByDescending(x => x.subject_total).ToList();

                        for (int i = 0; i < sortedResult.Count; i++)
                        {
                            sortedResult[1].subject_rank = i + 1;
                        }

                        using (var db = new Model1())
                        {
                            db.results1.AddRange(sortedResult);
                            db.SaveChanges();
                            MessageBox.Show("Result Uploaded Successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured. \n");
            }

            Cursor = Cursors.Arrow;
        }
        
    }
}
