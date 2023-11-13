namespace CofeeShop.Views
{
    partial class OrderReceiptForm
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
            lblCustomerName = new Label();
            lblOrderDate = new Label();
            lblOrderTime = new Label();
            lblTotalCost = new Label();
            txtOrderedItems = new Label();
            label1 = new Label();
            lblTax = new Label();
            lblAmountToPay = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(48, 21);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(47, 16);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "label1";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(281, 21);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(47, 16);
            lblOrderDate.TabIndex = 1;
            lblOrderDate.Text = "label2";
            // 
            // lblOrderTime
            // 
            lblOrderTime.AutoSize = true;
            lblOrderTime.Location = new Point(485, 21);
            lblOrderTime.Name = "lblOrderTime";
            lblOrderTime.Size = new Size(47, 16);
            lblOrderTime.TabIndex = 2;
            lblOrderTime.Text = "label3";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(485, 269);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(47, 16);
            lblTotalCost.TabIndex = 3;
            lblTotalCost.Text = "label3";
            // 
            // txtOrderedItems
            // 
            txtOrderedItems.AutoSize = true;
            txtOrderedItems.Location = new Point(126, 93);
            txtOrderedItems.Name = "txtOrderedItems";
            txtOrderedItems.Size = new Size(47, 16);
            txtOrderedItems.TabIndex = 4;
            txtOrderedItems.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 62);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 5;
            label1.Text = "Your Items :";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(485, 290);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(47, 16);
            lblTax.TabIndex = 6;
            lblTax.Text = "label3";
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.AutoSize = true;
            lblAmountToPay.Location = new Point(485, 313);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(47, 16);
            lblAmountToPay.TabIndex = 7;
            lblAmountToPay.Text = "label3";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Highlight;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(643, 397);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 27);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // OrderReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(lblAmountToPay);
            Controls.Add(lblTax);
            Controls.Add(label1);
            Controls.Add(txtOrderedItems);
            Controls.Add(lblTotalCost);
            Controls.Add(lblOrderTime);
            Controls.Add(lblOrderDate);
            Controls.Add(lblCustomerName);
            Name = "OrderReceiptForm";
            Text = "OrderReceiptForm";
            Load += OrderReceiptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblOrderDate;
        private Label lblOrderTime;
        private Label lblTotalCost;
        private Label txtOrderedItems;
        private Label label1;
        private Label lblTax;
        private Label lblAmountToPay;
        private Button btnClose;
    }
}