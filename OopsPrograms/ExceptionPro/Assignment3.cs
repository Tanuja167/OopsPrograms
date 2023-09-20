using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            /* try
             {
                 if(age < 18)
                 {
                     throw new Exception("you can not vote");
                 }
                 Console.WriteLine("you can vote: ");
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 Console.WriteLine("inside finally block: ");
             }*/

            /*4. Chcek the  code try with finally*/

            try
            {
                if (age < 18)
                {
                    Console.WriteLine("you can not vote");
                }
                else
                {
                    Console.WriteLine("you can vote");
                }
            }
            finally
            {
                Console.WriteLine("Inside finally block: ");
            }
        }
    }
}
