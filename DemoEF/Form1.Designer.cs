namespace DemoEF {
    partial class Form1 : Form {
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
            categoryList = new ComboBox();
            dgProducts = new DataGridView();
            Discontinued = new DataGridViewCheckBoxColumn();
            ReoderLevel = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            UnitsOnOrder = new DataGridViewTextBoxColumn();
            UnitsInStock = new DataGridViewTextBoxColumn();
            QuantityPerUnit = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            SupplierId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // categoryList
            // 
            categoryList.FormattingEnabled = true;
            categoryList.Location = new Point(21, 26);
            categoryList.Name = "categoryList";
            categoryList.Size = new Size(266, 28);
            categoryList.TabIndex = 0;
            categoryList.SelectedIndexChanged += categoryList_SelectedIndexChanged;
            // 
            // dgProducts
            // 
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, SupplierId, CategoryId, QuantityPerUnit, UnitsInStock, UnitsOnOrder, UnitPrice, ReoderLevel, Discontinued });
            dgProducts.Location = new Point(12, 60);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.RowTemplate.Height = 29;
            dgProducts.Size = new Size(1179, 420);
            dgProducts.TabIndex = 1;
            dgProducts.CellContentClick += dgProducts_CellContentClick;
            // 
            // Discontinued
            // 
            Discontinued.DataPropertyName = "Discontinued";
            Discontinued.HeaderText = "Discontinued";
            Discontinued.MinimumWidth = 6;
            Discontinued.Name = "Discontinued";
            Discontinued.Width = 125;
            // 
            // ReoderLevel
            // 
            ReoderLevel.DataPropertyName = "ReorderLevel";
            ReoderLevel.HeaderText = "ReorderLevel";
            ReoderLevel.MinimumWidth = 6;
            ReoderLevel.Name = "ReoderLevel";
            ReoderLevel.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // UnitsOnOrder
            // 
            UnitsOnOrder.DataPropertyName = "UnitsOnOrder";
            UnitsOnOrder.HeaderText = "UnitsOnOrder";
            UnitsOnOrder.MinimumWidth = 6;
            UnitsOnOrder.Name = "UnitsOnOrder";
            UnitsOnOrder.Width = 125;
            // 
            // UnitsInStock
            // 
            UnitsInStock.DataPropertyName = "UnitsInStock";
            UnitsInStock.HeaderText = "UnitsInStock";
            UnitsInStock.MinimumWidth = 6;
            UnitsInStock.Name = "UnitsInStock";
            UnitsInStock.Width = 125;
            // 
            // QuantityPerUnit
            // 
            QuantityPerUnit.DataPropertyName = "QuantityPerUnit";
            QuantityPerUnit.HeaderText = "QuantityPerUnit";
            QuantityPerUnit.MinimumWidth = 6;
            QuantityPerUnit.Name = "QuantityPerUnit";
            QuantityPerUnit.Width = 125;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryName";
            CategoryId.HeaderText = "CategoryName";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.Width = 125;
            // 
            // SupplierId
            // 
            SupplierId.DataPropertyName = "SupplierId";
            SupplierId.HeaderText = "SupplierId";
            SupplierId.MinimumWidth = 6;
            SupplierId.Name = "SupplierId";
            SupplierId.Width = 125;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId1";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            ProductId.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 492);
            Controls.Add(dgProducts);
            Controls.Add(categoryList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox categoryList;
        private DataGridView dgProducts;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn SupplierId;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn QuantityPerUnit;
        private DataGridViewTextBoxColumn UnitsInStock;
        private DataGridViewTextBoxColumn UnitsOnOrder;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn ReoderLevel;
        private DataGridViewCheckBoxColumn Discontinued;
    }
}