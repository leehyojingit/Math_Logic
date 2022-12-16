namespace Math_Logic
{
    partial class Form1
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
            this.tb_question = new System.Windows.Forms.TextBox();
            this.p_control = new System.Windows.Forms.Panel();
            this.cb_customnum = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_b_max = new System.Windows.Forms.TextBox();
            this.tb_b_min = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_f_max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_f_min = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_one = new System.Windows.Forms.RadioButton();
            this.rb_two = new System.Windows.Forms.RadioButton();
            this.rb_three = new System.Windows.Forms.RadioButton();
            this.rb_four = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ng_num = new System.Windows.Forms.TextBox();
            this.tb_cor_num = new System.Windows.Forms.TextBox();
            this.cb_math = new System.Windows.Forms.ComboBox();
            this.tb_start = new System.Windows.Forms.Button();
            this.tb_ans = new System.Windows.Forms.TextBox();
            this.bt_ans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_timeout = new System.Windows.Forms.Label();
            this.pgbar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.p_image = new System.Windows.Forms.Panel();
            this.p_control.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_question
            // 
            this.tb_question.BackColor = System.Drawing.Color.Green;
            this.tb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_question.ForeColor = System.Drawing.Color.White;
            this.tb_question.Location = new System.Drawing.Point(5, 13);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(1865, 613);
            this.tb_question.TabIndex = 0;
            this.tb_question.TabStop = false;
            this.tb_question.Text = "서우야! 공부하자!";
            this.tb_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_question.WordWrap = false;
            // 
            // p_control
            // 
            this.p_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.p_control.Controls.Add(this.cb_customnum);
            this.p_control.Controls.Add(this.label4);
            this.p_control.Controls.Add(this.panel3);
            this.p_control.Controls.Add(this.panel2);
            this.p_control.Controls.Add(this.label3);
            this.p_control.Controls.Add(this.label2);
            this.p_control.Controls.Add(this.tb_ng_num);
            this.p_control.Controls.Add(this.tb_cor_num);
            this.p_control.Controls.Add(this.cb_math);
            this.p_control.Controls.Add(this.tb_start);
            this.p_control.Location = new System.Drawing.Point(12, 786);
            this.p_control.Name = "p_control";
            this.p_control.Size = new System.Drawing.Size(882, 195);
            this.p_control.TabIndex = 1;
            // 
            // cb_customnum
            // 
            this.cb_customnum.AutoSize = true;
            this.cb_customnum.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_customnum.Location = new System.Drawing.Point(7, 52);
            this.cb_customnum.Name = "cb_customnum";
            this.cb_customnum.Size = new System.Drawing.Size(78, 20);
            this.cb_customnum.TabIndex = 17;
            this.cb_customnum.Text = "숫자 지정";
            this.cb_customnum.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "연산 자릿수";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tb_b_max);
            this.panel3.Controls.Add(this.tb_b_min);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tb_f_max);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tb_f_min);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 71);
            this.panel3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "~";
            // 
            // tb_b_max
            // 
            this.tb_b_max.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tb_b_max.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_b_max.Location = new System.Drawing.Point(207, 39);
            this.tb_b_max.Name = "tb_b_max";
            this.tb_b_max.Size = new System.Drawing.Size(100, 21);
            this.tb_b_max.TabIndex = 19;
            // 
            // tb_b_min
            // 
            this.tb_b_min.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tb_b_min.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_b_min.Location = new System.Drawing.Point(80, 39);
            this.tb_b_min.Name = "tb_b_min";
            this.tb_b_min.Size = new System.Drawing.Size(100, 21);
            this.tb_b_min.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "뒤자리";
            // 
            // tb_f_max
            // 
            this.tb_f_max.BackColor = System.Drawing.Color.Khaki;
            this.tb_f_max.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_f_max.Location = new System.Drawing.Point(207, 12);
            this.tb_f_max.Name = "tb_f_max";
            this.tb_f_max.Size = new System.Drawing.Size(100, 21);
            this.tb_f_max.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "~";
            // 
            // tb_f_min
            // 
            this.tb_f_min.BackColor = System.Drawing.Color.Khaki;
            this.tb_f_min.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_f_min.Location = new System.Drawing.Point(80, 12);
            this.tb_f_min.Name = "tb_f_min";
            this.tb_f_min.Size = new System.Drawing.Size(100, 21);
            this.tb_f_min.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "앞자리";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rb_one);
            this.panel2.Controls.Add(this.rb_two);
            this.panel2.Controls.Add(this.rb_three);
            this.panel2.Controls.Add(this.rb_four);
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 42);
            this.panel2.TabIndex = 14;
            // 
            // rb_one
            // 
            this.rb_one.AutoSize = true;
            this.rb_one.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_one.Location = new System.Drawing.Point(12, 17);
            this.rb_one.Name = "rb_one";
            this.rb_one.Size = new System.Drawing.Size(77, 20);
            this.rb_one.TabIndex = 4;
            this.rb_one.TabStop = true;
            this.rb_one.Text = "일의 자리";
            this.rb_one.UseVisualStyleBackColor = true;
            // 
            // rb_two
            // 
            this.rb_two.AutoSize = true;
            this.rb_two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_two.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_two.Location = new System.Drawing.Point(95, 17);
            this.rb_two.Name = "rb_two";
            this.rb_two.Size = new System.Drawing.Size(77, 20);
            this.rb_two.TabIndex = 5;
            this.rb_two.TabStop = true;
            this.rb_two.Text = "십의 자리";
            this.rb_two.UseVisualStyleBackColor = true;
            // 
            // rb_three
            // 
            this.rb_three.AutoSize = true;
            this.rb_three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_three.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_three.Location = new System.Drawing.Point(178, 17);
            this.rb_three.Name = "rb_three";
            this.rb_three.Size = new System.Drawing.Size(77, 20);
            this.rb_three.TabIndex = 6;
            this.rb_three.TabStop = true;
            this.rb_three.Text = "백의 자리";
            this.rb_three.UseVisualStyleBackColor = true;
            // 
            // rb_four
            // 
            this.rb_four.AutoSize = true;
            this.rb_four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_four.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_four.Location = new System.Drawing.Point(261, 17);
            this.rb_four.Name = "rb_four";
            this.rb_four.Size = new System.Drawing.Size(77, 20);
            this.rb_four.TabIndex = 7;
            this.rb_four.TabStop = true;
            this.rb_four.Text = "천의 자리";
            this.rb_four.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "틀린 숫자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "맞춘 숫자";
            // 
            // tb_ng_num
            // 
            this.tb_ng_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tb_ng_num.Enabled = false;
            this.tb_ng_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ng_num.Location = new System.Drawing.Point(523, 88);
            this.tb_ng_num.Name = "tb_ng_num";
            this.tb_ng_num.ReadOnly = true;
            this.tb_ng_num.Size = new System.Drawing.Size(150, 98);
            this.tb_ng_num.TabIndex = 10;
            // 
            // tb_cor_num
            // 
            this.tb_cor_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_cor_num.Enabled = false;
            this.tb_cor_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cor_num.Location = new System.Drawing.Point(367, 88);
            this.tb_cor_num.Name = "tb_cor_num";
            this.tb_cor_num.ReadOnly = true;
            this.tb_cor_num.Size = new System.Drawing.Size(150, 98);
            this.tb_cor_num.TabIndex = 9;
            // 
            // cb_math
            // 
            this.cb_math.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_math.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_math.FormattingEnabled = true;
            this.cb_math.Location = new System.Drawing.Point(183, 3);
            this.cb_math.Name = "cb_math";
            this.cb_math.Size = new System.Drawing.Size(167, 28);
            this.cb_math.TabIndex = 8;
            this.cb_math.Text = "연산방식";
            // 
            // tb_start
            // 
            this.tb_start.BackColor = System.Drawing.Color.Lime;
            this.tb_start.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_start.Location = new System.Drawing.Point(677, 17);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(189, 169);
            this.tb_start.TabIndex = 4;
            this.tb_start.Text = "시작";
            this.tb_start.UseVisualStyleBackColor = false;
            this.tb_start.Click += new System.EventHandler(this.tb_start_Click);
            // 
            // tb_ans
            // 
            this.tb_ans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_ans.BackColor = System.Drawing.SystemColors.Info;
            this.tb_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ans.Location = new System.Drawing.Point(900, 806);
            this.tb_ans.Name = "tb_ans";
            this.tb_ans.Size = new System.Drawing.Size(633, 143);
            this.tb_ans.TabIndex = 2;
            this.tb_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_ans
            // 
            this.bt_ans.Font = new System.Drawing.Font("휴먼모음T", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_ans.Location = new System.Drawing.Point(1539, 786);
            this.bt_ans.Name = "bt_ans";
            this.bt_ans.Size = new System.Drawing.Size(353, 195);
            this.bt_ans.TabIndex = 3;
            this.bt_ans.Text = "정답 맞추기";
            this.bt_ans.UseVisualStyleBackColor = true;
            this.bt_ans.Click += new System.EventHandler(this.bt_ans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "다음 문제를 맞추어 보세요!!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lb_timeout
            // 
            this.lb_timeout.AutoSize = true;
            this.lb_timeout.BackColor = System.Drawing.Color.Green;
            this.lb_timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeout.Location = new System.Drawing.Point(1584, 667);
            this.lb_timeout.Name = "lb_timeout";
            this.lb_timeout.Size = new System.Drawing.Size(252, 76);
            this.lb_timeout.TabIndex = 6;
            this.lb_timeout.Text = "timeout";
            // 
            // pgbar
            // 
            this.pgbar.BackColor = System.Drawing.Color.Fuchsia;
            this.pgbar.Location = new System.Drawing.Point(39, 684);
            this.pgbar.Name = "pgbar";
            this.pgbar.Size = new System.Drawing.Size(1539, 59);
            this.pgbar.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pb2);
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.tb_question);
            this.panel1.Location = new System.Drawing.Point(7, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1873, 638);
            this.panel1.TabIndex = 8;
            // 
            // pb2
            // 
            this.pb2.BackgroundImage = global::Math_Logic.Properties.Resources.dice2;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(1077, 127);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(363, 320);
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImage = global::Math_Logic.Properties.Resources.dice1;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(360, 118);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(363, 320);
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // p_image
            // 
            this.p_image.BackgroundImage = global::Math_Logic.Properties.Resources.black_sw;
            this.p_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_image.Location = new System.Drawing.Point(1680, 12);
            this.p_image.Name = "p_image";
            this.p_image.Size = new System.Drawing.Size(200, 115);
            this.p_image.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Math_Logic.Properties.Resources.bgr1;
            this.ClientSize = new System.Drawing.Size(1890, 1037);
            this.Controls.Add(this.pgbar);
            this.Controls.Add(this.p_image);
            this.Controls.Add(this.lb_timeout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ans);
            this.Controls.Add(this.tb_ans);
            this.Controls.Add(this.p_control);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEE SEO WOO Math_Logic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.p_control.ResumeLayout(false);
            this.p_control.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Panel p_control;
        private System.Windows.Forms.TextBox tb_ans;
        private System.Windows.Forms.Button bt_ans;
        private System.Windows.Forms.RadioButton rb_three;
        private System.Windows.Forms.RadioButton rb_two;
        private System.Windows.Forms.RadioButton rb_one;
        private System.Windows.Forms.Button tb_start;
        private System.Windows.Forms.RadioButton rb_four;
        private System.Windows.Forms.TextBox tb_ng_num;
        private System.Windows.Forms.TextBox tb_cor_num;
        private System.Windows.Forms.ComboBox cb_math;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_timeout;
        private System.Windows.Forms.ProgressBar pgbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_image;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.CheckBox cb_customnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_f_max;
        private System.Windows.Forms.TextBox tb_f_min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_b_max;
        private System.Windows.Forms.TextBox tb_b_min;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}

