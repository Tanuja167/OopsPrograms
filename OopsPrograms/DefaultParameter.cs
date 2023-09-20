using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class DefaultParameter
    {
        static void Main(string[] args)
        {
            Car c = new Car("hundai city", 900000);
            Console.WriteLine(c.Display());
            c.Accept("i10", 700000);
            Console.WriteLine(c.Display());

        }
    }
    public class Car
    {
        private string modelname, companyname;
        private int cost;

        public  Car(string modelname, int cost, string companyname="hundai")
        {
            this.modelname = modelname;
            this.cost = cost;
            this.companyname = companyname;
        }
        public void Accept(string modelname, int cost, string companyname="Hundai")
        {
            this.modelname = modelname;
            this.cost = cost;
            this.companyname = companyname;
        }
        public string Display()
        {
            return $"ModelName: {modelname}, Cost: {cost}, Company: {companyname} ";
        }
       
    }
}
