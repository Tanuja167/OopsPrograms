using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{
    internal class customExcep
    {
        /*Use / create Student class , accept the name from constructor & if name is empty or null then raise 
         * an exception ie. NameException with message ‘name is required’*/

        static void Main(string[] args)
        {
            try
            {
                Student stud = new Student("Tanuja");
            }
            catch (NameException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
   
        public class NameException : Exception
        {
           
            public NameException(string error) : base(error)
            {

            }
        }
        public class Student
        {
            public Student(string name)
            {
                if (string.IsNullOrEmpty(name))
            {
                throw new NameException("name");
            
            }
                else
            {
                Console.WriteLine(name);
            }
        }
    }
}
