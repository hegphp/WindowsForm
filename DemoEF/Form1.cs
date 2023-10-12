using DemoEF.Models;
using DemoEF.Service;

namespace DemoEF {
    public partial class Form1 : Form {
        int selectedId;

        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
            categoryList.DisplayMember = "CategoryName";
            categoryList.ValueMember = "CategoryId";
            categoryList.DataSource = categoryService.GetCategories();

            List<Category> categoriesClone = categoryService.GetCategories();

            dgProducts.AutoGenerateColumns = false;

            priceNumeric.DecimalPlaces = 2;
            priceNumeric.Increment = 0.1m;
            priceNumeric.Maximum = 999999;

            updateCateList.DataSource = categoriesClone;
            updateCateList.ValueMember = "CategoryId";
            updateCateList.DisplayMember = "CategoryName";

            LoadDataFroDGV();
        }

        private void LoadDataFroDGV() {
            int CategoryId = Convert.ToInt32(categoryList.SelectedValue);

            dgProducts.DataSource = productService.GetProductByCateId(CategoryId)
                .Select(p => new {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    //SupplierId = p.SupplierId,
                    //CategoryName = categoryService.GetCategoryById(p.CategoryId.Value).CategoryName,
                    CategoryName = p.Category.CategoryName,
                    //QuantityPerUnit = p.QuantityPerUnit,
                    //UnitsInStock = p.UnitsInStock,
                    //UnitsOnOrder = p.UnitsOnOrder,
                    UnitPrice = p.UnitPrice,
                    //ReorderLevel = p.ReorderLevel,
                    //Discontinued = p.Discontinued
                }).ToList();
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e) {
            LoadDataFroDGV();
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e) {
            //Check if the row index or the column index is negative or not
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            selectedId = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells[0].Value);
            Product selectedProduct = productService.getProductById(selectedId);
            productName.Text = selectedProduct.ProductName;
            priceNumeric.Value = selectedProduct.UnitPrice.Value;
            updateCateList.SelectedValue = selectedProduct.CategoryId;
        }



        private void saveButton_Click(object sender, EventArgs e) {
            Product product = productService.getProductById(selectedId);
            product.ProductName = productName.Text; 
            product.UnitPrice = priceNumeric.Value;
            //product.Category = (int)updateCateList.SelectedValue;
            productService.UpdateProduct(product);

            LoadDataFroDGV();
        }
    }
}