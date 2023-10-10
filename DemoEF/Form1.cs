using DemoEF.Service;

namespace DemoEF {
    public partial class Form1 : Form {

        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            categoryList.DisplayMember = "CategoryName";
            categoryList.ValueMember = "CategoryId";
            categoryList.DataSource = categoryService.GetCategories();

            dgProducts.AutoGenerateColumns = false;

            LoadDataFroDGV();
        }

        private void LoadDataFroDGV() {
            int CategoryId = Convert.ToInt32(categoryList.SelectedValue);

            dgProducts.DataSource = productService.GetProductByCateId(CategoryId)
                .Select(p => new {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    SupplierId = p.SupplierId,
                    CategoryName = categoryService.GetCategoryById(p.CategoryId.Value).CategoryName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    UnitPrice = p.UnitPrice,
                    ReorderLevel = p.ReorderLevel,
                    Discontinued = p.Discontinued
                }).ToList();
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e) {
            LoadDataFroDGV();
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}