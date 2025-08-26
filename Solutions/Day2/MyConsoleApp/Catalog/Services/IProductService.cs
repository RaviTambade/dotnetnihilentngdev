
namespace Catalog;

public interface IProductService
{
    void AddProduct(Product product);
    Product GetProduct(int id);
    IEnumerable<Product> GetAllProducts();
    void UpdateProduct(Product product);
    void DeleteProduct(int id);
}
