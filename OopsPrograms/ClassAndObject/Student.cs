using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ClassAndObject
{
    internal class Student
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            p.Accept("Tanu", 121);
            p.Display();
        }
    }
    public class Person
    {
        String name;
        int id;
        public void Accept(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public void Display()
        {
            Console.WriteLine($"Name of student: {name}, And ID is: {id} ");
        }
    }
    
}
