using System;

namespace 가위바위보
{
    public class RSP
    {
        int man_su = 0;int cnt = 0; int ga = 0; int ba = 0; int bo = 0;
        int my_w = 0; int my_l = 0; int my_d = 0;

        public static void my_w_l_d(ref int my_w, ref int my_l, ref int my_d, string result)
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

        public static void computer_su(ref int ga, ref int ba, ref int bo, int com_su) //컴퓨터가 낸 수 증가하기
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

        public static string check_W_L(int man_su, int com_su) // 가위바위보 결과 리턴
        {
            string result;
            if (man_su == com_su)
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
                if (com_su == 1)
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
