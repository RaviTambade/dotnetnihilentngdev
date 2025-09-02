namespace OnlineShoppingAPI.Repositories
{
    using OnlineShoppingAPI.Entities;
    using System.Collections.Generic;

    //Repository Pattern
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
