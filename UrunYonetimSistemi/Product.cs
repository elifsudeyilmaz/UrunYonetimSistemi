using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeInventory
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        

        public Product(int id, string name, string category, double price, int stock)
        {
            ID = id;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Category: {Category}, Price: {Price:C}, Stock: {Stock}";
        }
    }
}
