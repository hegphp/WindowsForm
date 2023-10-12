namespace OrderFilter {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ordersListDg = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Freight = new DataGridViewTextBoxColumn();
            employeeListCB = new ComboBox();
            customerListCB = new ComboBox();
            fromDTPicker = new DateTimePicker();
            toDTPicker = new DateTimePicker();
            filterButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersListDg).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // ordersListDg
            // 
            ordersListDg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersListDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersListDg.Columns.AddRange(new DataGridViewColumn[] { OrderId, Employee, Customer, Freight });
            ordersListDg.Location = new Point(12, 143);
            ordersListDg.Name = "ordersListDg";
            ordersListDg.RowHeadersWidth = 51;
            ordersListDg.RowTemplate.Height = 29;
            ordersListDg.Size = new Size(1057, 435);
            ordersListDg.TabIndex = 0;
            ordersListDg.ColumnHeaderMouseClick += ordersListDg_ColumnHeaderMouseClick;
            // 
            // OrderId
            // 
            OrderId.DataPropertyName = "OrderId";
            OrderId.HeaderText = "OrderId";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.Width = 125;
            OrderId.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Employee
            // 
            Employee.DataPropertyName = "Employee";
            Employee.HeaderText = "Employee";
            Employee.MinimumWidth = 6;
            Employee.Name = "Employee";
            Employee.Width = 125;
            Employee.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Customer
            // 
            Customer.DataPropertyName = "Customer";
            Customer.HeaderText = "Customer";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.Width = 125;
            Customer.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Freight
            // 
            Freight.DataPropertyName = "Freight";
            Freight.HeaderText = "Freight";
            Freight.MinimumWidth = 6;
            Freight.Name = "Freight";
            Freight.Width = 125;
            Freight.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // employeeListCB
            // 
            employeeListCB.FormattingEnabled = true;
            employeeListCB.Location = new Point(33, 28);
            employeeListCB.Name = "employeeListCB";
            employeeListCB.Size = new Size(206, 28);
            employeeListCB.TabIndex = 1;
            employeeListCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // customerListCB
            // 
            customerListCB.FormattingEnabled = true;
            customerListCB.Location = new Point(33, 85);
            customerListCB.Name = "customerListCB";
            customerListCB.Size = new Size(206, 28);
            customerListCB.TabIndex = 2;
            // 
            // fromDTPicker
            // 
            fromDTPicker.Location = new Point(312, 28);
            fromDTPicker.Name = "fromDTPicker";
            fromDTPicker.Size = new Size(279, 27);
            fromDTPicker.TabIndex = 3;
            // 
            // toDTPicker
            // 
            toDTPicker.Location = new Point(666, 29);
            toDTPicker.Name = "toDTPicker";
            toDTPicker.Size = new Size(279, 27);
            toDTPicker.TabIndex = 4;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(312, 79);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(107, 34);
            filterButton.TabIndex = 5;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 6;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 31);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 7;
            label2.Text = "To";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 590);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(filterButton);
            Controls.Add(toDTPicker);
            Controls.Add(fromDTPicker);
            Controls.Add(customerListCB);
            Controls.Add(employeeListCB);
            Controls.Add(ordersListDg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ordersListDg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView ordersListDg;
        private ComboBox employeeListCB;
        private ComboBox customerListCB;
        private DateTimePicker fromDTPicker;
        private DateTimePicker toDTPicker;
        private Button filterButton;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Freight;
    }
}