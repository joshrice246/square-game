using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace squarethingy_thang
{
    public partial class Form1 : Form
    {

        Rectangle player1 = new Rectangle(770, 280, 20, 20);
        Rectangle player2 = new Rectangle(770, 250, 20, 20);
        Rectangle point;
        Rectangle speedboost;
        Rectangle hurtbox;
        Rectangle hurtbox2;
        Rectangle hurtbox3;
        Rectangle hurtbox4;
        Rectangle hurtbox5; 
        Random randgen = new Random();

        int player1Score = 0;
        int player2Score = 0;
        int random;
        int player1Speed = 5;
        int player2Speed = 5;
        int p1HP = 3;
        int p2Hp = 3;
        // 816, 489      screen size


        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;
        bool spawn = false;
        bool spawn2 = false;

        SolidBrush blueBrush = new SolidBrush(Color.Purple);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenbrush = new SolidBrush(Color.Green);
        SolidBrush hurt = new SolidBrush(Color.Red);
        Pen playerbrush = new Pen(Color.White, 1);

        public Form1()
        {
            InitializeComponent();
            int x = randgen.Next(0, this.Width - 20);
            int y = randgen.Next(0, this.Height - 20);

            int a = randgen.Next(0, this.Width - 20);
            int b = randgen.Next(0, this.Height - 20);

            int c = randgen.Next(0, this.Width - 20);
            int d = randgen.Next(0, this.Height - 20);

            int e = randgen.Next(0, this.Width - 20);
            int f = randgen.Next(0, this.Height - 20);

            int g = randgen.Next(0, this.Width - 20);
            int h = randgen.Next(0, this.Height - 20);

            int k = randgen.Next(0, this.Width - 20);
            int j = randgen.Next(0, this.Height - 20);

            int l = randgen.Next(0, this.Width - 20);
            int m = randgen.Next(0, this.Height - 20);

            speedboost = new Rectangle (x,y,10,10);

           point = new Rectangle(a, b, 10, 10);

            hurtbox = new Rectangle(c, d, 10, 10);

          hurtbox2 = new Rectangle(e, f, 10, 10);

            hurtbox3 = new Rectangle(g, h, 10, 10);

            hurtbox4 = new Rectangle(k, j, 10, 10);

            hurtbox5 = new Rectangle(l, m, 10, 10);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p1ScoreLabel.Text = $"{player1Score}";
            p2ScoreLabel.Text = $"{player2Score}";

            hp1.Text = $"HP = {p2Hp}";
            hp2.Text = $"HP = {p1HP}";


            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(greenbrush, player2);
            e.Graphics.FillRectangle(whiteBrush, point);
            e.Graphics.FillRectangle(yellowBrush, speedboost);
            e.Graphics.FillRectangle(hurt, hurtbox);
            e.Graphics.FillRectangle(hurt, hurtbox2);
            e.Graphics.FillRectangle(hurt, hurtbox3);
            e.Graphics.FillRectangle(hurt, hurtbox4);
            e.Graphics.FillRectangle(hurt, hurtbox5);


        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
           
            try
            {
                if (aPressed == true && player1.X > 0)
                {
                    player1.X -= player1Speed;
                }

                if (wPressed == true && player1.Y > 0)
                {
                    player1.Y -= player1Speed;
                }

                if (dPressed == true && player1.X < this.Width - player1.Width)
                {
                    player1.X += player1Speed;
                }

                if (sPressed == true && player1.Y < this.Height - player1.Height)
                {
                    player1.Y += player1Speed;
                }




                if (leftPressed == true && player2.X > 0)
                {
                    player2.X -= player2Speed;
                }

                if (rightPressed == true && player2.X < this.Width - player2.Width)
                {
                    player2.X += player2Speed;
                }

                if (upPressed == true && player2.Y > 0)
                {
                    player2.Y -= player2Speed;
                }

                if (downPressed == true && player2.Y < this.Height - player2.Height)
                {
                    player2.Y += player2Speed;
                }


                //borders
                if (player1.Height <= 0)
                {

                }
                else if (player1.Height >= 20)
                {

                }

                if (player2.Height <= 0)
                {

                }
                else if (player2.Height >= 20)
                {

                }

            }
            catch
            {
                p1ScoreLabel.Text = $"ERROR";
                p2ScoreLabel.Text = $"ERROR";
            }


            try
            {
                //win point interact and move 
                if (player1.IntersectsWith(point))
                {
                    player1Score += 1;
                }
                else if (player2.IntersectsWith(point))
                {
                    player2Score += 1;
                }

                //speedboost interact and move
                if (player1.IntersectsWith(speedboost))
                {
                    player1Speed += 2;
                }
                else if (player2.IntersectsWith(speedboost))
                {
                    player2Speed += 2;
                }


                if (player2.IntersectsWith(hurtbox))
                {
                    p2Hp -= 1;
                }
                else if (player1.IntersectsWith(hurtbox))
                {
                    p1HP -= 1;
                }

                if (player2.IntersectsWith(hurtbox2))
                {
                    p2Hp -= 1;
                }
                else if (player1.IntersectsWith(hurtbox2))
                {
                    p1HP -= 1;
                }

                if (player2.IntersectsWith(hurtbox3))
                {
                    p2Hp -= 1;
                }
                else if (player1.IntersectsWith(hurtbox3))
                {
                    p1HP -= 1;
                }

                if (player2.IntersectsWith(hurtbox4))
                {
                    p2Hp -= 1;
                }
                else if (player1.IntersectsWith(hurtbox4))
                {
                    p1HP -= 1;
                }

                if (player2.IntersectsWith(hurtbox5))
                {
                    p2Hp -= 1;
                }
                else if (player1.IntersectsWith(hurtbox5))
                {
                    p1HP -= 1;
                }

                if (player1.IntersectsWith(point))
                {
                    point.Y = randgen.Next(this.Height - 100);
                    point.X = randgen.Next(5, 200);
                }

                if (player2.IntersectsWith(point))
                {
                    point.Y = randgen.Next(this.Height - 100);
                    point.X = randgen.Next(5, 200);
                }

                if (player1.IntersectsWith(speedboost))
                {
                    speedboost.Y = randgen.Next(this.Height - 100);
                    speedboost.X = randgen.Next(5, 200);
                }

                if (player2.IntersectsWith(speedboost))
                {
                    speedboost.Y = randgen.Next(this.Height - 100);
                    speedboost.X = randgen.Next(5, 200);
                }

                if (player1.IntersectsWith(hurtbox))
                {
                    hurtbox.Y = randgen.Next(this.Height - 100);
                    hurtbox.X = randgen.Next(5, 200);
                }

                if (player2.IntersectsWith(hurtbox))
                {
                    hurtbox.Y = randgen.Next(this.Height - 100);
                    hurtbox.X = randgen.Next(5, 200);
                }


                if (player1.IntersectsWith(hurtbox2))
                {
                    hurtbox2.Y = randgen.Next(this.Height - 100);
                    hurtbox2.X = randgen.Next(5, 200);
                }

                if (player2.IntersectsWith(hurtbox2))
                {
                    hurtbox2.Y = randgen.Next(this.Height - 100);
                    hurtbox2.X = randgen.Next(5, 200);
                }


                if (player1.IntersectsWith(hurtbox3))
                {
                    hurtbox3.Y = randgen.Next(this.Height - 100);
                    hurtbox3.X = randgen.Next(5, 200);
                }

                if (player2.IntersectsWith(hurtbox3))
                {
                    hurtbox3.Y = randgen.Next(this.Height - 100);
                    hurtbox3.X = randgen.Next(5, 200);
                }


                if (player1.IntersectsWith(hurtbox4))
                {
                    hurtbox4.Y = randgen.Next(this.Height - 100);
                    hurtbox4.X = randgen.Next(5, 200);
                }

                if (player2.IntersectsWith(hurtbox4))
                {
                    hurtbox4.Y = randgen.Next(this.Height - 100);
                    hurtbox4.X = randgen.Next(5, 200);
                }



                if (player1.IntersectsWith(hurtbox5))
                {
                    hurtbox5.Y = randgen.Next(this.Height - 100);
                    hurtbox5.X = randgen.Next(5, 200);
                }

                if (player2.IntersectsWith(hurtbox5))
                {
                    hurtbox5.Y = randgen.Next(this.Height - 100);
                    hurtbox5.X = randgen.Next(5, 200);
                }

                //reset on death
                if (p1HP == 0 && spawn == false)
                {
                    player1Speed = 1;
                    spawn = true;
                    hurt1.Enabled = true;
                    screen.Enabled = true;
                }
                else if (p2Hp == 0 && spawn == false)
                {
                    player2Speed = 1;
                    spawn2 = true;
                    hurt2.Enabled = true;
                    screen.Enabled = true;

                }



                //wait 4 seconds -3 
                if (player1Speed == 7)
                {
                    speedtimer2.Enabled = true;
                    speed.Enabled = true;
                }
                else if (player2Speed == 7)
                {
                    speedtimer.Enabled = true;
                    speed.Enabled = true;

                }

                //speed cap
                if (player1Speed == 9)
                {
                    player1Speed -= 2;
                }
                else if (player2Speed == 9)
                {
                    player2Speed -= 2;

                }


                if (player1Score == 5)
                {
                    gameover.Text = $"GAME OVER\n player1 wins";
                }
                if (player2Score == 5)
                {
                    gameover.Text = $"GAME OVER\n player2 wins";

                }





                if (player1Score == 5)
                {
                    gameTimer.Stop();
                }

                if (player2Score == 5)
                {
                    gameTimer.Stop();
                }


            }
            catch
            {
                p1ScoreLabel.Text = $"ERROR2";
                p2ScoreLabel.Text = $"ERROR2";
            }
            Refresh();
        }
    

        private void speedtimer_Tick(object sender, EventArgs e)
        {
            speedtimer.Enabled = false;

            if(speedtimer.Enabled == false)
            {
                player2Speed -= 3;
               
            }
            else
            {

            }
            
           
        }

        private void speedtimer2_Tick(object sender, EventArgs e)
        {
            speedtimer2.Enabled = false;

            if (speedtimer2.Enabled == false)
            {
                player1Speed -= 3;

            }
            else
            {

            }

            
        }

        private void hurt1_Tick(object sender, EventArgs e)
        {
            hurt1.Enabled = false;
            if (spawn == true)
            {
                p1HP += 3;
                player1Speed += 4;
                spawn = false;
            }
            else
            {

            }
        }
    

        private void hurt2_Tick(object sender, EventArgs e)
        {
            hurt2.Enabled = false;
            if (spawn2 == true)
            {
                p2Hp += 3;
                player2Speed += 4;
                spawn2 = false;
            }
            else
            {

            }
        }

        private void screen_Tick(object sender, EventArgs e)
        {
            screen.Enabled = false;
            gameover.Text = $"SLOW DOWN";
            text.Enabled = true;
        }

        private void speed_Tick(object sender, EventArgs e)
        {
            speed.Enabled = false;
            gameover.Text = $"SPEED BUFFED";
            text.Enabled = true;
        }

        private void text_Tick(object sender, EventArgs e)
        {
            text.Enabled = false;
            gameover.Text = $"";
        }
    }
    }

