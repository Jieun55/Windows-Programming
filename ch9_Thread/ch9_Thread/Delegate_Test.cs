using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9_Thread
{
    delegate void SimpleDelegate1();  // 2. 델리게이트 선언 - 매개변수 없음
    delegate void SimpleDelegate2(int i);  // 2. 델리게이트 선언 - 매개변수 있음

    class aaaa   // 델리게이트 선언하면 호출할 메소드 반드시 있어야 한다.
    {
        public void Gun()   // 1. 델리게이트 할 메소드 작성- 반환형  , 매개변수 없음
        {
            Console.WriteLine(" Gun 총알 발사");
        }

        public void Missile(int x)   // 1. 델리게이트 할 메소드 작성-반환형 없고 , 매개변수 있음
        {
            Console.WriteLine("Missile {0} 개 발사  ", x);
        }
    }
    class Delegate_Test
    {
        public static void Main(string[] args)
        {
            aaaa dele = new aaaa();  // 3. aaaa클래스의 인스턴스 dele 생성   aaaa = dele 
            SimpleDelegate1 s1 = new SimpleDelegate1(dele.Gun);
            // 4. s1 델리게이트 인스턴스 생성    //  dele.Gun== aaaa.Gun 

            SimpleDelegate2 s2 = new SimpleDelegate2(dele.Missile);
            // 4. s2 델리게이트 인스턴스 생성        // dele.Missile==aaaa.Missile

            s1();  // 5. 델리게이트 안의 메소드  dele.Gun 호출 
            s2(3);   // 5. 델리게이트 안의 메소드 dele.Missile 호출 - 매개변수 있음

        }
    }
}
