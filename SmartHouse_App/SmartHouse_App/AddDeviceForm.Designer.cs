namespace SmartHouse_App
{
    partial class AddDeviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtLocation = new TextBox();
            txtDevicename = new TextBox();
            txtDeviceType = new ComboBox();
            btnOK = new Button();
            chkStatus = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 71);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Device Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 116);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "DeviceTypeID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 168);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(121, 160);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(213, 23);
            txtLocation.TabIndex = 6;
            // 
            // txtDevicename
            // 
            txtDevicename.Location = new Point(120, 68);
            txtDevicename.Name = "txtDevicename";
            txtDevicename.Size = new Size(213, 23);
            txtDevicename.TabIndex = 7;
            // 
            // txtDeviceType
            // 
            txtDeviceType.FormattingEnabled = true;
            txtDeviceType.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            txtDeviceType.Location = new Point(121, 117);
            txtDeviceType.Name = "txtDeviceType";
            txtDeviceType.Size = new Size(212, 23);
            txtDeviceType.TabIndex = 8;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(371, 303);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // chkStatus
            // 
            chkStatus.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkStatus.Location = new Point(234, 189);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(113, 38);
            chkStatus.TabIndex = 11;
            chkStatus.Text = "Status";
            chkStatus.UseVisualStyleBackColor = true;
            chkStatus.CheckedChanged += chkStatus_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            label1.Location = new Point(7, 356);
            label1.Name = "label1";
            label1.Size = new Size(451, 46);
            label1.TabIndex = 12;
            label1.Text = "* TypeID: 1-light,2-air conditioner,3-camera,4-smartlock,5-smoke detector,6-motion sensor";
            // 
            // AddDeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 411);
            Controls.Add(label1);
            Controls.Add(chkStatus);
            Controls.Add(btnOK);
            Controls.Add(txtDeviceType);
            Controls.Add(txtDevicename);
            Controls.Add(txtLocation);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDeviceForm";
            Load += AddDeviceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtLocation;
        private TextBox txtDevicename;
        private ComboBox txtDeviceType;
        private Button btnOK;
        private CheckBox chkStatus;
        private Label label1;
    }
}