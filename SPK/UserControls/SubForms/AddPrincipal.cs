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
using DB.Services.Interfaces;
using DB;
using DB.Services.DataRepository;

namespace SPK.UserControls.SubForms
{
    public partial class AddPrincipal : UserControl
    {
        private IUnitOfWork _unitOfWork;
        public AddPrincipal()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1) 
                && ValidateFomControls.CheckPassword(_txtPassword.Text, _txtConfirmPassword.Text))
            {
                var principal = CreatePrincipal();

                if (principal != null)
                {
                    try
                    {
                        _unitOfWork = new UnitOfWork(new Model1());
                        _unitOfWork.PrincipalRepository.Add(principal);
                        await _unitOfWork.Save();
                        _unitOfWork.Dispose();
                        MessageBox.Show("Admin added");

                    }
                    catch (Exception ex)
                    {
                        Utils.LogException(ex);

                        MessageBox.Show("An error occured. Please contact Admin");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error occured. Contact support");
                }
            }
        }

        private principal CreatePrincipal()
        {
            var pr = new principal()
            {
                date_registered = DateTime.Today.ToString("d"),
                email = _txtEmail.Text,
                firstname = _txtFirstname.Text,
                lastname = txtOthernames.Text,
                next_of_kin = _txtFatherName.Text,
                next_of_kin_phone = _txtFatherPhone.Text,
                next_of_kin_relationship = _txtSponsorRelationship.Text,
                password = _txtPassword.Text,
                phone = _txtPhone.Text,
                position = _textBox1.Text,
                sex = cBoxSex.Text,
                time_registered = DateTime.Now,
                username = _txtUsername.Text
            };
            return pr;
        }


    }
}
