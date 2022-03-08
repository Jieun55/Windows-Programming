using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oje527
{
    public class Bills
    {
        private int _kwh;
        private double _tax;

        public int Kwh
        {
            get { return _kwh; }
            set { _kwh = value; }
        }

        public double Tax(int _kwh)
        {
            _tax = 0;
            if (_kwh <= 100)
            {
                _tax += 410;
                _tax += _kwh * 60.7;
            }
            else if (_kwh > 100 && _kwh <= 200)
            {
                _tax += 910;
                _tax += 100 * 60.7;
                _tax += (_kwh-100) * 125.9;
            }
            else if (_kwh > 200 && _kwh <= 300)
            {
                _tax += 1600;
                _tax += 100 * 60.7;
                _tax += 100* 125.9;
                _tax += (_kwh - 200) * 187.9;
            }
            else if (_kwh > 300 && _kwh <= 400)
            {
                _tax += 3850;
                _tax += 100 * 60.7;
                _tax += 100 * 125.9;
                _tax += 100 * 187.9;
                _tax += (_kwh - 300) * 280.6;
            }
            else if (_kwh > 400 && _kwh <= 500)
            {
                _tax += 7300;
                _tax += 100 * 60.7;
                _tax += 100 * 125.9;
                _tax += 100 * 187.9;
                _tax += 100 * 280.6;
                _tax += (_kwh - 400) * 417.7;
            }
            else
            {
                _tax += 12940;
                _tax += 100 * 60.7;
                _tax += 100 * 125.9;
                _tax += 100 * 187.9;
                _tax += 100 * 280.6;
                _tax += 100 * 417.7;
                _tax += (_kwh - 500) * 709.5;
            }
            return _tax;
        }
    }
    class 문제1
    {
        static void Main()
        {
            Bills a = new Bills();
            Console.Write("전기 사용량 입력 단위(kwh) : ");
            a.Kwh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("========================================");
            Console.WriteLine("사용 전력량 \t 전기 요금");
            Print(a.Kwh, a.Tax(a.Kwh));
        }
        private static void Print(int kwh, double tax)
        {
            Console.WriteLine("{0} Kw/h \t {1} 원", kwh, tax);
        }
    }
}
