namespace CofeeShop.Views
{
    partial class ViewAllOrders
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
            dgvOrders = new DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Tax = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { CustomerName, EmployeeName, Date, Cost, Tax, TotalAmount });
            dgvOrders.Location = new Point(44, 36);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowTemplate.Height = 27;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(708, 260);
            dgvOrders.TabIndex = 0;
            // 
            // CustomerName
            // 
            CustomerName.FillWeight = 395.939117F;
            CustomerName.HeaderText = "Customer Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 140;
            // 
            // EmployeeName
            // 
            EmployeeName.FillWeight = 40.81218F;
            EmployeeName.HeaderText = "Employee Name";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 140;
            // 
            // Date
            // 
            Date.FillWeight = 40.81218F;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 190;
            // 
            // Cost
            // 
            Cost.FillWeight = 40.81218F;
            Cost.HeaderText = "Cost";
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.Width = 60;
            // 
            // Tax
            // 
            Tax.FillWeight = 40.81218F;
            Tax.HeaderText = "Tax";
            Tax.Name = "Tax";
            Tax.ReadOnly = true;
            Tax.Width = 60;
            // 
            // TotalAmount
            // 
            TotalAmount.FillWeight = 40.81218F;
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Width = 115;
            // 
            // ViewAllOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOrders);
            Name = "ViewAllOrders";
            Text = "All Orders";
            Load += ViewAllOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Tax;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}