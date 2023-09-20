using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Student3
    {
        private int rollno;
        private string name;
        private double percentage;

        public int RollNo
        {
            set { rollno = value; }
            get { return rollno; }
        }
        public string Name
        {
            set {name=value; }
            get { return name; }
        }
        public double Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }
        public string print()
        {
            return $"RollNo: {rollno}, Name: {name}, Percentage: {percentage}";
        }

    }
    

    
}
