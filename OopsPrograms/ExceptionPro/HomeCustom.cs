using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{
    internal class HomeCustom
    {
        static void Main(string[] args)
        {
            try
            {
                Student6 s = new Student6("tanu");
            }
            catch(NameException1 e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
    }
    public class NameException1 : Exception
    {
        public NameException1(string error): base(error) 
        { 

        }
    }
    public class Student6
    {
        public Student6(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new NameException1("name is required");
            }
            Console.WriteLine(name);
        }
    }
}
