using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Movie
    {
        private int mid;
        private string mname;
        private int tprice;

        private int nooftickets = 15;
        private int availble;
        private int user_tickets;
        
        private string type;
        private int totalcost=0;
           
        public Movie(int mid, string mname, int tprice, int nooftickets)
        {   
            this.mid = mid;
            this.mname = mname;
            this.tprice = tprice;
            this.nooftickets= nooftickets;

        }
        public void Available_Tickets()
        {
            Console.WriteLine("enter number of tickets you want");
            user_tickets = Convert.ToInt32(Console.ReadLine());

            if (user_tickets<nooftickets)
            {
                availble = nooftickets - user_tickets;
                Console.WriteLine("Available Tickets: " + availble);
                this.PriceCal();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void PriceCal()
        {

            Console.WriteLine("1.Silver");
            Console.WriteLine("2.Gold");
            Console.WriteLine("3.Platinum");
           
            Console.WriteLine("enter your choice");
            int choice=Convert.ToInt32(Console.ReadLine());
            

            switch (choice)
            {
                case 1:
                    type = "siliver";
                    tprice = 100;
                    break;
                case 2:
                    type = "gold";
                    tprice = 200;
                    break;
                case 3:
                    type = "Platinum";
                    tprice = 300;
                    break;
                default:
                    break;
                    
            }
            totalcost = user_tickets * tprice;
            Console.WriteLine("Total cost"+totalcost);

        }
        
        public string Display()
            {
                return $"Movie Id: {mid}, Movie Name: {mname},  Number Of Tickets: {nooftickets}, TotalCost: {totalcost}";
            }
        
    }
}
