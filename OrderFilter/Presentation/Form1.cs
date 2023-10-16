using OrderFilter.Logic.IService;
using OrderFilter.Models;
using OrderFilter.Presentation;
using OrderFilter.Service;
using System.ComponentModel;

namespace OrderFilter {
    public partial class Form1 : Form {
        IOrderService orderService;
        IEmployeeService employeeService;
        ICustomerService customerService;
        IShipService shipperService;
        IProductService productService;

        public Form1(IOrderService _orderService, IEmployeeService _employeeService, ICustomerService _customerService, IShipService _shipperService, IProductService _productService) {
            orderService = _orderService;
            employeeService = _employeeService;
            customerService = _customerService;
            shipperService = _shipperService;
            productService = _productService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            LoadDGV();
        }

        private void LoadDGV() {
            int employeeId = (int)employeeListCB.SelectedValue;
            string customerId = (string)customerListCB.SelectedValue;

            ordersListDg.DataSource = orderService.GetOrdersByFilter(employeeId, customerId, fromDTPicker.Value, toDTPicker.Value)
                .Select(o => new {
                    OrderId = o.OrderId,
                    Employee = o.Employee.FirstName + " " + o.Employee.LastName,
                    Customer = o.Customer.ContactName,
                    Freight = o.Freight,
                    ShipVia = o.ShipVia
                }).ToSortableBindingList();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var customerList = customerService.GetCustomerList().Select(c => new { 
                c.CustomerId,
                c.ContactName
            }).ToList();

            var customerFirstOption = new {CustomerId = "0", ContactName = "All Customer" };

            customerList.Insert(0, customerFirstOption);

            customerListCB.DataSource = customerList;
            customerListCB.ValueMember = "CustomerId";
            customerListCB.DisplayMember = "ContactName";

            var empListCb = employeeService.GetEmployeeList().Select(emp => new {
                EmployeeId = emp.EmployeeId,
                FullName = emp.FirstName + " " + emp.LastName
            }).ToList();

            var empListFirstOption = new { EmployeeId = 0, FullName = "All Employee" };

            empListCb.Insert(0, empListFirstOption);

            employeeListCB.DataSource = empListCb;

            employeeListCB.ValueMember = "EmployeeId";
            employeeListCB.DisplayMember = "FullName";

            var bs = new BindingSource();
            bs.DataSource = orderService.GetOrderList().Select(o => new {
                OrderId = o.OrderId,
                Employee = o.Employee.FirstName + " " + o.Employee.LastName,
                Customer = o.Customer.ContactName,
                Freight = o.Freight
            }).ToSortableBindingList();

            ordersListDg.DataSource = bs;

            addOrderBtn.Click += openAddOrderForm;
        }

        private void openAddOrderForm(object sender, EventArgs e) {
            AddOrder addOrderForm = new AddOrder(employeeService, customerService, shipperService, productService, orderService);
            addOrderForm.ShowDialog();
        }

        private void ordersListDg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            try {
                DataGridViewColumn newColumn = ordersListDg.Columns[e.ColumnIndex];
                DataGridViewColumn oldColumn = ordersListDg.SortedColumn;
                ListSortDirection direction;

                //check if the oldColumn is null or not
                if (oldColumn != null) {
                    //sort the same column again, reversing the sort order
                    if (oldColumn == newColumn && ordersListDg.SortOrder == System.Windows.Forms.SortOrder.Ascending) {
                        direction = ListSortDirection.Descending;
                    }
                    else {
                        //sort a new column and remove the old SortGlyph
                        direction = ListSortDirection.Ascending;
                        oldColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                    }
                }
                else {
                    direction = ListSortDirection.Ascending;
                }

                //Sort the selected column
                ordersListDg.Sort(newColumn, direction);
                //ordersListDg.SortOrder = direction;
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ? System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ordersListDg_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}