using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Models
{
    public class Order
    {
        // Private fields with proper naming conventions
        private string customerName;
        private string employeeName;
        private DateTime orderDate;
        private List<OrderItem> orderItems;
        private decimal totalCost;
        private int taxValue;

        // Properties using C# naming conventions
        public string CustomerName
        {
            get { return this.customerName; }
            private set { this.customerName = value; }
        }
        public string EmployeeName
        {
            get { return this.employeeName; }
            private set { this.employeeName = value; }
        }

        public DateTime OrderDate
        {
            get { return this.orderDate; }
            private set { this.orderDate = value; }
        }



        public List<OrderItem> OrderItems
        {
            get { return this.orderItems; }
             set { this.orderItems = value; }
        }
        public decimal TotalCost
        {
            get { return this.totalCost; }
            set { this.totalCost = value; }
        }
        public int TaxValue
        {
            get { return this.taxValue; }
            set { this.taxValue = value; }
        }


        public Order(string customerName, string employeeName)
        {
            EmployeeName = employeeName;
            CustomerName = customerName;
            OrderDate = DateTime.Now;
            OrderItems = new List<OrderItem>();
            TotalCost = 0;
        }

        public Order(string customerName, string employeeName,DateTime date, decimal cost, int tax)
        {
            EmployeeName = employeeName;
            CustomerName = customerName;
            OrderDate = date;
            OrderItems = new List<OrderItem>();
            TotalCost = cost;
            this.taxValue = tax;
        }


        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var orderItem in OrderItems)
            {
                totalCost += orderItem.CalculateItemTotal();
            }
            return totalCost;
        }


    }
}
