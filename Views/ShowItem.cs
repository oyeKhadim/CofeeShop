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
    public partial class ShowItem : Form
    {
        private MenuItem menuItem;
        public ShowItem(MenuItem menuItem)
        {
            InitializeComponent();
            this.menuItem = menuItem;
        }

        private void lblAddItem_Click(object sender, EventArgs e)
        {

        }

        private void ShowItem_Load(object sender, EventArgs e)
        {
            PopulateMenuItemData();
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
            lblCost.ForeColor = ThemeColor.PrimaryColor;
            lblImgURL.ForeColor = ThemeColor.PrimaryColor;
        }
        private void PopulateMenuItemData()
        {

            comboBoxCategory.Text = menuItem.Category;
            textBoxName.Text = menuItem.ShortDescription;
            richTextBoxDescription.Text = menuItem.LongDescription;
            textBoxRetailedPrice.Text = menuItem.RetailPrice.ToString("C");
            textBoxCost.Text = menuItem.CostPrice.ToString("C");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
