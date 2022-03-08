using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1 //네임 스페이스 이름
{
    class Test //클래스 이름
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 입력 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine();
            Console.Write("숫자 입력 : ");
            int a = Console.Read();
            Console.WriteLine(a);
            Console.WriteLine();
        }
    }
}
