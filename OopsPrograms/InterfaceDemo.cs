using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
           User u = new User();
            u.Print(); 
        }
    }
    public interface Iprintable
    {
        void Print();
    }
    public class User: Iprintable
    {
        public void Print() 
        {
            Console.WriteLine("User details");
        }
    }
}
