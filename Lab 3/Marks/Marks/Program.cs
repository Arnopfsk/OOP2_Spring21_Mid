using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            double phy = 50.5, che = 60.6, bio = 70.7, math = 80.8, com = 90.9;
            double sum = phy + che + bio + math + com;
            sum /= 5.0;
            Console.WriteLine("per" + sum + "%");
            if (sum < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (sum >= 50 && sum < 75)
            {
                Console.WriteLine("C+");
            }
            else if (sum >= 75 && sum <= 79)
            {
                Console.WriteLine("B");
            }
            else if (sum >= 80 && sum < 85)
            {
                Console.WriteLine("B+");
            }
            else if (sum >= 85 && sum < 89)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("A+");
            }
        }
    }
}
