using Day26Concepts.Models;
using System.Collections.Generic;

namespace Day26Concepts.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}