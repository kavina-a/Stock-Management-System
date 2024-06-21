    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace STgui
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void addqbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int addedQuantity = int.Parse(addingqtxtbox.Text);
                int addedStockCode = int.Parse(exsctxtbox.Text);
                DateTime datetime = DateTime.Now;


                if ((addedQuantity < 0) || (addedStockCode < 0))
                {
                    MessageBox.Show("Invalid Input: Stock Code and Quantity must be non-negative values.");
                }


                else
                {
                    // Create an object of the stockitem class using the second constructor
                    stockitem item = new stockitem(datetime, addedStockCode, addedQuantity);
                    item.quantAdd(addedQuantity);

                    addingqtxtbox.Text = "";
                    exsctxtbox.Text = "";


                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input : Please enter valid numeric values " + ex.Message, "Error");
            }


            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error");
            }


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}


