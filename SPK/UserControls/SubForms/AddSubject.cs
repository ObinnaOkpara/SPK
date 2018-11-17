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
    public partial class AddSubject : UserControl
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddSubject()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new Model1());
        }

        private void btnSave_Load(object sender, EventArgs e)
        {
            
        }
    }
}
