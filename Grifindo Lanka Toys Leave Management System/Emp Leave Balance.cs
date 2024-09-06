using MySql.Data.MySqlClient;
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
    public partial class Emp_Leave_Balance : Form
    {
        public Emp_Leave_Balance()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string Eid = txteid.Text;
            string AnnualLeaveBalance = txtannualleavebalance.Text;
            string CasualLeaveBalance = txtcasualleavebalance.Text;
            string ShortLeaveBalance = txtshortleavebalance.Text;


            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "INSERT INTO employeeleavebalance (Eid, AnnualLeaveBalance, CasualLeaveBalance, ShortLeaveBalance) " +
                           "VALUES (@Eid, @AnnualLeaveBalance, @CasualLeaveBalance, @ShortLeaveBalance)";


            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Eid", Eid);
                    cmd.Parameters.AddWithValue("@AnnualLeaveBalance", AnnualLeaveBalance);
                    cmd.Parameters.AddWithValue("@CasualLeaveBalance", CasualLeaveBalance);
                    cmd.Parameters.AddWithValue("@ShortLeaveBalance", ShortLeaveBalance);


                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee leave balance added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Unable to add employee leave balance.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }



        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            string Eid = txteid.Text;
            string AnnualLeaveBalance = txtannualleavebalance.Text;
            string CasualLeaveBalance = txtcasualleavebalance.Text;
            string ShortLeaveBalance = txtshortleavebalance.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "UPDATE employeeleavebalance SET " + "AnnualLeaveBalance = @AnnualLeaveBalance, " + "CasualLeaveBalance = @CasualLeaveBalance, " +
                           "ShortLeaveBalance = @ShortLeaveBalance " + "WHERE Eid = @Eid";


            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Eid", Eid);
                    cmd.Parameters.AddWithValue("@AnnualLeaveBalance", AnnualLeaveBalance);
                    cmd.Parameters.AddWithValue("@CasualLeaveBalance", CasualLeaveBalance);
                    cmd.Parameters.AddWithValue("@ShortLeaveBalance", ShortLeaveBalance);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee leave balance successfully updated.");
                        }
                        else
                        {
                            MessageBox.Show("Unable to update employee leave balance.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }




        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee leave balance record?", "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

                string query = "DELETE FROM employeeleavebalance WHERE Eid = @Eid";

                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Eid", txteid.Text);
                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee leave balance record successfully deleted.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete employee leave balance record.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Delete Operation Canceled.");
            }




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Menu mm2 = new Main_Menu("Admin");
            this.Hide();
            mm2.ShowDialog();

            this.Close();
        }
    }
}
