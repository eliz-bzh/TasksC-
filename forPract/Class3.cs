using System;
using System.Collections.Generic;
using System.Text;

namespace forPract
{
    class GreatComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
