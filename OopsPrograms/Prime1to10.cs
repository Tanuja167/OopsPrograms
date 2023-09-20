using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Prime1to10
    {

       // private int num;
        public int Isprime(int num)
        {
            int count = 0;
       


              for (int j = 2; j < num; j++)
              {

                  if (num % j == 0)
                  {
                      count++;
                      break;
                  }
              }
              return count;    

        }
    }
}
