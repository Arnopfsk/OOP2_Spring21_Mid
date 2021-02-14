using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                arr[i] = arr2[i];
            }
            Console.WriteLine("copying values : ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
