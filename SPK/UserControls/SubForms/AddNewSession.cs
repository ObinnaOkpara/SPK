
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
using System.Text.RegularExpressions;

namespace SPK.UserControls.SubForms
{
    public partial class AddNewSession : UserControl
    {
        private IUnitOfWork _unitOfWork;
        public AddNewSession()
        {
            InitializeComponent();
        }

        bool RegexCheckTextbox( string input)
        {
            Regex regex = new Regex(@"^\d{4}\/\d{4}$");

            Match match = regex.Match(input);

            return match.Success;
        }

        bool CheckIfSessionIsValid(string input)
        {
           
            var firstyear = input.Substring(0, 4);

            var secondYear = input.Substring(5, 4);

            if (int.Parse(firstyear) > int.Parse(secondYear))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckTextboxes(this, errorProvider1))
            {
                if (RegexCheckTextbox(_txtSession.Text) && CheckIfSessionIsValid(_txtSession.Text))
                {
                    try
                    {
                        _unitOfWork = new UnitOfWork(new Model1());

                        if (_unitOfWork.SessionRepository.CheckIfItExists(_txtSession.Text))
                        {
                            MessageBox.Show("This session already exists.");
                            return;
                        }

                        var Session = new session()
                        {
                            sessions = _txtSession.Text,
                            date_added = DateTime.Today.ToString("d"),
                            time_added = DateTime.Now,
                        };

                        _unitOfWork.SessionRepository.Add(Session);
                        await _unitOfWork.Save();
                        _unitOfWork.Dispose();
                        MessageBox.Show($"Session {_txtSession.Text} was added successfully.");
                    }
                    catch (Exception ex)
                    {
                        Utils.LogException(ex);
                        MessageBox.Show("Error occured. Contact support");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter the session in the approved format");
                }
            }
        }
    }
}
