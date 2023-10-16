using OrderFilter.Logic.IService;
using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Logic.Service {
    internal class ProductService : IProductService{
        NorthWindContext _context;

        public ProductService() {
            _context = new NorthWindContext();
        }

        public List<Product> GetProductList() { 
            return _context.Products.ToList();
        }

        public Product GetProductById(int id) {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
