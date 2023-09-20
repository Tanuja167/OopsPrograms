using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OopsPrograms.Employee1;

namespace OopsPrograms
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            /*Manager m = new Manager(1000, 5000, "Tanuja");
            m.CalculateSalary();
            m.display();*/
            Employee1 e=new Employee1(2000,"XYZ");
            e.CalculateSalary();
            e.display();

         


        }
    }
    public class Employee1
    {
        
        protected string name;
        protected double salary, hra, pf, da, ta, gross;

        public Employee1(double salary, string name) 
        {
            this.salary = salary;
            this.name = name;
            

        }
        public virtual void  CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            pf = salary * 0.12;
            ta = salary * 0.10;
            gross = (salary + hra + da + ta) - pf;

        }
        public virtual void display()
        {
            Console.WriteLine("Gross  Salary  :" + gross + "Name: " + name);
        }

        public class Manager: Employee1
        {
            private double foodallowance;

            public Manager(double foodallowance, double salary, string name) : base(salary, name)
            {
                this.foodallowance = foodallowance;
            }
            public override void CalculateSalary()
            {
                hra = salary * 0.40;
                da = salary * 0.20;
                pf = salary * 0.12;
                ta = salary * 0.10;
                gross = (salary + hra + da + ta+foodallowance) - pf;

            }
            
            public override void display()
            {
                Console.WriteLine("Gross  Salary  :" + gross + "Name: " + name);
            }
        }
    }
}
