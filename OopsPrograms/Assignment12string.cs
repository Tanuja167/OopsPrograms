using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /*12.	Write a C# program to find unique char.*/
    internal class Assignment12string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string st = Console.ReadLine();
            char[] ch = st.ToCharArray();
            

            for(int i=0;i<ch.Length; i++)
            {
                int cnt = 1;
                bool flag = false;
                for(int k = i-1;k>=0;k--)
                {
                    if (ch[i] == ch[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    for(int j=i+1;j<ch.Length;j++)
                    {
                        if (ch[j] == ch[i])
                        {
                            cnt++;
                        }
                    }
                    if(cnt == 1)
                    {
                        Console.WriteLine("unique character found is: " + ch[i]);
                    }
                }
                
            }
        }
    }
}
