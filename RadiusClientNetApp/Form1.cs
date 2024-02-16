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
            string attribute = txtAttribute.Text;
            int timeout = Convert.ToInt16(txtTimeout.Text);
            uint port = Convert.ToUInt16(txtPort.Text);
            string output = "";

            RadiusClient rc = new RadiusClient(hostname, sharedKey, timeout, port);
            RadiusPacket authPacket = rc.Authenticate(username, password);
            authPacket.SetAttribute(new VendorSpecificAttribute(10, 1, UTF8Encoding.UTF8.GetBytes(attribute)));
            authPacket.SetAttribute(new VendorSpecificAttribute(10, 2, new[] { (byte)7 }));
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
    }
}
