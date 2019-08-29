using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStringUsingLength
{
    public class StringSort : IComparer<string>
    {
        public StringSort()
        {

        }
        public int Compare(string x, string y)
        {
            if (x.Length > y.Length)
                return 1;
            else if (x.Length < y.Length)
                return -1;
            else
                return 0;
        }
    }
}
