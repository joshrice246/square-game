﻿namespace squarethingy_thang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.speedtimer = new System.Windows.Forms.Timer(this.components);
            this.speedtimer2 = new System.Windows.Forms.Timer(this.components);
            this.hp2 = new System.Windows.Forms.Label();
            this.hp1 = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.hurt1 = new System.Windows.Forms.Timer(this.components);
            this.hurt2 = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Timer(this.components);
            this.speed = new System.Windows.Forms.Timer(this.components);
            this.text = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.p2ScoreLabel, "p2ScoreLabel");
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.p1ScoreLabel, "p1ScoreLabel");
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // speedtimer
            // 
            this.speedtimer.Interval = 4000;
            this.speedtimer.Tick += new System.EventHandler(this.speedtimer_Tick);
            // 
            // speedtimer2
            // 
            this.speedtimer2.Interval = 4000;
            this.speedtimer2.Tick += new System.EventHandler(this.speedtimer2_Tick);
            // 
            // hp2
            // 
            this.hp2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.hp2, "hp2");
            this.hp2.ForeColor = System.Drawing.Color.White;
            this.hp2.Name = "hp2";
            // 
            // hp1
            // 
            this.hp1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.hp1, "hp1");
            this.hp1.ForeColor = System.Drawing.Color.White;
            this.hp1.Name = "hp1";
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gameover, "gameover");
            this.gameover.ForeColor = System.Drawing.Color.White;
            this.gameover.Name = "gameover";
            // 
            // hurt1
            // 
            this.hurt1.Interval = 3000;
            this.hurt1.Tick += new System.EventHandler(this.hurt1_Tick);
            // 
            // hurt2
            // 
            this.hurt2.Interval = 3000;
            this.hurt2.Tick += new System.EventHandler(this.hurt2_Tick);
            // 
            // screen
            // 
            this.screen.Interval = 500;
            this.screen.Tick += new System.EventHandler(this.screen_Tick);
            // 
            // speed
            // 
            this.speed.Interval = 500;
            this.speed.Tick += new System.EventHandler(this.speed_Tick);
            // 
            // text
            // 
            this.text.Interval = 500;
            this.text.Tick += new System.EventHandler(this.text_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer speedtimer;
        private System.Windows.Forms.Timer speedtimer2;
        private System.Windows.Forms.Label hp2;
        private System.Windows.Forms.Label hp1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Timer hurt1;
        private System.Windows.Forms.Timer hurt2;
        private System.Windows.Forms.Timer screen;
        private System.Windows.Forms.Timer speed;
        private System.Windows.Forms.Timer text;
    }
}

