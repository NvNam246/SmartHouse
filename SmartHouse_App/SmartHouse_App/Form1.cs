using System;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartHouse_App
{
    public partial class Form1 : Form
    {
        private function fn = new function();
        string query;


        public Form1()
        {
            InitializeComponent();
        }

        private void LoadScheduleList()
        {
            dgvSchedules.DataSource = fn.GetData(@"SELECT s.ScheduleID, d.DeviceName, s.StartTime, s.EndTime,s.RepeatPattern,s.Status
                     FROM Schedules s
                     JOIN Devices d ON s.DeviceID = d.DeviceID").Tables[0];

        }
        private void LoadSensorList()
        {
            dgvSensor.DataSource = fn.GetData("SELECT * FROM SensorLogs ").Tables[0];

        }

        private void LoadDeviceList()
        {
            dgvDevices.DataSource = fn.GetData("SELECT DeviceID,DeviceName,DeviceTypeID,Status,Location,LastUpdated FROM Devices ").Tables[0];

        }



        private void dgvDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadElectricData()
        {
            string query = @"
                            SELECT EU.UsageID, D.DeviceName, EU.UsageDate, EU.ConsumedKWh
                            FROM EnergyUsage EU
                            JOIN Devices D ON EU.DeviceID = D.DeviceID
                            ORDER BY EU.UsageDate DESC";

            DataSet ds = fn.GetData(query);
            dgvElectric.DataSource = ds.Tables[0];

            //CalculateTotalKwh(ds.Tables[0]);
        }

        private void LoadDevicesToComboBox()
        {
            string query = "SELECT DeviceID, DeviceName FROM Devices";
            SqlDataReader reader = fn.getForcombo(query);

            DataTable dt = new DataTable();
            dt.Load(reader);

            cbxDevices.DataSource = dt;
            cbxDevices.DisplayMember = "DeviceName";
            cbxDevices.ValueMember = "DeviceID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDeviceList();
            LoadScheduleList();
            LoadDevicesToComboBox();
            LoadElectricData();
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "dd/MM/yyyy HH:mm";
            LoadSensorList();
            txtUser.Text = FormLogin.LoggedInUser;
            txtRole.Text = FormLogin.UserRole;

            if (FormLogin.UserRole == "admin")
            {
                btnDelete.Visible = true;
                btnAddDevice.Visible = true;
                btnAddSchedule.Visible = true;
                button8.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                btnAddDevice.Visible = false;
                btnAddSchedule.Visible = false;
                button8.Visible = false;
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            AddDeviceForm addDeviceForm = new AddDeviceForm();
            addDeviceForm.Show();
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            if (dgvDevices.SelectedRows.Count > 0)
            {
                int deviceID = Convert.ToInt32(dgvDevices.SelectedRows[0].Cells["DeviceID"].Value);
                bool currentStatus = Convert.ToBoolean(dgvDevices.SelectedRows[0].Cells["Status"].Value);

                bool newStatus = !currentStatus;

                query = $"UPDATE Devices SET Status = {(newStatus ? 1 : 0)}, LastUpdated = GETDATE() WHERE DeviceID = {deviceID}";
                fn.setData(query, $"Device status changed to {(newStatus ? "ON" : "OFF")}!");

                LoadDeviceList();
            }
            else
            {
                MessageBox.Show("Please select a device to toggle status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LoadAllItems()
        {
            string query = "SELECT DeviceID,DeviceName,DeviceTypeID,Status,Location,LastUpdated FROM Devices";
            DataSet ds = fn.GetData(query);
            dgvDevices.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllItems();

        }
        string selectedIDDevice = "";

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedIDDevice))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this device?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Devices WHERE DeviceID = '" + selectedIDDevice + "'";
                    fn.setData(query, "Device Deleted");

                }
            }
            else
            {
                MessageBox.Show("Please select a device first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDevices.Rows[e.RowIndex];
                selectedIDDevice = row.Cells["DeviceID"].Value.ToString();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
        private void LoadSchedules()
        {
            string query = @"SELECT s.ScheduleID, d.DeviceName, s.StartTime, s.EndTime,s.RepeatPattern,s.Status
                     FROM Schedules s
                     JOIN Devices d ON s.DeviceID = d.DeviceID";
            DataSet ds = fn.GetData(query);
            dgvSchedules.DataSource = ds.Tables[0];
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (cbxDevices.SelectedIndex != -1)
            {
                int deviceId = Convert.ToInt32(cbxDevices.SelectedValue);
                DateTime start = dtpStartTime.Value;
                DateTime end = dtpEndTime.Value;
                string repeat = txtRepeatpattern.Text;
                bool statusSchedule = chkStatusSchedule.Checked;

                if (end <= start)
                {
                    MessageBox.Show("End time must be after start time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int statusValue = statusSchedule ? 1 : 0;

                string query = $@"
                                INSERT INTO Schedules (DeviceID, StartTime, EndTime, RepeatPattern, Status)
                                VALUES ({deviceId}, '{start:yyyy-MM-dd HH:mm:ss}', '{end:yyyy-MM-dd HH:mm:ss}', '{repeat}', {statusValue})";


                fn.setData(query, "Schedule added successfully!");
                LoadSchedules(); // Refresh datagridview
            }
            else
            {
                MessageBox.Show("Please select a device.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string selectedScheduleID = "";
        private void button8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedScheduleID))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Schedules WHERE ScheduleID = '" + selectedScheduleID + "'";
                    fn.setData(query, "Schedule Deleted");
                    LoadScheduleList();

                }
            }
            else
            {
                MessageBox.Show("Please select a schedule first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSchedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSchedules.Rows[e.RowIndex];
                selectedScheduleID = row.Cells["ScheduleID"].Value.ToString();
            }
        }



        private void btnTurnSchedule_Click_1(object sender, EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count > 0)
            {
                int ScheduleID = Convert.ToInt32(dgvSchedules.SelectedRows[0].Cells["ScheduleID"].Value);
                bool ScheduleCurrentStatus = Convert.ToBoolean(dgvSchedules.SelectedRows[0].Cells["Status"].Value);

                bool newScheduleStatus = !ScheduleCurrentStatus;

                query = $"UPDATE Schedules SET Status = {(newScheduleStatus ? 1 : 0)} WHERE ScheduleID = {ScheduleID}";
                fn.setData(query, $"Schedule status changed to {(newScheduleStatus ? "ON" : "OFF")}!");

                LoadScheduleList();
            }
            else
            {
                MessageBox.Show("Please select a Schedule to toggle status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            string query = @"
                            SELECT sl.LogID, d.DeviceName, sl.SensorType, sl.Value, sl.LogTime
                            FROM SensorLogs sl
                            JOIN Devices d ON sl.DeviceID = d.DeviceID
                            ORDER BY sl.LogTime ASC";
            DataSet ds = fn.GetData(query);
            dgvSensor.DataSource = ds.Tables[0];
        }

        private void btnFilterA_Z_Click(object sender, EventArgs e)
        {
            string query = @"
                            SELECT sl.LogID, d.DeviceName, sl.SensorType, sl.Value, sl.LogTime
                            FROM SensorLogs sl
                            JOIN Devices d ON sl.DeviceID = d.DeviceID
                            ORDER BY d.DeviceName ASC";

            DataSet ds = fn.GetData(query);
            dgvSensor.DataSource = ds.Tables[0];
        }

        private void btnFilterType_Click(object sender, EventArgs e)
        {
            string query = @"
                            SELECT sl.LogID, d.DeviceName, sl.SensorType, sl.Value, sl.LogTime
                            FROM SensorLogs sl
                            JOIN Devices d ON sl.DeviceID = d.DeviceID
                            ORDER BY sl.SensorType ASC";
            DataSet ds = fn.GetData(query);
            dgvSensor.DataSource = ds.Tables[0];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
            
             DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   this.Hide();
                   FormLogin formLogin = new FormLogin();
                formLogin.Show();
                }
            
           
        }
    }
}
