using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace gameApp
{
    public partial class LoginForm : Form
    {
        private Form1 form1;
        public LoginForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NSMD3G2;Initial Catalog=gameApp;Integrated Security=True");


        private void tryLoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameLoginBox.Text;
            string password = passwordLoginBox.Text;

            try
            {
                conn.Open();
                String querry = "SELECT * FROM Player WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();

                if (reader.Read())
                {
                    int level = reader.GetInt32(reader.GetOrdinal("level"));
                    int tokens = reader.GetInt32(reader.GetOrdinal("tokens"));
                    MessageBox.Show("Login successful!");
                    MainForm mainForm = new MainForm(username, level, tokens);
                    mainForm.Show();
                    this.Close();
                    this.form1.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
