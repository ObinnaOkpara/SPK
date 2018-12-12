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
    public partial class PasswordReset : UserControl
    {
        public PasswordReset()
        {
            InitializeComponent();
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {

            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1) && ValidateFomControls.CheckTextboxes(this, errorProvider1))
            {

                if (cboxType.Text == "Student")
                {
                    try
                    {
                        using (var db = new Model1())
                        {
                            var stud = db.students.FirstOrDefault(x => x.reg_number == _txtUsername.Text);
                            if (stud != null)
                            {

                                stud.gen_password = _txtPassword.Text;
                                db.SaveChanges();
                                MessageBox.Show("Password changed");
                            }
                            else
                            {
                                MessageBox.Show("No user found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Utils.LogException(ex);
                        MessageBox.Show("An error occured. Please contact admin");
                    }
                }
                else if (cboxType.Text == "Teacher")
                {
                    try
                    {
                        using (var db = new Model1())
                        {
                            var tech = db.teachers.FirstOrDefault(x => x.username == _txtUsername.Text);

                            if (tech != null)
                            {
                                tech.password = _txtPassword.Text;
                                db.SaveChanges();
                                MessageBox.Show("Password changed");
                            }
                            else
                            {
                                MessageBox.Show("No user found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Utils.LogException(ex);
                        MessageBox.Show("An error occured. Please contact admin");
                    }
                }
                else if (cboxType.Text == "Principal")
                {
                    try
                    {
                        using (var db = new Model1())
                        {
                            var prp = db.principals.FirstOrDefault(x => x.username == _txtUsername.Text);
                            if (prp != null)
                            {

                                prp.password = _txtPassword.Text;
                                db.SaveChanges();
                                MessageBox.Show("Password changed");
                            }
                            else
                            {
                                MessageBox.Show("No user found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Utils.LogException(ex);
                        MessageBox.Show("An error occured. Please contact admin");
                    }
                }
                else if (cboxType.Text == "Admin")
                {
                    try
                    {
                        using (var db = new Model1())
                        {
                            var ad = db.users.FirstOrDefault(x => x.email == _txtUsername.Text);
                            if (ad != null)
                            {

                                ad.password = _txtPassword.Text;
                                db.SaveChanges();
                                MessageBox.Show("Password changed");
                            }
                            else
                            {
                                MessageBox.Show("User not found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Utils.LogException(ex);
                        MessageBox.Show("An error occured. Please contact admin");
                    }
                }
            }
        }

    }
}
