using OrderFilter.Service;
using System.ComponentModel;

namespace OrderFilter {
    public partial class Form1 : Form {
        private readonly CustomerService customerService = new CustomerService();
        private readonly EmployeeService employeeService = new();
        private readonly OrderService orderService = new();
        public Form1() {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

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
                    Freight = o.Freight
                }).ToSortableBindingList();
        }

        private void Form1_Load(object sender, EventArgs e) {
            customerListCB.DataSource = customerService.GetCustomerList();
            customerListCB.ValueMember = "CustomerId";
            customerListCB.DisplayMember = "ContactName";

            employeeListCB.DataSource = employeeService.getEmployeeList().Select(emp => new {
                EmployeeId = emp.EmployeeId,
                ContactName = emp.FirstName + " " + emp.LastName
            }).ToList();

            employeeListCB.ValueMember = "EmployeeId";
            employeeListCB.DisplayMember = "ContactName";

            var bs = new BindingSource();
            bs.DataSource = orderService.GetOrderList().Select(o => new {
                OrderId = o.OrderId,
                Employee = o.Employee.FirstName + " " + o.Employee.LastName,
                Customer = o.Customer.ContactName,
                Freight = o.Freight
            }).ToSortableBindingList();

            ordersListDg.DataSource = bs;

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