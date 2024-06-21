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
using System.Xml.Linq;

namespace STgui
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int stockcode = int.Parse(stockcodetxtbox.Text);
                string stockname = stocknametxtbox.Text;
                int quantity = int.Parse(quantitytxtbox.Text);
                DateTime datetime = DateTime.Now;
                int addingquantity = int.Parse(quantitytxtbox.Text);

               
                 if ((stockcode < 0) || (quantity < 0))
                {
                    MessageBox.Show("Invalid Input: Stock Code and Quantity must be non-negative values.");
                }

               
                else
                {

                    // Object creation - creating an object in the stockitem class called item and passing the values
                    stockitem item = new stockitem(stockcode, stockname, quantity);
                    if (item.saveItem())
                    {
                        transactionlog log = new transactionlog(datetime, stockcode, stockname, quantity, addingquantity);
                        log.saveLog();

                        stockcodetxtbox.Text = "";
                        stocknametxtbox.Text = "";
                        quantitytxtbox.Text = "";

                    }
                }
            }

            //CATCH EXCEPTIONS 
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
