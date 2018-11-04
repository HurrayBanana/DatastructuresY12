using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructuresY12
{
    /// <summary>
    /// test methods for Search class
    /// </summary>
    class SearchTests
    {
        internal static void Basic()
        {
            LinearSearchTest();
            SequentialSearchTest();
            BinarySearchTest();
        }

        private static void LinearSearchTest()
        {
            int[] testdata = Data.UnorderedList(15, 100);
            int[] searchlist = Data.UnorderedList(10, 100);

            Data.Show("\nLinear Search test", testdata);
            //search loop
            for (int i = 0; i < searchlist.Length; i++)
            {
                Console.WriteLine("Search for " + searchlist[i] + ":" + Search.Linear(testdata, searchlist[i]));
            }
            Console.WriteLine("End of Linear Search test");
        }

        private static void SequentialSearchTest()
        {
            int[] testdata = Data.OrderedList(15);
            int[] searchlist = Data.UnorderedList(10, 100);

            Data.Show("\nSequential Search test", testdata);
            //search loop
            for (int i = 0; i < searchlist.Length; i++)
            {
                Console.WriteLine("Search for " + searchlist[i] + ":" + Search.Linear(testdata, searchlist[i]));
            }
            Console.WriteLine("End of Linear Sequential test");
        }

        private static void BinarySearchTest()
        {
            int[] testdata = Data.OrderedList(15);
            int[] searchlist = Data.UnorderedList(10, 100);

            Data.Show("\nBinary Search test", testdata);
            //search loop
            for (int i = 0; i < searchlist.Length; i++)
            {
                Console.WriteLine("Search for " + searchlist[i] + ":" + Search.Linear(testdata, searchlist[i]));
            }
            Console.WriteLine("End of Binary Search test");
        }

    }
}
