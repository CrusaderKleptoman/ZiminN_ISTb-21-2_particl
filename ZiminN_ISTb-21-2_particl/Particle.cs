using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiminN_ISTb_21_2_particl
{
    internal class Particle
    {
        public float Life;
        public int Radius;
        public float X;
        public float Y;
        public float Direction;
        public float Speed;
        public static Random random = new Random();

        public Particle()
        {
            Direction = random.Next(360);
            Speed = 1 + random.Next(10);
            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public void Draw(Graphics g)
        {
            float koef = Math.Min(1f, Life / 100);
            int alpha = (int)(koef * 255);
            var color = Color.FromArgb(alpha, Color.Black);

            var brush = new SolidBrush(color);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }
    }
}
