namespace OrderFilter.Presentation {
    partial class AddOrder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            requiredDTP = new DateTimePicker();
            empCB = new ComboBox();
            customerCB = new ComboBox();
            shipperCB = new ComboBox();
            productListDgv = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rightPanel = new FlowLayoutPanel();
            totalLabel = new Label();
            totalPriceTb = new TextBox();
            addOrderBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)productListDgv).BeginInit();
            SuspendLayout();
            // 
            // requiredDTP
            // 
            requiredDTP.Location = new Point(128, 31);
            requiredDTP.Name = "requiredDTP";
            requiredDTP.Size = new Size(250, 27);
            requiredDTP.TabIndex = 0;
            // 
            // empCB
            // 
            empCB.FormattingEnabled = true;
            empCB.Location = new Point(128, 64);
            empCB.Name = "empCB";
            empCB.Size = new Size(250, 28);
            empCB.TabIndex = 1;
            // 
            // customerCB
            // 
            customerCB.FormattingEnabled = true;
            customerCB.Location = new Point(128, 98);
            customerCB.Name = "customerCB";
            customerCB.Size = new Size(250, 28);
            customerCB.TabIndex = 2;
            // 
            // shipperCB
            // 
            shipperCB.FormattingEnabled = true;
            shipperCB.Location = new Point(128, 132);
            shipperCB.Name = "shipperCB";
            shipperCB.Size = new Size(250, 28);
            shipperCB.TabIndex = 3;
            // 
            // productListDgv
            // 
            productListDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productListDgv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            productListDgv.Location = new Point(12, 179);
            productListDgv.Name = "productListDgv";
            productListDgv.RowHeadersWidth = 51;
            productListDgv.RowTemplate.Height = 29;
            productListDgv.Size = new Size(366, 367);
            productListDgv.StandardTab = true;
            productListDgv.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 5;
            label1.Text = "Required Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 67);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Employee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 135);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Ship";
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rightPanel.Location = new Point(403, 31);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(538, 481);
            rightPanel.TabIndex = 9;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(563, 526);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(42, 20);
            totalLabel.TabIndex = 10;
            totalLabel.Text = "Total";
            // 
            // totalPriceTb
            // 
            totalPriceTb.Location = new Point(626, 523);
            totalPriceTb.Name = "totalPriceTb";
            totalPriceTb.Size = new Size(215, 27);
            totalPriceTb.TabIndex = 11;
            // 
            // addOrderBtn
            // 
            addOrderBtn.Location = new Point(847, 521);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.Size = new Size(94, 29);
            addOrderBtn.TabIndex = 12;
            addOrderBtn.Text = "Add Order";
            addOrderBtn.UseVisualStyleBackColor = true;
            addOrderBtn.Click += addOrderBtn_Click;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 558);
            Controls.Add(addOrderBtn);
            Controls.Add(totalPriceTb);
            Controls.Add(totalLabel);
            Controls.Add(rightPanel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productListDgv);
            Controls.Add(shipperCB);
            Controls.Add(customerCB);
            Controls.Add(empCB);
            Controls.Add(requiredDTP);
            Name = "AddOrder";
            Text = "AddOrder";
            Load += AddOrder_Load;
            ((System.ComponentModel.ISupportInitialize)productListDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker requiredDTP;
        private ComboBox empCB;
        private ComboBox customerCB;
        private ComboBox shipperCB;
        private DataGridView productListDgv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel rightPanel;
        private Label totalLabel;
        private TextBox totalPriceTb;
        private Button addOrderBtn;
    }
}