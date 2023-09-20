using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsPrograms.ConstructorAndMethod
{
    
     /*create another method in Student class setCustomData(int customId, String customName) These 2 variables are
      * local variables.Call setCustomData from main method using Student object and assign any values to customId,
        customName from main method.Observe your values are overwritten in id and name instance variables.Then print
         id and name in main method.*/

    internal class StudentA1
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.setCustomData(121, "John");
            s1.display();
        }
    }
    public class Student1
    {
        private int customId;
        private String customName;

        public void setCustomData(int customId, String customName)
        {
           this.customId = 100;
            this.customName = "XYZ";
        }
        public void display()
        {
            Console.WriteLine($"ID: {customId},  Name: {customName}");
        }
    }
}
