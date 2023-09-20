using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ClassAndObject
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Employee0 e= new Employee0();
            e.Accept(01, "Alisha", "COMP", 50000.00);
            Console.WriteLine(e.Show());
        }
    }
    public class Employee0
    {
        int id;
        string name, dep;
        double ta, da, hra, pf, salary, gross;

        public void Accept(int id, string name, string dep, double salary)
        {
            this.id = id;
            this.name = name;
            this.dep = dep;
            this.salary = salary;
        }
        public void CalSal()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.12;
            pf = salary * 0.10;
            gross = (hra + da + ta) - pf;
        }
        public string Show()
        {
            return $"Employee ID: {id},  Name: {name},  DEP: {dep},  salary: {salary}, Gross: {gross}";
        }
        
    }
}
