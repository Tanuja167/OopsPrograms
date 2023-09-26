using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Date class");
                Date d1=new Date();
                d1.AcceptDate(4, "Aug", 2023);
                string res= d1.PrintDate();
                Console.WriteLine(res);
                Console.WriteLine();

              //student
              Student s = new Student();
              s.AcceptDetails("tanuja", 101, "comp", 67 , 87, 66);   
              s.calculate();
              Console.WriteLine(s.PrintDetails());
              s.grade();

              Student s1 = new Student();
              s1.AcceptDetails("tanuja", 101, "comp", 67, 87, 66);
              s1.calculate();
              Console.WriteLine(s1.PrintDetails());
              s1.grade();
              Console.WriteLine("Total students are: " + Student.GetCount1());

              Console.WriteLine();

              //employee
              Employee e = new Employee();
              e.Accept(4, "Emp1","Dep1" ,40000);
              e.CalculateSalary();
              Console.WriteLine(e.Print());
              Console.WriteLine();

              //book
              Book b=new Book();
              b.Accept(11, "ABCD", "XYZ", 100.56);
              string result1 = b.Display();
              Console.WriteLine(result1); */

            
           

            /* Console.WriteLine("Employee class");

             Employee2 e1= new Employee2(10, "Emp1", "Dep1", 40000);      //parameterised Constructor
             e1.CalculateSalary();
             Console.WriteLine(e1.Print());

             Employee2 e2 = new Employee2("Emp1", "Dep1", 40000);      //parameterised Constructor
             e2.CalculateSalary();
             Console.WriteLine(e2.Print());

             Employee2 e3 = new Employee2("Emp1", "Dep1", 40000);      //parameterised Constructor
             e3.CalculateSalary();
             Console.WriteLine(e3.Print());

             Console.WriteLine("Total employees are: "+Employee2.GetCount());

             Console.WriteLine();
             Console.WriteLine("________________________________________________");*/



            /*  Console.WriteLine("Student class");
              Student2 s2=new Student2(100, "Sagar", 12, "CS", 45, 78, 89);
              s2.calculate();
              s2.grade();
              Console.WriteLine(s2.PrintDetails());
              Console.WriteLine();

              Console.WriteLine("Book Class");
              Book2 B1=new Book2();                 //default
              Console.WriteLine(B1.Display());
              Console.WriteLine();
              Book2 B = new Book2(1, "OOP", "John", 67.89);   //parameterised
              Console.WriteLine(B.Display());
              Console.WriteLine();*/


            /* Console.WriteLine("Enter the default balance");
             double bal = Convert.ToDouble(Console.ReadLine());
             Bank b = new Bank(101,"Xyz",bal);
             Console.WriteLine(b.print());

             Console.WriteLine("Enter amount to credit");
             double d_amt=Convert.ToDouble(Console.ReadLine());
             b.credit(d_amt);

             Console.WriteLine(b.print());

             Console.WriteLine("enter debit amount");
             double deb_am=Convert.ToDouble(Console.ReadLine());
             string msg = b.Debit(deb_am);
             Console.WriteLine(msg);
             Console.WriteLine(b.print());
             Console.WriteLine();


             Console.WriteLine("Product class");
             Product p = new Product(1, "Pen", 100.00);
             Product p1 = new Product(2, "pencil", 30);

             Console.WriteLine(p.Discount(10));
             Console.WriteLine(p1.Discount(5));  */



            PropertyStudent3 st=new PropertyStudent3();
             st.RollNo = 1;                            //Property intializer
             st.Name = "Tanuja";
             st.Percentage =  78.00;
             Console.WriteLine(st.print());

             //Object Intializer
             PropertyStudent3 s=new PropertyStudent3() { RollNo = 2, Name = "Alisha", Percentage = 80.00};
             Console.WriteLine(s.print());
             Console.WriteLine(  );

             /*Product2 p2 = new Product2();
             p2.Code = 101;                   //property intializer
             p2.Name = "Pen";
             p2.Price = 10.00;
             Console.WriteLine(p2.print());

             Product2 pr2 = new Product2() { Code = 102, Name = "pencil", Price = 20.00 };
             Console.WriteLine(pr2.print());    //object intializer 
*/
           /* Movie m = new Movie(1, "ABC", 200, 14);
            
            m.Available_Tickets();
            Console.WriteLine(m.Display());

            Movie m1 = new Movie(1, "ABC", 200, 12);
            
            m1.Available_Tickets();
            Console.WriteLine(m1.Display());*/

            /*  Prime p = new Prime();
              p.IsPrimeCheck(7);
              bool ischeck = p.IsPrimeCheck(7);

              if(ischeck)
              {
                  Console.WriteLine("Prime");
              }
              else
              {
                  Console.WriteLine("not prime");
              }*/

            /*         Prime p1 = new Prime();

                     p1.IsPrime(7);
                     p1.Check();*/


            /*        Prime1to10 p=new Prime1to10();
                    for(int i=1;i<=10; i++)
                   {
                       if(p.Isprime(i)==0)
                       {
                           Console.WriteLine( i);
                       }
                   }   */

            /* Calculate c = new Calculate();
             Console.WriteLine(c.Addition(2,5));
             Console.WriteLine(c.Addition(2, 5,12));
             Console.WriteLine(c.Addition(10, 12.00));
             Console.WriteLine(c.Addition(30.78, 15.10)); */

             

            /*   StudentAssign sa=new StudentAssign();
                sa.getId(10);
                Console.WriteLine(sa.displayData());
                Console.WriteLine();*/

                /*Assignment5Aug8 a5=new Assignment5Aug8();
                a5.Intialize();
                Console.WriteLine(a5.Display());  */ 

            /*Assign6Aug8 a8 = new Assign6Aug8();
            a8.insert(1001, "XYZ", 5000.00);
            Console.WriteLine(a8.Display());
            Console.WriteLine("Enter amount deposite:");
            double d_amt=Convert.ToDouble(Console.ReadLine());
            a8.deposite(d_amt);
            Console.WriteLine(a8.Display());
            Console.WriteLine("Enter amount to withdraw");
            double w_amt=Convert.ToDouble(Console.ReadLine());
            string s=a8.WithDraw(w_amt);
            Console.WriteLine(s);
            Console.WriteLine( a8.checkbalance());
            Console.WriteLine(a8.Display());  */


        }

    }
    
}
