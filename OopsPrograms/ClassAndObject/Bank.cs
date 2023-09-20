using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ClassAndObject
{
    internal class Bank
    { 
    
        static void Main(string[] args)
        {
            Bank0 b = new Bank0();
            b.Acccept(12345432, "Pooja", 2000.00);
            b.Display();
            Console.WriteLine("enter amount to credit");
            int cre=Convert.ToInt32(Console.ReadLine());
            b.credit(cre);
            Console.WriteLine("Enter amount to debit");
            int deb=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b.Debit(deb));
            b.Display();


        }
    }
    public class Bank0
    {
        int ac_no;
        string name;
        double bal;

        public void Acccept(int ac_no, string name, double bal)
        {
            this.ac_no = ac_no;
            this.name = name;
            this.bal = bal;
        }
        public void credit(double  cre_amt)
        {
            bal = bal + cre_amt;
        }
        public string Debit(double deb_amt) 
        {
            string msg = "";
            if(deb_amt<=bal)
            {
                bal = bal - deb_amt;
                msg = "transaction sucessful";
            }
            else
            {
                msg = "Insufficient Balance";
            }
            return msg;
        }
        public void Display()
        {
            Console.WriteLine($"Account number: {ac_no}, Name: {name}, BAL: {bal}");
        }
    }
}
