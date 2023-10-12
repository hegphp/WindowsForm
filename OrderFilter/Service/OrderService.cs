using Microsoft.EntityFrameworkCore;
using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Service {
    internal class OrderService : BaseService{
        public List<Order> GetOrdersByFilter(int employeeId, string customerId, DateTime from, DateTime to) {

            return _context.Orders.Include(o => o.Employee).Include(o => o.Customer)
                .Where(o => o.EmployeeId == employeeId)
                .Where(o => o.CustomerId == customerId)
                .Where(o => o.OrderDate >= from && o.OrderDate <= to).ToList();
        }

        public List<Order> GetOrderList() { 
            return _context.Orders.Include(o => o.Employee).Include(o => o.Customer).ToList();
        }
    }
}
