using System;
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

namespace STgui
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=stock_db";

            if (string.IsNullOrEmpty(usernametxt.Text) || string.IsNullOrEmpty(passwordtxt.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                MySqlConnection con = new MySqlConnection(connection);

                try
                {
                    con.Open();
                    string selectQuery = "SELECT * FROM user_details WHERE Username = '" + usernametxt.Text + "' AND Password = '" + passwordtxt.Text + "';";
                    MySqlCommand command = new MySqlCommand(selectQuery, con);
                    MySqlDataReader mdr;
                    mdr = command.ExecuteReader();
                    if (mdr.Read())
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();

                        Form2 f2 = new Form2();
                        f2.Show();

                    }
                    else
                    {

                        MessageBox.Show("Incorrect Login Information! Try again.");
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error");
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
