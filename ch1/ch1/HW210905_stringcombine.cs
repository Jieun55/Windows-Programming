using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class HW_stringcombine
    {
        static void Main(string[] args)
        {
            Console.Write("문자열 s1 입력 : ");
            string s1 = Console.ReadLine();
            Console.Write("문자열 s2 입력 : ");
            string s2 = Console.ReadLine();

            Hap(s1, s2);

        }
        static void Hap(string s1, string s2)
        {
            string hap = s1 + s2;
            Console.WriteLine("s1과 s2의 합은 = " + hap);
        }
    }
}
