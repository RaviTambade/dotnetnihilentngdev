namespace CatalogRepositories;

using CatalogEntities;
using System.Collections.Generic;
public class ProductRepository : IProductRepository
{


    //automic operations
    public IEnumerable<Product> GetAllProducts()
    {
        return JSONCatalogManager.LoadProducts();
    }


    public Product? GetProductById(int id)
    {
        IEnumerable<Product> products = GetAllProducts();
        return products.FirstOrDefault(p => p.Id == id);
    }

    public void AddProduct(Product product)
    {
        List<Product> products = GetAllProducts().ToList();
        products.Add(product);
        JSONCatalogManager.SaveProducts(products);
    }

    public void UpdateProduct(Product product)
    {
        
    }

    public void DeleteProduct(int id)
    {


    }
}
