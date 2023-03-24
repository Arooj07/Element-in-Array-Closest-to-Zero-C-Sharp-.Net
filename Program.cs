using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,-1,2,-3,4};

            Array.Sort(arr);
            
            int y = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    y = arr[i];

                    Console.WriteLine("Closest to Zero is: " + y);
                    break;

                }
            }

        }

    }
}
