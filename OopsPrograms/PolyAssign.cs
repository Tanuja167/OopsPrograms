using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /*1. WAJP2 create a class Kid with method readBook() and another method  readBook () with 2 
     * parameters. The method readBook here is over-loaded (same method name but different parameters)
     Create a class BigKid which extends Kid created above. Implement readBook()  differently in BigKid 
    class. Here the method readBook() has been over-ridden in  the child class BigKid()*/
    internal class PolyAssign
    {
        static void Main(string[] args)
        {
            Kid b=new BigKid();
            b.readbook();
            b.readbook("ABC", "XYZ");
            Kid k = new BigKid();
            k.readbook();
            Kid s = new Kid();
            s.readbook();
        }
    }
    public class Kid
    {
        public  virtual void readbook()
        {
            Console.WriteLine("readbook in kid class");
        }
        public void readbook(string a, string b)
        {
            Console.WriteLine($"Second readbook method{a}, {b}");
        }

    }
    public class BigKid : Kid
    {
        public override void readbook()
        {
            Console.WriteLine("readbook in Bigkid class");
        }
    }
}
