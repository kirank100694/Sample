using DAy44Concepts.Models;
using System.Collections.Generic;

namespace DAy44Concepts.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}