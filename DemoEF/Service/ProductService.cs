using DemoEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Service {
    internal class ProductService : BaseService {
        CategoryService categoryService = new CategoryService();
        
        public List<Product> GetProductByCateId(int categoryId) {
            return _context.Products
            .Include(p => p.Category)
            .Where(p => p.CategoryId == categoryId).ToList();
        }

        public Product getProductById(int productId) {
            return _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.ProductId == productId);
        }

        public void AddProduct(Product product) {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void RemoveProduct(int productId) {
            Product? p = _context.Products.FirstOrDefault(p => p.ProductId == productId);

            if (p != null) {
                _context.Products.Remove(p);
                _context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product) {

        }
    }
}
