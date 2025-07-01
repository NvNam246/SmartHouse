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

namespace SmartHouse_App
{
    public partial class FormLogin : Form
    {
        function fn = new function();
        string query;
        public static string LoggedInUser = "";
        public static string UserRole = "";
        public static string UserName = "";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select Username,Password,Role from [Users] where Username = '" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'";
            DataSet ds = fn.GetData(query);


            if (ds.Tables[0].Rows.Count != 0)
            {
                lblError.Visible = false;
                LoggedInUser = txtUsername.Text;
                UserRole = ds.Tables[0].Rows[0]["Role"].ToString().ToLower();


                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                lblError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
