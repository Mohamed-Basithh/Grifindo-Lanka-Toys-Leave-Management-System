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
    public partial class Leave_History : Form
    {

        public Leave_History()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string Eid = txteid.Text;
            DateTime StartDate = dtpstartdate.Value.Date;
            DateTime EndDate = dtpenddate.Value.Date;

            string query = @"
        SELECT e.Eid, e.FirstName, e.LastName, a.TypeName, a.Status
        FROM `employee` e
        JOIN `applyleave` a ON e.Eid = a.Eid
        WHERE e.Eid = @Eid
        AND a.LeaveStart <= @EndDate
        AND a.LeaveEnd >= @StartDate;";

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Eid", Eid);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
