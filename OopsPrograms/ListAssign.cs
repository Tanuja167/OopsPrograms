using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class ListAssign
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            for(int i=0;i<=5;i++)
            {
                string str = Console.ReadLine();
                list.Add(str);
            }
            for (int i = 0; i <= 5; i++)
            {
                int cnt = 0;
                for (int j = i + 1; j <= 5; j++)
                {
                    if (list[i] == list[j])
                    {
                        cnt++;
                      
                    }
                }
                Console.WriteLine($"{list[i]} - {cnt}");
            }
        }
    }
}
