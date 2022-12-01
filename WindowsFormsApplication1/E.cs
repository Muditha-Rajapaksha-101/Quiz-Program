using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class frmE : Form
    {
        SoundPlayer st = new SoundPlayer();
        SoundPlayer ansT = new SoundPlayer();
        SoundPlayer ansF = new SoundPlayer();
        SoundPlayer leave = new SoundPlayer();
        public frmE()
        {
            InitializeComponent();
        }
        int tim;
        private void A_Load(object sender, EventArgs e)
        {
            leave.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\leave.wav";
            leave.Load();

            st.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\start.wav";
            st.Load();

            ansT.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\true.wav";
            ansT.Load();


            ansF.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\false.wav";
            ansF.Load();
            
            if (pub.team == "t1")
            {
                if (pub.t1l50 == true)
                {
                    btn50.Enabled = true;
                }
                else if (pub.t1l50 == false)
                {
                    btn50.Enabled = false;
                }
                if (pub.t1la == true)
                {
                    btnAF.Enabled = true;
                }
                else if (pub.t1la == false)
                {
                    btnAF.Enabled = false;
                }
            }
            else if (pub.team == "t2")
            {
                if (pub.t2l50 == true)
                {
                    btn50.Enabled = true;
                }
                else if (pub.t2l50 == false)
                {
                    btn50.Enabled = false;
                }
                if (pub.t2la == true)
                {
                    btnAF.Enabled = true;
                }
                else if (pub.t2la == false)
                {
                    btnAF.Enabled = false;
                }
            }
        }
       
        
        string f = "";
        string lan;
        string count;



        private void btnBS_Click(object sender, EventArgs e)
        {

            f = "bs";

            btnBS.Enabled = false;
            btnEcon.Enabled = false;
            btnAcc.Enabled = false;


            
        }

        private void btnEcon_Click(object sender, EventArgs e)
        {

            f = "econ";

            btnBS.Enabled = false;
            btnEcon.Enabled = false;
            btnAcc.Enabled = false;
            
           
  
          

            
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            f = "acc";
            btnBS.Enabled = false;
            btnEcon.Enabled = false;
            btnAcc.Enabled = false;

          
            
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            ansT.Play();
            btn50.Enabled = false;
            btnAF.Enabled = false;

            txtAnswer.Clear();
            try
            {
                 if (count == "1")
                { 
                    btnHome.Enabled = true;
                    btnHome.Focus();
                }
                 else
                {
                    btnNH.Enabled = true;
                    btnNH.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Counting error in enable next");
            }
            try
            {
                if (f == "bs" && lan =="sin")
                {
                    if (opt4.Checked == true)
                    {
                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 4 - ව්‍යාපාර අවදානම කළමනාකරණය";
                }
                
                
                else if (f == "bs" && lan =="eng")
                {
                    if (opt4.Checked == true)
                    {
                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 4 - Business Risk Management ";
                }

                else if (f == "econ" && lan == "sin")
                {
                    if (opt2.Checked == true)
                    {
                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 2 - මුලතිව් ";
                }

                else if (f == "econ" && lan == "eng")
                {

                    if (opt2.Checked == true)
                    {
                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 2 - Mulathiv  ";
                }

                else if (f == "acc" && lan == "sin")
                {
                    if (opt1.Checked == true)
                    {
                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 1 - Rs.7500";
                }

                else if (f == "acc" && lan == "eng")
                {
                    if (opt1.Checked == true)
                    {

                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 1 - Rs.7500";
                }
                else
                {

                }
                btnChk.Enabled = false;
            }
            catch
            {   
                  MessageBox.Show("If error","Exception..!");       
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            lan = "sin";
            btnSin.Enabled = false;
            btnEng.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lan = "eng";
            btnSin.Enabled = false;
            btnEng.Enabled = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            st.Play();
            if (pub.team == "t1")
            {
                if (pub.t1l50 == true)
                {
                    btn50.Enabled = true;
                }
                else if (pub.t1l50 == false)
                {
                    btn50.Enabled = false;
                }
                if (pub.t1la == true)
                {
                    btnAF.Enabled = true;
                }
                else if (pub.t1la == false)
                {
                    btnAF.Enabled = false;
                }
            }
            else if (pub.team == "t2")
            {
                if (pub.t2l50 == true)
                {
                    btn50.Enabled = true;
                }
                else if (pub.t2l50 == false)
                {
                    btn50.Enabled = false;
                }
                if (pub.t2la == true)
                {
                    btnAF.Enabled = true;
                }
                else if (pub.t2la == false)
                {
                    btnAF.Enabled = false;
                }
            }
            opt1.Checked = false;
            opt2.Checked = false;
            opt3.Checked = false;
            opt4.Checked = false;

            btnTime.Enabled = true;
            txtQuestion.Clear();
            btnTime.Focus();
            try
            {
                if (count == "1")
                {
                    btnNH.Enabled = false;
                    //btnHome.Enabled = true;
                    btnChk.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("count error");
            }


            try
            {
                if (f == "bs" && lan == "sin")
                {
                    panel.Visible = false;
                    panel2.Visible = true;
                    
                    txtQuestion.Clear();
                    txtQuestion.Text = "ISO 31000:2009 ප්‍රමිති සහතිකය පිරිනමෙන්නේ කුමක් සඳහාද??";

                    opt1.Text = "මානව සම්පත් කළමණාකරනය";
                    opt2.Text = "තොරතුරු තාක්ෂණය";
                    opt3.Text = "බලශක්ති  කළමනාකරණය";
                    opt4.Text = "ව්‍යාපාර අවධානම් කළමනාකරණය";


                    
                }
               
                
                
                
                else if (f == "bs" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "International Organization for standardization grants ISO 31000:2009 standard related to,,";

                    opt1.Text = "Human resource management";
                    opt2.Text = "Information technology ";
                    opt3.Text = "Energy management";
                    opt4.Text = "Business risk management ";
                }
                
                
               
                
                else if (f == "econ" && lan == "sin")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "පහත දිස්ත්‍රික්ක අතරින් ලංකාවේ ඉහලම දරිද්‍රතා දර්ශක අගය පෙන්නුම් පෙන්නුම් කරනුයේ??";

                    opt1.Text = "හම්බන්තොට";
                    opt2.Text = "මුලතිව්";
                    opt3.Text = "මොනරාගල";
                    opt4.Text = "පුත්තලම";
                }
                
                
              
                
                
                else if (f == "econ" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "According to the poverty index ,Which of the following district has the highest poverty index ";

                    opt1.Text = "Hambanthota";
                    opt2.Text = "Mulathiv";
                    opt3.Text = "Monaragala";
                    opt4.Text = "Puttalam";
                }
               
                
               
                
                else if(f == "acc" && lan == "sin")
                {
                    panel.Visible= false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "2014.1.1 දින යන්ත්‍රයක පිරිවැය 100000 ක් හා සමුච්චිත ක්ෂය 20000 කි. 2014,7,1 දින එම යන්ත්‍රය 82500 කට ප්‍රත්‍යාගනනය කරන ලදී.(වාර්ෂික ක්ෂය අනුපාතය 10%) වසරේ ප්‍රත්‍යාගන   සංචිතයට ඇතුලත් වන අගය?";

                    opt1.Text = "Rs.7500";
                    opt2.Text = "Rs.12500";
                    opt3.Text = "Rs.2500";
                    opt4.Text = "Rs.8250";
                }
                
                
                
                else if (f == "acc" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "On 01-01-2015, Cost of a machine was Rs100,000 accumulated depreciation was Rs20,000, on 01-07-2015 it was revalued at Rs82,500. Annual rate of depreciation is 10%, How much should be transferred to revaluation reserve account for the year?";

                    opt1.Text = "Rs  7,500/=";
                    opt2.Text = "Rs 12,000/=";
                    opt3.Text = "Rs  2,500/=";
                    opt4.Text = "Rs  8,250/=";
                }
                
                else
                {
                    MessageBox.Show("Please Enter all the inputs", "Data error.!");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input.!", "Validation error.!");
            }
            btnTime.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void opt4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNH_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            tim2 = 35;
            txtAnswer.BackColor = Color.WhiteSmoke;
            timer.Stop();
            tim = 30;
            txtTime.Clear();
            opt1.Enabled = true;
            opt2.Enabled = true;
            opt3.Enabled = true;
            opt4.Enabled = true;
            
            
            count = "1";
            panel2.Visible = false;
            panel.Visible = true;

            txtQuestion.Clear();
            txtAnswer.Clear();
            
            opt1.Text = "null";
            opt2.Text = "null";
            opt3.Text = "null";
            opt4.Text = "null";


            btnSin.Enabled = true;
            btnEng.Enabled = true;

           
            try
            {
                if(f == "bs")
                {
                    btnEcon.Enabled = true;
                    btnAcc.Enabled = true;
                }
                else if (f == "econ")
                {
                    btnBS.Enabled = true;
                    btnAcc.Enabled = true;
                }
                else if (f == "acc")
                {
                    btnBS.Enabled = true;
                    btnEcon.Enabled = true;
                }
                else
                {
                    MessageBox.Show("error.!");
                }
            }
            catch
            {

            }
            f = "";
            lan = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            leave.Play();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (f == "bs" && lan == "sin")
            {
                opt1.Enabled = false;
                opt2.Enabled = false;
            }
            else if (f == "bs" && lan == "eng")
            {
                opt1.Enabled = false;
                opt2.Enabled = false;
            }
            else if (f == "econ" && lan == "sin")
            {
                opt1.Enabled = false;
                opt4.Enabled = false;
            }
            else if (f == "econ" && lan == "eng")
            {
                opt1.Enabled = false;
                opt4.Enabled = false;
            }
            else if (f == "acc" && lan == "sin")
            {
                opt3.Enabled = false;
                opt4.Enabled = false;
            }
            else if (f == "acc" && lan == "eng")
            {
                opt4.Enabled = false;
                opt3.Enabled = false;
            }
            else
            {
                MessageBox.Show("error in 50/50 mode", "Exception.!");
            }
            btnAF.Enabled = false;
            timer.Stop();
            txtTime.Clear();
            tim = 15;
            timer.Start();

            
            btn50.Enabled = false;

            if (pub.team == "t1")
            {
                pub.t1l50 = false;
            }
            else if (pub.team == "t2")
            {
                pub.t2l50 = false;
            }
        }

        private void btnAF_Click(object sender, EventArgs e)
        {
            btn50.Enabled = false;
            timer.Stop();
            txtTime.Clear();
            tim = 15;
            timer.Start();

            btnAF.Enabled = false;

            if (pub.team == "t1")
            {
                pub.t1la = false;
            }
            else if (pub.team == "t2")
            {
                pub.t2la = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnTime_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void btnTime_Click_1(object sender, EventArgs e)
        {
            tim2 = 35;
            timer2.Start();
            tim = 30;
            timer.Start();
        }
       
        private void timer_Tick_1(object sender, EventArgs e)
        {
            tim--;
            txtTime.Text = tim.ToString();

            if (tim == 10)
            {
                btn50.Enabled = false;
                btnAF.Enabled = false;

            }
            if (tim == 0)
            {
                

                timer.Stop();

                btn50.Enabled = false;
                btnAF.Enabled = false;

                btnTime.Enabled = false;
                
                btnChk.Focus();


            }
            if (opt1.Checked == true)
            {
                timer.Stop();
                btn50.Enabled = false;
                btnAF.Enabled = false;
                
            }
            if (opt2.Checked == true)
            {
                timer.Stop();
                btn50.Enabled = false;
                btnAF.Enabled = false;
                
            }
            if (opt3.Checked == true)
            {
                timer.Stop();
                btn50.Enabled = false;
                btnAF.Enabled = false;
                
            }
            if (opt4.Checked == true)
            {
                timer.Stop();
                btn50.Enabled = false;
                btnAF.Enabled = false;
                
            }
        }
        int tim2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            tim2--;
            if (tim2 == 0)
            {
                opt1.Enabled = false;
                opt2.Enabled = false;
                opt3.Enabled = false;
                opt4.Enabled = false;
            }
        }

    }
}
