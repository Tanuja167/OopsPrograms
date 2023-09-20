using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class baseuse
    {
        static void Main(string[] args)
        {
            child c = new child();
           // c.show();

        }
    }
    public class parent
    {
        //protected int x = 10;

        public parent(string name)
        {
            Console.WriteLine("parent: "+name);
        }
       /* public void show()
        {
            Console.WriteLine("this is parent: ");
        }*/
    }
    public class child : parent
    {
       // int x = 20;

        public child() : base("tanuja")
        {
            Console.WriteLine("child");
        }
       /* public void show()
        {
            Console.WriteLine(x + " "+base.x );

        }*/
    }
}
