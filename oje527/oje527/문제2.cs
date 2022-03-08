using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oje527
{
    class 문제2
    {
        static void Main(string[] args)
        {
            int[] temp_numbers = new int[7];
            Random randNum = new Random();
            
            for (int a = 0; a < 5; a ++)
            {
                for (int i = 0; i < 7; i++)
                {
                    int resultNum = randNum.Next(1, 45);
                    temp_numbers[i] = resultNum;
                }
                Console.WriteLine("중복 제거 전 랜덤 값");
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(temp_numbers[i] + "\t");
                }

                Console.WriteLine();
                Console.WriteLine("중복 제거 후 오름 차순으로 정렬");
                for (int i = 0; i <= temp_numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j <= temp_numbers.Length - 1; j++)
                    {
                        int imsi = 0;
                        if (temp_numbers[i] > temp_numbers[j])
                        {
                            imsi = temp_numbers[j];
                            temp_numbers[j] = temp_numbers[i];
                            temp_numbers[i] = imsi;
                        }
                        else if(temp_numbers[i] == temp_numbers[j])
                        {
                            temp_numbers[j] = randNum.Next(1, 45);
                        }

                        else
                            continue;
                    }
                }
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(temp_numbers[i] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
