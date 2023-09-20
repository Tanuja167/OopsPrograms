using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Product
    {
        int id;
        string name;
        double price;

        public Product()
        {
            id = 0;
            name = "";
            price = 0;
        }
        public Product(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public string Discount(int dis_val)
        {
           
            
                price = price-((price/100)*dis_val);
            return $"ID: {id}, Name: {name}, Price: {price}";
        }
        
    }
}

