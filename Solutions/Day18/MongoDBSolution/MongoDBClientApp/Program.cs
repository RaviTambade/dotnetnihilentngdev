// 🔹 MongoDB settings


        //Mongo DB connection string

        string connectionString = "mongodb://localhost:27017"; // adjust if needed
        string databaseName = "ecommerce";
        string collectionName = "products";

        var repo = new ProductRepository(connectionString, databaseName, collectionName);

        Console.WriteLine("=== Product CRUD using MongoDB.Driver ===\n");

 // 1. CREATE
 var product = new Product
 {
     Id = 1,
     Title = "Jasmine",
     Description = "Smelling Flower",
     UnitPrice = 12,
     Quantity = 2300,
     ImageUrl = "/images/jasmine.jpg"
 };

 repo.Insert(product);
 Console.WriteLine("✅ Inserted Product: Jasmine");
 

// 2. READ ALL
Console.WriteLine("\n📦 All Products:");
        foreach (var p in repo.GetAll())
        {
            Console.WriteLine($"{p.Id} - {p.Title} | {p.Description} | {p.UnitPrice:C} | Qty: {p.Quantity}");
        }

        // 3. READ by Business Id
        var jasmine = repo.GetByBusinessId(1);
        if (jasmine != null)
        {
            Console.WriteLine($"\n🔍 Found Product by Id=1: {jasmine.Title}, Price={jasmine.UnitPrice}");
        }

        // 4. UPDATE
        jasmine.UnitPrice = 15;
        jasmine.Quantity = 2500;
        repo.Update(jasmine);
        Console.WriteLine($"\n✏️ Updated Jasmine → Price={jasmine.UnitPrice}, Qty={jasmine.Quantity}");

        // 5. DELETE
        repo.Delete(1);
        Console.WriteLine("\n🗑️ Deleted Product with Id=1");

        // Show remaining
        Console.WriteLine("\n📦 Products after Delete:");
        foreach (var p in repo.GetAll())
        {
            Console.WriteLine($"{p.Id} - {p.Title}");
        }

        Console.WriteLine("\n=== Done ===");
   