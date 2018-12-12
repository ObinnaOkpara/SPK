using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.Services.Interfaces;
using DB.Services.DataRepository;
using DB;

namespace SPK.UserControls.SubForms
{
    public partial class AddAdmin : UserControl
    {
        private IUnitOfWork _unitOfWork;
        public AddAdmin()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                try
                {
                    var admin = CreateAdmin();

                    if (admin != null)
                    {
                        _unitOfWork = new UnitOfWork(new Model1());
                        _unitOfWork.UserRepository.Add(admin);
                        await _unitOfWork.Save();
                        MessageBox.Show("Admin added");
                    }
                    else
                    {
                        MessageBox.Show("Error occured. Contact support");
                    }
                }
                catch (Exception ex)
                {
                    Utilities.Utils.LogException(ex);
                    MessageBox.Show("Error occured. Contact support");
                }
            }
        }

        user CreateAdmin()
        {
            string _title;
            if (radMiss.Checked)
            {
                _title = "Miss";
            }
            else if (radMr.Checked)
            {
                _title = "Mr";
            }
            else if (radMrs.Checked)
            {
                _title = "Mrs";
            }
            else
            {
                MessageBox.Show("Please select title");
                return null;
            }
            var ad = new user()
            {
                address = _txtAddress.Text,
                date_of_reg = DateTime.Today.ToString("d"),
                email = _txtEmail.Text,
                fullname = _txtFirstname.Text + " " + txtOthernames.Text + " " + _txtSurname.Text,
                lga = _txtLGA.Text,
                nationality = cBoxCountry.Text,
                password = _txtPassword.Text,
                phone = _txtPhone.Text,
                state = cBoxState.Text,
                time_of_reg = DateTime.Now,
                title = _title
            };

            return ad;
        }

        bool ValidateControls()
        {
            if (string.Equals(_txtConfirmPassword.Text, _txtPassword.Text))
            {
                var txtboxes = Controls.OfType<TextBox>().Where(box => box.Name.StartsWith("_"));

                foreach (var tbox in txtboxes)
                {
                    if (string.IsNullOrWhiteSpace(tbox.Text))
                    {
                        errorProvider1.SetError(tbox, "Please fill the required field");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Password not the same");
                return false;
            }

            return true;
        }
    }
}
