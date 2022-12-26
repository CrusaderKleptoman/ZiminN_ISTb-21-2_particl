using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiminN_ISTb_21_2_particl.MyParticle
{
    internal class TopEmitter : Emitter
    {
        public int Width;

        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle);

            particle.X = Particle.random.Next(Width);
            particle.Y = 0;

            particle.SpeedX = Particle.random.Next(-2, 2);
            particle.SpeedY = 1;
        }
    }
}
