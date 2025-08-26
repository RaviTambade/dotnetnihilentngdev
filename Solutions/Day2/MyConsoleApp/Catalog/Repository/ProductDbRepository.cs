
namespace Catalog;

public class ProductDBRepository : IProductRepository
{
   // to perform CRUD Operations against MongoDB
    public void AddProduct(Product product)
    {
        
    }

    public Product GetProduct(int id)
    {
        return new Product();
         
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return new List<Product>();
    }

    public void UpdateProduct(Product product)
    {
         
    }

    public void DeleteProduct(int id)
    {
         
    }
}
