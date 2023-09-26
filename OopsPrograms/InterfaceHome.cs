using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /*Create an interface with name IPrintable , declare method as Print(); Implement the interface with Employee, 
      Manager , Student class And display the respective details of that class.*/

    internal class InterfaceHome
    {
        static void Main(string[] args)
        {
            employee e=new employee();
            e.print();
            Managerr manager = new Managerr();
            manager.print();
            Student1 s = new Student1();
            s.print();

        }
    }
    public interface Iprintable1
    {
        void print();
    }
    public class employee: Iprintable1
    {
        public void print()
        {
            Console.WriteLine("Employee class");
        }
    }
    public class Managerr: Iprintable1
    {
        public void print()
        {
            Console.WriteLine("Manger Class");
        }
    }
    public class Student1: Iprintable1
    {
        public void print()
        {
            Console.WriteLine("Student Class:");
        }
    }

}
