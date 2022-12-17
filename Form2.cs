using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Math_Logic
{
    public partial class Form2 : Form
    {

        int[] clear = new int[7];
        private FileStream fs;
        private StreamWriter sw;
        private StreamReader sr;
        private String path;
        public Form2()
        {
            InitializeComponent();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void f2_btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
            panel6.BackColor = Color.Black;
            panel7.BackColor = Color.Black;
            panel8.BackColor = Color.Black;

            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel7.Enabled = false;
            panel8.Enabled = false;

            for (int i = 0; i < 7; i++) clear[i] = 0;
            
            this.p_bar1.Value = 0;

            DateTime time = DateTime.Now;
            string day_info=null;

            switch(time.DayOfWeek)
            {
                case (DayOfWeek.Monday):
                    panel2.BackColor = Color.White;
                    panel2.Enabled = true;
                    day_info = "오늘은 월요일! 일정을 확인하세요";
                    break;
                case (DayOfWeek.Tuesday):
                    panel3.BackColor = Color.White;
                    panel3.Enabled = true;
                    day_info = "오늘은 화요일! 일정을 확인하세요";
                    break;
                case (DayOfWeek.Wednesday):
                    panel4.BackColor = Color.White;
                    panel4.Enabled = true;
                    day_info = "오늘은 수요일! 일정을 확인하세요";
                    break;
                case (DayOfWeek.Thursday):
                    panel5.BackColor = Color.White;
                    panel5.Enabled = true;
                    day_info = "오늘은 목요일! 일정을 확인하세요";
                    break;
                case (DayOfWeek.Friday):
                    panel6.BackColor = Color.White;
                    panel6.Enabled = true;
                    day_info = "오늘은 금요일! 일정을 확인하세요";
                    break;
                case (DayOfWeek.Saturday):
                    panel7.BackColor = Color.LightBlue;
                    panel7.Enabled = true;
                    day_info = "오늘은 토요일! 일정을 확인하세요";
                    break;
                case (DayOfWeek.Sunday):
                    panel8.BackColor = Color.LightPink;
                    panel8.Enabled = true;
                    day_info = "오늘은 일요일! 일정을 확인하세요";
                    break;

            }

            tb_info.Text = day_info;

            path = "Schedule_Checker.txt";

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);
                sr = new StreamReader(fs);
                if (sr.ReadLine()==null)
                {
                    
                    for (int i = 0; i < 7; i++)
                    {                       
                        sw.WriteLine(clear[i].ToString());
                    }
                    sw.Close();
                    fs.Close();
                }
               
                else
                {
                    sr.DiscardBufferedData();
                    sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                    for (int i = 0; i < 7; i++)
                    {
                        clear[i] = Convert.ToInt32(sr.ReadLine());                        
                    }
                    sr.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (clear[0] == 1) pb_mon_res.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            if (clear[1] == 1) pb_tues.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            if (clear[2] == 1) pb_wed.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            if (clear[3] == 1) pb_thus.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            if (clear[4] == 1) pb_fri.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            if (clear[5] == 1) pb_sat.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            if (clear[6] == 1) pb_sun.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;

        }

        private void result_image(int result_num)
        {
            Random rand = new Random();
            int val1 = rand.Next(1, 18);
            Image bgr_img = global::Math_Logic.Properties.Resources.one1;
            switch (val1)
            {
                case 1:
                    bgr_img = global::Math_Logic.Properties.Resources.one1;
                    break;
                case 2:
                    bgr_img = global::Math_Logic.Properties.Resources.one2;
                    break;
                case 3:
                    bgr_img = global::Math_Logic.Properties.Resources.one3;
                    break;
                case 4:
                    bgr_img = global::Math_Logic.Properties.Resources.one4;
                    break;
                case 5:
                    bgr_img = global::Math_Logic.Properties.Resources.one5;
                    break;
                case 6:
                    bgr_img = global::Math_Logic.Properties.Resources.one6;
                    break;
                case 7:
                    bgr_img = global::Math_Logic.Properties.Resources.one7;
                    break;
                case 8:
                    bgr_img = global::Math_Logic.Properties.Resources.one8;
                    break;
                case 9:
                    bgr_img = global::Math_Logic.Properties.Resources.one9;
                    break;
                case 10:
                    bgr_img = global::Math_Logic.Properties.Resources.one10;
                    break;
                case 11:
                    bgr_img = global::Math_Logic.Properties.Resources.one11;
                    break;
                case 12:
                    bgr_img = global::Math_Logic.Properties.Resources.one12;
                    break;
                case 13:
                    bgr_img = global::Math_Logic.Properties.Resources.one13;
                    break;
                case 14:
                    bgr_img = global::Math_Logic.Properties.Resources.one14;
                    break;
                case 15:
                    bgr_img = global::Math_Logic.Properties.Resources.one15;
                    break;
                case 16:
                    bgr_img = global::Math_Logic.Properties.Resources.one16;
                    break;
                case 17:
                    bgr_img = global::Math_Logic.Properties.Resources.one17;
                    break;
            }

            switch (result_num)
            {
                case 1:
                    pb_mon_res.BackgroundImage = bgr_img;
                    break;
                case 2:
                    pb_tues.BackgroundImage = bgr_img;
                    break;
                case 3:
                    pb_wed.BackgroundImage = bgr_img;
                    break;
                case 4:
                    pb_thus.BackgroundImage = bgr_img;
                    break;
                case 5:
                    pb_fri.BackgroundImage = bgr_img;
                    break;
                case 6:
                    pb_sat.BackgroundImage = bgr_img;
                    break;
                case 7:
                    pb_sun.BackgroundImage = bgr_img;
                    break;
            }
        
        }

        private void bar_change(int val, int day)
        {
            this.p_bar1.BackColor = Color.Yellow;
            this.p_bar1.ForeColor = Color.Red;
            p_bar1.Value += val;
            if(p_bar1.Value == 100)
            {
                switch(day)
                {
                    case (1):
                        result_image(day);
                        clear[0] = 1;
                        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        try
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                sw.WriteLine(clear[i].ToString());
                            }
                           
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }finally
                        {
                            sw.Close();
                            fs.Close();
                        }
                        break;
                    case (2):
                        result_image(day);
                        clear[1] = 1;
                        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        try
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                sw.WriteLine(clear[i].ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sw.Close();
                            fs.Close();
                        }
                        break;
                    case (3):
                        result_image(day);
                        clear[2] = 1;
                        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        try
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                sw.WriteLine(clear[i].ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sw.Close();
                            fs.Close();
                        }
                        break;
                    case (4):
                        result_image(day);
                        clear[3] = 1;
                        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        try
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                sw.WriteLine(clear[i].ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sw.Close();
                            fs.Close();
                        }
                        break;
                    case (5):
                        result_image(day);
                        clear[4] = 1;
                        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        try
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                sw.WriteLine(clear[i].ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sw.Close();
                            fs.Close();
                        }
                        break;
                    case (6):
                        result_image(day);
                        clear[5] = 1;
                        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        try
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                sw.WriteLine(clear[i].ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sw.Close();
                            fs.Close();
                        }
                        break;
                    case (7):
                        result_image(day);
                        clear[6] = 1;
                        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        try
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                sw.WriteLine(clear[i].ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sw.Close();
                            fs.Close();
                        }
                        break;
                }
            }
        }


        /// <summary>
        /// Monday Schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_mon1_Click(object sender, EventArgs e)
        {
            this.bt_mon1.BackColor = Color.Gray;
            this.bt_mon1.Enabled = false;
            pb_mon1.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25,1);
        }

        private void bt_mon2_Click(object sender, EventArgs e)
        {
            this.bt_mon2.BackColor = Color.Gray;
            this.bt_mon2.Enabled = false;
            pb_mon2.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 1);
        }

        private void bt_mon3_Click(object sender, EventArgs e)
        {
            this.bt_mon3.BackColor = Color.Gray;
            this.bt_mon3.Enabled = false;
            pb_mon3.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 1);
        }

        private void bt_mon4_Click(object sender, EventArgs e)
        {
            this.bt_mon4.BackColor = Color.Gray;
            this.bt_mon4.Enabled = false;
            pb_mon4.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 1);
        }


      
        private void bt_tu1_Click(object sender, EventArgs e)
        {
            this.bt_tu1.BackColor = Color.Gray;
            this.bt_tu1.Enabled = false;
            pb_tu1.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25,2);
        }
        

        private void bt_tu2_Click(object sender, EventArgs e)
        {
            this.bt_tu2.BackColor = Color.Gray;
            this.bt_tu2.Enabled = false;
            pb_tu2.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 2);
        }

        private void bt_tu3_Click(object sender, EventArgs e)
        {
            this.bt_tu3.BackColor = Color.Gray;
            this.bt_tu3.Enabled = false;
            pb_tu3.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 2);
        }

        private void bt_tu4_Click(object sender, EventArgs e)
        {
            this.bt_tu4.BackColor = Color.Gray;
            this.bt_tu4.Enabled = false;
            pb_tu4.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 2);
        }

        private void bt_wed1_Click(object sender, EventArgs e)
        {
            this.bt_wed1.BackColor = Color.Gray;
            this.bt_wed1.Enabled = false;
            pb_wed1.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 3);
        }

        private void bt_wed2_Click(object sender, EventArgs e)
        {
            this.bt_wed2.BackColor = Color.Gray;
            this.bt_wed2.Enabled = false;
            pb_wed2.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 3);
        }

        private void bt_wed3_Click(object sender, EventArgs e)
        {
            this.bt_wed3.BackColor = Color.Gray;
            this.bt_wed3.Enabled = false;
            pb_wed3.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 3);
        }

        private void bt_wed4_Click(object sender, EventArgs e)
        {
            this.bt_wed4.BackColor = Color.Gray;
            this.bt_wed4.Enabled = false;
            pb_wed4.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 3);
        }

        private void bt_thu1_Click(object sender, EventArgs e)
        {
            this.bt_thu1.BackColor = Color.Gray;
            this.bt_thu1.Enabled = false;
            pb_thu1.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 4);
        }
        private void bt_thu2_Click(object sender, EventArgs e)
        {
            this.bt_thu2.BackColor = Color.Gray;
            this.bt_thu2.Enabled = false;
            pb_thu2.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 4);
        }
        private void bt_thu3_Click(object sender, EventArgs e)
        {
            this.bt_thu3.BackColor = Color.Gray;
            this.bt_thu3.Enabled = false;
            pb_thu3.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 4);
        }

        private void bt_thu4_Click(object sender, EventArgs e)
        {
            this.bt_thu4.BackColor = Color.Gray;
            this.bt_thu4.Enabled = false;
            pb_thu4.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 4);
        }

        private void bt_fri1_Click(object sender, EventArgs e)
        {
            this.bt_fri1.BackColor = Color.Gray;
            this.bt_fri1.Enabled = false;
            pb_fri1.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 5);
        }

        private void bt_fri2_Click(object sender, EventArgs e)
        {
            this.bt_fri2.BackColor = Color.Gray;
            this.bt_fri2.Enabled = false;
            pb_fri2.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 5);
        }

        private void bt_fri3_Click(object sender, EventArgs e)
        {
            this.bt_fri3.BackColor = Color.Gray;
            this.bt_fri3.Enabled = false;
            pb_fri3.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 5);
        }

        private void bt_fri4_Click(object sender, EventArgs e)
        {
            this.bt_fri4.BackColor = Color.Gray;
            this.bt_fri4.Enabled = false;
            pb_fri4.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            bar_change(25, 5);
        }
        private void bt_sat1_Click(object sender, EventArgs e)
        {
            bar_change(20, 6);
            pb_sat1.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sat1.BackColor = Color.Gray;
            this.bt_sat1.Enabled = false;
        }

        private void bt_sat2_Click(object sender, EventArgs e)
        {
            bar_change(20, 6);
            pb_sat2.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sat2.BackColor = Color.Gray;
            this.bt_sat2.Enabled = false;
        }

        private void bt_sat3_Click(object sender, EventArgs e)
        {
            bar_change(20, 6);
            pb_sat3.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sat3.BackColor = Color.Gray;
            this.bt_sat3.Enabled = false;
        }

        private void bt_sat4_Click(object sender, EventArgs e)
        {
            bar_change(20, 6);
            pb_sat4.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sat4.BackColor = Color.Gray;
            this.bt_sat4.Enabled = false;
        }

        private void bt_sat5_Click(object sender, EventArgs e)
        {
            bar_change(20, 6);
            pb_sat5.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sat5.BackColor = Color.Gray;
            this.bt_sat5.Enabled = false;
        }

        private void bt_sun1_Click(object sender, EventArgs e)
        {
            bar_change(35, 7);
            pb_sun1.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sun1.BackColor = Color.Gray;
            this.bt_sun1.Enabled = false;
        }

        private void bt_sun2_Click(object sender, EventArgs e)
        {
            bar_change(35, 7);
            pb_sun2.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sun2.BackColor = Color.Gray;
            this.bt_sun2.Enabled = false;
        }

        private void bt_sun3_Click(object sender, EventArgs e)
        {
            bar_change(30, 7);
            pb_sun3.BackgroundImage = global::Math_Logic.Properties.Resources.Luffys_flag;
            this.bt_sun3.BackColor = Color.Gray;
            this.bt_sun3.Enabled = false;
        }
    }
}
