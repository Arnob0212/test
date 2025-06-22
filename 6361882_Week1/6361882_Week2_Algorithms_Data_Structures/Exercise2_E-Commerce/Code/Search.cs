using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class Search
    {
        public int LinearSearch(Product[] arr, string key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ProductName.ToLower() == key.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        public int BinarySearch(Product[] arr, string key)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int result = arr[mid].ProductName.CompareTo(key);

                if (result == 0)
                {
                    return mid;
                }
                else if (result < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}
