using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Prime
    {
      
        /*  public bool IsPrimeCheck(int n)
          {
              bool isprime = true;

              for(int i=2;i<n;i++)
              {
                  if(n%i==0)
                  {
                      isprime = false;
                      break;
                  }  
              }
              return isprime;
          }*/
        int count = 0;
        public int IsPrime(int n)
        {
            
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    count++;
                    break;
                }

            }
            return count;
            
        }
        public void Check()
        {
            if(count==0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
        
        

    }
}
