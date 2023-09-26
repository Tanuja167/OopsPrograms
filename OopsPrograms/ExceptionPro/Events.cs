using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ExceptionPro
{
    //Create a Bank a class, with Debit & Credit method
    //You can assign a default balance using constructor
    //Credit method will accept the amount that needs to be added in balance
    //Debit method will accept the amount that needs to be deducted from the balance.
    //If amount is greater than balance raise an event → insufficient balance
    //If balance is low (< 3000) raise an event low balance
    //If balance is zero then raise an event zero balance.
    //Also use exception handling in the code

    public delegate void MyDelegate();
    public class Bank
    {
        public event MyDelegate InsufficientBalance;
        public event MyDelegate LowBalance;
        public event MyDelegate ZeroBlance;

        private double accbalnce;
        public Bank(double accbalance)
        {

            this.accbalnce = accbalance;


        }

        public void Credit(double creditamt)
        {
            accbalnce += creditamt;


        }
        public void Debit(double Debitamt)
        {

            if (Debitamt > accbalnce)
            {

                InsufficientBalance();

            }
            else if (accbalnce < 3000)
            {

                LowBalance();

            }
            else if (accbalnce == 0)
            {

                ZeroBlance();
            }


        }


    }
    public class Events
    {
        public static void Main(string[] args)
        {
            try
            {

                Bank b = new Bank(2000);
                b.InsufficientBalance += delegate () { Console.WriteLine("Account balance is insufficient"); };
                b.LowBalance += delegate () { Console.WriteLine("Low balnace"); };
                b.ZeroBlance += delegate () { Console.WriteLine("Zero balance"); };

                b.Credit(6000);
                b.Debit(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }

        }


    }
}