using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    //описание абстрактного шарика
    class Ball
    {
        protected readonly int weight;
        protected readonly int radius;
        protected readonly Vector2D coordinate;

        public Ball(int weight, int radius, int x_coordinate, int y_coordinate)
        {
            this.weight = weight;
            this.radius = radius;
            coordinate = new Vector2D(x_coordinate, y_coordinate);
        }

        public int GetWeight() { return weight; }
        public float GetRadius() { return radius; }
        public void SetXCoordinate(int coordinate) { this.coordinate.X = coordinate; }
        public void SetYCoordinate(int coordinate) { this.coordinate.Y = coordinate; }
        public int GetXCoordinate() { return coordinate.X; }
        public int GetYCoordinate() { return coordinate.Y; }

        public bool IsIntersectWithBall(Ball ball)
        {
            if (coordinate.Distance(ball.coordinate) <= (radius + ball.radius)* (radius + ball.radius))
            {
                return true;
            }
            return false;
        }
    }
}

