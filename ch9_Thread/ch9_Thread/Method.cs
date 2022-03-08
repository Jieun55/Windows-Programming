using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9_Thread
{
    class mbc
    {
        public void Func1()
        {
            Console.WriteLine("메소드 1 호출함");
        }
        public void Func2(int x)
        {
            Console.WriteLine("메소드 2 값 : " + x);
        }

    }
    class Method
    {
        static void Main()
        {
            mbc sbs = new mbc();
            sbs.Func1();        // 매개변수 없고
            sbs.Func2(100);   // 매개변수 있고 
        }
    }
}
