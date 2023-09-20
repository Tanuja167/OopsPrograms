using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class LogicAssign14
    {
        static void Main(string[] args)
        {

            
            ActionStudent a = new ActionStudent(12, 25, "Rutuja", 89.00);
           
            a.CreateStudent();
            a.displaystudent();
           
        }
    }
    public class Student0
    {
       protected int stud_id, age;
       protected  double per;
       protected string stu_name;

        public Student0(int stud_id, int age, string stu_name, double per) 
        {
            this.stud_id = stud_id;
            this.age = age;
            this.stu_name = stu_name;
            this.per = per;
        }

    }
    public class ManagerStudent: Student0
    {
        public ManagerStudent(int stud_id, int age, string stu_name, double per):base(stud_id, age, stu_name, per)
        {
            Console.WriteLine("Manager student:");
        }
        public virtual void CreateStudent()
        {
            Console.WriteLine("create Manger student");
        }
        public virtual void displaystudent()
        {
            Console.WriteLine("student Id: " + stud_id + "Age "+age+"studdent name"+stu_name+" Percentage: "+per);
        }
    }
    public class ActionStudent: ManagerStudent
    {
        public ActionStudent(int stud_id, int age, string std_name, double per):base(stud_id, age, std_name, per)
        {

        }
        public override  void CreateStudent()
        {
            Console.WriteLine("Action");
        }
        public override void displaystudent()
        {
            Console.WriteLine("student Id: " + stud_id + "Age " + age + "studdent name" + stu_name + " Percentage: " + per);
        }

    }
}
