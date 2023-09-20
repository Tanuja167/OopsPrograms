using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /*7. Create interface IceCream with method eat and Juice with method drink. Create class Mastani 
     * which implements both interfaces.*/

    internal class InterFaceAssignIce
    {
        static void Main(string[] args)
        {
            Mastani m=new Mastani();
            m.drink();
            m.eat();
        }

    }
    public interface IIceCream
    {
         void eat();
    }
    public interface IJuice
    {
        void drink();
    }
    public class Mastani : IIceCream, IJuice
    {
        public void eat()
        {
            Console.WriteLine("Ice-Cream Interface implemented");
        }
        public void drink()
        {
            Console.WriteLine("Juice Interface implemented");
        }
    }
}
