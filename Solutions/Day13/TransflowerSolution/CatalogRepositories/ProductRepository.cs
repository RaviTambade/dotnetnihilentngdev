namespace CatalogRepositories;

using CatalogEntities;
using System.Collections.Generic;
public class ProductRepository : IProductRepository
{

    public IEnumerable<Product> GetAllProducts()
    {
        
        return new List<Product>();
        
    }

    public Product? GetProductById(int id)
    {
        return new Product();
    }

    public void AddProduct(Product product)
    {
        
    }

    public void UpdateProduct(Product product)
    {
        
    }

    public void DeleteProduct(int id)
    {


    }
}
