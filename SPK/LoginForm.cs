using DB;
using DB.Services.DataRepository;
using DB.Services.Interfaces;
using SPK.AuthorizedUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class LoginForm : Form
    {
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                var task = Login<user>();

                task.Wait();

                var loginResult = task.Result;
                if (loginResult)
                {
                    MessageBox.Show("admin logged in");
                }
                else
                {
                    MessageBox.Show("Invalid details");
                    return;
                }
            }
            else if (rdbPrincipal.Checked)
            {
                var task = Login<principal>();

                task.Wait();

                var loginResult = task.Result;
                if (loginResult)
                {
                    MessageBox.Show("principal logged in");
                }
                else
                {
                    MessageBox.Show("Invalid details");
                    return;
                }
            }
            else if (rdbTeacher.Checked)
            {
                var task = Login<teacher>();

                task.Wait();

                var loginResult = task.Result;
                if (loginResult)
                {
                    MessageBox.Show("teacher logged in");
                }
                else
                {
                    MessageBox.Show("Invalid details");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select an account");
                return;
            }

           // _unitOfWork.Dispose();
        }
    }
}
