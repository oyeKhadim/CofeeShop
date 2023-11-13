using CofeeShop.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CofeeShop.Controllers
{
    public class CoffeeShopController
    {

        private List<MenuItem> menu;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CoffeeShop.accdb";

        public CoffeeShopController()
        {
            menu = new List<MenuItem>();
            LoadMenu();  // Load menu from file on initialization
        }

        public void CreateMenuItem(string itemID, string category, string shortDescription, string longDescription, decimal retailPrice, decimal costPrice, string imageURL)
        {
            // Create a new menu item object (you might need to modify this to match your database structure)
            MenuItem newItem = new MenuItem(itemID, category, shortDescription, longDescription, retailPrice, costPrice, imageURL);

            try
            {
                // Establish a database connection (replace the connection string with your own)
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Create an SQL INSERT statement
                    string insertSql = "INSERT INTO Menu  " +
                                      "VALUES (@ItemID, @Category, @ShortDescription, @LongDescription, @RetailPrice, @CostPrice, @ImageURL)";

                    using (OleDbCommand cmd = new OleDbCommand(insertSql, connection))
                    {
                        // Set parameters
                        cmd.Parameters.AddWithValue("@ItemID", newItem.ItemID);
                        cmd.Parameters.AddWithValue("@Category", newItem.Category);
                        cmd.Parameters.AddWithValue("@ShortDescription", newItem.ShortDescription);
                        cmd.Parameters.AddWithValue("@LongDescription", newItem.LongDescription);
                        cmd.Parameters.AddWithValue("@RetailPrice", newItem.RetailPrice);
                        cmd.Parameters.AddWithValue("@CostPrice", newItem.CostPrice);
                        cmd.Parameters.AddWithValue("@ImageURL", newItem.ImageURL);

                        // Execute the INSERT command
                        cmd.ExecuteNonQuery();
                    }
                }
                menu.Add(newItem);
            }
            catch (OleDbException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void LoadMenu()
        {
            try
            {
                // Establish a database connection
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Create an SQL SELECT statement
                    string selectSql = "SELECT * FROM Menu";

                    using (OleDbCommand cmd = new OleDbCommand(selectSql, connection))
                    {
                        List<MenuItem> menu = new List<MenuItem>();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create MenuItem objects based on database records
                                MenuItem menuItem = new MenuItem(
                                    reader["ItemID"].ToString(),
                                    reader["Category"].ToString(),
                                    reader["ShortDescription"].ToString(),
                                    reader["LongDescription"].ToString(),
                                    Convert.ToDecimal(reader["RetailPrice"]),
                                    Convert.ToDecimal(reader["CostPrice"]),
                                    reader["ImgURL"].ToString()
                                );
                                menu.Add(menuItem);
                            }
                        }
                        this.menu = menu;
                    }
                }
            }
            catch (OleDbException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<MenuItem> GetMenu()
        {
            return menu;
        }
        public List<MenuItem> GetMenuByCategory(string category)
        {
            // Simulated data retrieval based on category
            return menu.Where(item => item.Category == category).ToList();
        }

        public MenuItem GetMenuItemByID(string itemID)
        {
            // Simulated data retrieval based on item ID
            return menu.FirstOrDefault(item => item.ItemID == itemID);
        }

        internal void UpdateMenuItem(string itemID, string category, string shortDescription, string longDescription, decimal retailPrice, decimal costPrice, string imageURL)
        {
            try
            {
                // Establish a database connection
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Create an SQL UPDATE statement
                    string updateSql = "UPDATE Menu SET Category = @Category, ShortDescription = @ShortDescription, LongDescription = @LongDescription, RetailPrice = @RetailPrice, CostPrice = @CostPrice, ImgURL = @ImageURL WHERE ItemID = @ItemID";

                    using (OleDbCommand cmd = new OleDbCommand(updateSql, connection))
                    {
                        // Set parameters
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@ShortDescription", shortDescription);
                        cmd.Parameters.AddWithValue("@LongDescription", longDescription);
                        cmd.Parameters.AddWithValue("@RetailPrice", retailPrice);
                        cmd.Parameters.AddWithValue("@CostPrice", costPrice);
                        cmd.Parameters.AddWithValue("@ImageURL", imageURL);
                        cmd.Parameters.AddWithValue("@ItemID", itemID);

                        // Execute the UPDATE command
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update the local list of menu items (if needed)
                var menuItem = menu.FirstOrDefault(item => item.ItemID == itemID);
                if (menuItem != null)
                {
                    menuItem.Category = category;
                    menuItem.ShortDescription = shortDescription;
                    menuItem.LongDescription = longDescription;
                    menuItem.RetailPrice = retailPrice;
                    menuItem.CostPrice = costPrice;
                    menuItem.ImageURL = imageURL;
                }
            }
            catch (OleDbException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        internal void DeleteMenuItem(string selectedItemID)
        {
            try
            {
                // Establish a database connection
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Create an SQL DELETE statement
                    string deleteSql = "DELETE FROM Menu WHERE ItemID = @ItemID";

                    using (OleDbCommand cmd = new OleDbCommand(deleteSql, connection))
                    {
                        // Set parameters
                        cmd.Parameters.AddWithValue("@ItemID", selectedItemID);

                        // Execute the DELETE command
                        cmd.ExecuteNonQuery();
                    }
                }

                // Remove the menu item from the local list (if needed)
                var menuItem = menu.FirstOrDefault(item => item.ItemID == selectedItemID);
                if (menuItem != null)
                {
                    menu.Remove(menuItem);
                }
            }
            catch (OleDbException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool CreateOrder(Order order)
        {
            try
            {
                // Establish a database connection
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Create an SQL INSERT statement for orders
                    string insertOrderSql = "INSERT INTO Orders (CustomerName, EmployeeName,OrderDate,  TotalCost, TaxValue) " +
                                             "VALUES (@CustomerName, @EmployeeName,@OrderDate,  @TotalCost, @TaxValue)";

                    using (OleDbCommand cmd = new OleDbCommand(insertOrderSql, connection))
                    {
                        // Set parameters for the order
                        cmd.Parameters.AddWithValue("@CustomerName", order.CustomerName);
                        cmd.Parameters.AddWithValue("@EmployeeName", order.EmployeeName);
                        cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate.ToString());
                        cmd.Parameters.AddWithValue("@TotalCost", order.TotalCost);
                        cmd.Parameters.AddWithValue("@TaxValue", order.TaxValue);

                        // Execute the INSERT command for orders
                        cmd.ExecuteNonQuery();
                    }


                }
                return true;
            }
            catch (OleDbException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            try
            {
                // Establish a database connection
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Create an SQL SELECT statement to retrieve orders
                    string selectOrdersSql = "SELECT * FROM Orders";

                    using (OleDbCommand cmd = new OleDbCommand(selectOrdersSql, connection))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create Order objects based on database records
                                Order order = new Order(
                                    reader["CustomerName"].ToString(),
                                    reader["EmployeeName"].ToString(),
                                    Convert.ToDateTime(reader["OrderDate"]),
                                   

                                    Convert.ToDecimal(reader["TotalCost"]),
                                    Convert.ToInt32(reader["TaxValue"])
                                );
                                // Add the order to the list
                                orders.Add(order);
                            }
                        }
                    }
                }
            }
            catch (OleDbException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return orders;
        }

    }
}




