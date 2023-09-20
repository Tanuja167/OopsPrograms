using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /* 5) Write a program for class and object : (initialization through method)
     Note : Initializing object simply means storing data into object  */

    public class Assignment5Aug8
    {
        private int id;
        private string name;
        private double percentage;

        public void Intialize()
        {
            id = 2;
            name = "ABC";
            percentage = 90.00;
        }
        public string Display()
            {
            return $"ID: {id}, Name: {name}, Percentage: {percentage}";
            }

    }
}
