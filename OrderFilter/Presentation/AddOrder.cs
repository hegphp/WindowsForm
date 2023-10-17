using OrderFilter.Logic.IService;
using OrderFilter.Logic.Service;
using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFilter.Presentation {
    public partial class AddOrder : Form {
        private IEmployeeService employeeService;
        private IOrderService orderService;
        private ICustomerService customerService;
        private IProductService productService;
        private IShipService shipService;
        private IOrderDetailService orderDetailService;

        public AddOrder(IEmployeeService _employeeService, ICustomerService _customerService, IShipService _shipService, IProductService _productService, IOrderService _orderService, IOrderDetailService _orderDetailService) {
            employeeService = _employeeService;
            orderService = _orderService;
            customerService = _customerService;
            productService = _productService;
            shipService = _shipService;
            orderDetailService = _orderDetailService;
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e) {
            //Load Employee List
            var empList = employeeService.GetEmployeeList().Select(e => new {
                employeeId = e.EmployeeId,
                contactName = e.FirstName + " " + e.LastName
            }).ToList();

            empCB.DataSource = empList;
            empCB.DisplayMember = "contactName";
            empCB.ValueMember = "employeeId";
            //Load customer List
            var customerList = customerService.GetCustomerList().Select(c => new {
                customerId = c.CustomerId,
                contactName = c.ContactName
            }).ToList();
            customerCB.DataSource = customerList;
            customerCB.DisplayMember = "contactName";
            customerCB.ValueMember = "customerId";
            //Load Shipper List
            var shipList = shipService.GetShipperList().Select(s => new {
                s.ShipperId,
                s.CompanyName
            }).ToList();
            shipperCB.DataSource = shipList;
            shipperCB.ValueMember = "shipperId";
            shipperCB.DisplayMember = "CompanyName";
            //Load Product List
            var productList = productService.GetProductList().Select(p => new {
                p.ProductId,
                p.ProductName
            }).ToList();
            productListDgv.DataSource = productList;

            productListDgv.SelectionChanged += ProductListDgv_MultiSelect;
        }

        private void ProductListDgv_MultiSelect(object sender, EventArgs e) {
            var productList = new List<Product>();

            for (int i = 0; i < productListDgv.SelectedRows.Count; i++) {
                productList.Add(productService.GetProductById(Convert.ToInt32(productListDgv.SelectedRows[i].Cells[0].Value)));
            }

            GeneratePanel(productList);
        }

        private void GeneratePanel(List<Product> productList) {
            rightPanel.Controls.Clear();
            int width = productListDgv.Width / 3;
            decimal? total = 0;
            //Access every element of productList
            foreach (var i in productList) {
                TextBox productIdTb = new TextBox();
                productIdTb.ReadOnly = true;
                productIdTb.Text = i.ProductId.ToString();
                rightPanel.Controls.Add(productIdTb);
                TextBox productNameTb = new TextBox();
                productNameTb.ReadOnly = true;
                productNameTb.Text = i.ProductName.ToString();
                rightPanel.Controls.Add(productNameTb);
                productNameTb.Width = (int)(width * 2);
                NumericUpDown productQuantity = new NumericUpDown();
                productQuantity.Value = 1;
                rightPanel.Controls.Add(productQuantity);
                rightPanel.SetFlowBreak(productQuantity, true);
                productQuantity.ValueChanged += ProductQuantity_ValueChanged;
                total += productQuantity.Value * i.UnitPrice;
            }
            totalPriceTb.Text = total.ToString();
        }

        private void ProductQuantity_ValueChanged(object? sender, EventArgs e) {
            List<Control> controls = new List<Control>();
            decimal? total = 0;
            //Access every control in the right panel
            for (int i = 0; i < rightPanel.Controls.Count; i++) {
                //check if the control is the product Id textbox or not
                if (i % 3 == 0) {
                    int productId = Convert.ToInt32(rightPanel.Controls[i].Text);
                    Product product = productService.GetProductById(productId);
                    int quantity = Convert.ToInt32(rightPanel.Controls[i + 2].Text);
                    total += quantity * product.UnitPrice;
                }
            }
            totalPriceTb.Text = total.ToString();
        }

        private void addOrderBtn_Click(object sender, EventArgs e) {
            //Add order
            Order newOrder = new Order();
            newOrder.RequiredDate = requiredDTP.Value;
            newOrder.EmployeeId = (int)empCB.SelectedValue;
            newOrder.CustomerId = customerCB.SelectedValue.ToString();
            newOrder.ShipVia = (int)shipperCB.SelectedValue;
            newOrder.OrderDate = DateTime.Now;

            Order addedOrder = orderService.AddOrder(newOrder);
            //Add order detail
            for (int i = 0; i < rightPanel.Controls.Count; i++) {
                //check if the control is the product Id textbox or not
                if (i % 3 == 0) {
                    OrderDetail orderDetail = new OrderDetail();
                    int productId = Convert.ToInt32(rightPanel.Controls[i].Text);
                    Product product = productService.GetProductById(productId);
                    int quantity = Convert.ToInt32(rightPanel.Controls[i + 2].Text);
                    orderDetail.ProductId = productId;
                    orderDetail.Quantity = Convert.ToInt16(quantity);
                    orderDetail.OrderId = addedOrder.OrderId;
                    orderDetailService.AddOrderDetails(orderDetail);
                }
            }
            MessageBox.Show("Added successfully!");
        }
    }
}
