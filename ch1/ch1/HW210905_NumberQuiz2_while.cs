using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class HW210905_NumberQuiz2_while
    {
        static void Main(string[] args)
        {
            Random su = new Random();
            int fix_su = su.Next(1, 100);
            int i = 0;
            while (true)
            {
                Console.Write("1에서 100 사이, 상대가 생각하고 있는 수를 입력하세요 : ");
                int input_su = Convert.ToInt16(Console.ReadLine());
                if (fix_su < input_su)
                    Console.WriteLine("너무 커");
                else if (fix_su > input_su)
                    Console.WriteLine("너무 작아");
                else
                {
                    Console.WriteLine("정답");
                    break;
                }
                i += 1;
            }
            Console.WriteLine("랜덤 값은 {0}", fix_su);
            Console.WriteLine("시도 횟수 = {0} ", i);
        }
    }
}
