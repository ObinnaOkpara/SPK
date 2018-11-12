using DB;
using SPK.AuthorizedUser;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool Login<TEntity>() where TEntity: class
        {
            using (var db = new Model1())
            {
                
                if (typeof(TEntity) == typeof(principal))
                {
                   var user = db.principals.
                            FirstOrDefault
                            (pr => pr.email == txtUsername.Text && pr.password == txtPassword.Text);

                    AuthorizedUser<principal>.CurrentUser = user;

                    return true;
                }
                else if (typeof(TEntity) ==typeof(teacher) )
                {
                    var user = db.teachers.
                            FirstOrDefault
                            (pr => pr.email == txtUsername.Text && pr.password == txtPassword.Text);

                    AuthorizedUser<teacher>.CurrentUser = user;
                    return true;
                }
                else if (typeof(TEntity) == typeof(user))
                {
                    var user = db.users.
                            FirstOrDefault
                            (pr => pr.email == txtUsername.Text && pr.password == txtPassword.Text);

                    AuthorizedUser<user>.CurrentUser = user;
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                if (Login<user>())
                {
                    //admin logged in
                }
                else
                {
                    MessageBox.Show("Invalid details");
                    return;
                }
            }
            else if (rdbPrincipal.Checked)
            {
                if (Login<principal>())
                {
                    //principal logged in
                }
                else
                {
                    MessageBox.Show("Invalid details");
                    return;
                }
            }
            else if (rdbTeacher.Checked)
            {
                if (Login<teacher>())
                {
                    //teacher logged in
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


            
           
        }
    }
}
