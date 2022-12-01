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
    public partial class frmH : Form
    {
        SoundPlayer st = new SoundPlayer();
        SoundPlayer ansT = new SoundPlayer();
        SoundPlayer ansF = new SoundPlayer();
        SoundPlayer leave = new SoundPlayer();
        public frmH()
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
                    txtAnswer.Text = "Answer Number 4 - E-Teller";
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
                    txtAnswer.Text = "Answer Number 4 - E-Teller";
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
                    txtAnswer.Text = "Answer Number 2 -  25";
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
                    txtAnswer.Text = "Answer Number 2 -  25";
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
                    txtAnswer.Text = "Answer Number 1 - Rs.2700/-";
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
                    txtAnswer.Text = "Answer Number 1 - Rs.2700/-";
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
                    txtQuestion.Text = "E-ගනුදෙනු වල ව්‍යාපාර හා ව්‍යාපාර අතර(B2B)අවස්ථාව සදහා නිදසුනක් නොවන්නේ?";

                    opt1.Text = "E-Dristributer(E-බෙදාහැරීම)";
                    opt2.Text = "E-Procument(E-පසම්පාධන)";
                    opt3.Text = "E-Exchanger(E-හුවමාරුව)";
                    opt4.Text = "E-Teller(E-වෙළඳාම)";


                    
                }
               
                
                
                
                else if (f == "bs" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "What is not an example for B2B(Business to Business) in E-Transaction";

                    opt1.Text = "E-Dristributer";
                    opt2.Text = "E-Procument";
                    opt3.Text = "E-Exchanger";
                    opt4.Text = "E-Teller";
                }
                
                
               
                
                else if (f == "econ" && lan == "sin")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "ශ්‍රි ලංකාවේ මුළු බලපත්‍රලාභී වානිජ බැංකු ගණන වන්නේ?";

                    opt1.Text = "24";
                    opt2.Text = "25";
                    opt3.Text = "26";
                    opt4.Text = "23";
                }
                
                
              
                
                
                else if (f == "econ" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "Number of licensed commercial banks in Sri Lanka? ";

                    opt1.Text = "24";
                    opt2.Text = "25";
                    opt3.Text = "26";
                    opt4.Text = "23";
                }
               
                
               
                
                else if(f == "acc" && lan == "sin")
                {
                    panel.Visible= false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "ව්‍යාපාරයක පැවැති සුලු මුදල් අග්‍රිමය වූයේ 5000/- කි. නමුත් එය ප්‍රමාණවත් නොවුයෙන් 2014.10.31 සිට එය 7500 දක්වා වැඩිකිරීම සඳහා  ඔක්තෝම්බර් මාසය අග 7100/- ක ප්‍රතිපූර්නයක් ලබා දුන් අතර මෙම මාසය මුල Rs. 1900 වටිනා මුදල් ප්‍රමානයක් අස්ථානගත වී ඇත.ඒ අනුව එය හැර මෙම මාසය තුල වියදම් කල මුලු මුදල්  ප්‍රමාණය  වන්නේ?";

                    opt1.Text = "Rs.2700";
                    opt2.Text = "Rs.4600";
                    opt3.Text = "Rs.7100";
                    opt4.Text = "Rs.3900";
                }
                
                
                
                else if (f == "acc" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "Petty cash imprest of a business was Rs5,000/=. Since it was not enough , its has been increased to Rs7,500/= from 31-10-2015. At the end of October Rs7,100/= was reimbursed and the beginning of October Rs1,900/= was lost, accordingly the correct petty cash expense during the month except the money lost was, ";

                    opt1.Text = "Rs.2700";
                    opt2.Text = "Rs.4600";
                    opt3.Text = "Rs.7100";
                    opt4.Text = "Rs.3900";
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
                opt3.Enabled = false;
            }
            else if (f == "bs" && lan == "eng")
            {
                opt1.Enabled = false;
                opt3.Enabled = false;
            }
            else if (f == "econ" && lan == "sin")
            {
                opt3.Enabled = false;
                opt4.Enabled = false;
            }
            else if (f == "econ" && lan == "eng")
            {
                opt4.Enabled = false;
                opt3.Enabled = false;
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
