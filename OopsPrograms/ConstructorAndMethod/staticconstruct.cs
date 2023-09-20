using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ConstructorAndMethod
{
    internal class staticconstruct
    {
        static void Main(string[] args)
        {
            student4 student = new student4();
            
        }
    }
    public class student4
    {
        static int x;
        static student4()
        {
            x = 10;
            Console.WriteLine("static constructor gets called: ");
            Console.WriteLine(x);
        }
        public student4()
        {
            x = 20;
            Console.WriteLine("instance constructor gets called: ");
            Console.WriteLine(x);
        }

    }
}
