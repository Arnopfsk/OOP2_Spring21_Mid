using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 3, 2, 1, 1, 3, 4, 5, 7, 6 };
            int[] ar = new int[100];
            HashSet<int> xx = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                xx.Add(arr[i]);
                ar[arr[i]]++;
            }
            foreach (int x in xx)
            {
                Console.WriteLine(x + " happend = " + ar[x] + " times");
            }
        }
    }
}
