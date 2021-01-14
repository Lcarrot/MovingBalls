using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Add(Vector2D vector)
        {
            this.X += vector.X;
            this.Y += vector.Y;
        }

        public int Distance(Vector2D vector)
        {
            return (this.X - vector.X) * (this.X - vector.X) + (this.Y - vector.Y) * (this.Y - vector.Y);
        }
    }
}
