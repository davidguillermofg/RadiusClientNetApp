using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP.Radius;

namespace RadiusClientNetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            string hostname = txtHostname.Text;
            string sharedKey = txtSharedKey.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string vendorSpecificData1 = txtVendorSpecificData1.Text;
            string vendorSpecificData2 = txtVendorSpecificData2.Text;
            uint vendorId = Convert.ToUInt16(txtVendorId.Text);
            int timeout = Convert.ToInt16(txtTimeout.Text);
            uint port = Convert.ToUInt16(txtPort.Text);
            string output = "";

            RadiusClient rc = new RadiusClient(hostname, sharedKey, timeout, port);
            RadiusPacket authPacket = rc.Authenticate(username, password);
            if(vendorSpecificData1.Length>0)
            {
                authPacket.SetAttribute(new VendorSpecificAttribute(vendorId, 1, UTF8Encoding.UTF8.GetBytes(vendorSpecificData1)));
            }
            if (vendorSpecificData2.Length > 0)
            {
                authPacket.SetAttribute(new VendorSpecificAttribute(vendorId, 2, UTF8Encoding.UTF8.GetBytes(vendorSpecificData2)));
            }
            RadiusPacket receivedPacket = await rc.SendAndReceivePacket(authPacket);

            if (receivedPacket == null)
            {
                string errMsg = "Can't contact remote radius server ! \n";
                output += errMsg;
                MessageBox.Show(errMsg);
                return;
            }
            output += "receivedPacket: " + receivedPacket.PacketType+" \n";
            switch (receivedPacket.PacketType)
            {
                case RadiusCode.ACCESS_ACCEPT:
                    output += "Access-Accept";
                    foreach (var attr in receivedPacket.Attributes)
                    {
                        output += attr.Type.ToString() + " = " + attr.Value;
                    }
                    break;
                case RadiusCode.ACCESS_CHALLENGE:
                    output += "Access-Challenge";
                    break;
                case RadiusCode.ACCESS_REJECT:
                    output += "Access-Reject";
                    if (!rc.VerifyAuthenticator(authPacket, receivedPacket))
                        output += "Authenticator check failed: Check your secret";
                    break;
                default:
                    output += "Rejected";
                    break;
            }
            output += " \n";
            txtOutput.Text = output;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
