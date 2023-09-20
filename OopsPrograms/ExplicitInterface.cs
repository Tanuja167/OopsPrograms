using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class ExplicitInterface
    {
        static void Main(string[] args)
        {
            Icustomer i = new Transaction();
            Console.WriteLine(i.display());
            Iorders io=new Transaction();
            Console.WriteLine(io.display());
        }
    }
    public interface Icustomer
    {
        string display();
    }
    public interface Iorders
    {
        string display();
    }
    public class Transaction: Icustomer, Iorders 
    { 
         string Icustomer.display()
        {
            return $"Customer details";
        }
        string Iorders.display()
        {
            return $"Order details";
        }
    }

}
