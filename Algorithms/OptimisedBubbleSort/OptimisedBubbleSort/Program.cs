using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimisedBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int []{ 2, 5, 1, 7, 88, 43, 45, 12, 34, 8, 22, 42, 90  };
            Boolean swapMade = true;
            int numComparisons = unsortedArray.Length;
            int temp;

            do
            {
                swapMade = false;

                for (int i = 0; i < numComparisons - 1; i++)
                {
                    if (unsortedArray[i] > unsortedArray[i + 1])
                    {
                        swapMade = true;
                        temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i + 1];
                        unsortedArray[i + 1] = temp;
                    }
                }
            } while (swapMade == true);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine(unsortedArray[i]);
            }
            Console.ReadKey();
              
        }
    }
}
