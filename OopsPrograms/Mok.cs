using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class Mok
    {
        static void Main(string[] args)
        {
            /*
            string str = "Good Morning";
            string str2 = "Hello";
            Console.WriteLine(str);*/

            /*  string str3 = string.Concat(str, str2);
              Console.WriteLine(str3);*/

            /* char[] ch = {  };
             string str4 = str.TrimStart();
             Console.WriteLine(str4);*/

            /* Console.WriteLine(str2.IndexOf('o'));

             string s = "hello all good";

             string[] strings = s.Split();
             int cnt = 0;

             for(int i=0;i<strings.Length; i++)
             {
                 cnt++;
             }
             Console.WriteLine("total number of words in string: "+cnt);*/

            //toggle case

            string str = "hello all hello";
            string[] str1 = str.Split();
            string str2 = "";

            for(int i=str1.Length-1; i>=0;i--)
            {
                str2 = str2+ " " + str1[i];
            }
            Console.WriteLine(str+": original string");
            Console.WriteLine(str2+ ":  after reverse");
            if (str.Equals(str2))
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }








        }
    }
}
