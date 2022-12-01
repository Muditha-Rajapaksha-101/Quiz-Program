namespace WindowsFormsApplication1
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.optT2 = new System.Windows.Forms.RadioButton();
            this.optT1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.grpHome = new System.Windows.Forms.GroupBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnHF = new System.Windows.Forms.Button();
            this.btnGF = new System.Windows.Forms.Button();
            this.btnFF = new System.Windows.Forms.Button();
            this.btnEF = new System.Windows.Forms.Button();
            this.btnDF = new System.Windows.Forms.Button();
            this.btnCF = new System.Windows.Forms.Button();
            this.btnBF = new System.Windows.Forms.Button();
            this.btnAF = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(876, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 460);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.jhgyukj2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 286);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(300, 180);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(100, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 166);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.h;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(214, 465);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(107, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 279);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnSound);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 40);
            this.panel2.TabIndex = 34;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(553, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(27, 27);
            this.btnStop.TabIndex = 43;
            this.btnStop.Text = "T";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(520, 1);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(27, 27);
            this.btnSound.TabIndex = 42;
            this.btnSound.Text = "S";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUndo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(226, 1);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(213, 32);
            this.btnUndo.TabIndex = 41;
            this.btnUndo.Text = "Undo ";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.optT2);
            this.panel3.Controls.Add(this.optT1);
            this.panel3.Location = new System.Drawing.Point(885, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 36);
            this.panel3.TabIndex = 39;
            // 
            // optT2
            // 
            this.optT2.AutoSize = true;
            this.optT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optT2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.optT2.Location = new System.Drawing.Point(112, 5);
            this.optT2.Name = "optT2";
            this.optT2.Size = new System.Drawing.Size(76, 22);
            this.optT2.TabIndex = 1;
            this.optT2.TabStop = true;
            this.optT2.Text = "Team 2";
            this.optT2.UseVisualStyleBackColor = true;
            // 
            // optT1
            // 
            this.optT1.AutoSize = true;
            this.optT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optT1.ForeColor = System.Drawing.SystemColors.Control;
            this.optT1.Location = new System.Drawing.Point(13, 5);
            this.optT1.Name = "optT1";
            this.optT1.Size = new System.Drawing.Size(76, 22);
            this.optT1.TabIndex = 0;
            this.optT1.TabStop = true;
            this.optT1.Text = "Team 1";
            this.optT1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // grpHome
            // 
            this.grpHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHome.BackColor = System.Drawing.Color.Black;
            this.grpHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpHome.BackgroundImage")));
            this.grpHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpHome.Controls.Add(this.btnIF);
            this.grpHome.Controls.Add(this.btnHF);
            this.grpHome.Controls.Add(this.btnGF);
            this.grpHome.Controls.Add(this.btnFF);
            this.grpHome.Controls.Add(this.btnEF);
            this.grpHome.Controls.Add(this.btnDF);
            this.grpHome.Controls.Add(this.btnCF);
            this.grpHome.Controls.Add(this.btnBF);
            this.grpHome.Controls.Add(this.btnAF);
            this.grpHome.Controls.Add(this.btnI);
            this.grpHome.Controls.Add(this.btnH);
            this.grpHome.Controls.Add(this.btnG);
            this.grpHome.Controls.Add(this.btnF);
            this.grpHome.Controls.Add(this.btnE);
            this.grpHome.Controls.Add(this.btnD);
            this.grpHome.Controls.Add(this.btnC);
            this.grpHome.Controls.Add(this.btnB);
            this.grpHome.Controls.Add(this.btnA);
            this.grpHome.Location = new System.Drawing.Point(8, 1);
            this.grpHome.Name = "grpHome";
            this.grpHome.Size = new System.Drawing.Size(845, 465);
            this.grpHome.TabIndex = 1;
            this.grpHome.TabStop = false;
            // 
            // btnIF
            // 
            this.btnIF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIF.BackgroundImage")));
            this.btnIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIF.Enabled = false;
            this.btnIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIF.Location = new System.Drawing.Point(652, 352);
            this.btnIF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnIF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnIF.Name = "btnIF";
            this.btnIF.Padding = new System.Windows.Forms.Padding(5);
            this.btnIF.Size = new System.Drawing.Size(185, 94);
            this.btnIF.TabIndex = 37;
            this.btnIF.Text = "I";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Visible = false;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnHF
            // 
            this.btnHF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHF.BackgroundImage")));
            this.btnHF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHF.Enabled = false;
            this.btnHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHF.Location = new System.Drawing.Point(331, 352);
            this.btnHF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnHF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnHF.Name = "btnHF";
            this.btnHF.Padding = new System.Windows.Forms.Padding(5);
            this.btnHF.Size = new System.Drawing.Size(185, 94);
            this.btnHF.TabIndex = 36;
            this.btnHF.Text = "H";
            this.btnHF.UseVisualStyleBackColor = true;
            this.btnHF.Visible = false;
            this.btnHF.Click += new System.EventHandler(this.btnHF_Click);
            // 
            // btnGF
            // 
            this.btnGF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGF.BackgroundImage")));
            this.btnGF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGF.Enabled = false;
            this.btnGF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGF.Location = new System.Drawing.Point(6, 352);
            this.btnGF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnGF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnGF.Name = "btnGF";
            this.btnGF.Padding = new System.Windows.Forms.Padding(5);
            this.btnGF.Size = new System.Drawing.Size(185, 94);
            this.btnGF.TabIndex = 35;
            this.btnGF.Text = "G";
            this.btnGF.UseVisualStyleBackColor = true;
            this.btnGF.Visible = false;
            this.btnGF.Click += new System.EventHandler(this.btnGF_Click);
            // 
            // btnFF
            // 
            this.btnFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFF.BackgroundImage")));
            this.btnFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFF.Enabled = false;
            this.btnFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFF.Location = new System.Drawing.Point(652, 181);
            this.btnFF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnFF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnFF.Name = "btnFF";
            this.btnFF.Padding = new System.Windows.Forms.Padding(5);
            this.btnFF.Size = new System.Drawing.Size(185, 94);
            this.btnFF.TabIndex = 34;
            this.btnFF.Text = "F";
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Visible = false;
            this.btnFF.Click += new System.EventHandler(this.btnFF_Click);
            // 
            // btnEF
            // 
            this.btnEF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEF.BackgroundImage")));
            this.btnEF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEF.Enabled = false;
            this.btnEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEF.Location = new System.Drawing.Point(331, 181);
            this.btnEF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnEF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnEF.Name = "btnEF";
            this.btnEF.Padding = new System.Windows.Forms.Padding(5);
            this.btnEF.Size = new System.Drawing.Size(185, 94);
            this.btnEF.TabIndex = 33;
            this.btnEF.Text = "E";
            this.btnEF.UseVisualStyleBackColor = true;
            this.btnEF.Visible = false;
            this.btnEF.Click += new System.EventHandler(this.btnEF_Click);
            // 
            // btnDF
            // 
            this.btnDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDF.BackgroundImage")));
            this.btnDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDF.Enabled = false;
            this.btnDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDF.Location = new System.Drawing.Point(6, 181);
            this.btnDF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnDF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnDF.Name = "btnDF";
            this.btnDF.Padding = new System.Windows.Forms.Padding(5);
            this.btnDF.Size = new System.Drawing.Size(185, 94);
            this.btnDF.TabIndex = 32;
            this.btnDF.Text = "D";
            this.btnDF.UseVisualStyleBackColor = true;
            this.btnDF.Visible = false;
            this.btnDF.Click += new System.EventHandler(this.btnDF_Click);
            // 
            // btnCF
            // 
            this.btnCF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCF.BackgroundImage")));
            this.btnCF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCF.Enabled = false;
            this.btnCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCF.Location = new System.Drawing.Point(652, 13);
            this.btnCF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnCF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnCF.Name = "btnCF";
            this.btnCF.Padding = new System.Windows.Forms.Padding(5);
            this.btnCF.Size = new System.Drawing.Size(185, 94);
            this.btnCF.TabIndex = 31;
            this.btnCF.Text = "C";
            this.btnCF.UseVisualStyleBackColor = true;
            this.btnCF.Visible = false;
            this.btnCF.Click += new System.EventHandler(this.btnCF_Click);
            // 
            // btnBF
            // 
            this.btnBF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBF.BackgroundImage")));
            this.btnBF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBF.Enabled = false;
            this.btnBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBF.Location = new System.Drawing.Point(331, 13);
            this.btnBF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnBF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnBF.Name = "btnBF";
            this.btnBF.Padding = new System.Windows.Forms.Padding(5);
            this.btnBF.Size = new System.Drawing.Size(185, 94);
            this.btnBF.TabIndex = 30;
            this.btnBF.Text = "B";
            this.btnBF.UseVisualStyleBackColor = true;
            this.btnBF.Visible = false;
            this.btnBF.Click += new System.EventHandler(this.btnBF_Click);
            // 
            // btnAF
            // 
            this.btnAF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAF.BackgroundImage")));
            this.btnAF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAF.Enabled = false;
            this.btnAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAF.Location = new System.Drawing.Point(6, 13);
            this.btnAF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnAF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnAF.Name = "btnAF";
            this.btnAF.Padding = new System.Windows.Forms.Padding(5);
            this.btnAF.Size = new System.Drawing.Size(185, 94);
            this.btnAF.TabIndex = 29;
            this.btnAF.Text = "A";
            this.btnAF.UseVisualStyleBackColor = true;
            this.btnAF.Visible = false;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnI
            // 
            this.btnI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnI.BackgroundImage")));
            this.btnI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(652, 351);
            this.btnI.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnI.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnI.Name = "btnI";
            this.btnI.Padding = new System.Windows.Forms.Padding(5);
            this.btnI.Size = new System.Drawing.Size(185, 94);
            this.btnI.TabIndex = 28;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnH
            // 
            this.btnH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnH.BackgroundImage")));
            this.btnH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(331, 351);
            this.btnH.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnH.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnH.Name = "btnH";
            this.btnH.Padding = new System.Windows.Forms.Padding(5);
            this.btnH.Size = new System.Drawing.Size(185, 94);
            this.btnH.TabIndex = 27;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnG
            // 
            this.btnG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnG.BackgroundImage")));
            this.btnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(6, 351);
            this.btnG.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnG.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnG.Name = "btnG";
            this.btnG.Padding = new System.Windows.Forms.Padding(5);
            this.btnG.Size = new System.Drawing.Size(185, 94);
            this.btnG.TabIndex = 26;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnF
            // 
            this.btnF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnF.BackgroundImage")));
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(652, 180);
            this.btnF.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnF.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnF.Name = "btnF";
            this.btnF.Padding = new System.Windows.Forms.Padding(5);
            this.btnF.Size = new System.Drawing.Size(185, 94);
            this.btnF.TabIndex = 25;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnE
            // 
            this.btnE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnE.BackgroundImage")));
            this.btnE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(331, 180);
            this.btnE.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnE.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnE.Name = "btnE";
            this.btnE.Padding = new System.Windows.Forms.Padding(5);
            this.btnE.Size = new System.Drawing.Size(185, 94);
            this.btnE.TabIndex = 24;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnD.BackgroundImage")));
            this.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(6, 180);
            this.btnD.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnD.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnD.Name = "btnD";
            this.btnD.Padding = new System.Windows.Forms.Padding(5);
            this.btnD.Size = new System.Drawing.Size(185, 94);
            this.btnD.TabIndex = 23;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnC.BackgroundImage")));
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(652, 12);
            this.btnC.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnC.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnC.Name = "btnC";
            this.btnC.Padding = new System.Windows.Forms.Padding(5);
            this.btnC.Size = new System.Drawing.Size(185, 94);
            this.btnC.TabIndex = 22;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnB.BackgroundImage")));
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(331, 12);
            this.btnB.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnB.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnB.Name = "btnB";
            this.btnB.Padding = new System.Windows.Forms.Padding(5);
            this.btnB.Size = new System.Drawing.Size(185, 94);
            this.btnB.TabIndex = 21;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnA.BackgroundImage")));
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(6, 12);
            this.btnA.MaximumSize = new System.Drawing.Size(300, 200);
            this.btnA.MinimumSize = new System.Drawing.Size(102, 76);
            this.btnA.Name = "btnA";
            this.btnA.Padding = new System.Windows.Forms.Padding(5);
            this.btnA.Size = new System.Drawing.Size(185, 94);
            this.btnA.TabIndex = 20;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(586, 1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(27, 27);
            this.btnUp.TabIndex = 44;
            this.btnUp.Text = "U";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "*****************BRAINIACS 2015***********(By Ananda College Commerce Society)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnF;
        internal System.Windows.Forms.GroupBox grpHome;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDF;
        private System.Windows.Forms.Button btnCF;
        private System.Windows.Forms.Button btnBF;
        private System.Windows.Forms.Button btnAF;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnHF;
        private System.Windows.Forms.Button btnGF;
        private System.Windows.Forms.Button btnFF;
        private System.Windows.Forms.Button btnEF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton optT2;
        private System.Windows.Forms.RadioButton optT1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnUp;

    }
}

