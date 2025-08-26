//Logical collection of .net types
//class, interface, struct, enum
//delegate, event


//Primitive types   
//int, float, double, char, bool

namespace  Catalog;
 
    public class Product
    {
        //access specifier: visibility 
        //public , protected, internal
        private string name;
        private decimal price;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }

        //Constructor overloading
        public Product()
        {
            this.name = string.Empty;
            this.price = 0.0m;
        }
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }

