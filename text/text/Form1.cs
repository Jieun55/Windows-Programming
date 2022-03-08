using System;
using System.Windows.Forms;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array1 = new int[3] { 4, 5, -1 };
            int[] array2 = new int[4] { -1, -1, -1, -1 };
            int[] randarray = new int[3] { -1, -1, -1 };
            int[] question = new int[3] { 0, 0, 0 };
            Random random = new Random();

            int rand_q = random.Next(0, 3); // 0~2 랜덤 생성
            array1[2] = rand_q;

            //문제 랜덤으로 섞기
            for (int i = 0; i < randarray.Length; i++)
            {
                while(true)
                {
                    int num = random.Next(0, 3); // 0~2 랜덤 생성
                    if (randarray[0] != num && randarray[1] != num && randarray[2] != num)
                    {
                        randarray[i] = num;
                        break;
                    }
                }
            }
            for (int i = 0; i < randarray.Length; i++)
            {
                int[] tmp = new int[3] { array1[0], array1[1], array1[2] };
                question[i] = tmp[randarray[i]];
            }
            label1.Text = Convert.ToString(question[0]) + Convert.ToString(question[1]) + Convert.ToString(question[2]);
            
            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    int rand_o = random.Next(0, 4); // 0~4 랜덤 생성
                    if (array2[0] != rand_o && array2[1] != rand_o && array2[2] != rand_o && array2[3] != rand_o)
                    {
                        array2[i] = rand_o;
                        break;
                    }
                }
            }
            label2.Text = Convert.ToString(array2[0]) + Convert.ToString(array2[1]) + Convert.ToString(array2[2]) + Convert.ToString(array2[3]);
        }
    }
}