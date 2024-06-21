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

namespace STgui
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;user id=root;password=;database=stock_db";
                MySqlConnection con = new MySqlConnection(connection);
                con.Open();
                string data = "SELECT * FROM transactionlog_table";
                MySqlCommand cmd = new MySqlCommand(data, con);
                MySqlDataAdapter dataadpt = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                dataadpt.Fill(datatable);
                dataGridView1.DataSource = datatable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unxpected error occured , please try restarting application " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
