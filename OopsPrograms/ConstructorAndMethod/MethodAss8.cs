using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ConstructorAndMethod
{
    /*8)Write  Program for arithmetic  operation for each operation write separate Method.
    9) Write Program for arithmetic operation for each operation write separate Method using parameter Passing*/
    internal class MethodAss8
    {
        static void Main(string[] args)
        {
            Arith a=new Arith();
            a.ADD(20, 20);
            a.display();
            a.Sub(20, 10);
            a.display();
            a.Mul(20, 2);
            a.display();
            a.Div(200, 2);
            a.display();

        }
    }
    public class Arith
    {
        double result;
        public void ADD(int a, int b)
        {
            result = a + b;
        }
        public void Sub(int x, int y)
        {
            result = x - y;
        }
        public void Mul(int x, int y) 
        {
            result = x * y;
        }
        public void Div(int x, int y)
        {
            result = x / y;
        }
        public void display()
        {
            Console.WriteLine($"{result}");
        }
    }
}
