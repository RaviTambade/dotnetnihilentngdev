

namespace Catalog
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product GetProduct(int id)
        {
            return  new Product(); 
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            
        }

        public void DeleteProduct(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}