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
    public partial class UpdateMenuForm : Form
    {
        private MenuItem menuItem;
        private CoffeeShopController coffeeShopController;
        public UpdateMenuForm(MenuItem menuItem, CoffeeShopController coffeeShopController)
        {
            InitializeComponent();
            this.menuItem = menuItem;
            this.coffeeShopController = coffeeShopController;
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
            lblCategory.ForeColor = ThemeColor.PrimaryColor;
            lblName.ForeColor = ThemeColor.PrimaryColor;
            lblDescription.ForeColor = ThemeColor.PrimaryColor;
            lblRetailedPrice.ForeColor = ThemeColor.PrimaryColor;
            lblCost.ForeColor = ThemeColor.PrimaryColor;
            lblImgURL.ForeColor = ThemeColor.PrimaryColor;
        }
        private void PopulateMenuItemData()
        {

            comboBoxCategory.Text = menuItem.Category;
            textBoxName.Text = menuItem.ShortDescription;
            richTextBoxDescription.Text = menuItem.LongDescription;
            textBoxRetailedPrice.Text = menuItem.RetailPrice.ToString();
            textBoxCost.Text = menuItem.CostPrice.ToString();
            textBoxImgUrl.Text = menuItem.ImageURL;

            try
            {
                pictureBoxItem.Load(menuItem.ImageURL);
                pictureBoxItem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading image from the provided URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateMenuForm_Load(object sender, EventArgs e)
        {

            PopulateMenuItemData();
            LoadTheme();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(comboBoxCategory.Text) ||
        string.IsNullOrWhiteSpace(textBoxRetailedPrice.Text) ||
        string.IsNullOrWhiteSpace(textBoxCost.Text) ||
        string.IsNullOrWhiteSpace(textBoxImgUrl.Text))
            {
                MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select A valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxRetailedPrice.Text, out decimal retailPrice) ||
                !decimal.TryParse(textBoxCost.Text, out decimal costPrice))
            {
                MessageBox.Show("Invalid price input.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate ShortDescription, LongDescription, and ImageURL to disallow commas
            if (textBoxName.Text.Contains(",") || richTextBoxDescription.Text.Contains(",") ||
                textBoxImgUrl.Text.Contains(","))
            {
                MessageBox.Show("Fields cannot contain commas.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new menu item
            string category = comboBoxCategory.Text;
            string shortDescription = textBoxName.Text;
            string longDescription = richTextBoxDescription.Text;
            string imageURL = textBoxImgUrl.Text;

            // Call the controller to create a menu item
            coffeeShopController.UpdateMenuItem(menuItem.ItemID, category, shortDescription,
                                                longDescription, retailPrice, costPrice, imageURL);

            MessageBox.Show("Menu item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
