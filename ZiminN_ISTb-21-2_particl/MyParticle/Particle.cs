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
        public float SpeedX;
        public float SpeedY;
        public static Random random = new Random();


        public Particle()
        {
            var direction = (double)random.Next(360);
            var speed = 1 + random.Next(10);

            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public virtual void Draw(Graphics g)
        {
            float koef = Math.Min(1f, Life / 100);
            int alpha = (int)(koef * 255);
            var color = Color.FromArgb(alpha, Color.Black);

            var brush = new SolidBrush(color);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public class ParticleColorful : Particle
        {
            public Color FromColor;
            public Color ToColor;

            public static Color MixColor(Color color1, Color color2, float koef)
            {
                return Color.FromArgb(
                    (int)(color2.A * koef + color1.A * (1 - koef)),
                    (int)(color2.R * koef + color1.R * (1 - koef)),
                    (int)(color2.G * koef + color1.G * (1 - koef)),
                    (int)(color2.B * koef + color1.B * (1 - koef))
                    );
            }

            public override void Draw(Graphics g)
            {
                float koef = Math.Min(1f, Life / 100);
                koef = Math.Max(0, koef);
                var color = MixColor(ToColor, FromColor, koef);

                var brush = new SolidBrush(color);
                g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
                brush.Dispose();

            }
        }
    }
}
