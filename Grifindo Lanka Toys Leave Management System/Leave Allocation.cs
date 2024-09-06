using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class Leave_Allocation : Form
    {
        public Leave_Allocation()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            string AllocationId = txtallocationid.Text;
            string AnnualLeaves = txtannualleaves.Text;
            string CasualLeaves = txtcasualleaves.Text;
            string ShortLeaves = txtshortleaves.Text;


            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "INSERT INTO leaveallocation (AllocationId, AnnualLeaves, CasualLeaves, ShortLeaves) " +
                           "VALUES (@AllocationId, @AnnualLeaves, @CasualLeaves, @ShortLeaves)";


            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AllocationId", AllocationId);
                    cmd.Parameters.AddWithValue("@AnnualLeaves", AnnualLeaves);
                    cmd.Parameters.AddWithValue("@CasualLeaves", CasualLeaves);
                    cmd.Parameters.AddWithValue("@ShortLeaves", ShortLeaves);


                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No Record Was Inserted!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Menu mm2 = new Main_Menu("Admin");
            this.Hide();
            mm2.ShowDialog();

            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string AllocationId = txtallocationid.Text;
            string AnnualLeaves = txtannualleaves.Text;
            string CasualLeaves = txtcasualleaves.Text;
            string ShortLeaves = txtshortleaves.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "UPDATE leaveallocation SET " + "AnnualLeaves = @AnnualLeaves, " + "CasualLeaves = @CasualLeaves, " +
                           "ShortLeaves = @ShortLeaves " + "WHERE AllocationId = @AllocationId";


            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AllocationId", AllocationId);
                    cmd.Parameters.AddWithValue("@AnnualLeaves", AnnualLeaves);
                    cmd.Parameters.AddWithValue("@CasualLeaves", CasualLeaves);
                    cmd.Parameters.AddWithValue("@ShortLeaves", ShortLeaves);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No Record Was Inserted!");
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
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete this Record?", "Confirm Delete",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

                string query = "DELETE FROM leaveallocation WHERE AllocationId = @AllocationId";

                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AllocationId", txtallocationid.Text);

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Deleted Successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No Record Was Deleted.");
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
    }
}
