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
    public partial class frmHome : Form
    {
         SoundPlayer mys = new SoundPlayer();
         SoundPlayer up = new SoundPlayer();
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        
        }
        string undo;
        private void btnA_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "A";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if(optT2.Checked == true)
            {
                pub.team = "t2";
            }

            frmA newform = new frmA();
            newform.Show();
            btnA.Enabled = false;
            btnAF.Visible = true;
        }

            
            
        private void frmHome_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
            
            optT1.Checked = true;
            mys.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\back.wav";
            mys.Load();
            mys.PlayLooping();

            up.SoundLocation = @"C:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\up.wav";
            up.Load();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;

            btnAF.Visible = false;
            btnBF.Visible = false;
            btnCF.Visible = false;
            btnDF.Visible = false;
            btnEF.Visible = false;
            btnFF.Visible = false;
            btnGF.Visible = false;
            btnHF.Visible = false;
            btnIF.Visible = false;

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "C";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }
            frmC newform = new frmC();
            newform.Show();
            btnC.Enabled = false;
            btnCF.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "B";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }

            frmB newform = new frmB();
            newform.Show();
            btnB.Enabled = false;
            btnBF.Visible = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "D";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }
            frmD newform = new frmD();
            newform.Show();
            btnD.Enabled = false;
            btnDF.Visible = true;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "E";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }
            
            frmE newform = new frmE();
            newform.Show();
            btnE.Enabled = false;
            btnEF.Visible = true;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "F";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }
            
            frmF newform = new frmF();
            newform.Show();
            btnF.Enabled = false;
            btnFF.Visible = true;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "G";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }
            
            frmG newform = new frmG();
            newform.Show();
            btnG.Enabled = false;
            btnGF.Visible = true;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "H";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }
            
            frmH newform = new frmH();
            newform.Show();
            btnH.Enabled = false;
            btnHF.Visible = true;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            mys.Stop();
            undo = "I";
            if (optT1.Checked == true)
            {
                pub.team = "t1";
            }
            else if (optT2.Checked == true)
            {
                pub.team = "t2";
            }
            
            frmI newform = new frmI();
            newform.Show();
            btnI.Enabled = false;
            btnIF.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;

            btnAF.Visible = false;
            btnBF.Visible = false;
            btnCF.Visible = false;
            btnDF.Visible = false;
            btnEF.Visible = false;
            btnFF.Visible = false;
            btnGF.Visible = false;
            btnHF.Visible = false;
            btnIF.Visible = false;


            pub.t1l50 = true;
            pub.t1la = true;
            pub.t2l50 = true;
            pub.t2la = true;
        }

        private void btnAF_Click(object sender, EventArgs e)
        {

        }

        private void btnCF_Click(object sender, EventArgs e)
        {

        }

        private void btnBF_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                if (undo == "A")
                {
                    btnA.Enabled = true;
                    btnAF.Visible = false;
                }
                if (undo == "B")
                {
                    btnB.Enabled = true;
                    btnBF.Visible = false;
                }
                if (undo == "C")
                {
                    btnC.Enabled = true;
                    btnCF.Visible = false;
                }

                if (undo == "D")
                {
                    btnD.Enabled = true;
                    btnDF.Visible = false;
                }

                if (undo == "E")
                {
                    btnE.Enabled = true;
                    btnEF.Visible = false;
                }

                if (undo == "F")
                {
                    btnF.Enabled = true;
                    btnFF.Visible = false;
                }

                if (undo == "G")
                {
                    btnG.Enabled = true;
                    btnGF.Visible = false;
                }

                if (undo == "H")
                {
                    btnH.Enabled = true;
                    btnHF.Visible = false;
                }

                if (undo == "I")
                {
                    btnI.Enabled = true;
                    btnIF.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Reset Error", "Reset error!");
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            mys.SoundLocation = @"E:\luka 2015 final\v.21(acc eng added )\WindowsFormsApplication1\sound\back.wav";
            mys.Load();
            mys.PlayLooping();
        }

        private void btnFF_Click(object sender, EventArgs e)
        {

        }

        private void btnEF_Click(object sender, EventArgs e)
        {

        }

        private void btnDF_Click(object sender, EventArgs e)
        {

        }

        private void btnGF_Click(object sender, EventArgs e)
        {

        }

        private void btnHF_Click(object sender, EventArgs e)
        {

        }

        private void btnIF_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mys.Stop();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            up.Play();
        }
    }
}