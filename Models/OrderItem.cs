using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Models
{
    public class OrderItem
    {

        // Private fields with proper naming conventions
        private MenuItem menuItem;
        private int quantity;

        // Properties using C# naming conventions
        public MenuItem MenuItem
        {
            get { return this.menuItem; }
            private set { this.menuItem = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            private set { this.quantity = value; }
        }

        public OrderItem(MenuItem menuItem, int quantity)
        {
            MenuItem = menuItem;
            Quantity = quantity;
        }

        public decimal CalculateItemTotal()
        {
            return MenuItem.RetailPrice * Quantity;
        }


    }
}
