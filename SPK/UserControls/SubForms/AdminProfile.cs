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

namespace SPK.UserControls.SubForms
{
    public partial class AdminProfile : UserControl
    {
        public AdminProfile()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                var ad = GetUser();
                if (ad != null)
                {

                    DisplayInfo(ad);
                }
            }
        }

        user GetUser()
        {
            return AuthorizedUser.AuthorizedUser<user>.CurrentUser;
        }

        void DisplayInfo(user admin)
        {
            lblPhone.Text = admin.phone;
            lblEmail.Text = admin.email;
            lblAddress.Text = admin.address;
            // lblSex.Text = admin.
            lblNation.Text = admin.nationality;
            lblState.Text = admin.state;
            lblLGA.Text = admin.lga;
            lblDate.Text = admin.date_of_reg;

        }
    }
}
