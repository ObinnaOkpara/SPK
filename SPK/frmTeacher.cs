using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class frmTeacher : Form
    {

        bool _mousedown;
        Point startpt;

        public frmTeacher()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.DarkRed;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimise_MouseHover(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.FromArgb(0, 125, 113);
        }

        private void picMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimises the program
        }

        private void picMinimise_MouseLeave(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mousedown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            startpt = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                var curpos = PointToScreen(e.Location);
                Location = new Point(curpos.X - startpt.X, curpos.Y - startpt.Y);
            }
        }

        private void showUserControl(Control ctrl)
        {
            Cursor = Cursors.WaitCursor;

            panContainer.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            panContainer.Controls.Add(ctrl);

            Cursor = Cursors.Arrow;
        }
        private void btnDashboard_ClickEvent(object sender, EventArgs e)
        {

        }
        
    }
}
