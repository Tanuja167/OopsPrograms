using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{
    internal class AgeExcep11
    {
        static void Main(string[] args)
        {
           try
            {
                Customer c1 = new Customer(22);
                
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class AgeException : Exception
    {
        public AgeException(string error): base(error) 
        {

        }
    }
    public class Customer
    {
        public Customer(int age)
        {
            if(age < 18)
            {
                throw new AgeException("you can not vote");
            }
            Console.WriteLine("you can vote: ");
        }
    }
}
