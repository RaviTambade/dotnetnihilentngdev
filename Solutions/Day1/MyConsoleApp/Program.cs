
using Catalog;
using HR;
int count = 45;
count++;
if (count > 50)
{
    Console.WriteLine("Count exceeded 50");
}
else
{
    Console.WriteLine("Count is within the limit");
}
Console.WriteLine(count);

Product product = new Product("Laptop", 1500.00m);
Console.WriteLine($"Product Name: {product.GetName()}, Price: {product.GetPrice()}");


SalesEmployee se = new SalesEmployee("John Doe", 12345, 50000);