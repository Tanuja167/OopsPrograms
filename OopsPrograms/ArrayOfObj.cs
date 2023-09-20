using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class ArrayOfObj
    {
        static void Main(string[] args)
        {
            Product1[] p = new Product1[3];
            p[0] = new Product1(1, "Tanuja", 78000);
            p[1] = new Product1(2, "xyz", 56789);
            p[2] = new Product1(3, "abc", 56789);

            foreach(var item in p)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
    public class Product1
    {
      public  int id;
      public  string name;
      public int price;

        public Product1(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{id},{name},{price}";
        }
    }
}

/*for(int i=0; i<emp.Length; i++)
            {
                Console.WriteLine("Enter Id:");
                int empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                string n= Console.ReadLine();
                Console.WriteLine("Enter salary");
                int sal = Convert.ToInt32(Console.ReadLine());
for(int i=0;i<p.Length;i++) 
            {
                if (p[i].sal > 20000)
                {
                    Console.WriteLine(emp[i]);
                }
            }*/
            
