using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructuresY12
{
    /// <summary>
    /// a group of data item generators and display methods
    /// </summary>
    class Data
    {
        /// <summary>
        /// display an array in a nice format
        /// </summary>
        /// <param name="message"></param>
        /// <param name="testdata"></param>
        public static void Show(string message, int[] testdata)
        {
            //don't display more than 40
            if (testdata.Length > 40)
                return;

            Console.WriteLine(message);

            for (int i = 0; i < testdata.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(testdata[i]);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// will make duplicates
        /// </summary>
        /// <param name="datapoints"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static int[] UnorderedList(int datapoints, int high)
        {
            Random r = new Random();
            int[] data = new int[datapoints];
            for (int i = 0; i < datapoints; i++)
            {
                data[i] = r.Next(1, high);
            }
            return data;
        }

        public static int[] OrderedList(int datapoints)
        {
            Random r = new Random();
            int[] data = new int[datapoints];
            int lastValue = 0;
            int gap = 4;

            for (int i = 0; i < datapoints; i++)
            {
                lastValue = data[i] = r.Next(lastValue + 1, lastValue + gap);
            }
            return data;
        }
    }
}
