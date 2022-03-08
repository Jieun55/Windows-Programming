using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class HW210905_NumberQuiz1
    {
        static void Main(string[] args)
        {
            int fix_su = 44; int i = 0;
            while(true){
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
            Console.WriteLine("시도 횟수 = {0} ", i);
        }
    }
}
