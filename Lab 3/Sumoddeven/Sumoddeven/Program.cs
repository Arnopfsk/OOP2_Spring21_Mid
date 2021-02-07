using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumoddeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd = 0, even = 0;
            for (int i = 1; i <= 49; i += 2)
            {
                odd += i;
            }
            for (int i = 2; i <= 50; i += 2)
            {
                even += i;
            }
            Console.WriteLine("Sum of Even Numbers : " + even);
            Console.WriteLine("Sum of odd Numbers : " + odd);
        }
    }
}
