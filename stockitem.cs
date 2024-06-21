using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace STgui
{
    class stockitem
    {
        private int Stockcode;
        private string Name;
        private int Quantity;
        private DateTime DateandTime;

        
        public stockitem(int stockcode, string name, int quantity)
        {

            Stockcode = stockcode;
            Name = name;
            Quantity = quantity;
        }

        public stockitem(DateTime datetime, int stockcode, int quantity)
        {
            DateandTime = datetime;
            Stockcode = stockcode;
            Quantity = quantity;
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

        public virtual bool saveItem()
        {
            //SQL CONNECTION
            string connection = "server=localhost;user id=root;password=;database=stock_db";
            MySqlConnection con = new MySqlConnection(connection);

            //SELECT AND STORE THE CODE THAT MATCHES WITH THE CODE ENTERED BY USER 
            string checkQuery = "SELECT 1 FROM stock_table WHERE Stockcode = @code";
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@code", this.Stockcode);


            con.Open();
            //CHECK IF THE CODE ENTERED HAS A MATCH IF NOT , IT WILL RETURN FALSE AND DISPLAY A MESSAGE
            using (MySqlDataReader reader = checkCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show("Stock item already exists!");
                    //con.Close();
                    return false;
                }
            }

            //INSERT A ROW INTO THE STOCK TABLE
            string data = "INSERT INTO stock_table(Stockcode, Name, Quantity) VALUES(@code, @name, @quantity)";
            MySqlCommand cmd = new MySqlCommand(data, con);
            cmd.Parameters.AddWithValue("@code", this.Stockcode);
            cmd.Parameters.AddWithValue("@name", this.Name);
            cmd.Parameters.AddWithValue("@quantity", this.Quantity);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Item added successfully");
            con.Close();
            return true;
        }



        public void quantAdd(int addingQuantity)
        {
            string connection = "server=localhost;user id=root;password=;database=stock_db";
            MySqlConnection stockSystemConn = new MySqlConnection(connection);

            //CHECKING ALL THE ROWS FROM THE STCOK TABLE  
            stockSystemConn.Open();
            string checkQuery = "SELECT COUNT(*) FROM stock_table WHERE StockCode = @code";
            MySqlCommand cmd = new MySqlCommand(checkQuery, stockSystemConn);
            cmd.Parameters.AddWithValue("@code", this.Stockcode);

            int itemExist = Convert.ToInt32(cmd.ExecuteScalar());

            if (itemExist > 0)
            {
                string getQuantityQuery = "SELECT Quantity FROM stock_table WHERE StockCode = @code";
               
                string getNameQuery = "SELECT Name FROM stock_table WHERE StockCode = @code"; 

                cmd = new MySqlCommand(getQuantityQuery, stockSystemConn);
                cmd.Parameters.AddWithValue("@code", this.Stockcode);

                int currentQuantity = Convert.ToInt32(cmd.ExecuteScalar());
                int newQuantity = currentQuantity + addingQuantity;

                cmd = new MySqlCommand(getNameQuery, stockSystemConn);
                cmd.Parameters.AddWithValue("@code", this.Stockcode);

                //STORING THE CODES NAME 
                string itemName = cmd.ExecuteScalar()?.ToString(); 

                string updateQuery = "UPDATE stock_table SET Quantity = @totalnewquantity WHERE StockCode = @code";
                cmd = new MySqlCommand(updateQuery, stockSystemConn);
                cmd.Parameters.AddWithValue("@totalnewquantity", newQuantity);
                cmd.Parameters.AddWithValue("@code", this.Stockcode);
                cmd.ExecuteNonQuery();

                string insertLogQuery = "INSERT INTO transactionlog_table (DateandTime, Description, StockCode, StockitemName, QuantityAdded, NewQuantityInStock) " +
                "VALUES (@dateandtime, @description, @stockcode, @name, @quantityAdded, @newQuantity)";

                try
                {
                    using (MySqlCommand logCmd = new MySqlCommand(insertLogQuery, stockSystemConn))
                    {
                        logCmd.Parameters.AddWithValue("@dateandtime", DateTime.Now); 
                        logCmd.Parameters.AddWithValue("@description", "QUANTITY ADDED");
                        logCmd.Parameters.AddWithValue("@stockcode", this.Stockcode);
                        logCmd.Parameters.AddWithValue("@quantityAdded", this.Quantity);
                        logCmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                        logCmd.Parameters.AddWithValue("@name", itemName); 
                        logCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Quantity successfully updated.New quantity in stock: " + newQuantity);
                    stockSystemConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,"error");
                }
            }
            else
            {
                MessageBox.Show("Item doesn't exist. Try adding the new stock");
                stockSystemConn.Close();
            }
        }
    }
}
