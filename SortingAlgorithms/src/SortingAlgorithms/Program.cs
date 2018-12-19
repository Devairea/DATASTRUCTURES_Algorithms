using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MainController
    {
        public static void Main(string[] args)
        {
            string[] stringList = { "Brian", "Dona", "Anna", "Tom", "Ian", "Bob", "Guy", "Iona", "Jack", "Jim", "Joe", "Mark ", "Nadia" };
            int[] intList = { 25, 19, 11, 80, 1, 45, 60, 24, 82, 12, 30, 20, 76, 34, 10, 47 };
            int[] intList2 = { 25, 19, 11, 80, 1, 45, 60, 24, 82, 12, 30, 20, 76, 34, 10, 47 };

            Logic lg = new Logic();
            Stopwatch rolex = Stopwatch.StartNew();

            //code goes here
            stringList = lg.bubbleSortStrings(stringList);
            rolex.Stop();

            Console.WriteLine("Bubble Sort Time taken: {0}ms", rolex.Elapsed.TotalMilliseconds);

            Stopwatch GTech = Stopwatch.StartNew();

            //code goes here
            intList = lg.shellSortInts(intList);
            GTech.Stop();

            Console.WriteLine("Shell Short Time taken: {0}ms", GTech.Elapsed.TotalMilliseconds);

            Stopwatch Sporty = Stopwatch.StartNew();

            //code goes here
            intList2 = lg.insertionSortInts(intList2);
            Sporty.Stop();

            Console.WriteLine("insertion Sort Time taken: {0}ms", Sporty.Elapsed.TotalMilliseconds);
            

            foreach(string name in stringList)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine("");
            foreach (int value in intList)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("");
            foreach (int value in intList2)
            {
                Console.Write(value + " ");
            }

            Console.ReadKey();
        }
    }
}
