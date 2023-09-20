using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Student2
    {
        private int id, roll_no;
        private string name, branch;
        private double percentage, english, hindi, marathi, total;

        

        public Student2(int i, string nn, int r, string bb, double en, double mar, double hi)
        {
            id = i;
            roll_no = r;
            name = nn;
            branch = bb;
            english = en;
            hindi = hi;
            marathi = mar;
        }
        public void calculate()
        {
            total = marathi + hindi + english;
            percentage = total / 3;
        }
        public void grade()
        {
            if (percentage > 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage > 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage > 60)
            {
                Console.WriteLine("Grade c");
            }
            else if (percentage > 50)
            {
                Console.WriteLine("Grade d");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }


        public string PrintDetails()
        {
            return $"Name: {name}  ID: {id}  Roll_no:{roll_no}  Percentage:{percentage} Branch: {branch}  Total: {total}";
        }
    }
}
