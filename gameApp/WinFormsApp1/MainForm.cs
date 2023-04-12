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

namespace gameApp
{
    public partial class MainForm : Form
    {
        string username;
        int level;
        int tokens;
        public MainForm(string username, int level, int tokens)
        {
            InitializeComponent();
            this.username = username;
            this.level = level;
            this.tokens = tokens;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NSMD3G2;Initial Catalog=gameApp;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, Color.DarkGoldenrod);
            label2.Text = username;
            label5.Text = tokens.ToString();
            label6.Text = level.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT username, level, tokens FROM Player", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            adapter = new SqlDataAdapter("SELECT description, difficulty, tokens FROM Quest", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        public void refresh()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT username, level, tokens FROM Player", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            adapter = new SqlDataAdapter("SELECT description, difficulty, tokens FROM Quest", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            QuestForm createQuestForm = new QuestForm(conn, username, tokens, this);
            createQuestForm.Show();
        }
    }
}
