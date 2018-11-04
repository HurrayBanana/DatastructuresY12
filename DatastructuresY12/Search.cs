using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructuresY12
{
    /// <summary>
    /// a batch of static search methods 
    /// (static means you don't need an instance of the class to execute the methods)
    /// use Search.Linear() to call
    /// </summary>
    class Search
    {
        /// <summary>
        /// can search unsorted data
        /// </summary>
        /// <param name="data">list to search</param>
        /// <param name="item">item to search for</param>
        /// <returns>index of item or -1 if not found</returns>
        public static int Linear(int[] data, int item)
        {
            int i = 0;
            while (i < data.Length)
            {
                if (data[i] == item)
                    return i;
                i++;
            }
            return -1;
        }
        /// <summary>
        /// linear searches ordered data but stops if numbers become larger than search item
        /// </summary>
        /// <param name="data">list to search</param>
        /// <param name="item">item to search for</param>
        /// <returns>index of item or -1 if not found</returns>
        public int Sequential(int[] data, int item)
        {
            int i = 0;
            while (i < data.Length && data[i] < item)
            {
                if (data[i] == item)
                    return i;
            }
            return -1;
        }
        /// <summary>Searches an ordered list using divide and conquer methodology</summary>
        /// <param name="data">list to search</param>
        /// <param name="item">item to search for</param>
        /// <returns>index of item or -1 if not found</returns>
        public int Binary(int[] data, int item)
        {
            int m;
            int l = 0;
            int r = data.Length - 1;
            while (l <= r)
            {
                m = (l + r) / 2;
                if (data[m] == item)
                    return m;
                else if (data[m] > item)
                    r = m - 1;
                else
                    l = m + 1;
            }

            return -1;
        }
    }
}
