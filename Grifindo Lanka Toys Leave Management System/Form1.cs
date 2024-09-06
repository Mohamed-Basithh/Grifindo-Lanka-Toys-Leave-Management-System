using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    public partial class Login_Page : Form
    {

        private string mysqlconn = "server=127.0.0.1;user=root;database=grifindo_leavemgmt_db;password=";

        public Login_Page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(170, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text.Trim();
            string Password = txtpassword.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    string query = "SELECT Role FROM login WHERE Username = @Username AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    conn.Open();
                    object? roleObj = cmd.ExecuteScalar();

                    if (roleObj != null)
                    {
                        string role = roleObj.ToString();

                        if (!string.IsNullOrEmpty(role))
                        {
                            this.Hide();
                            Main_Menu mainMenu = new Main_Menu(role);
                            mainMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }


    }
}
