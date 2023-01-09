using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiminN_ISTb_21_2_particl.MyEmitter
{
    internal class CircleEmitter : Emitter
    {
        public int Radius = 100;
        public bool MovingRight;
        public int MovingAmount;
        public int DirectionSpeed;
        public override void ResetParticle(Particle particle)
        {
            particle.Life = 20 + Particle.random.Next(LifeMin, LifeMax);
            var direction = Direction + (double)Particle.random.Next(Spreading) - Spreading / 2;

            particle.X = (float)(X + Radius * Math.Cos(direction / 180 * Math.PI) / 2);
            particle.Y = (float)(Y + Radius * Math.Sin(direction / 180 * Math.PI) / 2);
            var speed = Particle.random.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);
            
            particle.Radius = Particle.random.Next(RadiusMin, RadiusMax);

        }
        public override void UpdateState()
        {
            base.UpdateState();
            if(MovingRight)
            {
                X += 5;
                MovingAmount += 5;
            }
            else
            {
                X -= 5;
                MovingAmount -= 5;
            }
            if (MovingAmount == 300)
            {
                MovingRight = false;
            }
            if (MovingAmount == -300)
            {
                MovingRight = true;
            }
            Direction += DirectionSpeed;
        }
        public override void Render(Graphics g)
        {
            base.Render(g);
            g.DrawEllipse(
                           new Pen(Color.Red),
                           X - Radius / 2,
                           Y - Radius / 2,
                           Radius,
                           Radius
                       );
        }
    }
}
