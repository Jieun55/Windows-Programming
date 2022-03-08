using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Method_Sample
    {
        static void Main(string[] args)
        {
            // 절차 지향 방식으로 구성
            Console.Write("사각형의 가로의 길이를 입력하세요 : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("사각형의 세로의 길이를 입력하세요 : ");
            double b = Convert.ToInt32(Console.ReadLine());

            int length = OtherClass.Length_Calc(a, b);
            Console.WriteLine("사각형의 둘레의 길이는 {0} 이고 ",length);

            double Area = OtherClass.Area_Calc(a, b);
            Console.WriteLine("사각형의 면적의 반은 {0} 이고 ", Area);

            string c = OtherClass.Rectangle_Calc(a, b);
            Console.WriteLine(" {0} ", c);
        }

        //public static int Length_Calc(double a1, double b1)
        //{
        //    int length = Convert.ToInt32((2 * a1) + (2 * b1));
        //    return length;
        //}

        //public static double Area_Calc(double a1, double b1)
        //{
        //    double Area = (a1 * b1) / 2;
        //    return Area;
        //}

        //public static string Rectangle_Calc(double a1, double b1)
        //{
        //    string c;
        //    if (a1 == b1)
        //    {
        //        c = "정사각형이다.";
        //    }
        //    else
        //    {
        //        c = "직각사각형이다.";
        //    }
        //    return c;
        //}
    }
}
