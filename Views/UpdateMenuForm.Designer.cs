namespace CofeeShop.Views
{
    partial class UpdateMenuForm
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
            pictureBoxItem = new PictureBox();
            textBoxImgUrl = new TextBox();
            lblImgURL = new Label();
            textBoxCost = new TextBox();
            textBoxRetailedPrice = new TextBox();
            lblName = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            lblRetailedPrice = new Label();
            lblCost = new Label();
            richTextBoxDescription = new RichTextBox();
            textBoxName = new TextBox();
            comboBoxCategory = new ComboBox();
            btnUpdateItem = new Button();
            btnCancel = new Button();
            lblAddItem = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Location = new Point(540, 71);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new Size(170, 170);
            pictureBoxItem.TabIndex = 30;
            pictureBoxItem.TabStop = false;
            // 
            // textBoxImgUrl
            // 
            textBoxImgUrl.Location = new Point(232, 292);
            textBoxImgUrl.Name = "textBoxImgUrl";
            textBoxImgUrl.Size = new Size(253, 25);
            textBoxImgUrl.TabIndex = 29;
            // 
            // lblImgURL
            // 
            lblImgURL.AutoSize = true;
            lblImgURL.Location = new Point(91, 295);
            lblImgURL.Name = "lblImgURL";
            lblImgURL.Size = new Size(79, 16);
            lblImgURL.TabIndex = 28;
            lblImgURL.Text = "Image URL";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(232, 257);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(253, 25);
            textBoxCost.TabIndex = 27;
            // 
            // textBoxRetailedPrice
            // 
            textBoxRetailedPrice.Location = new Point(232, 216);
            textBoxRetailedPrice.Name = "textBoxRetailedPrice";
            textBoxRetailedPrice.Size = new Size(253, 25);
            textBoxRetailedPrice.TabIndex = 26;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(91, 119);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 16);
            lblName.TabIndex = 25;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(91, 74);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 16);
            lblCategory.TabIndex = 24;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(91, 161);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(81, 16);
            lblDescription.TabIndex = 23;
            lblDescription.Text = "Description";
            // 
            // lblRetailedPrice
            // 
            lblRetailedPrice.AutoSize = true;
            lblRetailedPrice.Location = new Point(91, 219);
            lblRetailedPrice.Name = "lblRetailedPrice";
            lblRetailedPrice.Size = new Size(98, 16);
            lblRetailedPrice.TabIndex = 22;
            lblRetailedPrice.Text = "Retailed Price";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(91, 260);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(36, 16);
            lblCost.TabIndex = 21;
            lblCost.Text = "Cost";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(232, 158);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(253, 40);
            richTextBoxDescription.TabIndex = 20;
            richTextBoxDescription.Text = "";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(232, 119);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(253, 25);
            textBoxName.TabIndex = 19;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Coffee", "Tea", "Pastry" });
            comboBoxCategory.Location = new Point(232, 71);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(253, 24);
            comboBoxCategory.TabIndex = 18;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.FlatStyle = FlatStyle.Flat;
            btnUpdateItem.Location = new Point(540, 353);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(75, 26);
            btnUpdateItem.TabIndex = 17;
            btnUpdateItem.Text = "Update";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(634, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 26);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblAddItem
            // 
            lblAddItem.AutoSize = true;
            lblAddItem.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddItem.Location = new Point(232, 9);
            lblAddItem.Name = "lblAddItem";
            lblAddItem.Size = new Size(301, 41);
            lblAddItem.TabIndex = 31;
            lblAddItem.Text = "Update Item Details";
            // 
            // UpdateMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAddItem);
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
            Controls.Add(btnUpdateItem);
            Controls.Add(btnCancel);
            Name = "UpdateMenuForm";
            Text = "Update Item";
            Load += UpdateMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxItem;
        private TextBox textBoxImgUrl;
        private Label lblImgURL;
        private TextBox textBoxCost;
        private TextBox textBoxRetailedPrice;
        private Label lblName;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblRetailedPrice;
        private Label lblCost;
        private RichTextBox richTextBoxDescription;
        private TextBox textBoxName;
        private ComboBox comboBoxCategory;
        private Button btnUpdateItem;
        private Button btnCancel;
        private Label lblAddItem;
    }
}