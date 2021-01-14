using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    // класс для описания шарика, двугающегося в 2-мерной плоскости
    class MovableBall : Ball, IMovable
    {
        private readonly Vector2D speed;

        public MovableBall(int weight, int radius, int n_speed, int t_speed, int x_coordinate, int y_coordinate) : base(weight, radius, x_coordinate, y_coordinate)
        {

            speed = new Vector2D(n_speed, t_speed);
        }
        public int GetXSpeed() { return speed.X; }
        public int GetYSpeed() { return speed.Y; }
        public void SetXSpeed(int speed) { this.speed.X = speed; }
        public void SetYSpeed(int speed) { this.speed.Y = speed; }


        public void Move() // смещение координаты на новую координту путём прибавления скорости
        {
            coordinate.Add(speed);
        }
    }
}
