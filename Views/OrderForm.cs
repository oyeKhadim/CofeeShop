using CofeeShop.Controllers;
using CofeeShop.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeeShop.Views
{
    public partial class OrderForm : Form
    {
        private CoffeeShopController coffeeShopController;
        private List<MenuItem> menuItems;
        private List<OrderItem> selectedItems;
        public OrderForm(CoffeeShopController controller)
        {
            coffeeShopController = controller;
            menuItems = coffeeShopController.GetMenu();
            selectedItems = new List<OrderItem>();
            InitializeComponent();
            PopulateMenuItems();
        }
        private void PopulateMenuItems()
        {
            // Clear existing items in the ListView
            listViewMenu.Items.Clear();

            // Get the menu from the CoffeeShopController
            List<MenuItem> menu = coffeeShopController.GetMenu();

            // Populate the ListView with menu items
            foreach (var item in menu)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemID);
                listViewItem.SubItems.Add(item.ShortDescription);
                listViewItem.SubItems.Add(item.Category);
                listViewItem.SubItems.Add(item.RetailPrice.ToString());
                listViewMenu.Items.Add(listViewItem);
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (listViewMenu.SelectedItems.Count >= 1)
            {
                // Get the selected menu item's ID
                string selectedItemID = listViewMenu.SelectedItems[0].SubItems[0].Text;

                // Find the menu item with the selected ID
                MenuItem selectedMenuItem = menuItems.Find(item => item.ItemID == selectedItemID);

                int quantity = 0;
                try
                {
                    // Attempt to parse the text from textBoxQuantity to an integer
                    if (!int.TryParse(textBoxQuantity.Text, out quantity) || quantity <= 0)
                    {
                        // Parsing failed, display an error message
                        throw new Exception("Please enter a valid integer for the quantity.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add the selected item and quantity to the order
                OrderItem orderItem = new OrderItem(selectedMenuItem, quantity);
                selectedItems.Add(orderItem);
                UpdateOrderSummary(orderItem);
            }
        }

        private void UpdateOrderSummary(OrderItem orderItem)
        {
            ListViewItem listViewItem = new ListViewItem(orderItem.MenuItem.ItemID);
            listViewItem.SubItems.Add(orderItem.MenuItem.ShortDescription);
            listViewItem.SubItems.Add(orderItem.MenuItem.Category);
            listViewItem.SubItems.Add(orderItem.MenuItem.RetailPrice.ToString());
            listViewItem.SubItems.Add(orderItem.Quantity.ToString());
            listViewOrder.Items.Add(listViewItem);
            updateCost();

        }

        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                // Get the selected order item's index
                int selectedIndex = listViewOrder.SelectedIndices[0];

                // Remove the selected item from the order
                selectedItems.RemoveAt(selectedIndex);
                UpdateOrderSummary();
            }

        }
        private decimal CalculateTotalCost()
        {
            decimal totalCost = 0;

            foreach (var orderItem in selectedItems)
            {
                totalCost += orderItem.MenuItem.RetailPrice * orderItem.Quantity;
            }

            return totalCost;
        }
        private void UpdateOrderSummary()
        {
            // Clear existing items in the order summary ListView
            listViewOrder.Items.Clear();

            // Iterate through the selected items and add them to the order summary
            foreach (var orderItem in selectedItems)
            {
                ListViewItem listViewItem = new ListViewItem(orderItem.MenuItem.ItemID);
                listViewItem.SubItems.Add(orderItem.MenuItem.ShortDescription);
                listViewItem.SubItems.Add(orderItem.MenuItem.Category);
                listViewItem.SubItems.Add(orderItem.MenuItem.RetailPrice.ToString());
                listViewItem.SubItems.Add(orderItem.Quantity.ToString());
                listViewOrder.Items.Add(listViewItem);
            }

            updateCost();
        }

        private void updateCost()
        {
            // Calculate and display the total cost
            decimal totalCost = CalculateTotalCost();
            lblTotalCost.Text = "Total Cost: " + totalCost.ToString("C");
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            // Clear the selected items and reset UI
            selectedItems.Clear();
            UpdateOrderSummary();
            textBoxCustomerName.Text = string.Empty;
        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {

            // Get customer name
            string customerName = textBoxCustomerName.Text.Trim(); // Trim to remove leading and trailing spaces

            // Check if customer name is empty
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter the customer's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the function without further processing
            }
            string employeeName = textBoxEmployeeName.Text.Trim(); // Trim to remove leading and trailing spaces

            // Check if customer name is empty
            if (string.IsNullOrEmpty(employeeName))
            {
                MessageBox.Show("Please enter the employees's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the function without further processing
            }

            // Check if there are no items in the order
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select items to order.", "No Items in Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the function without further processing
            }
            // Prompt the user for tax value and validate it
            int taxValue = 0;
            bool validTax = false;
            try
            {
                while (!validTax)
                {
                    string taxInput = Interaction.InputBox("Enter the tax value:", "Tax Value", "", -1, -1);

                    // Handle the case when the user clicks Cancel or closes the prompt
                    if (string.IsNullOrEmpty(taxInput))
                        return; // Exit the function

                    if (int.TryParse(taxInput, out taxValue) && taxValue >= 0)
                    {
                        validTax = true; // Valid tax value entered, exit the loop
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid positive integer for the tax value.", "Invalid Tax Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                // Handle any exceptions (e.g., if the user closes the prompt)
                return; // Exit the function
            }

            // Create the order
            Order order = new Order(customerName,employeeName);
            order.TaxValue = taxValue;

            // Calculate total cost
            decimal totalCost = CalculateTotalCost();
            order.TotalCost = totalCost;
            order.OrderItems = selectedItems;

            //save in DB
            if (coffeeShopController.CreateOrder(order))
            {
                MessageBox.Show("Order submitted successfully!", "Order Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Show Receipt
                OrderReceiptForm f = new OrderReceiptForm(order);
                f.ShowDialog();
            }
        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
            lblTotalCost.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}
