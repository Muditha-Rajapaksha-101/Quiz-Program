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
    public partial class frmB : Form
    {
        SoundPlayer st = new SoundPlayer();
        SoundPlayer ansT = new SoundPlayer();
        SoundPlayer ansF = new SoundPlayer();
        SoundPlayer leave = new SoundPlayer();
        public frmB()
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
                    txtAnswer.Text = "Answer number 2 - ව්‍යවසායකයා ලෙස කටයුතු කිරීම";
                }
                
                
                else if (f == "bs" && lan =="eng")
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
                    txtAnswer.Text = "Answer number 2 - As a Enterpreneur ";
                }

                else if (f == "econ" && lan == "sin")
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
                    txtAnswer.Text = "Answer number 4 - සම්පූර්න වාසිය නිෂ්පාදකයාට හිමිවේ";
                }

                else if (f == "econ" && lan == "eng")
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
                    txtAnswer.Text = "The total benefit goes to the producer";
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
                    txtAnswer.Text = "Answer number 1 - 562 500/- ";
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
                    txtAnswer.Text = "Answer number 1 - 562 500/-  }";
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
                    txtQuestion.Text = "හෙන්.රි මින්ට්ස්බර්ග් (Henry Mintzburg) ට අනුව තීරණ ගැනිමේ භූමිකාවට අයත් කාර්යභාර්යක්  ලෙස සැලකිය හැක්කේ?";

                    opt1.Text = "නායකයෙකු ලෙස කටයුතු කිරීම";
                    opt2.Text = "ව්‍යවසායකයා ලෙස කටයුතු කිරීම";
                    opt3.Text = "නියාමකයෙකු ලෙස කටයුතු කිරීම";
                    opt4.Text = "මාධ්‍ය ප්‍රචාරකයා ලෙස කටයුතු කිරිම";


                    
                }
               
                
                
                
                else if (f == "bs" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "According to henry mintzburg this is a function under decisional role" ;

                    opt1.Text = "As a figure head ";
                    opt2.Text = "As a Enterpreneur ";
                    opt3.Text = "As a leader ";
                    opt4.Text = "As a monitor ";
                }
                
                
               
                
                else if (f == "econ" && lan == "sin")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "පූර්ණ නම්‍ය සැපයුමක් ඇති භාන්ඩයකට සහනාධාරයක් ලබාදුන් විට අති වන ප්‍රතිඵලයක් නොවන්නේ?";

                    opt1.Text = "සම්පූර්ණ වාසිය පාරිභෝගිකයට වේ";
                    opt2.Text = "ආණ්ඩුවේ පිරිවැය වැඩි වේ.";
                    opt3.Text = "භාණ්ඩයේ අලෙවිය වැඩිවේ.";
                    opt4.Text = "සම්පූර්න වාසිය නිෂ්පාදකයාට හිමිවේ";
                }
                
                
              
                
                
                else if (f == "econ" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "It is not a result which can be emerged when granting a subsidy to a product which has a perfectly elastic supply?";

                    opt1.Text = "Total benefit goes to the consumer";
                    opt2.Text = "Cost of the government increases";
                    opt3.Text = "Sale of the product increases ";
                    opt4.Text = "Total benefit goes to the producer";
                }
               
                
               
                
                else if(f == "acc" && lan == "sin")
                {
                    panel.Visible= false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "වසර මුල මිලට ගත් මෝටර් රථයක ගැනුම් මිල රු.600,000/- කි.ගුදම් ගාස්තු රු.30,000/-,ගෙන ඒමේ වියදම් රු.50000/- ,ලියාපදින්චි  ගාස්තුව  රු.50,000/-  , ආදායම් බලපත්‍ර ගාස්තුව රු.20000, භාවිතයට පෙර දරන ලද අලුත්වැඩියා ගාස්තුව රු.7500/- ,මෙහි ඵලදායි ජීවකාලය අවුරුදු 4 ක් හා සුන්බුන් අගය රු.37,500/- ක් නම් පළමු වර්ෂය අවසානයේදී ධාරන අගය?";

                    opt1.Text = "රු.562,500";
                    opt2.Text = "රු.750,000";
                    opt3.Text = "රු.615,000";
                    opt4.Text = "රු.637,500";
                }
                
                
                
                else if (f == "acc" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "A Vehicle has been acquired at the beginning of the year for a purchase price of Rs.600 000/-,Demurrage charges Rs.30 000,Registration charges Rs.50 000,Revenue License Rs.20 000,Carriage inwards Rs.50 000,Repair Charges incurred before the use Rs.7500,Economic useful life 4 years,Scrap Value Rs.37 500,Calculate the carrying value at the end of the first year ";

                    opt1.Text = "Rs.562,500";
                    opt2.Text = "Rs.750,000";
                    opt3.Text = "Rs.615,000";
                    opt4.Text = "Rs.637,500";
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
                opt2.Enabled = false;
                opt3.Enabled = false;
            }
            else if (f == "econ" && lan == "eng")
            {
                opt2.Enabled = false;
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
