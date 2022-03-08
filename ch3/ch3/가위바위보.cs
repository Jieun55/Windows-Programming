using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class 가위바위보
    {
        static void Main(string[] args)
        {
            int man_su = 0; int cnt = 0; int ga = 0; int ba = 0; int bo = 0;
            int my_w = 0; int my_l = 0; int my_d = 0;
            while(true)
            {
                Random Number = new Random();
                int com_su = Number.Next(1, 4);
                Console.Write("1, 2, 3 중 하나의 수 입력 : "); // 1: 가위, 2: 바위, 3: 보
                man_su = Convert.ToInt16(Console.ReadLine()); // 수 입력 받음
                if (man_su == -1) break; cnt++;
                string result = check_W_L(man_su, com_su);      // 게임 실행 결과 - 메소드 호출
                Console.WriteLine(result);
                Console.WriteLine("컴의 선택은 {0}", com_su);
                Console.WriteLine("-------------------------------------");
                computer_su(ref ga, ref ba, ref bo, com_su);    // 컴퓨터가 제시한 수 카운트 - 메소드 호출
                my_w_l_d(ref my_w, ref my_l, ref my_d, result); // 내가 승, 패, 비김 횟수 - 메소드 호출
            }
            Console.WriteLine();
            Console.WriteLine("총 게임 횟수 {0} 번", cnt);
            Console.WriteLine("컴의 가위 = {0}, 컴의 바위 = {1}, 컴의 보 = {2}", ga, ba, bo);
            Console.WriteLine("서로비김 = {0}, 내가 승 = {1}, 내가 패 = {2}", my_d, my_w, my_l);
        }
        private static void my_w_l_d(ref int my_w, ref int my_l, ref int my_d, string result)
        {
            if (result == "내가 이김")
            {
                my_w += 1;
            }
            else if (result == "컴이 이김")
            {
                my_l += 1;
            }
            else
            {
                my_d += 1;
            }
        }
        private static void computer_su(ref int ga, ref int ba, ref int bo, int com_su)
        {
            if (com_su == 1)
            {
                ga += 1;
            }
            else if (com_su == 2)
            {
                ba += 1;
            }
            else
            {
                bo += 1;
            }
        }
        private static string check_W_L(int man_su, int com_su)
        {
            string result;
            if (man_su == com_su )
            {
                result = "서로 비김";
            }
            else if (man_su == 1)
            {
                if (com_su == 2)
                {
                    result = "컴이 이김";
                }
                else // 컴퓨터가 3일때
                {
                    result = "내가 이김";
                }
            }

            else if (man_su == 2)
            {
                if (com_su == 1)
                {
                    result = "내가 이김";
                }
                else // 컴퓨터가 3일때
                {
                    result = "컴이 이김";
                }
            }

            else
            {
                if(com_su == 1)
                {
                    result = "컴이 이김";
                }
                else // 컴퓨터가 2일때
                {
                    result = "내가 이김";
                }
            }
            return result;
        }
    }
}
