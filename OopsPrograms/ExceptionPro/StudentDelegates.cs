using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{

    internal class StudentDelegates
    {
        static void Main(string[] args)
        {
            try
            {
                Student7 stud1 = new Student7();

                // bind event with delegate
                // this a method body / code
                //{ Console.WriteLine("You are fail"); }
                stud1.Fail += delegate () { Console.WriteLine("You are fail"); };
                stud1.Pass += delegate () { Console.WriteLine("You are pass"); };

                stud1.AcceptPercentage(65);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        public delegate void Mydelegate3();

        public class Student7
        {
            public event Mydelegate3 Fail;
            public event Mydelegate3 Pass;

            public void AcceptPercentage(double per)
            {
                if (per < 40)
                {
                    Fail();
                }
                else
                {
                    Pass();
                }
            }
        }
    }
}
   /* public class Message
    {
         public void SucessMessage()
        {
            Console.WriteLine("You are pass in the Exam");
        }
        public void FailMessage()
        {
            Console.WriteLine("You are fail in the exam");
        }
    }*/


