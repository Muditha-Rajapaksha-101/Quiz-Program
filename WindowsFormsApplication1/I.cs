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
    public partial class frmI : Form
    {
        SoundPlayer st = new SoundPlayer();
        SoundPlayer ansT = new SoundPlayer();
        SoundPlayer ansF = new SoundPlayer();
        SoundPlayer leave = new SoundPlayer();
        public frmI()
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
                    txtAnswer.Text = "Answer Number 1 - ලංකා බැංකුව";
                }
                
                
                else if (f == "bs" && lan =="eng")
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
                    txtAnswer.Text = "Answer Number 1 - Bank of ceylon";
                }

                else if (f == "econ" && lan == "sin")
                {
                    if (opt3.Checked == true)
                    {
                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 3 - ආදායම් ප්‍රතිවිපකය මතයි";
                }

                else if (f == "econ" && lan == "eng")
                {
                    if (opt3.Checked == true)
                    {
                        ansT.Play();
                        txtAnswer.BackColor = Color.Lime;
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 3 - Based on the income effect";
                }

                else if (f == "acc" && lan == "sin")
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
                    txtAnswer.Text = "Answer Number 4- ශ්‍රිලංකා ගිනුම්කරණ හා විගණන  ප්‍රමිත සමික්ෂණ මණ්ඩලය";
                }

                else if (f == "acc" && lan == "eng")
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
                    txtAnswer.Text = "Answer Number 4- Acc & auditing Standards monitoring ";
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
                    txtQuestion.Text = "ක්‍රමවත්  හා නිවැරදි ණය පත්(Credit Card) ක්‍රමයක් 1989 පෙබරවාරි මස මුලින්ම ශ්‍රි ලංකාවට හදුන්වා දුන්නෙ?";

                    opt1.Text = "ලංකා බැංකුව";
                    opt2.Text = "මහජන බැංකුව";
                    opt3.Text = "කොමර්ෂල් බැංකුව";
                    opt4.Text = "HSBC";


                    
                }
               
                
                
                
                else if (f == "bs" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "Which bank introduced a systematic credit card system to srilanka in february 1989?" ;

                    opt1.Text = "Bank of Ceylon";
                    opt2.Text = "People's bank ";
                    opt3.Text = "Commercial Bank ";
                    opt4.Text = "HSBC";
                }
                
                
               
                
                else if (f == "econ" && lan == "sin")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "ගිෆන් භාණ්ඩ හා බාල භාන්ඩ යන දෙකම සාමාන්‍ය භාන්ඩ වලින් වෙනස් වනුයේ?";

                    opt1.Text = "මිල ප්‍රතිවිපාකය මතයි";
                    opt2.Text = "ආදේශන ප්‍රතිවිපාකය මතයි";
                    opt3.Text = "ආදායම් ප්‍රතිවිපකය මතයි";
                    opt4.Text = "එය අවස්ථාව අනුව වෙනස් වේ.";
                }
                
                
              
                
                
                else if (f == "econ" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "Giffen goods and inferior goods are different from normal good?";

                    opt1.Text = "Based on the price effect";
                    opt2.Text = "Based on the substitution effect";
                    opt3.Text = "Based on the income effect";
                    opt4.Text = "This is depend on the occasion";
                }
               
                
               
                
                else if(f == "acc" && lan == "sin")
                {
                    panel.Visible= false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = " ශ්‍රි ලංකාවේ LKAS 01 ට අනුව, ගිණුම්කරණය අනිවාර්ය ව්‍යාපාරවල  මූල්‍ය ප්‍රකාශන  ගිණුම්කරණ ප්‍රමිත වලට යටත්ව  සිදු වෙන්නේ දැයි අධීක්ෂණය කරනුයේ?";

                    opt1.Text = "ශ්‍රි ලංකා වරලත් ගණකාධිකාරී ආයතනය";
                    opt2.Text = "ශ්‍රිලංකා ගිනුම්කරන ප්‍රමිත කමිටුව";
                    opt3.Text = "ශ්‍රිලංකා මහා බැංකුව";
                    opt4.Text = "ශ්‍රිලංකා ගිනුම්කරණ හා විගණන  ප්‍රමිත සමික්ෂණ මණ්ඩලය";
                }
                
                
                
                else if (f == "acc" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "Which one of the following Body supervises whether the financial statements of a compulsary entity as per LKAS 01, do comply with the accounting standards";

                    opt1.Text = "CA Sri Lanka";
                    opt2.Text = "Accounting Standard Committee";
                    opt3.Text = "Central Bank of Sri Lanka";
                    opt4.Text = "Acc. & auditing Standards monitoring Board";
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
                opt3.Enabled = false;
                opt4.Enabled = false;
            }
            else if (f == "bs" && lan == "eng")
            {
                opt4.Enabled = false;
                opt3.Enabled = false;
            }
            else if (f == "econ" && lan == "sin")
            {
                opt1.Enabled = false;
                opt2.Enabled = false;
            }
            else if (f == "econ" && lan == "eng")
            {
                opt1.Enabled = false;
                opt2.Enabled = false;
            }
            else if (f == "acc" && lan == "sin")
            {
                opt1.Enabled = false;
                opt3.Enabled = false;
            }
            else if (f == "acc" && lan == "eng")
            {
                opt1.Enabled = false;
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
