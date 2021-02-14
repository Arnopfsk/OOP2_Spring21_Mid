using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unique
{
    class Program
    {
        static void Main(string[] args)
        {
            int unique;

            int[] arr4 = new int[] { 1, 1, 3, 4, 5, 5, 7, 8, 5, 6 };
            Console.Write("elements : ");
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Unique elements : ");
            for (int i = 0; i < arr4.Length; i++)
            {
                unique = 0;

                for (int j = 0; j < i - 1; j++)
                {

                    if (arr4[i] == arr4[j])
                    {
                        unique++;
                    }
                }

                for (int k = i + 1; k < arr4.Length; k++)
                {
                    if (arr4[i] == arr4[k])
                    {
                        unique++;
                    }

                    if (arr4[i] == arr4[i + 1])
                    {
                        i++;
                    }
                }


                if (unique == 0)
                {

                    Console.Write(arr4[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
