using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Employee2
    {
        int id;
        String name, department;
        double salary, hra, pf, da, ta, gross;
        private static int count = 0;

       public static int GetCount()
        {
            return count;
        }
        public Employee2(int id, string name, string department, double salary)
        {
            count++;
            this.id =count;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            pf = salary * 0.12;
            ta = salary * 0.10;
            gross = (salary + hra + da + ta) - pf;

        }
        public string Print()
        {
            return $"ID: {id} Name: {name}  Department: {department}  Salary: {salary}  Gross: {gross}";
        }
    }
}
