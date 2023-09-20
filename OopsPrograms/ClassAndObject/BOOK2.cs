using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ClassAndObject
{
    internal class BOOK2
    {
        static void Main(string[] args)
        {
            Book2 b=new Book2();
            Console.WriteLine(b.display());
            Book2 b1 = new Book2(201, "Agnipank", "A.P.J", 300.00);
            Console.WriteLine(b1.display());
        }
    }
    public class Book2
    {
        int id;
        string title, author;
        double price;

        public Book2()
        {
            id = 001;
            title = "NDA";
            author = "JOHN";
            price = 200;
        }
        public Book2(int id, string title, string author, double price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public string display()
        {
            return $"Book Details: ID: {id}, Title: {title}, Author: {author}, Price: {price}";
        }
    }
}
