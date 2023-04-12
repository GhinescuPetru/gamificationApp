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
using System.Net.Mail;

namespace gameApp
{
    public partial class RegisterForm : Form
    {
        private Form1 form1;
        public RegisterForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NSMD3G2;Initial Catalog=gameApp;Integrated Security=True");

        private void tryRegisterButton_Click(object sender, EventArgs e)
        {
            string username = userRegisterBox.Text;
            string password = passwordRegisterBox.Text;
            string email = emailRegisterBox.Text;
            bool emailVerify = false;

            try
            {
                conn.Open();
                String querry = "SELECT * FROM Player WHERE username = @username OR email = @email";
                SqlCommand checkUserCmd = new SqlCommand(querry, conn);

                checkUserCmd.Parameters.AddWithValue("@username", username);
                checkUserCmd.Parameters.AddWithValue("@email", email);

                SqlDataReader reader = checkUserCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Username or email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username/email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                var mailAddress = new MailAddress(email);
                emailVerify = (mailAddress.Address == email);
            }
            catch
            {
                emailVerify =  false;
            }

            if (emailVerify == false) {
                MessageBox.Show("Invalid email adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8 || !password.Any(char.IsSymbol) || !password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain a special character, a digit and an uppercase letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO Player (username, email, password, level, tokens) VALUES (@username, @email, @password, @level, @tokens)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@level", 1);
                insertCmd.Parameters.AddWithValue("@tokens", 100);

                int rowsAffected = insertCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm(username, 1, 100);
                    mainForm.Show();
                    this.Close();
                    this.form1.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
