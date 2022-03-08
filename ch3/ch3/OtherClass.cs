using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class OtherClass
    {
        public static int Length_Calc(double a1, double b1)
        {
            int length = Convert.ToInt32((2 * a1) + (2 * b1));
            return length;
        }

        public static double Area_Calc(double a1, double b1)
        {
            double Area = (a1 * b1) / 2;
            return Area;
        }

        public static string Rectangle_Calc(double a1, double b1)
        {
            string c;
            if (a1 == b1)
            {
                c = "정사각형이다.";
            }
            else
            {
                c = "직각사각형이다.";
            }
            return c;
        }
    }
}
