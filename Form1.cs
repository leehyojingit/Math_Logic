using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Math_Logic
{
    public partial class Form1 : Form
    {

        public int number_count = 10;        //0 :1의 자리
        public int math_type = 0;           //0 : 덧셈
        public bool isStart = false;        // 학습 시작여부
        public bool isAns = false;          // 시작 시 정답 제출여부, 다음문제 
        public int cor_num = 0;
        public int wrong_num = 0;
        public int ret_ans = 0;
        public int timeout = 100;
        public string quest_log;
        public int mode = 0; 

        private FileStream fs;
        private StreamWriter sw;
        private String path;

        public Form1()
        {
            InitializeComponent();
            cb_math.Items.Add("덧셈");
            cb_math.Items.Add("뺄셈");
            cb_math.Items.Add("곱셈");
            cb_math.Items.Add("나눗셈");
            cb_math.Items.Add("주사위");

            tb_cor_num.Text = cor_num.ToString();
            tb_ng_num.Text = wrong_num.ToString();

            timer1.Interval = 1000;            
            timer1.Tick += new EventHandler(updateHandler);

            pgbar.Maximum = 100;
            pgbar.Minimum = 0;
            pgbar.Value = 100;

            DateTime dateTime = DateTime.Now;
           // path = System.Environment.CurrentDirectory + "\\"+ dateTime.ToString() + "_Wrong.txt";
            path = dateTime.ToString("yyMMdd_hh_mm_ss")+ "_Wrong.txt";

            pb1.Hide();
            pb2.Hide();
        }
        private void updateHandler(object sender, EventArgs e)
        {            
            if (timeout == 0)
            {
                Console.Beep(880, 400);     //높은도
                wrong_num++;
                tb_ng_num.Text = wrong_num.ToString();
                timeout = 100;
            }
            else timeout--;
            lb_timeout.Text = timeout.ToString();
            pgbar.Value = timeout;
        }
        private void tb_start_Click(object sender, EventArgs e)
        {
            if(!isStart)
            { 
                init_condition();
                tb_start.BackColor = Color.Red;
                tb_start.Text = "종료";
                isStart = true;
                isAns = false;

                if(cb_math.SelectedIndex == 4)
                {
                    tb_question.Hide();
                    pb1.Show();
                    pb2.Show();
                    mode = 1;
                }
                else
                {
                    mode = 0;
                    pb1.Hide();
                    pb2.Hide();
                    tb_question.Show();
                }

                do_question();
                timeout = 100;
                timer1.Start();
                
            }
            else
            {
                tb_start.BackColor = Color.Green;
                tb_start.Text = "시작";
                isStart = false;
                timeout = 100;
                timer1.Stop();
                bt_ans.Text = "정답 맞추기";
            }
        }
        void init_condition()
        {
            if (rb_one.Checked)
            {
                number_count = 10;
            }
            else if(rb_two.Checked)
            {
                number_count = 100;
            }
            else if(rb_three.Checked)
            {
                number_count = 1000;
            }
            else if(rb_four.Checked)
            {
                number_count = 10000; 
            }
            else
            {
                number_count = 10;
            }

        }

        private string path_val1;
        private string path_val2;
        void do_question()
        {

            int val1 = 0;
            int val2 = 0;
            int f_min, f_max, b_min, b_max;
            if (mode==0)
            { 
                Random rand = new Random();
                if(cb_customnum.Checked)
                {
                    try
                    {
                        f_min = Convert.ToInt32(tb_f_min.Text);
                        f_max = Convert.ToInt32(tb_f_max.Text);
                        b_min = Convert.ToInt32(tb_b_min.Text);
                        b_max = Convert.ToInt32(tb_b_max.Text);
                        val1 = rand.Next(f_min, f_max+1);
                        val2 = rand.Next(b_min, b_max+1);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                   
                   
                }
                else
                {
                    val1 = rand.Next((number_count / 10), number_count);
                    val2 = rand.Next((number_count / 10), number_count);
                }
                 

                switch(cb_math.SelectedIndex)
                { 
                    case 0:
                        tb_question.Text = val1.ToString() + " + " + val2.ToString();
                    
                        ret_ans = val1 + val2;
                        break;
                    case 1:
                        tb_question.Text = val1.ToString() + " - " + val2.ToString();
                        ret_ans = val1 - val2;
                        break;
                    case 2:
                        tb_question.Text = val1.ToString() + " x " + val2.ToString();
                        ret_ans = val1 * val2;
                        break;
                    case 3:
                        tb_question.Text = val1.ToString() + " % " + val2.ToString();
                        ret_ans = val1 / val2;
                        break;
                    default :
                        tb_question.Text = val1.ToString() + " + " + val2.ToString();
                        ret_ans = val1 + val2;
                        break;
                }
                quest_log = tb_question.Text;
            }

            else if(mode==1)
            {
                Random rand = new Random();
                 val1 = rand.Next(1, 6);
                 val2 = rand.Next(1, 6);
                ret_ans = val1 + val2;

                path_val1 = "dice" + val1.ToString() + ".png";
                path_val2 = "dice" + val2.ToString() + ".png";
                pb1.BackgroundImage = Image.FromFile(path_val1);
                pb2.BackgroundImage = Image.FromFile(path_val2);

                quest_log = "주사위 : " + val1.ToString() + " + " + val2.ToString();
            }
        }

        private void bt_ans_Click(object sender, EventArgs e)
        {
            if(isStart)
            {
                if(!isAns)
                {
                    if(tb_ans.Text != "")
                    { 
                        int ans = Convert.ToInt32(tb_ans.Text);
                        if (ans == ret_ans)
                        {

                            Console.Beep(440, 200);     //도
                            Console.Beep(554, 200);     //미
                            Console.Beep(659, 200);     //솔
                            Console.Beep(880, 200);     //높은도
                                                        //Thread.Sleep(20);
                                                           
                            if(mode ==1)
                            {
                                pb1.BackgroundImage = global::Math_Logic.Properties.Resources.like;
                                pb2.BackgroundImage = global::Math_Logic.Properties.Resources.like;
                            }
                            

                            tb_question.Text = "정답입니다!!!";
                            cor_num++;
                            tb_cor_num.Text = cor_num.ToString();

                            bt_ans.Text = "다음 문제";
                            isAns = true;

                            timer1.Stop();
                        }
                        else
                        {

                            Console.Beep(880, 400);     //높은도
                            wrong_num++;
                            tb_ng_num.Text = wrong_num.ToString();

                            if(mode ==1)
                            {
                                pb1.BackgroundImage = global::Math_Logic.Properties.Resources.angry;
                                pb2.BackgroundImage = global::Math_Logic.Properties.Resources.angry;

                                this.Update();
                                Thread.Sleep(1000);
                                pb1.BackgroundImage = Image.FromFile(path_val1);
                                pb2.BackgroundImage = Image.FromFile(path_val2);
                            }                           

                            Random rand = new Random();
                            int num = rand.Next(1, 5);
                            switch (num)
                            {
                                case 1:
                                    p_image.BackgroundImage = global::Math_Logic.Properties.Resources.mom;
                                    break;
                                case 2:
                                    p_image.BackgroundImage = global::Math_Logic.Properties.Resources.daddy;
                                    break;
                                case 3:
                                    p_image.BackgroundImage = global::Math_Logic.Properties.Resources.mustuch;
                                    break;
                                case 4:
                                    p_image.BackgroundImage = global::Math_Logic.Properties.Resources.squiz;
                                    break;
                            }


                            try
                            {
                                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                                sw = new StreamWriter(fs);

                                sw.WriteLine(quest_log);

                                sw.Close();
                                fs.Close();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
                else
                {
                    do_question();
                    tb_ans.Clear();
                    bt_ans.Text = "정답 맞추기";
                    isAns = false;
                    p_image.BackgroundImage = global::Math_Logic.Properties.Resources.black_sw;
                    timeout = 100;
                    timer1.Start();
                }

                
            }

            

        }
    }
}
