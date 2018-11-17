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
using SPK.Utilities;

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
            if (ValidateTextboxes.Check(txtPassword.Text,txtConfirmPassword.Text,Controls,errorProvider1))
            {

                var principal = CreatePrincipal();

                if (principal != null)
                {
                    _unitOfWork = new UnitOfWork(new Model1());
                    _unitOfWork.PrincipalRepository.Add(principal);
                    await _unitOfWork.Save();
                    MessageBox.Show("Admin added");
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
                email = txtEmail.Text,
                firstname = txtFirstname.Text,
                lastname = txtOthernames.Text,
                next_of_kin = txtFatherName.Text,
                next_of_kin_phone = txtFatherPhone.Text,
                next_of_kin_relationship = txtSponsorRelationship.Text,
                password = txtPassword.Text,
                phone = txtPhone.Text,
                position = textBox1.Text,
                sex = cBoxSex.Text,
                time_registered = DateTime.Now,
                username = txtUsername.Text                
            };
            return pr;
        }

       
    }
}
