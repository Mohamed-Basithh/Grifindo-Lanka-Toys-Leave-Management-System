using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    public partial class Roaster : Form
    {
        public Roaster()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string RoasterId = txtroasterid.Text;
            DateTime StartTime = dtpstarttime.Value;
            DateTime EndTime = dtpendtime.Value;
            string Eid = txteid.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "INSERT INTO roaster (RoasterId, StartTime, EndTime, Eid) " +
                           "VALUES (@RoasterId, @StartTime, @EndTime, @Eid)";


            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoasterId", RoasterId);
                    cmd.Parameters.AddWithValue("@StartTime", StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", EndTime);
                    cmd.Parameters.AddWithValue("@Eid", Eid);


                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Roaster details successfully inserted");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert roaster details.");
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
            string RoasterId = txtroasterid.Text;
            DateTime StartTime = dtpstarttime.Value;
            DateTime EndTime = dtpendtime.Value;
            string Eid = txteid.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "UPDATE roaster SET " + "StartTime = @StartTime, " + "EndTime = @EndTime, " +
                           "Eid = @Eid " + "WHERE RoasterId = @RoasterId";


            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoasterId", RoasterId);
                    cmd.Parameters.AddWithValue("@StartTime", StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", EndTime);
                    cmd.Parameters.AddWithValue("@Eid", Eid);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Roaster details successfully updated");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update roaster details");
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
            DialogResult result = MessageBox.Show("Are you sure you want to delete the roaster details?", "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

                string query = "DELETE FROM roaster WHERE RoasterId = @RoasterId";

                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoasterId", txtroasterid.Text);
                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Roaster details successfully deleted");
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete roaster details");
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
