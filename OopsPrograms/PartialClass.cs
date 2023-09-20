using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class PartialClass
    {
        static void Main(string[] args)
        {
            Cal c=new Cal();
            Console.WriteLine(c.Add(10, 20));
            Console.WriteLine(c.squ(2));
            Console.WriteLine(c.squ(4));
            Console.WriteLine(c.Add1(11, 11));
            

        }
    }
    public partial class Cal
    {
        int a,b;
         public int Add(int a, int b)
        {
            this.a= a; 
            this.b = b;
            return a + b;
        }
        public int squ(int a)
        {
            squareroot(a);
            return a * a;
        }
        partial void squareroot(int a);
        
    }
    public partial class Cal
    {
         int x, y ;
        public int Add1(int x, int y)
        {
            this.x = x;
            this.y = y;
            return x + y;
        }
        partial void squareroot(int a)
        {
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine("square root is implemented");

        }
    }
    public partial class Cal
    {
        public int Add2(int i, int j)
        {
           
            return a + b;
        }
        
    }
}
