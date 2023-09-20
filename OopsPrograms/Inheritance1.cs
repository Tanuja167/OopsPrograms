using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static OopsPrograms.person;

namespace OopsPrograms
{
    internal class Inheritance1
    {
        static void Main(string[] args)
        {
            Patient p = new Patient("Tanu", "ABC", 12345123, "A+", 1200);
            Console.WriteLine(p.Display());

        }
    }
    public class person
    {
        protected string name, address;
        protected long aadhr_no;

        public person(string name, string address, long aadhr_no)
        {
            this.name = name;
            this.address = address;
            this.aadhr_no = aadhr_no;
        }
        public class Patient : person
        {
            protected string BG;
            protected int bill;
            public Patient(string name, string address, long aadhr_no,string BG, int bill) :
                base(name, address, aadhr_no)
            {
                this.BG = BG;
                this.bill = bill;
            }
           
            public string Display()
            {
                return $"Name: {name}, Address: {address}, AadharNo: {aadhr_no}, Blood Group:{BG}, Bill: {bill}";


            }
        }
    }
}
