using CofeeShop.Controllers;
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
    public partial class MenuForm : Form
    {
        private CoffeeShopController coffeeShopController;
        public MenuForm(CoffeeShopController coffeeShopController)
        {
            InitializeComponent();
            this.coffeeShopController = coffeeShopController;
        }

        private void textBoxImgUrl_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxImgUrl.Text))
            {
                try
                {
                    // Attempt to load the image from the provided URL
                    pictureBoxItem.Load(textBoxImgUrl.Text);
                    pictureBoxItem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception)
                {
                    // Handle any exception that occurs (invalid URL or image not found)
                    MessageBox.Show("Error loading image from the provided URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Clear the PictureBox if the URL is empty
                pictureBoxItem.Image = null;
            }
        }

        private void textBoxImgUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
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
            coffeeShopController.CreateMenuItem(Guid.NewGuid().ToString(), category, shortDescription,
                                                longDescription, retailPrice, costPrice, imageURL);

            MessageBox.Show("Menu item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close tis form
            this.Close();
        }
        private void ClearInputFields()
        {
            // Clear input fields here
            comboBoxCategory.SelectedIndex = -1;
            textBoxName.Clear();
            richTextBoxDescription.Clear();
            textBoxRetailedPrice.Clear();
            textBoxCost.Clear();
            textBoxImgUrl.Clear();
            pictureBoxItem.Image = null;
        }
     

        private void MenuForm_Load(object sender, EventArgs e)
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
            lblCategory.ForeColor = ThemeColor.PrimaryColor;
            lblName.ForeColor = ThemeColor.PrimaryColor;
            lblDescription.ForeColor = ThemeColor.PrimaryColor;
            lblRetailedPrice.ForeColor = ThemeColor.PrimaryColor;
            lblImgURL.ForeColor = ThemeColor.PrimaryColor;
            lblCost.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}
