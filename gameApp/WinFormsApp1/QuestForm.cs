using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameApp
{
    public partial class QuestForm : Form
    {
        private SqlConnection conn;
        private string username;
        private int tokens;
        private MainForm mainForm;
        public QuestForm(SqlConnection conn, string username, int tokens, MainForm mainForm)
        {
            InitializeComponent();
            this.conn = conn;
            this.username = username;
            this.tokens = tokens;
            this.mainForm = mainForm;
        }

        private void createQuestButton_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text;
            string difficulty = difficultyComboBox.SelectedItem.ToString();
            int reward = (int)rewardNumericUpDown.Value;

            try
            {
                conn.Open();
                string query = "SELECT MAX(Id) FROM Quest";
                SqlCommand cmd = new SqlCommand(query, conn);
                int maxId = (int)cmd.ExecuteScalar();

                query = "INSERT INTO Quest (description, difficulty, tokens, id) VALUES (@description, @difficulty, @tokens, @maxId)";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@difficulty", difficulty);
                cmd.Parameters.AddWithValue("@tokens", reward);
                cmd.Parameters.AddWithValue("@maxId", maxId+1);
                cmd.ExecuteNonQuery();

                int newTokenBalance = tokens - reward;
                query = "UPDATE Player SET tokens = @newTokenBalance WHERE username = @username";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@newTokenBalance", newTokenBalance);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Quest created successfully!");
                this.Close();
                mainForm.refresh();
                
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

        private void QuestForm_Load(object sender, EventArgs e)
        {
            difficultyComboBox.Items.Add("Easy");
            difficultyComboBox.Items.Add("Normal");
            difficultyComboBox.Items.Add("Medium");
            difficultyComboBox.Items.Add("Hard");
        }
    }
}