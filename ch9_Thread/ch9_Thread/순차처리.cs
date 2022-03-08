using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9_Thread
{
    class 순차처리
    {
        static void FuncA()  // 일반 메소드
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("A : Count  A= " + i);
        }

        static void FuncB()   // 일반 메소드
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("B : Count  B= " + i);
        }

        static void Main(string[] args)
        {
            FuncA(); FuncB();
        }  // 일반  메소드 호출
    }
}
