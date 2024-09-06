using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    public partial class Main_Menu : Form
    {
        private string userRole;

        public Main_Menu(string role)
        {
            InitializeComponent(); 
            userRole = role; 
            ConfigureUIBasedOnRole(); 
        }

        private void ConfigureUIBasedOnRole()
        {
            if (userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                
                btnapplyleave.Visible = true;
                btnempregister.Visible = true;
                btnleaveallocation.Visible = true;
                btnroaster.Visible = true;
                btnempleavebalance.Visible = true;
                btnmanageleaverecords.Visible = true;
                btnleavereports.Visible = true;
                btnleavehistory.Visible = true;
            }
            else if (userRole.Equals("User", StringComparison.OrdinalIgnoreCase))
            {
           
                btnapplyleave.Visible = true;
                btnempregister.Visible = false;
                btnleaveallocation.Visible = false;
                btnroaster.Visible = false;
                btnempleavebalance.Visible = true;
                btnmanageleaverecords.Visible = false;
                btnleavereports.Visible = false;
                btnleavehistory.Visible = true;
            }
        }

       
        private void btnempregister_Click(object sender, EventArgs e)
        {
            Emp_Register er2 = new Emp_Register();
            this.Hide();
            er2.ShowDialog();

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Page lp2 = new Login_Page();
            this.Hide();
            lp2.ShowDialog();

            this.Close();
        }

        private void btnapplyleave_Click(object sender, EventArgs e)
        {
            Apply_Leave_Request alr2 = new Apply_Leave_Request();
            this.Hide();
            alr2.ShowDialog();

            this.Close();
        }

        private void btnmanageleaverecords_Click(object sender, EventArgs e)
        {
            Manage_Leave_Records mlr2 = new Manage_Leave_Records();
            this.Hide();
            mlr2.ShowDialog();

            this.Close();
        }

        private void btnleaveallocation_Click(object sender, EventArgs e)
        {
            Leave_Allocation la2 = new Leave_Allocation();
            this.Hide();
            la2.ShowDialog();

            this.Hide();
        }

        private void btnroaster_Click(object sender, EventArgs e)
        {
            Roaster r2 = new Roaster();
            this.Hide();
            r2.ShowDialog();

            this.Close();
        }

        private void btnviewstatus_Click(object sender, EventArgs e)
        {
            Emp_Leave_Balance elb2 = new Emp_Leave_Balance();
            this.Hide();
            elb2.ShowDialog();

            this.Close();
        }

        private void btnleavehistory_Click(object sender, EventArgs e)
        {
            Leave_History lh2 = new Leave_History();
            this.Hide();
            lh2.ShowDialog();

            this.Close();
        }

        private void btnleavereports_Click(object sender, EventArgs e)
        {
            Leave_Reports lr2 = new Leave_Reports();
            this.Hide();
            lr2.ShowDialog();

            this.Close();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
