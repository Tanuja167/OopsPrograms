using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Constructor
{
    /* add method displayData inside Student class change values of id name in that method & also 
    print the changed values in same method. Call displayData method from main method and 
    see the output. Observe displayData canonly be called by creating object of Student*/
    internal class StudentAssignment
    {
        static void Main(string[] args)
        {
            Student s = new Student(200, "Tanuja");
            s.display();
           

        }
    }
    public class Student
    {
        int id;
        string name;
        public Student(int id, string name )
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            id = 101;
            name = "Alisha";

            Console.WriteLine("Name"+name+" "+"ID"+id);
        }
    }
}
