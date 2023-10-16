using OrderFilter.Logic.IService;
using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Logic.Service {
    internal class ShipService : IShipService{
        NorthWindContext _context;

        public ShipService() {
            _context = new NorthWindContext();
        }

        public List<Shipper> GetShipperList() {
            return _context.Shippers.ToList();
        }
    }
}
