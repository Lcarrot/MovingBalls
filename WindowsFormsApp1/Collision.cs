using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Collision
    {

        public static void CheckAndFixCollisionWithBoarders(MovableBall ball, int height, int width)
        {
            if (ball.GetXCoordinate() < 0 || ball.GetXCoordinate() > width)
            {
                ball.SetXSpeed(ball.GetXSpeed() * -1);
            }
            if (ball.GetYCoordinate() < 0 || ball.GetYCoordinate() > height)
            {
                ball.SetYSpeed(ball.GetYSpeed() * -1);
            }
        }

        public static void CheckAndFixCollisionAmongBalls(MovableBall[] balls, int lastIndex)
        {
            for (int i = 0; i < lastIndex - 1; i++)
            {
                for (int k = i+1; k < lastIndex; k++)
                {
                    if (balls[i].IsIntersectWithBall(balls[k]))
                    {
                        SetCoordinates(balls[i], balls[k]);
                    }
                }
            }
        }

        private static int SetCoordinates(MovableBall ball1, MovableBall ball2)
        {
            // меняем скорость по x
            Console.WriteLine("start to calculate");
            int speed = ball1.GetXSpeed();
            ball1.SetXSpeed(((ball1.GetWeight() - ball2.GetWeight())*ball1.GetXSpeed()+2*ball2.GetWeight()*ball2.GetXSpeed())
                /(ball1.GetWeight() + ball2.GetWeight()));
            ball2.SetXSpeed(((ball2.GetWeight() - ball1.GetWeight()) * ball2.GetXSpeed() + 2*ball1.GetWeight() * speed)
                / (ball1.GetWeight() + ball2.GetWeight()));
            // меняем скорость по y
            speed = ball1.GetYSpeed();
            ball1.SetYSpeed(((ball1.GetWeight() - ball2.GetWeight()) * ball1.GetYSpeed() + 2 * ball2.GetWeight() * ball2.GetYSpeed())
                / (ball1.GetWeight() + ball2.GetWeight()));
            ball2.SetYSpeed(((ball2.GetWeight() - ball1.GetWeight()) * ball2.GetYSpeed() + 2 * ball1.GetWeight() * speed)
                / (ball1.GetWeight() + ball2.GetWeight()));
            return speed;
        }
    }
}
