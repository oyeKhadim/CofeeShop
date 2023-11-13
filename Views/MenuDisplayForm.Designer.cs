namespace CofeeShop.Views
{
    partial class MenuDisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxCategory = new ComboBox();
            btnViewDetails = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            dgvMenu = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            ItemID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            CostPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Coffee", "Tea", "Pastry" });
            comboBoxCategory.Location = new Point(608, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(166, 24);
            comboBoxCategory.TabIndex = 1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Location = new Point(193, 222);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(101, 26);
            btnViewDetails.TabIndex = 2;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(514, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 26);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(699, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 26);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { ItemID, Name, Category, CostPrice });
            dgvMenu.Location = new Point(22, 12);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersVisible = false;
            dgvMenu.RowHeadersWidth = 10;
            dgvMenu.RowTemplate.Height = 27;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(567, 204);
            dgvMenu.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(407, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 26);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(300, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 26);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ItemID
            // 
            ItemID.HeaderText = "ID";
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            ItemID.Visible = false;
            // 
            // Name
            // 
            Name.HeaderText = "Item Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // CostPrice
            // 
            CostPrice.HeaderText = "Price";
            CostPrice.Name = "CostPrice";
            CostPrice.ReadOnly = true;
            // 
            // MenuDisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvMenu);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnViewDetails);
            Controls.Add(comboBoxCategory);
            //Name = "MenuDisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += MenuDisplayForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxCategory;
        private Button btnViewDetails;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dgvMenu;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn CostPrice;
    }
}