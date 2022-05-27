using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2Reverse
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void Reverse(ref string str)
        {
            string sRev = "";
            for (int k = str.Length - 1; k >= 0; k--)
            {
                sRev = sRev + str[k];
            }
            str = sRev;
        }
    }
}
