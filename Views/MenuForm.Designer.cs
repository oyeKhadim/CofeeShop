namespace CofeeShop.Views
{
    partial class MenuForm
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
            btnCancel = new Button();
            btnAddItem = new Button();
            comboBoxCategory = new ComboBox();
            textBoxName = new TextBox();
            richTextBoxDescription = new RichTextBox();
            lblCost = new Label();
            lblRetailedPrice = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblName = new Label();
            textBoxRetailedPrice = new TextBox();
            textBoxCost = new TextBox();
            lblImgURL = new Label();
            textBoxImgUrl = new TextBox();
            pictureBoxItem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(653, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 26);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Location = new Point(559, 330);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 26);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Coffee", "Tea", "Pastry" });
            comboBoxCategory.Location = new Point(251, 48);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(253, 24);
            comboBoxCategory.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(251, 96);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(253, 25);
            textBoxName.TabIndex = 4;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(251, 135);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(253, 40);
            richTextBoxDescription.TabIndex = 5;
            richTextBoxDescription.Text = "";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(110, 237);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(36, 16);
            lblCost.TabIndex = 6;
            lblCost.Text = "Cost";
            // 
            // lblRetailedPrice
            // 
            lblRetailedPrice.AutoSize = true;
            lblRetailedPrice.Location = new Point(110, 196);
            lblRetailedPrice.Name = "lblRetailedPrice";
            lblRetailedPrice.Size = new Size(98, 16);
            lblRetailedPrice.TabIndex = 7;
            lblRetailedPrice.Text = "Retailed Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(110, 138);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(81, 16);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(110, 51);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 16);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(110, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 16);
            lblName.TabIndex = 10;
            lblName.Text = "Name";
            // 
            // textBoxRetailedPrice
            // 
            textBoxRetailedPrice.Location = new Point(251, 193);
            textBoxRetailedPrice.Name = "textBoxRetailedPrice";
            textBoxRetailedPrice.Size = new Size(253, 25);
            textBoxRetailedPrice.TabIndex = 11;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(251, 234);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(253, 25);
            textBoxCost.TabIndex = 12;
            // 
            // lblImgURL
            // 
            lblImgURL.AutoSize = true;
            lblImgURL.Location = new Point(110, 272);
            lblImgURL.Name = "lblImgURL";
            lblImgURL.Size = new Size(79, 16);
            lblImgURL.TabIndex = 13;
            lblImgURL.Text = "Image URL";
            // 
            // textBoxImgUrl
            // 
            textBoxImgUrl.Location = new Point(251, 269);
            textBoxImgUrl.Name = "textBoxImgUrl";
            textBoxImgUrl.Size = new Size(253, 25);
            textBoxImgUrl.TabIndex = 14;
            textBoxImgUrl.TextChanged += textBoxImgUrl_TextChanged;
            textBoxImgUrl.Leave += textBoxImgUrl_Leave;
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Location = new Point(559, 48);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new Size(170, 170);
            pictureBoxItem.TabIndex = 15;
            pictureBoxItem.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxItem);
            Controls.Add(textBoxImgUrl);
            Controls.Add(lblImgURL);
            Controls.Add(textBoxCost);
            Controls.Add(textBoxRetailedPrice);
            Controls.Add(lblName);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblRetailedPrice);
            Controls.Add(lblCost);
            Controls.Add(richTextBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxCategory);
            Controls.Add(btnAddItem);
            Controls.Add(btnCancel);
            Name = "MenuForm";
            Text = "Add Item To Menu";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAddItem;
        private ComboBox comboBoxCategory;
        private TextBox textBoxName;
        private RichTextBox richTextBoxDescription;
        private Label lblCost;
        private Label lblRetailedPrice;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblName;
        private TextBox textBoxRetailedPrice;
        private TextBox textBoxCost;
        private Label lblImgURL;
        private TextBox textBoxImgUrl;
        private PictureBox pictureBoxItem;
    }
}