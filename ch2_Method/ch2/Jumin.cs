using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class Jumin
    {
        static void Main(string[] args)
        {
            string jumin = ""; string gubun1 = ""; string this_year = "";
            int year = 0; int month = 0; int day = 0; int gubun = 0; int age = 0; int c_year = 0;

            Console.Write("주민번호 13자리를 입력하세요 : ");
            jumin = Console.ReadLine();

            year = Convert.ToInt16(jumin.Substring(0, 2));
            month = Convert.ToInt16(jumin.Substring(2, 2));
            day = Convert.ToInt16(jumin.Substring(4, 2));
            gubun = Convert.ToInt16(jumin.Substring(6, 1));

            this_year = Convert.ToString(DateTime.Now);             // 시스템 날짜 사용
            c_year = Convert.ToInt32(this_year.Substring(0, 4));    // 시스템 날짜 사용
            year = Calc_Year(year, gubun);                          // 출생년도 계산 - 메소드 호출
            age = Calc_Age(year, gubun, age, c_year);               // 나이 계싼 - 메소드 호출
            gubun1 = Calc_Gubun(gubun, gubun1);                     // 성별 계산 - 메소드 호출

            Console.WriteLine("년도는 : {0}", year);
            Console.WriteLine("월은 : {0}", month);
            Console.WriteLine("일은 : {0}", day);
            Console.WriteLine("올해 나이는 : {0}", age);
            Console.WriteLine("성별은 : {0}", gubun1);
        }

        private static int Calc_Year(int year, int gubun)
        {
            if (gubun == 1 || gubun == 2)
            {
                year = 1900 + year;
            }
            else
                year = 2000 + year;
            return year;
        }
        private static int Calc_Age(int year, int gubun, int age, int c_year)
        {
            age = c_year - year;
            return age;
        }
        private static string Calc_Gubun(int gubun, string gubun1)
        {
            if (gubun == 1 || gubun == 3)
                gubun1 = "남자";
            else
                gubun1 = "여자";
            return gubun1;
        }
    }
}
