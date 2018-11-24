﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK
{
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AppType == "Client")
            {
                radClient.Checked = true;
            }
            else
            {
                radServer.Checked = true;
            }
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

        private static void QshareFolder(string FolderPath, string ShareName, string Description)
        {
            try
            {
                // Create a ManagementClass object

                ManagementClass managementClass = new ManagementClass("Win32_Share");

                // Create ManagementBaseObjects for in and out parameters

                ManagementBaseObject inParams = managementClass.GetMethodParameters("Create");

                ManagementBaseObject outParams;

                // Set the input parameters

                inParams["Description"] = Description;

                inParams["Name"] = ShareName;

                inParams["Path"] = FolderPath;

                inParams["Type"] = 0x0; // Disk Drive

                //Another Type:

                // DISK_DRIVE = 0x0

                // PRINT_QUEUE = 0x1

                // DEVICE = 0x2

                // IPC = 0x3

                // DISK_DRIVE_ADMIN = 0x80000000

                // PRINT_QUEUE_ADMIN = 0x80000001

                // DEVICE_ADMIN = 0x80000002

                // IPC_ADMIN = 0x8000003

                //inParams["MaximumAllowed"] = int maxConnectionsNum;

                // Invoke the method on the ManagementClass object

                outParams = managementClass.InvokeMethod("Create", inParams, null);

                // Check to see if the method invocation was successful

                if ((uint)(outParams.Properties["ReturnValue"].Value) != 0)

                {

                    throw new Exception("Unable to share directory.");

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "error!");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}