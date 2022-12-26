using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ZiminN_ISTb_21_2_particl.Particle;

namespace ZiminN_ISTb_21_2_particl.MyParticle
{
    internal class RepaintZone : IImpactPoint
    {
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r < Radius / 2)
            {
                particle.FromColor = color;
                particle.ToColor = color;
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                    new Pen(color, 5),
                    X - Radius / 2,
                    Y - Radius / 2,
                    Radius,
                    Radius
                );
        }

    }
}
