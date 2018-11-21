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
using SPK.Utilities;
using DB;
using DB.Services.DataRepository;

namespace SPK.UserControls.SubForms
{
    public partial class AddNewSession : UserControl
    {
        private IUnitOfWork _unitOfWork;
        public AddNewSession()
        {
            InitializeComponent();
        }

        private async void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1))
            {
                var Session = new session()
                {
                    sessions = _txtSession.Text,
                    date_added = DateTime.Today.ToString("d"),
                    time_added = DateTime.Now,
                };

                _unitOfWork = new UnitOfWork(new Model1());
                _unitOfWork.SessionRepository.Add(Session);
                await _unitOfWork.Save();
                _unitOfWork.Dispose();
                MessageBox.Show($"Session {_txtSession.Text} was added successfully.");
            }
        }
    }
}
