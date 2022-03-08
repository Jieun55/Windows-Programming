using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class HW210905_CombineTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("하나의 수 s1 입력 : ");
            int s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("하나의 수 s2 입력 : ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sum = s1 + s2;

            Console.WriteLine("{0}과 {1}의 합은 = {2}", s1, s2, sum);
        }
    }
}
