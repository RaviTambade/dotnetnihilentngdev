using MongoDB.Driver;   // DB connectivity learning

using System.Collections.Generic;

public class ProductRepository
{
    private readonly IMongoCollection<Product> _products;

    public ProductRepository(string connectionString, string databaseName, string collectionName)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        _products = database.GetCollection<Product>(collectionName);
    }

    // CREATE
    public void Insert(Product product)
    {
        _products.InsertOne(product);
    }

    // READ ALL
    public List<Product> GetAll()
    {

        //LINQ : feature of C# programming
        //Query against .net collection objects
        //Extension Methods:

        return _products.Find(p => true).ToList();
    }

    // READ by MongoDB _id
    public Product GetByMongoId(string mongoId)
    {
        return _products.Find(p => p._id == mongoId).FirstOrDefault();
    }

    // READ by Business Id
    public Product GetByBusinessId(int id)
    {
        return _products.Find(p => p.Id == id).FirstOrDefault();
    }

    // UPDATE by Business Id
    public void Update(Product product)
    {
        _products.ReplaceOne(p => p.Id == product.Id, product);
    }

    // DELETE by Business Id
    public void Delete(int id)
    {
        _products.DeleteOne(p => p.Id == id);
    }
}
