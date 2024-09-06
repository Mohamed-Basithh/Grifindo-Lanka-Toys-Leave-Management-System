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
    public partial class Manage_Leave_Records : Form
    {
        public Manage_Leave_Records()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string LeaveId = txtleaveid.Text;
            string TypeName = cmbtypename.Text;
            string LeaveStart = dtpleavestart.Value.ToString("yyyy-MM-dd");
            string LeaveEnd = dtpleaveend.Value.ToString("yyyy-MM-dd");
            string Duration = txtduration.Text;
            string Reason = txtreason.Text;
            string Status = cmbstatus.Text;
            string Eid = txteid.Text;
            string AllocationId = txtallocationid.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "UPDATE applyleave SET " +
                "TypeName = @TypeName, " +
                "LeaveStart = @LeaveStart, " +
                "LeaveEnd = @LeaveEnd, " +
                "Duration = @Duration, " +
                "Reason = @Reason, " +
                "Status = @Status, " +
                "Eid = @Eid, " +
                "AllocationId = @AllocationId " +
                "WHERE LeaveId = @LeaveId";



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
                            MessageBox.Show("Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No Record Was Updated!");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtleaveid.Text = row.Cells["LeaveId"].Value.ToString();
                cmbtypename.Text = row.Cells["TypeName"].Value.ToString();
                dtpleavestart.Value = Convert.ToDateTime(row.Cells["LeaveStart"].Value);
                dtpleaveend.Value = Convert.ToDateTime(row.Cells["LeaveEnd"].Value);
                txtduration.Text = row.Cells["Duration"].Value.ToString();
                txtreason.Text = row.Cells["Reason"].Value.ToString();
                cmbstatus.Text = row.Cells["Status"].Value.ToString();
                txteid.Text = row.Cells["Eid"].Value.ToString();
                txtallocationid.Text = row.Cells["AllocationId"].Value.ToString();
            }
        }

        private void Manage_Leave_Records_Load(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";
            string query = "SELECT LeaveId, TypeName, LeaveStart, LeaveEnd, Duration, Reason, Status, Eid, AllocationId FROM applyleave WHERE Status = 'pending';";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtleaveid.Text = "";
            cmbtypename.Text = "";
            dtpleavestart.Value = DateTime.Now;
            dtpleaveend.Value = DateTime.Now;
            txtduration.Text = "";            
            txtreason.Text = "";
            cmbstatus.Text = "";
            txteid.Text = "";
            txtallocationid.Text = "";
        }
    }
}
