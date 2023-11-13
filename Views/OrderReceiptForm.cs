using CofeeShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeeShop.Views
{
    public partial class OrderReceiptForm : Form
    {
        public OrderReceiptForm(Order order)
        {
            InitializeComponent();
            DisplayOrderDetails(order);
        }

        private void DisplayOrderDetails(Order order)
        {
            // Display order details in the form's UI
            lblCustomerName.Text = "Customer Name: " + order.CustomerName;
            lblOrderDate.Text = "Order Date: " + order.OrderDate.ToShortDateString();
            lblOrderTime.Text = "Order Time: " + order.OrderDate.ToString(@"hh\:mm\:ss");

            // Display ordered items
            StringBuilder itemsText = new StringBuilder();
            foreach (var orderItem in order.OrderItems)
            {
                itemsText.AppendLine($"---> {orderItem.Quantity} x {orderItem.MenuItem.ShortDescription} - {orderItem.MenuItem.RetailPrice:C} each");
            }
            // Display the items in a multiline textbox
            txtOrderedItems.Text = itemsText.ToString();

            // Display total cost
            lblTotalCost.Text = "Total Cost: " + order.TotalCost.ToString("C");
            lblTax.Text = "Tax: " + order.TaxValue.ToString("C");
            lblAmountToPay.Text = "Amount To Pay: " + (order.TaxValue + order.TotalCost).ToString("C");

        }

        private void OrderReceiptForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
