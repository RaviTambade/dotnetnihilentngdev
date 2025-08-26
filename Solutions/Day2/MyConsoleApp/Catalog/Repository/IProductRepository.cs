
//interface act like contract


namespace  Catalog
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(int id);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}