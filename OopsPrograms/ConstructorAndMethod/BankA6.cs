using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ConstructorAndMethod
{
    /* 6) Create a class Account containing following methods : insert() to insert account data display() to display 
     * account information deposit() to deposit amount withdraw() to withdraw amount checkbalance() to check balance
     * e.g. class Account{ int acc_no; String name; float amount; } */

    internal class BankA6
    {
        static void Main(string[] args)
        {
            Account a=new Account();
            a.insert(123, "ABC", 6000.00);
            Console.WriteLine(a.display());
            a.deposite(200);
            a.withdraw(800);
            Console.WriteLine(a.checkbal());
            Console.WriteLine(a.display());
        }
    }
    public class Account
    {
        int acc_no;
        string name;
        double bal;
        public void insert(int acc_no, string name, double bal)
        {
            this.acc_no = acc_no;
            this.name = name;
            this.bal = bal;
        }
        public string display()
        {
            return $"Account ID: {acc_no}, Name: {name}, Balance: {bal}";
        }
        public void deposite(double d_amt)
        {
            bal = bal + d_amt;
        }
        public string withdraw(double w_amt)
        {
            string msg = "";
            if(w_amt<=bal)
            {
                bal = bal-w_amt;
                msg ="transaction sucessful";
            }
            else
            {
                msg = "Insufficient balance";
            }
            return msg ;
        }
        public double checkbal()
        {
            return bal;
        }
    }
}
