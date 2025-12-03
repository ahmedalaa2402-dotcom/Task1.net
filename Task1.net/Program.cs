using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int persmall = 25;
            const int perlarge = 35;
            const double taxrate = .06;
            Console.WriteLine("Enter small carpet :");
            int numSmall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter large carpet :");
            int numLarge = Convert.ToInt32(Console.ReadLine());

            int cost = ((numSmall * persmall) + (numLarge * perlarge));

            double tax = cost * taxrate ;

          double total = cost + tax;
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of persmall: " + numSmall);
            Console.WriteLine("Number of persmall: " + numLarge);
            Console.WriteLine("price per small: " + persmall );
            Console.WriteLine("price per large: " + perlarge);
            Console.WriteLine("cost: "+cost);
Console.WriteLine("tax: "+tax);
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("total: "+total);
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
