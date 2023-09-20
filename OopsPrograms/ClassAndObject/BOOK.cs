using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ClassAndObject
{
    internal class BOOK
    {
        static void Main(string[] args)
        {
            Book b=new Book();
            b.Accept("IIB", "C.V", 120.00);
            Book b1=new Book();
            b1.Accept("XYZ", "ABC", 200);
            b.display();
            b1.display();
        }
    }
    public class Book
    {
        string name, author_name;
        double price;

        public void Accept(string name, string  author_name, double price)
        {
            this.name = name;
            this.author_name = author_name;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine($"Book Details: Name: {name}, Author_Name: {author_name}, Price: {price}");
        }

    }
}
