using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Logic.IService {
    public interface IOrderService {
        List<Order> GetOrdersByFilter(int employeeId, string customerId, DateTime from, DateTime to);

        List<Order> GetOrderList();

        Order AddOrder(Order order);
    }
}
