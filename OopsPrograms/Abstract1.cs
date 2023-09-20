using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class Abstract1
    {
        static void Main(string[] args)
        {
            Reactangle r = new Reactangle(10,20);
            r.Area();
            Console.WriteLine(r.Display());
            Console.WriteLine(r.Print());
        }
    }
     public abstract class Shape
    {
 
        public abstract string Draw(string name);
        public abstract void Area();
        public string Display()
        {
            return "This is shape class";
        }
    }

    public class Reactangle : Shape
    {
        private  int l, b;
        
        private double area;
        public Reactangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }

        public override void Area()
        {
            area = l*b;
        }
        public override string Draw(string name)
        {
            return name;
        }

        public string Print()
        {
            return $"area of Reactangle is {area}";
        }
    }


}
