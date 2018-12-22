using DB;
using DB.Services.DataRepository;
using DB.Services.Interfaces;
using SPK.AuthorizedUser;
using SPK.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class LoginForm : Form
    {
        bool _mousedown;
        Point startpt;

        private readonly IUnitOfWork _unitOfWork;
        public LoginForm()
        {
            
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new Model1());
            
        }

        private async Task<bool> Login<TEntity>() where TEntity : class
        {
           

            using (var db = new Model1())
            {

                if (typeof(TEntity) == typeof(principal))
                {
                    var user = await _unitOfWork.PrincipalRepository.LoginPrincipal(txtUsername.Text, txtPassword.Text);


                    if (user != null)
                    {
                        AuthorizedUser<principal>.CurrentUser = user;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (typeof(TEntity) == typeof(teacher))
                {
                    var user = await _unitOfWork.TeacherRepository.LoginTeacher(txtUsername.Text, txtPassword.Text);
                    //var user = await db.teachers.
                    //        FirstOrDefaultAsync
                    //        (pr => pr.email == txtUsername.Text && pr.password == txtPassword.Text);

                    if (user != null)
                    {
                        AuthorizedUser<teacher>.CurrentUser = user;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (typeof(TEntity) == typeof(user))
                {
                    var user = await _unitOfWork.UserRepository.LoginAdmin(txtUsername.Text, txtPassword.Text);

                    if (user != null)
                    {
                        AuthorizedUser<user>.CurrentUser = user;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;

            }
            
        }
        
        private void btnSignIn_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (cBoxType.Text == "Admin")
                {
                    var task = Login<user>();

                    task.Wait();

                    var loginResult = task.Result;
                    if (loginResult)
                    {
                        MessageBox.Show("Login Successful");

                        Cursor = Cursors.Arrow;
                        var frm = new frmMain("admin");
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        Cursor = Cursors.Arrow;
                        MessageBox.Show("Invalid details");
                        return;
                    }
                }
                else if (cBoxType.Text == "Principal")
                {
                    var task = Login<principal>();

                    task.Wait();

                    var loginResult = task.Result;
                    if (loginResult)
                    {
                        MessageBox.Show("Login Successful");

                        Cursor = Cursors.Arrow;
                        var frm = new frmMain("principal");
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        Cursor = Cursors.Arrow;
                        MessageBox.Show("Invalid details");
                        return;
                    }
                }
                else if (cBoxType.Text == "Teacher")
                {
                    var task = Login<teacher>();

                    task.Wait();

                    var loginResult = task.Result;
                    if (loginResult)
                    {
                        MessageBox.Show("Login Successful");

                        Cursor = Cursors.Arrow;
                        var frm = new frmTeacher();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid details");

                        Cursor = Cursors.Arrow;
                        return;
                    }
                }
                else
                {
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Please select an account");
                    return;
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("An error occured. Please contact support");
            }
            Cursor = Cursors.Arrow;


            // _unitOfWork.Dispose();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimises the program
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.DarkRed;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picMinimise_MouseHover(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.FromArgb(0, 125, 113);
        }

        private void picMinimise_MouseLeave(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.FromArgb(0, 150, 136);
        }
        
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            startpt = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _mousedown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                var curpos = PointToScreen(e.Location);
                Location = new Point(curpos.X - startpt.X, curpos.Y - startpt.Y);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var appPath = @"\\" + Path.Combine(Environment.MachineName, @"spkq");
                File.Copy(Path.Combine(Environment.CurrentDirectory, "small.png"), Path.Combine(appPath, "small.png"), true);
                MessageBox.Show("Successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Cursor = Cursors.Arrow;
        }
    }
}
