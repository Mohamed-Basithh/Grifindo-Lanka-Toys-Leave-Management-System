using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    public partial class Emp_Register : Form
    {
        public Emp_Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Eid = txteid.Text;
            string FirstName = txtfirstname.Text;
            string LastName = txtlastname.Text;
            string DateOfBirth = dtpdateofbirth.Value.ToString("yyyy-MM-dd");
            string MobileNo = txtmobileno.Text;
            string Position = cmbposition.Text;
            string JoinDate = dtpjoindate.Value.ToString("yyyy-MM-dd");
            string PermanentEmployee = cmbpermanentemployee.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "INSERT INTO employee (Eid, FirstName, LastName, DateOfBirth, MobileNo, Position, JoinDate, PermanentEmployee) " +
                           "VALUES (@Eid, @FirstName, @LastName, @DateOfBirth, @MobileNo, @Position, @JoinDate, @PermanentEmployee)";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Eid", Eid);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@MobileNo", MobileNo);
                    cmd.Parameters.AddWithValue("@Position", Position);
                    cmd.Parameters.AddWithValue("@JoinDate", JoinDate);
                    cmd.Parameters.AddWithValue("@PermanentEmployee", PermanentEmployee);

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


        private void button4_Click(object sender, EventArgs e)
        {
            string Eid = txteid.Text;
            string FirstName = txtfirstname.Text;
            string LastName = txtlastname.Text;
            string DateOfBirth = dtpdateofbirth.Value.ToString("yyyy-MM-dd");
            string MobileNo = txtmobileno.Text;
            string Position = cmbposition.Text;
            string JoinDate = dtpjoindate.Value.ToString("yyyy-MM-dd");
            string PermanentEmployee = cmbpermanentemployee.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "UPDATE employee SET " + "FirstName = @FirstName, " + "LastName = @LastName, " +
                           "DateOfBirth = @DateOfBirth, " + "MobileNo = @MobileNo, " + "Position = @Position, " +
                           "JoinDate = @JoinDate, " + "PermanentEmployee = @PermanentEmployee " + "WHERE Eid = @Eid";


            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Eid", Eid);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@MobileNo", MobileNo);
                    cmd.Parameters.AddWithValue("@Position", Position);
                    cmd.Parameters.AddWithValue("@JoinDate", JoinDate);
                    cmd.Parameters.AddWithValue("@PermanentEmployee", PermanentEmployee);

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete this Record?", "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

                string query = "DELETE FROM employee WHERE Eid = @Eid";


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

        private void btnsearch_Click(object sender, EventArgs e)
        {

            string searcheid = txteid.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

            string query = "SELECT * FROM employee WHERE Eid = @Eid";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Eid", searcheid);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtfirstname.Text = reader["FirstName"].ToString();
                                txtlastname.Text = reader["LastName"].ToString();
                                dtpdateofbirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                                txtmobileno.Text = reader["MobileNo"].ToString();
                                cmbposition.Text = reader["Position"].ToString();
                                dtpjoindate.Value = Convert.ToDateTime(reader["JoinDate"]);
                                cmbpermanentemployee.Text = reader["PermanentEmployee"].ToString();

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

        private void btnclear_Click(object sender, EventArgs e)
        {

            txteid.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            dtpdateofbirth.Value = DateTime.Now;
            txtmobileno.Text = "";
            cmbposition.Text = "";
            dtpjoindate.Value = DateTime.Now;
            cmbpermanentemployee.Text = "";

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
