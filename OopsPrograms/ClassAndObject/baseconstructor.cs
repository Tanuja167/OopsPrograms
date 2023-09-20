using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ClassAndObject
{
    internal class baseconstructor
    {
        static void Main(string[] args)
        {
            child c = new child("tanuja");

        }
    }
    public class parent
    {
        public parent(string name)
        {
            Console.WriteLine("parent class: "+name);
        }
    }
    public class child : parent
    {
        public child(string name) : base(name)
        {
           
            /*Console.WriteLine("enter name: ");
            name = Console.ReadLine();*/
            Console.WriteLine("child class");
        }
    }
}
