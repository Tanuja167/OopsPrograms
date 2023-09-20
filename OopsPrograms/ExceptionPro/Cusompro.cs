using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{
    internal class Cusompro
    {
        static void Main(string[] args)
        {
            try
            {
                stringexcep e = new stringexcep("tanuja00");
            }
            catch(NameExceptions excep)
            {
                Console.WriteLine(excep.Message);
            }
        }
    }
    public class NameExceptions : Exception
    {
        public NameExceptions(string error):base(error) 
        { 
        }
    }
    public class stringexcep
    {
        public stringexcep(string str)
        {
            Console.WriteLine(str);
            char[] ch = str.ToCharArray();

           for(int i=0; i<ch.Length; i++)
            {
                if (ch[i] >= 'a' && ch[i]<='z' || ch[i] >= 'A' && ch[i]<='Z')
                {
                    continue;
                }
                else
                {
                    throw new NameExceptions("string contains digits or special symbol");
                }
            }
        }
    }
}
