using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace OopsPrograms.ConstructorAndMethod
{
    /* Create Product class with code, name & Price. Assign value using property Use both property & object 
     * initializer syntax, & display the product details*/

    internal class ProductPro
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.CODE = 1001;
            p.Name = "Test";
            p.Price = 200.00;
            p.display();
          //  Product p1 = new Product(){ 101, "Tanu", 200};

        }
    }
    public class Product
    {
        int code;
        string name;
        double price;

        public int CODE
        {
            set { code = value; }
            get { return code; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public void display()
        {
            Console.WriteLine($"Product CODE{code}, NAME: {name}, Price: {price}");
        }
    }
}
