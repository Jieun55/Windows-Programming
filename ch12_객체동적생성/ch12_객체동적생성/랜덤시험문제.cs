using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch12_객체동적생성
{
    public partial class 랜덤시험문제 : Form
    {
        #region // 생성할 컨트롤 객체 생성 및 변수 선언
        GroupBox[] GB = new GroupBox[3];                // 그룹 박스 -5문제
        RadioButton[,] Bogi = new RadioButton[3, 4];    // 보기 -5개
        Label lbScore = new Label();                    // 점수 표시 Label
        Button button = new Button();                   // Button 
        int Score = 0;                                  // 점수 변수
        int[] array1 = new int[3] { 3, 4, -1 };         // 문제 랜덤 전 배열
        int[] array2 = new int[4] { -1, -1, -1, -1 };   // 보기 랜덤을 위한 배열
        int[] randarray = new int[3] { -1, -1, -1 };    // 문제를 랜덤으로 섞을 순서
        int[] question = new int[3] { 0, 0, 0 };        // 문제 랜덤 후 배열

        public 랜덤시험문제()
        {
            InitializeComponent();
            string aa = "[문제 ";     // 1]은 소스에서 추가해야 함
            string[,] Question = new string[5, 6]
            {
                {"다음 중 1+1 = ?", "일", "이", "삼", "사", "이" },
                {"인천에 있는 산은 ?", "한라산", "백두산", "계양산", "금강산", "계양산"},
                {"인천 대학은 어느 구에 있나 ?", "송도구", "연수구", "남구", "중구", "연수구"},
                {"다음 중에서 태연이 아닌 것은 ?", "1", "2", "3", "4", "3"},
                {"아래 사진은 누구인가 ?", "아이유", "설현", "태연", "수지", "수지"}
            };
            #endregion

            #region // 점수 표시할 Label 동적으로 생성
            lbScore = new Label();
            this.lbScore.Name = "lbScore";
            this.lbScore.Text = "Score";
            this.lbScore.Size = new Size(90, 30);
            this.lbScore.Location = new System.Drawing.Point(30,770);
            this.Controls.Add(lbScore);
            #endregion 

            #region // 버튼 생성
            this.button.Name = "btnSubmit";
            this.button.Text = "채점하기";
            this.button.Size = new Size(90, 30);
            this.button.AutoSize = true;
            this.button.Location = new System.Drawing.Point(180, 790);
            this.button.Click += new EventHandler(button_Click);
            this.Controls.Add(button);
            #endregion

            #region // 랜덤 문제, 랜덤 보기 생성
            Random random = new Random();
            int rand_q = random.Next(0, 3); // 0~2 랜덤 생성
            array1[2] = rand_q;

            //문제 랜덤으로 섞을 순서
            for (int i = 0; i < randarray.Length; i++)
            {
                while (true)
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
                question[i] = tmp[randarray[i]]; // 랜덤 문제 배열 ex) 4 5 1
            }

            // 보기 랜덤 배열
            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    int rand_o = random.Next(0, 4); // 0~4 랜덤 생성
                    if (array2[0] != rand_o && array2[1] != rand_o && array2[2] != rand_o && array2[3] != rand_o)
                    {
                        array2[i] = rand_o; // array2에 보기 랜덤 배열 순서 넣음 ex) 0 2 3 1
                        break;
                    }
                }
            }
            #endregion

            #region // 문제 랜덤 선택, 보기 랜덤 선택
            for (int n = 0; n < 3; n++) // 문제 수
            {
                int k = question[n]; // 중복되지 않은 문제
                GB[n] = new GroupBox();
                this.GB[n].AutoSize = true;
                this.GB[n].Location = new System.Drawing.Point(10, 10 + (n * 250));
                this.GB[n].Size = new System.Drawing.Size(350, 200);
                this.GB[n].TabIndex = 0;
                this.GB[n].TabStop = false;
                this.GB[n].Text = aa + (n + 1 + "] " + Question[k, 0]);
                this.Controls.Add(GB[n]);
                //문제 생성 끝

                // 보기 생성
                for(int i=0; i<4; i++) // 보기 수
                {
                    int j = array2[i]; // 중복되지 않은 랜덤 보기 순서
                    Bogi[n, i] = new RadioButton();
                    if (k == 0 || k == 1 || k == 2)
                    {
                        this.Bogi[n, i].Location = new System.Drawing.Point(30, 30 + (i * 20));
                        this.Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                        this.Bogi[n, i].Text = Question[k, j + 1];
                    }
                    if (k == 3) // 3번 질문 선택 - 보기(사진)
                    {
                        if(i == 0)
                        {
                            Bogi[n, i].Location = new System.Drawing.Point(30, 30);
                            PictureBox op1 = new PictureBox
                            {
                                Location = new System.Drawing.Point(Bogi[n, i].Left + 20, 30),
                                Image = Properties.Resources.iu,
                                Size = new System.Drawing.Size(70, 70),
                                SizeMode = PictureBoxSizeMode.Zoom
                            };
                            this.Controls.Add(op1); op1.BringToFront();
                        }
                        else if(i == 1)
                        {
                            Bogi[n, i].Location = new System.Drawing.Point(160, 30);
                            PictureBox op2 = new PictureBox
                            {
                                Location = new System.Drawing.Point(Bogi[n, i].Left + 70, 30),
                                Image = Properties.Resources.ty1,
                                Size = new System.Drawing.Size(70, 70),
                                SizeMode = PictureBoxSizeMode.Zoom
                            };
                            this.Controls.Add(op2); op2.BringToFront();
                        }
                        else if (i == 2)
                        {
                            Bogi[n, i].Location = new System.Drawing.Point(30, 120);
                            PictureBox op3 = new PictureBox
                            {
                                Location = new System.Drawing.Point(Bogi[n, i].Left + 20, 120),
                                Image = Properties.Resources.ty4,
                                Size = new System.Drawing.Size(70, 70),
                                SizeMode = PictureBoxSizeMode.Zoom
                            };
                            this.Controls.Add(op3); op3.BringToFront();
                        }
                        else
                        {
                            Bogi[n, i].Location = new System.Drawing.Point(160, 120);
                            PictureBox op4 = new PictureBox
                            {
                                Location = new System.Drawing.Point(Bogi[n, i].Left + 70, 120),
                                Image = Properties.Resources.ty3,
                                Size = new System.Drawing.Size(70, 70),
                                SizeMode = PictureBoxSizeMode.Zoom
                            };
                            this.Controls.Add(op4); op4.BringToFront();
                        }
                        this.Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                        this.Bogi[n, i].Text = Question[k, j + 1];
                    }
                    else if (k == 4) // 5번 질문 선택 - 질문(사진)
                    {
                        this.Bogi[n, i].Location = new System.Drawing.Point(210, 30 + (i * 20));
                        this.Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                        this.Bogi[n, i].Text = Question[k, j + 1];
                        PictureBox quest = new PictureBox
                        {
                            Image = Properties.Resources.suzy,
                            Location = new System.Drawing.Point(30, Bogi[n, i].Top),
                            Size = new System.Drawing.Size(70, 70),
                            SizeMode = PictureBoxSizeMode.Zoom
                        };
                        this.Controls.Add(quest); quest.BringToFront();
                    }
                    if (i == 4)
                        this.Bogi[n, i].Visible = false;
                    this.Controls.Add(Bogi[n, i]);
                    this.GB[n].Controls.Add(this.Bogi[n, i]);
                }
            }
            #endregion
        }

        #region // 채점하기
        void button_Click(object sender, EventArgs e)
        {
            // 버튼 클릭 시 처리해야 할 내용 작성
            Button button = sender as Button;   // 버튼 객체 생성
            for (int i = 0; i < 3; i++)         // 문제수 for 문
            {
                for (int j = 0; j < 4; j++)     // 보기수 for 문
                {
                    if (Bogi[i, j].Checked == true) 
                        if (Bogi[i, j].Text == Bogi[i, 4].Text)
                            Score += 1;
                }
            }
            lbScore.Text = "Score : " + Convert.ToString(Score);
            Score = 0; // 점수 초기화
        }
        #endregion
    }
}