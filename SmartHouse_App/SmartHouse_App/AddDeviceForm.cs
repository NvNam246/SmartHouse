using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartHouse_App
{
    public partial class AddDeviceForm : Form
    {
        function fn = new function();
        string query;
        public AddDeviceForm()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtDevicename.Clear();
            txtDeviceType.SelectedIndex = -1;
            txtLocation.Clear();
            chkStatus.Checked = false;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDevicename.Text != "" && txtDeviceType.Text != "" && txtLocation.Text != "")
            {
                string name = txtDevicename.Text.Trim();
                int type = int.Parse(txtDeviceType.Text.Trim());
                string location = txtLocation.Text.Trim();
                bool status = chkStatus.Checked;

                query = "INSERT INTO Devices (DeviceName, DeviceTypeID, Status, Location, LastUpdated) " +
                        $"VALUES (N'{name}', {type}, '{(status ? 1 : 0)}', N'{location}', GETDATE())";

                fn.setData(query, "Device Added");

                AddDeviceForm_Load(this, null);

                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill in all the required information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddDeviceForm_Load(object sender, EventArgs e)
        {

        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
