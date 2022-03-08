using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class GBB
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("1에서 100 사이, 상대가 생각하고 있는 수를 입력하세요 : ");
                int input_su = Convert.ToInt16(Console.ReadLine());
                int correct = NumIsRight(input_su);
                if (correct == 1) Console.WriteLine("너무 커");
                else if (correct == 2) Console.WriteLine("너무 작아");
                else
                {
                    Console.WriteLine("정답");
                    break;
                }
                i += 1;
            }
            Console.WriteLine("시도 횟수 = {0} ", i);
        }
        private static int NumIsRight(int input_su)
        {
            int fix_su = 44;
            if (fix_su < input_su)
                return 1; //너무 커
            else if (fix_su > input_su)
                return 2; // 너무 작아
            else
                return 3; // 정답
        }
    }
}