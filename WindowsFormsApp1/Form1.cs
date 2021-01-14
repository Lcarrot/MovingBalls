using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private readonly MovableBall[] balls = new MovableBall[50];
        private readonly Pen blackPen = new Pen(Color.Black, 5);
        private int lastPoint = 0;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.AllPaintingInWmPaint 
                | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Draw ellipse to screen.
            Graphics g = e.Graphics;
            Collision.CheckAndFixCollisionAmongBalls(balls, lastPoint);
            for (int i = 0; i < lastPoint; i++)
            {
                Collision.CheckAndFixCollisionWithBoarders(balls[i], panel1.Height, panel1.Width);
                DrawBall(balls[i], g);
            }
        }

        private void CreateBallClick(object sender, EventArgs e)
        {
            CreateNewBall();
            Console.WriteLine("click");
        }

        private void CreateNewBall()
        {
            balls[lastPoint++] = new MovableBall(Convert.ToInt32(weight.Text), Convert.ToInt32(radius.Text),
                    Convert.ToInt32(n_speed.Text), Convert.ToInt32(t_speed.Text), 0, 0);
            Console.WriteLine("creating new Ball");
        }

        private void DrawBall(MovableBall ball, Graphics graphics)
        {
            RectangleF rect = new RectangleF(ball.GetXCoordinate(), ball.GetYCoordinate(), ball.GetRadius(), ball.GetRadius());
            graphics.DrawEllipse(blackPen, rect);
            ball.Move();
        }

        private void InputOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (!(Char.IsDigit(symbol) || symbol == 8))
            {
                e.Handled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
