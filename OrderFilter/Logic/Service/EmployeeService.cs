using OrderFilter.Logic.IService;
using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Service {
    internal class EmployeeService : IEmployeeService{
        NorthWindContext _context;

        public EmployeeService() {
            _context = new NorthWindContext();
        }

        public List<Employee> GetEmployeeList() { 
            return _context.Employees.ToList();
        }
    }
}
