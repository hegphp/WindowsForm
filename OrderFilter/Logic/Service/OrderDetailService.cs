using OrderFilter.Logic.IService;
using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Logic.Service {
    internal class OrderDetailService : IOrderDetailService {
        NorthWindContext _context;

        public OrderDetailService() {
            _context = new NorthWindContext();
        }
        public OrderDetail AddOrderDetails(OrderDetail orderDetail) {
            var newDetails = _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
            return newDetails.Entity;
        }
    }
}
