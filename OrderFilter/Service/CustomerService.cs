using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Service {
    internal class CustomerService : BaseService{
        //Get customer List
        public List<Customer> GetCustomerList() { 
            return _context.Customers.ToList();
        }
    }
}
