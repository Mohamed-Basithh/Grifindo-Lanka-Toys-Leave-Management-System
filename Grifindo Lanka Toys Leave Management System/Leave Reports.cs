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
    public partial class Leave_Reports : Form
    {
        public Leave_Reports()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string Eid = txteid.Text;
            DateTime StartDate = dtpstartdate.Value.Date;
            DateTime EndDate = dtpenddate.Value.Date;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    string query = @"
                SELECT e.Eid, e.LastName, a.TypeName, a.LeaveStart, a.LeaveEnd, a.Reason, a.Status
                FROM employee e
                JOIN applyleave a ON e.Eid = a.Eid
                WHERE e.Eid = @Eid
                AND a.LeaveStart >= @StartDate
                AND a.LeaveEnd <= @EndDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Eid", Eid);
                        cmd.Parameters.AddWithValue("@StartDate", StartDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@EndDate", EndDate.ToString("yyyy-MM-dd"));

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView2.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No records found for the given criteria.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Menu mm2 = new Main_Menu("Admin");
            this.Hide();
            mm2.ShowDialog();

            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
