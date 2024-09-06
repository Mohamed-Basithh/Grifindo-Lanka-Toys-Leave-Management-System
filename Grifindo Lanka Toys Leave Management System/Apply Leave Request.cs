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
    public partial class Apply_Leave_Request : Form
    {
        public Apply_Leave_Request()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string LeaveId = txtleaveid.Text;
            string TypeName = cmbtypename.Text;
            DateTime LeaveStart = dtpleavestart.Value;
            DateTime LeaveEnd = dtpleaveend.Value;
            string Duration = txtduration.Text;
            string Reason = txtreason.Text;
            string Status = cmbstatus.Text;
            string Eid = txteid.Text;
            string AllocationId = txtallocationid.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "INSERT INTO applyleave (LeaveId, TypeName, LeaveStart, LeaveEnd, Duration, Reason, Status, Eid, AllocationId) " +
                           "VALUES (@LeaveId, @TypeName, @LeaveStart, @LeaveEnd, @Duration, @Reason, @Status, @Eid, @AllocationId)";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LeaveId", LeaveId);
                    cmd.Parameters.AddWithValue("@TypeName", TypeName);
                    cmd.Parameters.AddWithValue("@LeaveStart", LeaveStart);
                    cmd.Parameters.AddWithValue("@LeaveEnd", LeaveEnd);
                    cmd.Parameters.AddWithValue("@Duration", Duration);
                    cmd.Parameters.AddWithValue("@Reason", Reason);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Eid", Eid);
                    cmd.Parameters.AddWithValue("@AllocationId", AllocationId);
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave Request Sent Successfully");
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchleaveid = txtleaveid.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "SELECT * FROM applyleave WHERE LeaveId = @LeaveId";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LeaveId", searchleaveid);
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtleaveid.Text = reader["LeaveId"].ToString();
                                cmbtypename.Text = reader["TypeName"].ToString();
                                dtpleavestart.Value = Convert.ToDateTime(reader["LeaveStart"]);
                                dtpleaveend.Value = Convert.ToDateTime(reader["LeaveEnd"]);
                                txtduration.Text = reader["Duration"].ToString();
                                txtreason.Text = reader["Reason"].ToString();
                                cmbstatus.Text = reader["Status"].ToString();
                                txteid.Text = reader["Eid"].ToString();
                                txtallocationid.Text = reader["allocationId"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("No Record Found!");
                            }
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
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete this Request?", "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

                string query = "DELETE FROM applyleave WHERE LeaveId = @LeaveId";

                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LeaveId", txtleaveid.Text);
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
