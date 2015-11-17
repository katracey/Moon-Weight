using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150914_MoonWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight?");
            string earthWeight = Console.ReadLine();
            double moonWeight = int.Parse(earthWeight) * .17;
            Console.WriteLine("Your moon weight is " + moonWeight);

        }
    }
}
