using System;
using System.Windows.Forms;
using 가위바위보;

namespace oje_가위바위보
{
    public partial class oje_가위바위보 : Form
    {
        public oje_가위바위보()
        {
            InitializeComponent();
        }

        bool result_view; // 결과 보기 플래그
        int User_count = 0, Com_count = 0, Draw_count = 0;
        // 내가 승.            컴 승         비김 수
        int User_S = 0, User_R, User_P = 0; // 나의 가위 바위 보 수
        int Com_S = 0, Com_R, Com_P = 0; // 컴의 가위 바위 보 수

        private void Change()
        {
            lb_Me_Score.Text = $"내가 이긴 횟수 : {User_count}";
            lb_Com_Score.Text = $"컴퓨터가 이긴 횟수 : {Com_count}";
            lb_Draw_Score.Text = $"서로 비긴 횟수 : {Draw_count}";
            lb_Total_Count.Text = $"총 {User_count + Com_count + Draw_count}번의 게임을 진행하였습니다";
            lb_Me_S.Text = $"가위 횟수 : {User_S}";
            lb_Me_R.Text = $"바위 횟수 : {User_R}";
            lb_Me_P.Text = $"보 횟수 : {User_P}";
            lb_Com_S.Text = $"가위 횟수 : {Com_S}";
            lb_Com_R.Text = $"바위 횟수 : {Com_R}";
            lb_Com_P.Text = $"보 횟수 : {Com_P}";
        }

        private void btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();
        }

        private void Timer_View_Result_Tick(object sender, EventArgs e) // 결과창 폈다 접었다
        {
            int size = 20;
            if (!result_view)
            {
                if (Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기 ◀";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기 ▶";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width -= size;
                }
            }
        }  

        private void button1_Click(object sender, EventArgs e) // 가위 클릭 시
        {
            Random Number = new Random();
            int com_num = Number.Next(1, 4);
            int my_num = 1; // 내가 가위니까 1번
            User_S = User_S + 1;
            pictureBox2.ImageLocation = "Images/gawei.jpg";

            if (com_num == 1)
            {
                pictureBox1.ImageLocation = "Images/gawei.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 비김
                Draw_count++;
            }
            else if (com_num == 2)
            {
                pictureBox1.ImageLocation = "Images/bawei.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num);  // 내가 짐
                Com_count++;
            }
            else
            {
                pictureBox1.ImageLocation = "Images/bo.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 내가 이김
                User_count++;
            }
            RSP.computer_su(ref Com_S, ref Com_R, ref Com_P, com_num);
            Change();
        }

        private void button2_Click(object sender, EventArgs e) // 바위 클릭 시
        {
            Random Number = new Random();
            int com_num = Number.Next(1, 4);
            int my_num = 2; // 바위니까 2번
            User_R = User_R + 1;
            pictureBox2.ImageLocation = "Images/bawei.jpg";
            if (com_num == 1)
            {
                pictureBox1.ImageLocation = "Images/gawei.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 내가 이김
                User_count++;
            }
            else if (com_num == 2)
            {
                pictureBox1.ImageLocation = "Images/bawei.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 비김
                Draw_count++;
            }
            else
            {
                pictureBox1.ImageLocation = "Images/bo.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 내가 짐
                Com_count++;
            }
            RSP.computer_su(ref Com_S, ref Com_R, ref Com_P, com_num);
            Change();
        }

        private void button3_Click(object sender, EventArgs e) // 보 클릭 시
        {
            Random Number = new Random();
            int com_num = Number.Next(1, 4);
            int my_num = 3; // 보니까 3번
            User_P = User_P + 1;
            pictureBox2.ImageLocation = "Images/bo.jpg";
            if (com_num == 1)
            {
                pictureBox1.ImageLocation = "Images/gawei.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 내가 짐
                Com_count++;
            }
            else if (com_num == 2)
            {
                pictureBox1.ImageLocation = "Images/bawei.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 내가 이김
                User_count++;
            }
            else
            {
                pictureBox1.ImageLocation = "Images/bo.jpg";
                Result.Text = RSP.check_W_L(my_num, com_num); // 비김
                Draw_count++;
            }
            RSP.computer_su(ref Com_S, ref Com_R, ref Com_P, com_num);
            Change();
        }
    }
}
