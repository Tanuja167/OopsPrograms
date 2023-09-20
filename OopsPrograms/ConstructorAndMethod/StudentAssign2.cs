using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.ConstructorAndMethod
{
    /* 2. Create getId() method in Student class. call getId() method from displayData 
    method so that you know that one method can be called from another method. Return id
    from getId() method and set that id to the instance variable in displayData method.*/
    internal class StudentAssign2
    {
        static void Main(string[] args)
        {
            Student s2=new Student();
           
            //Console.WriteLine(s2.getId(121));
            Console.WriteLine(s2.displayData());
        }
    }
        public class Student
        {
            private int id = 1;
            public int getId(int id)
            {
                return id;
            }
            public string displayData()
            {

                this.getId(id);
                return $"ID: {id}";


            }

        }
}
