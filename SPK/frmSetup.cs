using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using MySql.Data.MySqlClient;

namespace SPK
{
    public partial class frmSetup : Form
    {
        string _from = "";
        public frmSetup(string from)
        {
            InitializeComponent();
            _from = from;
        }
        
        private void frmSetup_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AppType == "client")
            {
                radClient.Checked = true;
            }
            else
            {
                radServer.Checked = true;
            }
            txtDbName.Text = Properties.Settings.Default.DbName;
            txtUsername.Text = Properties.Settings.Default.DbUsername;
            txtPassword.Text = Properties.Settings.Default.DbPassword;

            txtName.Text = Properties.Settings.Default.DbName;
        }

        private void radServer_CheckedChanged(object sender, EventArgs e)
        {
            if (radServer.Checked)
            {
                panServer.Visible = true;
                panClient.Visible = false;
                txtServerName.Text = System.Environment.MachineName;
                
                try
                {
                    if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    {
                        MessageBox.Show("The system is not connected to a network.");
                    }
                    else
                    {
                        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                        var addresses = host.AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork);

                        foreach (var address in addresses)
                        {
                            lbIPs.Items.Add(address.ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The system is not connected to a network.");
                }

            }
            else
            {
                panServer.Visible = false;
                panClient.Visible = true;
                txtName.Text = Properties.Settings.Default.ServerName;
                txtIP.Text = Properties.Settings.Default.ServerIP;
            }
        }
        
        private void btnTest_Click(object sender, EventArgs e)
        {
            var server = txtIP.Text.Trim();
            var db = txtDbName.Text.Trim();
            var uid = txtUsername.Text.Trim();
            var pass = txtPassword.Text.Trim();

            var conString = $"SERVER={server}; DATABASE={db}; USER ID={uid}; PASSWORD={pass};";
            var conn = new MySqlConnection(conString);

            Cursor = Cursors.WaitCursor;

            try
            {
                conn.Open();
                MessageBox.Show("Connection successful.");


            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Try another IP.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return;
            }
            finally
            {
                conn.Dispose();
                Cursor = Cursors.WaitCursor;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (radClient.Checked)
                {
                    Properties.Settings.Default.DbName = txtDbName.Text.Trim();
                    Properties.Settings.Default.DbUsername = txtUsername.Text.Trim();
                    Properties.Settings.Default.DbPassword = txtPassword.Text.Trim();
                    Properties.Settings.Default.ServerIP = txtIP.Text.Trim();
                    Properties.Settings.Default.ServerName = txtName.Text.Trim();
                    Properties.Settings.Default.AppType = "client";

                    Properties.Settings.Default.ImagePath = @"\\" + Path.Combine(Properties.Settings.Default.ServerName, @"spk\");

                    var constring = $"SERVER={txtIP.Text.Trim()}; DATABASE={txtDbName.Text.Trim()}; USER ID={txtUsername.Text.Trim()}; PASSWORD={txtPassword.Text.Trim()};";
                    var db = new Model1();
                    db.AdjustConfigConString(constring);
                    db.Dispose();
                }
                else
                {
                    if (!Directory.Exists(@"c:/spk"))
                    {
                        MessageBox.Show("Please Create the shared spk folder.");
                        return;
                    }
                    if (!Directory.Exists(@"c:/spk/admin") || !Directory.Exists(@"c:/spk/image"))
                    {
                        MessageBox.Show("Please Create the sub folders in the spk folder.");
                        return;
                    }

                    Properties.Settings.Default.DbName = txtDbName.Text;
                    Properties.Settings.Default.DbUsername = txtUsername.Text;
                    Properties.Settings.Default.DbPassword = txtPassword.Text;
                    Properties.Settings.Default.ServerIP = "127.0.0.1";
                    Properties.Settings.Default.ServerName = txtServerName.Text;
                    Properties.Settings.Default.AppType = "server";
                    
                    Properties.Settings.Default.ImagePath = @"c:/spk/";
                    
                    var constring = $"SERVER=Localhost; DATABASE={txtDbName.Text.Trim()}; USER ID={txtUsername.Text.Trim()}; PASSWORD={txtPassword.Text.Trim()};";
                    var db = new Model1();
                    db.AdjustConfigConString(constring);
                    db.Dispose();
                }

                Properties.Settings.Default.SetupDone = true;
                Properties.Settings.Default.Save();

                MessageBox.Show("Configuration was saved successfully.");

                if (_from== "main")
                {
                    Close();
                }
                else
                {
                    LoginForm frm = new LoginForm();
                    frm.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var appPath = @"\\" + Path.Combine(txtName.Text, @"spk");
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
