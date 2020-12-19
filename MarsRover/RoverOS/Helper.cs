using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOS
{
    public static class Helper
    {
        public static int Mod(int k, int n)
        {
            return ((k %= n) < 0) ? k + n : k;
        }
    }
}
