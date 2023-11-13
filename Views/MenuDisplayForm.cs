using CofeeShop.Controllers;
using CofeeShop.Models;
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
    public partial class MenuDisplayForm : Form
    {
        private CoffeeShopController coffeeShopController;
        public MenuDisplayForm(CoffeeShopController controller)
        {
            coffeeShopController = controller;

            // Initialize UI elements and set up event handlers
            InitializeComponent();

            // Populate the ListView with menu items
            PopulateMenuItems();
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

        }

        private void PopulateMenuItems()
        {
            // Clear existing items in the DataGridView
            dgvMenu.Rows.Clear();

            // Get the menu from the CoffeeShopController
            List<MenuItem> menu = coffeeShopController.GetMenu();

            // Populate the DataGridView with menu items
            foreach (var item in menu)
            {
                dgvMenu.Rows.Add(item.ItemID, item.ShortDescription, item.Category, item.RetailPrice);
            }
        }



        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 1) // Check if one row is selected
            {
                // Get the selected menu item's ID from the first cell of the selected row
                string selectedItemID = dgvMenu.SelectedRows[0].Cells[0].Value.ToString();

                // Get the menu item from the CoffeeShopController
                MenuItem selectedItem = coffeeShopController.GetMenuItemByID(selectedItemID);

                // Create a new ShowItem form and display details of the selected item
                ShowItem f = new ShowItem(selectedItem);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an item to view details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the selected category
            comboBoxCategory.SelectedIndex = -1;

            // Reload all menu items
            PopulateMenuItems();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();

            // Get the menu items based on the selected category
            List<MenuItem> filteredMenu = coffeeShopController.GetMenuByCategory(selectedCategory);

            // Populate the DataGridView with the filtered menu items
            dgvMenu.Rows.Clear(); // Clear existing items
            foreach (var item in filteredMenu)
            {
                dgvMenu.Rows.Add(item.ItemID, item.ShortDescription, item.Category, item.RetailPrice);
            }
        }

        private void MenuDisplayForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 1)
            {
                // Get the selected menu item's ID from the first cell of the selected row
                string selectedItemID = dgvMenu.SelectedRows[0].Cells[0].Value.ToString();

                // Use the selectedItemID to retrieve the menu item from the database via CoffeeShopController
                MenuItem selectedItem = coffeeShopController.GetMenuItemByID(selectedItemID);

                // Create a form for updating the selected menu item
                UpdateMenuForm updateForm = new UpdateMenuForm(selectedItem, coffeeShopController);

                updateForm.ShowDialog();

                // Refresh the DataGridView to reflect the changes
                PopulateMenuItems();

            }
            else
            {
                MessageBox.Show("Please select an item to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 1)
            {
                // Get the selected menu item's ID from the first cell of the selected row
                string selectedItemID = dgvMenu.SelectedRows[0].Cells[0].Value.ToString();

                // Use the selectedItemID to delete the menu item from the database via CoffeeShopController
                coffeeShopController.DeleteMenuItem(selectedItemID);

                // Refresh the DataGridView to reflect the changes
                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
