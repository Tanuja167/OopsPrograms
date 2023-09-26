using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class Abstractclass
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            c.Area();
            Console.WriteLine(c.Draw("circle area: "));
            Console.WriteLine(c.print());
        }
    }
    public abstract class shape
    {
        int a; 
        int b;
        public shape(int a, int b)
        {
            this.a = a; 
            this.b = b; 
        }
       
        public abstract void Area();
        public abstract string Draw(string name);

        public string Display()
        {
            return "this is shape class";
        }

    }
    public class Circle : shape
    {
        const double pi = 3.14;
        int radius;
        double area;

        public Circle(int radius) : base( 3,4)
        {
            this.radius = radius;
        }
        public override void Area()
        {
            area = pi * radius* radius  + (3+4);
        }
        public override string Draw(string name)
        {
            return name;
        }
        public string print()
        {
            return $"Area of circle is: {area}";
        }
    }
}
