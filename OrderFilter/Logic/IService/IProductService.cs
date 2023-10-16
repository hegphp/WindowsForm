using OrderFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFilter.Logic.IService {
    public interface IProductService {
        List<Product> GetProductList();

        Product GetProductById(int id);
    }
}
