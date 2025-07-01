namespace SmartHouse_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            TabDevicesList = new TabPage();
            btnRefresh = new Button();
            btnTurn = new Button();
            btnDelete = new Button();
            btnAddDevice = new Button();
            dgvDevices = new DataGridView();
            tabPage2 = new TabPage();
            btnTurnSchedule = new Button();
            chkStatusSchedule = new CheckBox();
            txtRepeatpattern = new TextBox();
            label10 = new Label();
            label7 = new Label();
            dgvSchedules = new DataGridView();
            button8 = new Button();
            btnAddSchedule = new Button();
            dtpEndTime = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            cbxDevices = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPage1 = new TabPage();
            btnFilterType = new Button();
            btnFilterA_Z = new Button();
            btnFilterDate = new Button();
            label11 = new Label();
            label8 = new Label();
            dgvSensor = new DataGridView();
            tabPage3 = new TabPage();
            label12 = new Label();
            label9 = new Label();
            dgvElectric = new DataGridView();
            lblHeader = new Label();
            btnLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtRole = new TextBox();
            tabControl1.SuspendLayout();
            TabDevicesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSensor).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElectric).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabDevicesList);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tabControl1.Location = new Point(0, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1083, 529);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // TabDevicesList
            // 
            TabDevicesList.Controls.Add(btnRefresh);
            TabDevicesList.Controls.Add(btnTurn);
            TabDevicesList.Controls.Add(btnDelete);
            TabDevicesList.Controls.Add(btnAddDevice);
            TabDevicesList.Controls.Add(dgvDevices);
            TabDevicesList.Location = new Point(4, 24);
            TabDevicesList.Name = "TabDevicesList";
            TabDevicesList.Padding = new Padding(3);
            TabDevicesList.Size = new Size(1075, 501);
            TabDevicesList.TabIndex = 0;
            TabDevicesList.Text = "Devices List";
            TabDevicesList.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnRefresh.Location = new Point(830, 82);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(238, 28);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnTurn
            // 
            btnTurn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnTurn.Location = new Point(830, 31);
            btnTurn.Name = "btnTurn";
            btnTurn.Size = new Size(238, 23);
            btnTurn.TabIndex = 3;
            btnTurn.Text = "Turn on/off";
            btnTurn.UseVisualStyleBackColor = true;
            btnTurn.Click += btnTurn_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(830, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(238, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddDevice
            // 
            btnAddDevice.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnAddDevice.Location = new Point(830, 138);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.Size = new Size(238, 23);
            btnAddDevice.TabIndex = 1;
            btnAddDevice.Text = "Add Device";
            btnAddDevice.UseVisualStyleBackColor = true;
            btnAddDevice.Click += btnAddDevice_Click;
            // 
            // dgvDevices
            // 
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevices.BackgroundColor = Color.White;
            dgvDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevices.Dock = DockStyle.Left;
            dgvDevices.Location = new Point(3, 3);
            dgvDevices.Name = "dgvDevices";
            dgvDevices.Size = new Size(803, 495);
            dgvDevices.TabIndex = 0;
            dgvDevices.CellClick += dgvDevices_CellClick;
            dgvDevices.CellContentClick += dgvDevices_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnTurnSchedule);
            tabPage2.Controls.Add(chkStatusSchedule);
            tabPage2.Controls.Add(txtRepeatpattern);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dgvSchedules);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(btnAddSchedule);
            tabPage2.Controls.Add(dtpEndTime);
            tabPage2.Controls.Add(dtpStartTime);
            tabPage2.Controls.Add(cbxDevices);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1075, 501);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Schedules";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnTurnSchedule
            // 
            btnTurnSchedule.Location = new Point(954, 167);
            btnTurnSchedule.Name = "btnTurnSchedule";
            btnTurnSchedule.Size = new Size(104, 23);
            btnTurnSchedule.TabIndex = 17;
            btnTurnSchedule.Text = "Turn ON/OFF";
            btnTurnSchedule.UseVisualStyleBackColor = true;
            btnTurnSchedule.Click += btnTurnSchedule_Click_1;
            // 
            // chkStatusSchedule
            // 
            chkStatusSchedule.AutoSize = true;
            chkStatusSchedule.Location = new Point(148, 144);
            chkStatusSchedule.Name = "chkStatusSchedule";
            chkStatusSchedule.Size = new Size(108, 19);
            chkStatusSchedule.TabIndex = 16;
            chkStatusSchedule.Text = "Status ON/OFF";
            chkStatusSchedule.UseVisualStyleBackColor = true;
            // 
            // txtRepeatpattern
            // 
            txtRepeatpattern.Location = new Point(148, 108);
            txtRepeatpattern.Name = "txtRepeatpattern";
            txtRepeatpattern.Size = new Size(360, 22);
            txtRepeatpattern.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 108);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 14;
            label10.Text = "RepeatPattern :";
            // 
            // label7
            // 
            label7.Location = new Point(10, 181);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 13;
            label7.Text = "Schedules List";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvSchedules
            // 
            dgvSchedules.AllowUserToAddRows = false;
            dgvSchedules.AllowUserToDeleteRows = false;
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.BackgroundColor = Color.White;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Location = new Point(8, 207);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.Size = new Size(1060, 288);
            dgvSchedules.TabIndex = 12;
            dgvSchedules.CellClick += dgvSchedules_CellClick;
            dgvSchedules.CellContentClick += dgvSchedules_CellContentClick;
            // 
            // button8
            // 
            button8.Location = new Point(983, 126);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 11;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(872, 126);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(105, 23);
            btnAddSchedule.TabIndex = 9;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Location = new Point(150, 68);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(358, 22);
            dtpEndTime.TabIndex = 6;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Location = new Point(150, 39);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(358, 22);
            dtpStartTime.TabIndex = 5;
            // 
            // cbxDevices
            // 
            cbxDevices.FormattingEnabled = true;
            cbxDevices.Location = new Point(150, 6);
            cbxDevices.Name = "cbxDevices";
            cbxDevices.Size = new Size(358, 23);
            cbxDevices.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 144);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 3;
            label6.Text = "Action : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 69);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 2;
            label5.Text = "End Time : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 39);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 1;
            label4.Text = "Start Time : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 13);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Devices : ";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnFilterType);
            tabPage1.Controls.Add(btnFilterA_Z);
            tabPage1.Controls.Add(btnFilterDate);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(dgvSensor);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1075, 501);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Sensors";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFilterType
            // 
            btnFilterType.Location = new Point(995, 58);
            btnFilterType.Name = "btnFilterType";
            btnFilterType.Size = new Size(75, 23);
            btnFilterType.TabIndex = 8;
            btnFilterType.Text = "Type";
            btnFilterType.UseVisualStyleBackColor = true;
            btnFilterType.Click += btnFilterType_Click;
            // 
            // btnFilterA_Z
            // 
            btnFilterA_Z.Location = new Point(914, 58);
            btnFilterA_Z.Name = "btnFilterA_Z";
            btnFilterA_Z.Size = new Size(75, 23);
            btnFilterA_Z.TabIndex = 7;
            btnFilterA_Z.Text = "A-Z";
            btnFilterA_Z.UseVisualStyleBackColor = true;
            btnFilterA_Z.Click += btnFilterA_Z_Click;
            // 
            // btnFilterDate
            // 
            btnFilterDate.Location = new Point(833, 58);
            btnFilterDate.Name = "btnFilterDate";
            btnFilterDate.Size = new Size(75, 23);
            btnFilterDate.TabIndex = 6;
            btnFilterDate.Text = "Date";
            btnFilterDate.UseVisualStyleBackColor = true;
            btnFilterDate.Click += btnFilterDate_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(788, 62);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 5;
            label11.Text = "Filter :";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(192, 192, 255);
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(8, 3);
            label8.Name = "label8";
            label8.Size = new Size(1061, 52);
            label8.TabIndex = 2;
            label8.Text = "Sensors";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSensor
            // 
            dgvSensor.AllowUserToDeleteRows = false;
            dgvSensor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSensor.BackgroundColor = Color.White;
            dgvSensor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSensor.Location = new Point(8, 87);
            dgvSensor.Name = "dgvSensor";
            dgvSensor.ReadOnly = true;
            dgvSensor.Size = new Size(1061, 280);
            dgvSensor.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(dgvElectric);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1075, 501);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Electricity";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            label12.Location = new Point(577, 474);
            label12.Name = "label12";
            label12.Size = new Size(495, 24);
            label12.TabIndex = 13;
            label12.Text = "* TypeID: 1-light,2-air conditioner,3-camera,4-smartlock,5-smoke detector,6-motion sensor";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(192, 192, 255);
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(7, 3);
            label9.Name = "label9";
            label9.Size = new Size(1061, 52);
            label9.TabIndex = 3;
            label9.Text = "Electricity";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvElectric
            // 
            dgvElectric.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvElectric.BackgroundColor = SystemColors.ButtonHighlight;
            dgvElectric.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElectric.Location = new Point(3, 93);
            dgvElectric.Name = "dgvElectric";
            dgvElectric.ReadOnly = true;
            dgvElectric.Size = new Size(1062, 267);
            dgvElectric.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(192, 192, 255);
            lblHeader.BorderStyle = BorderStyle.Fixed3D;
            lblHeader.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(0, -1);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1083, 46);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "VNAI Dashboard";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Click += lblHeader_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            btnLogout.Location = new Point(997, 607);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            label1.Location = new Point(14, 583);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "User : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            label2.Location = new Point(14, 603);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Role : ";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            txtUser.Location = new Point(59, 583);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(191, 22);
            txtUser.TabIndex = 5;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            txtRole.Location = new Point(59, 603);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(191, 22);
            txtRole.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 642);
            Controls.Add(txtRole);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(lblHeader);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VNAI House";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            TabDevicesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSensor).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvElectric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabDevicesList;
        private TabPage tabPage2;
        private DataGridView dgvDevices;
        private Label lblHeader;
        private Button btnLogout;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtRole;
        private Button btnTurn;
        private Button btnDelete;
        private Button btnAddDevice;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Button button8;
        private Button btnAddSchedule;
        private Button button5;
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStartTime;
        private ComboBox cbxDevices;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private DataGridView dgvSchedules;
        private Label label8;
        private Button button9;
        private DataGridView dgvSensor;
        private Button btnRefresh;
        private Label label10;
        private TextBox txtRepeatpattern;
        private CheckBox chkStatusSchedule;
        private Button btnTurnSchedule;
        private Button btnFilterA_Z;
        private Button btnFilterDate;
        private Label label11;
        private Button btnFilterType;
        private DataGridView dgvElectric;
        private Label label9;
        private Label label12;
    }
}
