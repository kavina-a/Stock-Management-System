
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STgui
{
    class transactionlog
    {
        private int Stockcode;
        private string Name;
        private int Quantity;
        private DateTime DateandTime;

        private int Addingquantity;


        public transactionlog(DateTime datetime, int stockcode, string name, int quantity,int addingquantity)
        {
            DateandTime = datetime;
            Stockcode = stockcode;
            Name = name;
            Quantity = quantity;
            Addingquantity = addingquantity;
        }

  

        public int getstockcode()
        {
            return Stockcode;
        }

        public void Setstockcode(int stockcode)
        {
            Stockcode = stockcode;
        }

        public string getName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int getQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public DateTime getdateandtime()
        {
            return DateandTime;
        }

        public void setDateandTime(DateTime dateandtime)
        {
            DateandTime = dateandtime;
        }

        public int getaddingQuantity()
        {
            return Addingquantity;
        }

        public void SetaddingQuantity(int addingquantity)
        {
            Addingquantity = addingquantity;
        }


        public void saveLog()
        {
            //ADD THE DETAILS TO THE STOCK TABLE 
            string connection2 = "server=localhost;user id=root;password=;database=stock_db";
            string formattedDateTime = this.DateandTime.ToString("yyyy-MM-dd HH:mm:ss");
            string data2 = "INSERT INTO transactionlog_table(DateandTime, Description, StockCode, StockitemName, QuantityAdded, NewQuantityInStock) " +
                           "VALUES('" + formattedDateTime + "','" + "ITEM ADDED" + "','" + this.Stockcode + "','" + this.Name + "','" + this.Quantity + "','" + this.Quantity + "')";
            MySqlConnection con2 = new MySqlConnection(connection2);
            MySqlCommand cmd2 = new MySqlCommand(data2, con2);
            MySqlDataReader datareader2;
            con2.Open();
            datareader2 = cmd2.ExecuteReader();
            con2.Close();
        }

    }
}
