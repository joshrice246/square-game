using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace squarethingy_thang
{
    public partial class Form1 : Form
    {

        Rectangle player1 = new Rectangle(770, 280, 20, 20);
        Rectangle player2 = new Rectangle(770, 250, 20, 20);
        Rectangle point = new Rectangle(10, 270, 10, 10);
        Rectangle speedboost = new Rectangle(540, 270, 10, 10);

        int player1Score = 0;
        int player2Score = 0;

        int player1Speed = 5;
        int player2Speed = 5;

    // 816, 489      screen size

        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;

        SolidBrush blueBrush = new SolidBrush(Color.Purple);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenbrush = new SolidBrush(Color.Green);
        Pen playerbrush = new Pen(Color.White, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p1ScoreLabel.Text = $"{player1Score}";
            p2ScoreLabel.Text = $"{player2Score}";

            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(greenbrush, player2);
            e.Graphics.FillRectangle(whiteBrush, point);
            e.Graphics.FillRectangle(yellowBrush, speedboost);
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
                if (aPressed == true && player1.Y > 0)
                {
                    player1.X -= player1Speed;
                }

                if (wPressed == true && player1.Y > 0)
                {
                    player1.Y -= player1Speed;
                }

                if (dPressed == true && player1.Y > 0)
                {
                    player1.X += player1Speed;
                }

                if (sPressed == true && player1.Y < this.Height - player1.Height)
                {
                    player1.Y += player1Speed;
                }

                if (leftPressed == true && player2.Y > 0)
                {
                    player2.X -= player2Speed;
                }

                if (rightPressed == true && player2.Y > 0)
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
                    Random randGen = new Random();
                    int randomval = randGen.Next(450, 800);
                }
                else if (player2.IntersectsWith(point))
                {
                    player2Score += 1;
                    Random randGen = new Random();
                    int randomval = randGen.Next(450, 800);
                }

                //speedboost interact and move
                if (player1.IntersectsWith(speedboost))
                {
                    player1Speed += 2;
                    Random randGen = new Random();
                    int randomval = randGen.Next(450, 800);
                }
                else if (player2.IntersectsWith(speedboost))
                {
                    player2Speed += 2;
                    Random randGen = new Random();
                    int randomval = randGen.Next(450, 800);
                }

                //wait 4 seconds -3 
                if (player1Speed == 7)
                {
                    speedtimer2.Enabled = true;
                }
                else if (player2Speed == 7)
                {
                    speedtimer.Enabled = true;
                }

                if (player1Score == 5)
                {
                    gameTimer.Stop();
                }

                if (player2Score == 5)
                {
                    gameTimer.Stop();
                }

                Refresh();
            }
            catch
            {
                p1ScoreLabel.Text = $"ERROR2";
                p2ScoreLabel.Text = $"ERROR2";
            }
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
    }
    }

