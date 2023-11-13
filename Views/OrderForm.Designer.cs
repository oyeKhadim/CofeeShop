namespace CofeeShop.Views
{
    partial class OrderForm
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
            btnAddToOrder = new Button();
            btnRemoveFromOrder = new Button();
            btnFinalizeOrder = new Button();
            btnCancelOrder = new Button();
            lblTotalCost = new Label();
            textBoxQuantity = new TextBox();
            listViewOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            listViewMenu = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            textBoxCustomerName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxEmployeeName = new TextBox();
            SuspendLayout();
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.BackColor = SystemColors.Control;
            btnAddToOrder.FlatStyle = FlatStyle.Flat;
            btnAddToOrder.Location = new Point(11, 143);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(131, 26);
            btnAddToOrder.TabIndex = 0;
            btnAddToOrder.Text = "Add To Order";
            btnAddToOrder.UseVisualStyleBackColor = false;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnRemoveFromOrder
            // 
            btnRemoveFromOrder.FlatStyle = FlatStyle.Flat;
            btnRemoveFromOrder.Location = new Point(170, 143);
            btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            btnRemoveFromOrder.Size = new Size(166, 26);
            btnRemoveFromOrder.TabIndex = 1;
            btnRemoveFromOrder.Text = "Remove From Order";
            btnRemoveFromOrder.UseVisualStyleBackColor = true;
            btnRemoveFromOrder.Click += btnRemoveFromOrder_Click;
            // 
            // btnFinalizeOrder
            // 
            btnFinalizeOrder.FlatStyle = FlatStyle.Flat;
            btnFinalizeOrder.Location = new Point(170, 186);
            btnFinalizeOrder.Name = "btnFinalizeOrder";
            btnFinalizeOrder.Size = new Size(166, 26);
            btnFinalizeOrder.TabIndex = 2;
            btnFinalizeOrder.Text = "Finalize Order";
            btnFinalizeOrder.UseVisualStyleBackColor = true;
            btnFinalizeOrder.Click += btnFinalizeOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.FlatStyle = FlatStyle.Flat;
            btnCancelOrder.Location = new Point(11, 186);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(131, 26);
            btnCancelOrder.TabIndex = 3;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(11, 238);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(116, 16);
            lblTotalCost.TabIndex = 4;
            lblTotalCost.Text = "Total Price : $0.0";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(126, 100);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(210, 25);
            textBoxQuantity.TabIndex = 5;
            textBoxQuantity.Text = "0";
            // 
            // listViewOrder
            // 
            listViewOrder.AllowColumnReorder = true;
            listViewOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader2, columnHeader4, columnHeader9 });
            listViewOrder.FullRowSelect = true;
            listViewOrder.GridLines = true;
            listViewOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewOrder.Location = new Point(407, 269);
            listViewOrder.MultiSelect = false;
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new Size(406, 214);
            listViewOrder.TabIndex = 6;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 1;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cost";
            columnHeader4.Width = 50;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Quantity";
            columnHeader9.Width = 80;
            // 
            // listViewMenu
            // 
            listViewMenu.AllowColumnReorder = true;
            listViewMenu.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewMenu.FullRowSelect = true;
            listViewMenu.GridLines = true;
            listViewMenu.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewMenu.Location = new Point(407, 32);
            listViewMenu.MultiSelect = false;
            listViewMenu.Name = "listViewMenu";
            listViewMenu.Size = new Size(406, 177);
            listViewMenu.TabIndex = 7;
            listViewMenu.UseCompatibleStateImageBehavior = false;
            listViewMenu.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            columnHeader5.Width = 1;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Name";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Category";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Cost";
            columnHeader8.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 8;
            label2.Text = "Menu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 250);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 9;
            label3.Text = "Order : ";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(126, 32);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(210, 25);
            textBoxCustomerName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 16);
            label1.TabIndex = 11;
            label1.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 103);
            label4.Name = "label4";
            label4.Size = new Size(61, 16);
            label4.TabIndex = 12;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 70);
            label5.Name = "label5";
            label5.Size = new Size(114, 16);
            label5.TabIndex = 14;
            label5.Text = "Employee Name";
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.Location = new Point(126, 67);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(210, 25);
            textBoxEmployeeName.TabIndex = 13;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 495);
            Controls.Add(label5);
            Controls.Add(textBoxEmployeeName);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBoxCustomerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listViewMenu);
            Controls.Add(listViewOrder);
            Controls.Add(textBoxQuantity);
            Controls.Add(lblTotalCost);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnFinalizeOrder);
            Controls.Add(btnRemoveFromOrder);
            Controls.Add(btnAddToOrder);
            Name = "OrderForm";
            Text = "Make Order";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToOrder;
        private Button btnRemoveFromOrder;
        private Button btnFinalizeOrder;
        private Button btnCancelOrder;
        private Label lblTotalCost;
        private TextBox textBoxQuantity;
        private ListView listViewOrder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ListView listViewMenu;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label2;
        private Label label3;
        private TextBox textBoxCustomerName;
        private ColumnHeader columnHeader9;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox textBoxEmployeeName;
    }
}