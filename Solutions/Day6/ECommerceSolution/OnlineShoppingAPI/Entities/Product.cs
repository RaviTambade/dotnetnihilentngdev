
namespace OnlineShoppingAPI.Entities;

//OOP's:
//Object: state , Behavior, Identity

//Model : state
//POCO Class
//Entity
public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}
