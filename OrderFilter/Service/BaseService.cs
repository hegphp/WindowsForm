using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Service {
    internal class BaseService {
        protected NorthWindContext _context;

        public BaseService() {
            _context = new NorthWindContext();
        }
    }
}
