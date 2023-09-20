using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /*6.	Write a C# program to remove all occurrences of a character from string.*/
    internal class Assign6
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            Console.WriteLine(str);

            char[] ch = str.ToCharArray();

            Console.WriteLine("enter character that we want to remove: ");
            char c = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'c')
                {
                    str.Remove(i);
                }
                

            }
          

        }
    }
}
