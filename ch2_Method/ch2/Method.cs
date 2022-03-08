using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class Method
    {
        //static void Main(string[] args)
        //{
        //    int a = 2;
        //    int b = 3;
        //    //int tot = a + b;
        //    //Console.WriteLine("a + b = {0}", tot);
        //    Sum(a, b); // 매개변수를 가지고 메소드 호출함
        //}
        //private static void Sum(int c, int d)
        //{
        //    int tot = c + d;
        //    Console.WriteLine("a + b = {0}", tot);
        //    // 앞으로 이렇게 하지 마라. 메소드에서 출력하지 말고
        //    // 결과 값을 메인으로 리턴해 줘라
        //}


        //static void Main(string[] args)  // 리턴값 있음, 같은 클래스 내에서
        //{
        //    int a = 2;  int b = 3;
        //    int hap = Sum(a, b); // 매개변수를 가지고 메소드 호출
        //    Console.WriteLine("a+b={0}", hap); // 여기서 출력함
        //}

        //// 같은 클래스 내에서는 public, private 상관 없음
        //// 반환 값이 있으므로 반환형의 타입 int
        //private static int Sum(int a1, int b1)
        //{
        //    int tot;
        //    tot = a1 + b1;
        //    return tot; // 계산 후에 값을 호출한 곳으로 돌려 줌
        //}

        static void Main(string[] args)
        {
            //// 리턴값 있음
            int a = 12;
            int b = 3;
            int hap = Plus.Sum(a, b);
            Console.WriteLine("a+b={0}", hap);
        }
    }
    //public class Plus
    //{
    //    public static int Sum(int a, int b)
        // private static int Sum(int a, int b)
    //    {
    //        int tot;
    //        tot = a + b;
    //        return tot;
    //    }
    //}
}
