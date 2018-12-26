using DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class frmFirst : Form
    {
        bool timeDone = false;
        bool loadDone = false;

        Thread thread;
        System.Windows.Forms.Timer tim;
        bool toLogin = false;

        public frmFirst()
        {
            thread = new Thread(new ThreadStart(Splash));
            thread.Start();

            tim = new System.Windows.Forms.Timer();
            tim.Interval = 5000;
            tim.Tick += Tim_Tick;
            tim.Start();

            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;

            var conString = new Model1().GetConfigConString();

            var conn = new MySqlConnection(conString);

           toLogin = false;

            try
            {
                conn.Open();
                toLogin = true;

            }
            catch
            {
                toLogin = false;

            }
            finally
            {
                conn.Dispose();
            }

            if (timeDone)
            {
                thread.Abort();

                this.Hide();

                if (toLogin)
                {
                    LoginForm frmLogin = new LoginForm();
                    frmLogin.Show();
                }
                else
                {
                    frmSetup frm = new frmSetup("login");
                    frm.Show();
                }
            }
            loadDone = true;
        }

        private void Tim_Tick(object sender, EventArgs e)
        {
            if (loadDone)
            {
                thread.Abort();
                this.Hide();

                if (toLogin)
                {
                    LoginForm frmLogin = new LoginForm();
                    frmLogin.Show();
                }
                else
                {
                    frmSetup frm = new frmSetup("login");
                    frm.Show();
                }
            }
            else
            {
                timeDone = true;
            }
            tim.Stop();
        }

        private void Splash()
        {
            var frm = new frmSplash();

            Application.Run(frm);
        }

    }
}
