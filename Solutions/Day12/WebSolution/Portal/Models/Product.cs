
//SOLID Principles

//1. Single Responsibility Principle (SRP)
//2. Open/Closed Principle (OCP)
//3. Liskov Substitution Principle (LSP)
//4. Interface Segregation Principle (ISP)
//5. Dependency Inversion Principle (DIP)

//Single Responsibility Principle
//Model should have single responsibility of representing the data structure


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}