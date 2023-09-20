using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class Mock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int  a =0, b=1, temp;
            Console.WriteLine(a);
            //Console.WriteLine(b);

            for (int i=0; i<num; i++)
            {
               int f = a + b;
                Console.WriteLine(f);
                temp = a;
                a = b;
                b = f;


            }
            
        }
    }
}
