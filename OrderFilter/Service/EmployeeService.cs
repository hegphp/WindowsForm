using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Service {
    internal class EmployeeService : BaseService{
        public List<Employee> getEmployeeList() { 
            return _context.Employees.ToList();
        }
    }
}
