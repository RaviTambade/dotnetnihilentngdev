
namespace OnlineShoppingAPI.Repositories;
using System.Collections.Generic;
using OnlineShoppingAPI.Entities;



//ravi.tambade@transflower.in
//9881735801



//CRUD Operations agains List Colllection

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public ProductRepository()
    {
        // Seed with some initial data
        _products.Add(new Product { Id = 1, Title = "Gerbera", Price = 10.99M, Description = "Wedding Flower" });
        _products.Add(new Product { Id = 2, Title = "Rose", Price = 20.99M, Description = "Valentine's Day Flower" });
        _products.Add(new Product { Id = 3, Title = "Tulip", Price = 30.99M, Description = "Spring Flower" });
    }

    public IEnumerable<Product> GetAllProducts()
    {

        return _products;
    }

    public Product GetProductById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        var existingProduct = GetProductById(product.Id);
        if (existingProduct != null)
        {
            existingProduct.Title = product.Title;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
        }
    }

    public void DeleteProduct(int id)
    {
        var product = GetProductById(id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}