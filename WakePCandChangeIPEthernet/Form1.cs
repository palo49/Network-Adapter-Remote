using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WakePCandChangeIPEthernet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties ip = adapter.GetIPProperties();

                UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = ip.UnicastAddresses;

                foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                {
                    if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        cmbAdapters.Items.Add(adapter.Name);
                    }
                }
            }

            cmbAdapters.SelectedItem = Properties.Settings.Default.adapter;
            txtIPv4.Text = Properties.Settings.Default.IPv4;
            txtSubnetMask.Text = Properties.Settings.Default.subnet;
            txtGateway.Text = Properties.Settings.Default.gateway;

            bgWorkerRemote.RunWorkerAsync();
        }

        private void updateInfo(string selectedAdapterName)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.Name == selectedAdapterName)
                {
                    IPInterfaceProperties ipProperties = adapter.GetIPProperties();

                    foreach (UnicastIPAddressInformation ipInfo in ipProperties.UnicastAddresses)
                    {
                        if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            // IP adresa
                            string ipAddress = ipInfo.Address.ToString();
                            lblIPv4.Text = ipAddress;

                            // Mask of Subnet
                            string subnetMask = ipInfo.IPv4Mask.ToString();
                            lblSubnet.Text = subnetMask;

                        }
                    }

                    // Default Gateway
                    GatewayIPAddressInformationCollection gatewayAddresses = ipProperties.GatewayAddresses;
                    if (gatewayAddresses.Count > 0)
                    {
                        string gateway = gatewayAddresses[0].Address.ToString();
                        lblGateway.Text = gateway;
                    }
                    break; // Pokud jsme našli odpovídající adaptér, ukončíme cyklus.
                }
            }
        }

        private void cmbAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdapters.SelectedIndex >= 0) {
                txtIPv4.ReadOnly = txtSubnetMask.ReadOnly = txtGateway.ReadOnly = false;

                string selectedAdapterName = cmbAdapters.SelectedItem.ToString();
                updateInfo(selectedAdapterName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtIPv4.Text != string.Empty && txtSubnetMask.Text!= string.Empty) {
                try
                {
                    if (cmbAdapters.SelectedIndex >= 0)
                    {
                        Process p = new Process();
                        ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"" + cmbAdapters.SelectedItem + "\" static " + txtIPv4.Text + " " + txtSubnetMask.Text + " " + txtGateway.Text);
                        psi.Verb = "runas";
                        p.StartInfo = psi;
                        p.Start();
                    }
                    else
                    {
                        MessageBox.Show("Choose a network adapter from combobox.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("The IPv4, subnet and gateway must not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeDHCP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAdapters.SelectedIndex >= 0)
                {
                    Process p = new Process();
                    ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"" + cmbAdapters.SelectedItem + "\" dhcp");
                    psi.Verb = "runas";
                    p.StartInfo = psi;
                    p.Start();
                }
                else
                {
                    MessageBox.Show("Choose a network adapter from combobox.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmbAdapters.SelectedIndex != -1) { Properties.Settings.Default.adapter = cmbAdapters.SelectedItem.ToString(); }
            if (txtIPv4.Text != string.Empty) { Properties.Settings.Default.IPv4 = txtIPv4.Text; }
            if (txtSubnetMask.Text != string.Empty) { Properties.Settings.Default.subnet = txtSubnetMask.Text; }
            if (txtGateway.Text != string.Empty) { Properties.Settings.Default.gateway = txtGateway.Text; }
            
            Properties.Settings.Default.Save();
        }

        Remote remote= new Remote();
        private void bgWorkerRemote_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                if (remote.IsMachineOnline(txtGateway.Text))
                {
                    this.Invoke(new MethodInvoker(delegate {
                        lblRemoteState.Text = "Online";
                        lblRemoteState.ForeColor = Color.Green;
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate {
                        lblRemoteState.Text = "Offline";
                        lblRemoteState.ForeColor = Color.Coral;
                    }));
                }

                Thread.Sleep(5000);
            }
        }

        private void txtGateway_TextChanged(object sender, EventArgs e)
        {
            lblRemoteTitle.Text = "Remote status (" + txtGateway.Text + ")";
        }

        private void btnReloadInfo_Click(object sender, EventArgs e)
        {
            if (cmbAdapters.SelectedIndex >= 0)
            {
                string selectedAdapterName = cmbAdapters.SelectedItem.ToString();
                updateInfo(selectedAdapterName);
            }
        }

        private void btnSubnetDefault_Click(object sender, EventArgs e)
        {
            txtSubnetMask.Text = "255.255.255.0";
        }
    }
}
