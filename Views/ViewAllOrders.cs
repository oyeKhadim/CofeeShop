using CofeeShop.Controllers;
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
    public partial class ViewAllOrders : Form
    {
        private CoffeeShopController coffeeShopController;
        List<Order> orders;
        public ViewAllOrders(CoffeeShopController coffeeShopController)
        {
            InitializeComponent();

            this.coffeeShopController = coffeeShopController;
        }

        private void ViewAllOrders_Load(object sender, EventArgs e)
        {
            orders = coffeeShopController.GetOrders();
            //dgvOrders.DataSource = orders;
            foreach (var order in orders)
            {
                // Extract the information you need from the order
                string customerName = order.CustomerName;
                string employeeName = order.EmployeeName;
                DateTime date = order.OrderDate;
                decimal cost = order.TotalCost;
                int tax = order.TaxValue;

                // Create a new row for the DataGridView
                dgvOrders.Rows.Add(customerName, employeeName,date, cost.ToString("C"), tax.ToString("C"), (cost + tax).ToString("C"));
            }
        }
    }
}
