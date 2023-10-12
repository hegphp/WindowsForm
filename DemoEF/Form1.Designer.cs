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
            groupBox1 = new GroupBox();
            saveButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            refreshButton = new Button();
            updateCateList = new ComboBox();
            priceNumeric = new NumericUpDown();
            productName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).BeginInit();
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
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(12, 60);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.RowTemplate.Height = 29;
            dgProducts.Size = new Size(721, 420);
            dgProducts.TabIndex = 1;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(refreshButton);
            groupBox1.Controls.Add(updateCateList);
            groupBox1.Controls.Add(priceNumeric);
            groupBox1.Controls.Add(productName);
            groupBox1.Location = new Point(760, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 420);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(204, 349);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 35);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(74, 349);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(85, 35);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(204, 261);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 33);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(74, 261);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(85, 33);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // updateCateList
            // 
            updateCateList.FormattingEnabled = true;
            updateCateList.Location = new Point(84, 194);
            updateCateList.Name = "updateCateList";
            updateCateList.Size = new Size(202, 28);
            updateCateList.TabIndex = 2;
            // 
            // priceNumeric
            // 
            priceNumeric.Location = new Point(84, 113);
            priceNumeric.Name = "priceNumeric";
            priceNumeric.Size = new Size(202, 27);
            priceNumeric.TabIndex = 1;
            // 
            // productName
            // 
            productName.Location = new Point(84, 55);
            productName.Name = "productName";
            productName.Size = new Size(192, 27);
            productName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 492);
            Controls.Add(groupBox1);
            Controls.Add(dgProducts);
            Controls.Add(categoryList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox categoryList;
        private DataGridView dgProducts;
        private DataGridViewTextBoxColumn Supplier;
        private GroupBox groupBox1;
        private Button deleteButton;
        private Button addButton;
        private Button refreshButton;
        private ComboBox updateCateList;
        private NumericUpDown priceNumeric;
        private TextBox productName;
        private Button saveButton;
    }
}