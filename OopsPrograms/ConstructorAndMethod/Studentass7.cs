using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ConstructorAndMethod
{
    /* 7) Create class student and write a meaningful program with 3 methods (1 with return type (calculating 
     * percentage), 1 without return type (displaying student data), 1 with parameter list).*/

    internal class Studentass7
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.Accept(50, 60, 70);
            Console.WriteLine(s.cal());
            s.Display();
        }
    }
    public class student
    {
        double m1, m2, m3, avg, total;
        public void Accept(double m1, double m2, double m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public double cal()
        {
            total = m1 + m2 + m3;
            avg = total / 3;
            return avg;
        }
        public void Display()
        {
            Console.WriteLine("Average is: " + avg);
        }

    }

}
