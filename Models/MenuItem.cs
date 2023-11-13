using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Models
{
    public class MenuItem
    {

        // Private fields with proper naming conventions
        private string itemID;
        private string category;
        private string shortDescription;
        private string longDescription;
        private decimal retailPrice;
        private decimal costPrice;
        private string imageURL;

        // Properties using C# naming conventions
        public string ItemID
        {
            get { return this.itemID; }
            set { this.itemID = value; }
        }

        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public string ShortDescription
        {
            get { return this.shortDescription; }
            set { this.shortDescription = value; }
        }

        public string LongDescription
        {
            get { return this.longDescription; }
            set { this.longDescription = value; }
        }

        public decimal RetailPrice
        {
            get { return this.retailPrice; }
            set { this.retailPrice = value; }
        }

        public decimal CostPrice
        {
            get { return this.costPrice; }
            set { this.costPrice = value; }
        }

        public string ImageURL
        {
            get { return this.imageURL; }
            set { this.imageURL = value; }
        }


        // Constructor
        public MenuItem(string itemID, string category, string shortDescription,
                            string longDescription, decimal retailPrice, decimal costPrice,
                            string imageURL)
        {
            ItemID = itemID;
            Category = category;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            RetailPrice = retailPrice;
            CostPrice = costPrice;
            ImageURL = imageURL;
        }





    }
}
