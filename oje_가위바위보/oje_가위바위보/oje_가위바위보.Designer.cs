
namespace oje_가위바위보
{
    partial class oje_가위바위보
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer_View_Result = new System.Windows.Forms.Timer(this.components);
            this.btn_View_Result = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Com_P = new System.Windows.Forms.Label();
            this.lb_Com_R = new System.Windows.Forms.Label();
            this.lb_Com_S = new System.Windows.Forms.Label();
            this.lb_Me_P = new System.Windows.Forms.Label();
            this.lb_Me_R = new System.Windows.Forms.Label();
            this.lb_Me_S = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Total_Count = new System.Windows.Forms.Label();
            this.lb_Draw_Score = new System.Windows.Forms.Label();
            this.lb_Com_Score = new System.Windows.Forms.Label();
            this.lb_Me_Score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "컴";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "나";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("굴림", 20F);
            this.Result.ForeColor = System.Drawing.Color.Blue;
            this.Result.Location = new System.Drawing.Point(35, 218);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(66, 27);
            this.Result.TabIndex = 7;
            this.Result.Text = "결과";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 20F);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = global::oje_가위바위보.Properties.Resources.bo;
            this.button3.Location = new System.Drawing.Point(246, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 92);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 20F);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = global::oje_가위바위보.Properties.Resources.bawei;
            this.button2.Location = new System.Drawing.Point(130, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 92);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 20F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::oje_가위바위보.Properties.Resources.gawei;
            this.button1.Location = new System.Drawing.Point(12, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 92);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(130, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 77);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Timer_View_Result
            // 
            this.Timer_View_Result.Tick += new System.EventHandler(this.Timer_View_Result_Tick);
            // 
            // btn_View_Result
            // 
            this.btn_View_Result.Location = new System.Drawing.Point(256, 218);
            this.btn_View_Result.Name = "btn_View_Result";
            this.btn_View_Result.Size = new System.Drawing.Size(86, 23);
            this.btn_View_Result.TabIndex = 10;
            this.btn_View_Result.Text = "결과보기";
            this.btn_View_Result.UseVisualStyleBackColor = true;
            this.btn_View_Result.Click += new System.EventHandler(this.btn_View_Result_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_Com_P);
            this.groupBox1.Controls.Add(this.lb_Com_R);
            this.groupBox1.Controls.Add(this.lb_Com_S);
            this.groupBox1.Controls.Add(this.lb_Me_P);
            this.groupBox1.Controls.Add(this.lb_Me_R);
            this.groupBox1.Controls.Add(this.lb_Me_S);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_Total_Count);
            this.groupBox1.Controls.Add(this.lb_Draw_Score);
            this.groupBox1.Controls.Add(this.lb_Com_Score);
            this.groupBox1.Controls.Add(this.lb_Me_Score);
            this.groupBox1.Location = new System.Drawing.Point(357, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 337);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "게임결과";
            // 
            // lb_Com_P
            // 
            this.lb_Com_P.AutoSize = true;
            this.lb_Com_P.Location = new System.Drawing.Point(159, 281);
            this.lb_Com_P.Name = "lb_Com_P";
            this.lb_Com_P.Size = new System.Drawing.Size(33, 12);
            this.lb_Com_P.TabIndex = 11;
            this.lb_Com_P.Text = "보 수";
            // 
            // lb_Com_R
            // 
            this.lb_Com_R.AutoSize = true;
            this.lb_Com_R.Location = new System.Drawing.Point(159, 248);
            this.lb_Com_R.Name = "lb_Com_R";
            this.lb_Com_R.Size = new System.Drawing.Size(45, 12);
            this.lb_Com_R.TabIndex = 10;
            this.lb_Com_R.Text = "바위 수";
            // 
            // lb_Com_S
            // 
            this.lb_Com_S.AutoSize = true;
            this.lb_Com_S.Location = new System.Drawing.Point(159, 217);
            this.lb_Com_S.Name = "lb_Com_S";
            this.lb_Com_S.Size = new System.Drawing.Size(45, 12);
            this.lb_Com_S.TabIndex = 9;
            this.lb_Com_S.Text = "가위 수";
            // 
            // lb_Me_P
            // 
            this.lb_Me_P.AutoSize = true;
            this.lb_Me_P.Location = new System.Drawing.Point(19, 281);
            this.lb_Me_P.Name = "lb_Me_P";
            this.lb_Me_P.Size = new System.Drawing.Size(33, 12);
            this.lb_Me_P.TabIndex = 8;
            this.lb_Me_P.Text = "보 수";
            // 
            // lb_Me_R
            // 
            this.lb_Me_R.AutoSize = true;
            this.lb_Me_R.Location = new System.Drawing.Point(19, 248);
            this.lb_Me_R.Name = "lb_Me_R";
            this.lb_Me_R.Size = new System.Drawing.Size(45, 12);
            this.lb_Me_R.TabIndex = 7;
            this.lb_Me_R.Text = "바위 수";
            // 
            // lb_Me_S
            // 
            this.lb_Me_S.AutoSize = true;
            this.lb_Me_S.Location = new System.Drawing.Point(19, 217);
            this.lb_Me_S.Name = "lb_Me_S";
            this.lb_Me_S.Size = new System.Drawing.Size(45, 12);
            this.lb_Me_S.TabIndex = 6;
            this.lb_Me_S.Text = "가위 수";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "컴의";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "나의";
            // 
            // lb_Total_Count
            // 
            this.lb_Total_Count.AutoSize = true;
            this.lb_Total_Count.Location = new System.Drawing.Point(19, 115);
            this.lb_Total_Count.Name = "lb_Total_Count";
            this.lb_Total_Count.Size = new System.Drawing.Size(73, 12);
            this.lb_Total_Count.TabIndex = 3;
            this.lb_Total_Count.Text = "총 게임 횟수";
            // 
            // lb_Draw_Score
            // 
            this.lb_Draw_Score.AutoSize = true;
            this.lb_Draw_Score.Location = new System.Drawing.Point(19, 83);
            this.lb_Draw_Score.Name = "lb_Draw_Score";
            this.lb_Draw_Score.Size = new System.Drawing.Size(57, 12);
            this.lb_Draw_Score.TabIndex = 2;
            this.lb_Draw_Score.Text = "비긴 횟수";
            // 
            // lb_Com_Score
            // 
            this.lb_Com_Score.AutoSize = true;
            this.lb_Com_Score.Location = new System.Drawing.Point(19, 51);
            this.lb_Com_Score.Name = "lb_Com_Score";
            this.lb_Com_Score.Size = new System.Drawing.Size(85, 12);
            this.lb_Com_Score.TabIndex = 1;
            this.lb_Com_Score.Text = "컴이 이긴 횟수";
            // 
            // lb_Me_Score
            // 
            this.lb_Me_Score.AutoSize = true;
            this.lb_Me_Score.Location = new System.Drawing.Point(19, 20);
            this.lb_Me_Score.Name = "lb_Me_Score";
            this.lb_Me_Score.Size = new System.Drawing.Size(85, 12);
            this.lb_Me_Score.TabIndex = 0;
            this.lb_Me_Score.Text = "내가 이긴 횟수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "--------------------------------------";
            // 
            // oje_가위바위보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_View_Result);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "oje_가위바위보";
            this.Text = "오지은_가위바위보";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer Timer_View_Result;
        private System.Windows.Forms.Button btn_View_Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Com_P;
        private System.Windows.Forms.Label lb_Com_R;
        private System.Windows.Forms.Label lb_Com_S;
        private System.Windows.Forms.Label lb_Me_P;
        private System.Windows.Forms.Label lb_Me_R;
        private System.Windows.Forms.Label lb_Me_S;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Total_Count;
        private System.Windows.Forms.Label lb_Draw_Score;
        private System.Windows.Forms.Label lb_Com_Score;
        private System.Windows.Forms.Label lb_Me_Score;
        private System.Windows.Forms.Label label3;
    }
}

