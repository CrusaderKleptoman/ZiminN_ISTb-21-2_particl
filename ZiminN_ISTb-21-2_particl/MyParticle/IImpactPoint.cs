using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ZiminN_ISTb_21_2_particl.Particle;

namespace ZiminN_ISTb_21_2_particl
{
    internal abstract class IImpactPoint
    {
        public float X;
        public float Y;
        public Color color = Color.PaleVioletRed;
        public float Radius;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(color),
                    X - Radius / 2,
                    Y - Radius / 2,
                    Radius,
                    Radius
                );
        }
    }
}
