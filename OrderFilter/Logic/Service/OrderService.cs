using Microsoft.EntityFrameworkCore;
using OrderFilter.Logic.IService;
using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Service {
    internal class OrderService : IOrderService {
        NorthWindContext _context;

        public OrderService() {
            _context = new NorthWindContext();
        }

        public List<Order> GetOrdersByFilter(int employeeId, string customerId, DateTime from, DateTime to) {
            var output = _context.Orders.Include(o => o.Employee).Include(o => o.Customer).AsQueryable();

            //check if user choose all employee id option
            if (employeeId != 0)
                output = output.Where(o => o.EmployeeId == employeeId);
            //check if user choose all customer id option or not
            if (!customerId.Equals("0"))
                output = output.Where(o => o.CustomerId == customerId);
            return output.Where(o => o.OrderDate >= from && o.OrderDate <= to).ToList();
        }

        public List<Order> GetOrderList() {
            return _context.Orders.Include(o => o.Employee).Include(o => o.Customer).ToList();
        }

        public Order AddOrder(Order order) {
            var addedOrder = _context.Orders.Add(order);
            _context.SaveChanges();
            return addedOrder.Entity;
        }
    }
}
