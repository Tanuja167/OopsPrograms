using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OopsPrograms.ExceptionPro
{
    internal class Trycatch1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter name: ");
            string str = Console.ReadLine();
            try
            {
                if(string.IsNullOrEmpty(str))
                {
                    throw new Exception("Name is required:");
                }
                Console.WriteLine("name is: "+str);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            { 
                
                  Console.WriteLine("Inside finally block: ");
            }

            /* try
             {
                 int n1 = 10, n2 = 0;
                 int result = n1 / n2;
                 throw new Exception("not by zero");

             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             finally
             {
                 Console.WriteLine("Inside finally block");
             }
             */



        }
    }
}
