using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class HW_ConditionalOperater
    {
        static void Main(string[] args)
        {
            int max = 0; int min = 0;
            Console.Write("1 하나의 수 입력 : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("2 하나의 수 입력 : ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.Write("3 하나의 수 입력 : ");
            int c = Convert.ToInt16(Console.ReadLine());

            //if (a > b && a > c) // max = a
            //{
            //    max = a;
            //    if (b > c) min = c;
            //    else min = b;
            //}
            //else if (b > a && b > c) // max = b
            //{
            //    max = b;
            //    if (a > c) min = c;
            //    else min = a;
            //}
            //else if (c > a && c > b) // max = c
            //{
            //    max = c;
            //    if (a > b) min = b;
            //    else min = a;
            //}

            max = (a > b && a > c) ? a : (b > c) ? b : c;
            min = (a < b && a < c) ? a : (b < c) ? b : c;
            Console.WriteLine("The Max = {0}   The Min = {1}", max, min);
        }
    }
}
