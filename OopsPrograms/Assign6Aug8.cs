using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /* 6) Create a class Account containing following methods : insert() to insert account data
          display() to display account information deposit() to deposit amount withdraw() to 
           withdraw amount checkbalance() to check balance */

    public class Assign6Aug8
    {
        private int ac_no;
        private string name;
        private double amount;
        //private double dep_amt;
       // private double wd_amt;
        
        public void insert(int ac_no, string name, double amount)
        {
            this.ac_no = ac_no;
            this.name = name;
            this.amount = amount;

        }
        public string Display()
        {
            return $"Account No: {ac_no}, Name: {name}, Amount: {amount}";
        }

        public void deposite(double dep_amt)
        {
            
            if (dep_amt>0)
            {
                amount=amount+dep_amt;
                
            }
            else
            {
                Console.WriteLine("enter valid amount:");
            }
        }
        public string WithDraw(double wd_amt)
        {
            string msg = "";
            if (wd_amt<amount)
            {
                amount=amount-wd_amt;
                msg = "transaction done";
            }
            else
            {
                msg="Insufficient balance";
            }
            return msg;
        }
        public double checkbalance()
        {
            return amount;
        }
       

    }
}
