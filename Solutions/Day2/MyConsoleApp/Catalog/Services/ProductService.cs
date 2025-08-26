namespace Catalog;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
    }

    public Product GetProduct(int id)
    {
        return _productRepository.GetProduct(id);
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _productRepository.GetAllProducts();
    }

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
    }

    public void DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
    }
}
