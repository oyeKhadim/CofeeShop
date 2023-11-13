namespace CofeeShop.Views
{
    partial class ShowItem
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
            lblAddItem = new Label();
            btnCancel = new Button();
            textBoxImgUrl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Location = new Point(550, 115);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new Size(170, 170);
            pictureBoxItem.TabIndex = 31;
            pictureBoxItem.TabStop = false;
            // 
            // lblImgURL
            // 
            lblImgURL.AutoSize = true;
            lblImgURL.Location = new Point(101, 339);
            lblImgURL.Name = "lblImgURL";
            lblImgURL.Size = new Size(79, 16);
            lblImgURL.TabIndex = 29;
            lblImgURL.Text = "Image URL";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(242, 301);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.ReadOnly = true;
            textBoxCost.Size = new Size(253, 25);
            textBoxCost.TabIndex = 28;
            // 
            // textBoxRetailedPrice
            // 
            textBoxRetailedPrice.Location = new Point(242, 260);
            textBoxRetailedPrice.Name = "textBoxRetailedPrice";
            textBoxRetailedPrice.ReadOnly = true;
            textBoxRetailedPrice.Size = new Size(253, 25);
            textBoxRetailedPrice.TabIndex = 27;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(101, 163);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 16);
            lblName.TabIndex = 26;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(101, 118);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 16);
            lblCategory.TabIndex = 25;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(101, 205);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(81, 16);
            lblDescription.TabIndex = 24;
            lblDescription.Text = "Description";
            // 
            // lblRetailedPrice
            // 
            lblRetailedPrice.AutoSize = true;
            lblRetailedPrice.Location = new Point(101, 263);
            lblRetailedPrice.Name = "lblRetailedPrice";
            lblRetailedPrice.Size = new Size(98, 16);
            lblRetailedPrice.TabIndex = 23;
            lblRetailedPrice.Text = "Retailed Price";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(101, 304);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(36, 16);
            lblCost.TabIndex = 22;
            lblCost.Text = "Cost";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(242, 202);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.ReadOnly = true;
            richTextBoxDescription.Size = new Size(253, 40);
            richTextBoxDescription.TabIndex = 21;
            richTextBoxDescription.Text = "";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(242, 163);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(253, 25);
            textBoxName.TabIndex = 20;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Coffee", "Tea", "Pastry" });
            comboBoxCategory.Location = new Point(242, 115);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(253, 24);
            comboBoxCategory.TabIndex = 19;
            // 
            // lblAddItem
            // 
            lblAddItem.AutoSize = true;
            lblAddItem.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddItem.Location = new Point(284, 30);
            lblAddItem.Name = "lblAddItem";
            lblAddItem.Size = new Size(189, 41);
            lblAddItem.TabIndex = 18;
            lblAddItem.Text = "Item Details";
            lblAddItem.Click += lblAddItem_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(645, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBoxImgUrl
            // 
            textBoxImgUrl.Location = new Point(242, 336);
            textBoxImgUrl.Name = "textBoxImgUrl";
            textBoxImgUrl.ReadOnly = true;
            textBoxImgUrl.Size = new Size(253, 25);
            textBoxImgUrl.TabIndex = 30;
            // 
            // ShowItem
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
            Controls.Add(lblAddItem);
            Controls.Add(btnCancel);
            Name = "ShowItem";
            Text = "ShowItem";
            Load += ShowItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxItem;
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
        private Label lblAddItem;
        private Button btnCancel;
        private TextBox textBoxImgUrl;
    }
}