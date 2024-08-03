using DAy44Concepts.Models;
using System.Collections.Generic;

namespace DAy44Concepts.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "Name From TestRepository";
        }
    }
}
