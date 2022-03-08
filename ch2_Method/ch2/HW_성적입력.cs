using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class HW_성적입력
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.Write("학번 입력 ");
            int hakbun = Convert.ToInt16(Console.ReadLine());
                if (hakbun == -999)
                {
                    Console.WriteLine("성적처리 끝");
                    break;
                }
            Console.Write("이름 입력 ");
            string name = Console.ReadLine();
            Console.Write("국어 입력 ");
            int kor = Convert.ToInt16(Console.ReadLine());
                while (kor > 100 || kor < 0)
                {
                    Console.Write("범위 초과됨, 국어점수 다시 입력 ");
                    kor = Convert.ToInt16(Console.ReadLine());
                }
            Console.Write("영어 입력 ");
            int eng = Convert.ToInt16(Console.ReadLine());
                while (eng > 100 || eng < 0)
                {
                    Console.Write("범위 초과됨, 영어점수 다시 입력 ");
                    eng = Convert.ToInt16(Console.ReadLine());
                }
                Console.Write("수학 입력 ");
            int mat = Convert.ToInt16(Console.ReadLine());
                while (mat > 100 || mat < 0)
                {
                    Console.Write("범위 초과됨, 수학점수 다시 입력 ");
                    mat = Convert.ToInt16(Console.ReadLine());
                }

            int tot = Sungjuk.Total(kor, eng, mat);
            float aver = (float) tot / 3;

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6:F2}", hakbun, name, kor, eng, mat, tot, aver);
            Console.WriteLine();

            }
        }
    }

    public class Sungjuk
    {
        public static int Total(int kor, int eng, int mat)
        {
            int tot = kor + eng + mat;
            return tot;
        }
    }
}
