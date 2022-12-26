using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiminN_ISTb_21_2_particl.MyParticle
{
    internal class DieZone : IImpactPoint
    {
        public Color Color = Color.DarkBlue;
        public int amount = 0;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r < Radius / 2)
            {
                amount++;
                particle.Life = 0;
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                    new Pen(color, 3),
                    X - Radius / 2,
                    Y - Radius / 2,
                    Radius,
                    Radius
                );

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(
            $"{amount}",
            new Font("Verdana", 10),
            new SolidBrush(Color.Black),
            X,
            Y,
            stringFormat
        );
        }
    }
}
