using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{
    internal class Assignment1
    {
        /*1.If number is negative then throw negative number exception.*/
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number: ");
                int num =Convert.ToInt32(Console.ReadLine());

                if(num <0)
                {
                    throw new Exception("negative number exception");
                }
                Console.WriteLine(num);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
