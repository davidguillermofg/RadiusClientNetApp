namespace RadiusClientNetApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtSharedKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtVendorSpecificData1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVendorSpecificData2 = new System.Windows.Forms.TextBox();
            this.attribute2 = new System.Windows.Forms.Label();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "hostname:";
            // 
            // txtHostname
            // 
            this.txtHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostname.Location = new System.Drawing.Point(75, 6);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(345, 20);
            this.txtHostname.TabIndex = 1;
            this.txtHostname.Text = "10.16.32.48";
            // 
            // txtSharedKey
            // 
            this.txtSharedKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSharedKey.Location = new System.Drawing.Point(75, 32);
            this.txtSharedKey.Name = "txtSharedKey";
            this.txtSharedKey.Size = new System.Drawing.Size(345, 20);
            this.txtSharedKey.TabIndex = 3;
            this.txtSharedKey.Text = "12345678";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "sharedKey:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(74, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(345, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "vguillermo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(74, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(345, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "VGuille24";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "password:";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(259, 201);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(78, 20);
            this.txtTimeout.TabIndex = 9;
            this.txtTimeout.Text = "5000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "timeout (ms):";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(75, 201);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(101, 20);
            this.txtPort.TabIndex = 11;
            this.txtPort.Text = "1812";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "port:";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(8, 265);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(411, 50);
            this.txtOutput.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Output:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(74, 227);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(102, 23);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtVendorSpecificData1
            // 
            this.txtVendorSpecificData1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendorSpecificData1.Location = new System.Drawing.Point(122, 147);
            this.txtVendorSpecificData1.Name = "txtVendorSpecificData1";
            this.txtVendorSpecificData1.Size = new System.Drawing.Size(297, 20);
            this.txtVendorSpecificData1.TabIndex = 16;
            this.txtVendorSpecificData1.Text = "Testing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "vendorSpecificData1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "vendorId:";
            // 
            // txtVendorSpecificData2
            // 
            this.txtVendorSpecificData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendorSpecificData2.Location = new System.Drawing.Point(122, 170);
            this.txtVendorSpecificData2.Name = "txtVendorSpecificData2";
            this.txtVendorSpecificData2.Size = new System.Drawing.Size(297, 20);
            this.txtVendorSpecificData2.TabIndex = 20;
            this.txtVendorSpecificData2.Text = "7";
            // 
            // attribute2
            // 
            this.attribute2.AutoSize = true;
            this.attribute2.Location = new System.Drawing.Point(7, 173);
            this.attribute2.Name = "attribute2";
            this.attribute2.Size = new System.Drawing.Size(110, 13);
            this.attribute2.TabIndex = 19;
            this.attribute2.Text = "vendorSpecificData2:";
            // 
            // txtVendorId
            // 
            this.txtVendorId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendorId.Location = new System.Drawing.Point(122, 123);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(297, 20);
            this.txtVendorId.TabIndex = 18;
            this.txtVendorId.Text = "60797";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "http://www.iana.org/assignments/enterprise-numbers/";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 321);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVendorSpecificData2);
            this.Controls.Add(this.attribute2);
            this.Controls.Add(this.txtVendorId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVendorSpecificData1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSharedKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(370, 360);
            this.Name = "Form1";
            this.Text = "RadiusClient .Net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtSharedKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtVendorSpecificData1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVendorSpecificData2;
        private System.Windows.Forms.Label attribute2;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.Label label11;
    }
}

