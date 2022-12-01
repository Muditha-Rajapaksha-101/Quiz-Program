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
    public partial class frmA : Form
    {
        SoundPlayer st = new SoundPlayer();
        SoundPlayer ansT = new SoundPlayer();
        SoundPlayer ansF = new SoundPlayer();
        //SoundPlayer ansF = new SoundPlayer();
        SoundPlayer leave = new SoundPlayer();
        public frmA()
        {
            InitializeComponent();
        }
        int tim;
        private void A_Load(object sender, EventArgs e)
        {
            st.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\start.wav";
            st.Load();

            leave.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\leave.wav";
            leave.Load();

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
                        txtAnswer.BackColor = Color.Lime;
                        ansT.Play();
                    }
                    else
                    {
                        txtAnswer.BackColor = Color.Red;
                        ansF.Play();
                    }
                    txtAnswer.Text = "Answer Number 2 -   GMP(Good Manufacturing prachce)";
                }
                
                
                else if (f == "bs" && lan =="eng")
                {
                    if (opt2.Checked == true)
                    {
                        txtAnswer.BackColor = Color.Lime;
                        ansT.Play();
                        
                    }
                    else
                    {
                        ansF.Play();
                        txtAnswer.BackColor = Color.Red;
                    }
                    txtAnswer.Text = "Answer Number 2 - GMP";
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
                    txtAnswer.Text = "Answer Number 2 -රු.3/-     {  es/(es-ed)    }";
                    
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
                    txtAnswer.Text = "Answer Number 2 -රු.3/-     {  es/(es-ed)    }";
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
                    txtAnswer.Text = "Answer Number 4 - විෂයානුගත බව";
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
                    txtAnswer.Text = "Answer Number 4 - Subjective ";
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
                    txtQuestion.Text = "ඖෂධ සඳහා අත්‍යාවශ්‍ය ප්‍රමිතිය කුමක්ද?";

                    opt1.Text = "ISO 14001";
                    opt2.Text = "GMP";
                    opt3.Text = "ISO 22000";
                    opt4.Text = "OHSAS 18001";


                    
                }
               
                
                
                
                else if (f == "bs" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "The compulsory certificate for  pharmaceuticals";

                    opt1.Text = "ISO 14001";
                    opt2.Text = "GMP";
                    opt3.Text = "ISO 22000";
                    opt4.Text = "OHSAS 18001";
                }
                
                
               
                
                else if (f == "econ" && lan == "sin")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "කිසියම් වෙළඳපොලක භාණ්ඩයක් මත රු.10ක බද්දක් පනවයි.එම භාණ්ඩයේ සැපයුම් නම්‍යතාව 1.4 ක් හා ඉල්ලුම් නම්‍යතාව -0.6 ක් වේ  නිෂ්පාදකයා දරන බදු බර?";

                    opt1.Text = "2.25";
                    opt2.Text = "3";
                    opt3.Text = "2.75";
                    opt4.Text = "3.5";
                }
                
                
              
              
                
                else if (f == "econ" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "Govenment imposes a unit tax of Rs.10/= for a certain product.The elasticity of supply for this product is 1.4 and the elasticity of demand is -0.6.The burden of the unit tax imposed on producer would be?";

                    opt1.Text = "2.25";
                    opt2.Text = "3";
                    opt3.Text = "2.75";
                    opt4.Text = "3.5";
                }
               
                
               
                
                else if(f == "acc" && lan == "sin")
                {
                    panel.Visible= false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "යම් ගෙවීමක් වියදමක්ද,වත්කමක්ද යන්න තීරනය කිරිමේදී සැලකිල්ලක් නොදක්වන කරුන වන්නේ?";

                    opt1.Text = "ප්‍රමාණාත්මකභාවය";
                    opt2.Text = "සාපේක්ෂබව";
                    opt3.Text = "පැවැත්ම";
                    opt4.Text = "විෂයානුගත බව";
                }
                
                
                
                else if (f == "acc" && lan == "eng")
                {
                    panel.Visible = false;
                    panel2.Visible = true;

                    txtQuestion.Clear();
                    txtQuestion.Text = "Which one of the following is not considered in deciding a certain payment as an 'expense' or an 'asset'?";

                    opt1.Text = "Materiality ";
                    opt2.Text = "Comparability ";
                    opt3.Text = "Existence";
                    opt4.Text = "Subjective ";
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
            else if(f == "bs" && lan =="eng")
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
                opt1.Enabled = false;
                opt2.Enabled = false;
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
            int tim2;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
