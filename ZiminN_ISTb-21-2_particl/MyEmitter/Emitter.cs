using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ZiminN_ISTb_21_2_particl.Particle;

namespace ZiminN_ISTb_21_2_particl
{
    internal class Emitter
    {
        public List<Particle> particles = new List<Particle>();
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();
        public int MousePositionX;
        public int MousePositionY;
        public float GravitationX = 0;
        public float GravitationY = 1;
        public int ParticlesCount = 500;
        public int X;
        public int Y;
        public int Direction = 0;
        public int Spreading = 360;
        public int SpeedMin = 1;
        public int SpeedMax = 10;
        public int RadiusMin = 2;
        public int RadiusMax = 10;
        public int LifeMin = 20;
        public int LifeMax = 100;
        public int ParticlePerTick = 5;

        public Color ColorFrom = Color.SteelBlue;
        public Color ColorTo = Color.FromArgb(0, Color.Red);

        public virtual void UpdateState()
        {
            int particleToCreate = ParticlePerTick;

            foreach (var particle in particles)
            {
                if (particle.Life <= 0)
                {
                    if (particleToCreate > 0)
                    {
                        particleToCreate -= 1;
                        ResetParticle(particle);
                    }
                    
                }
                else
                {
                    particle.Life--;
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                }
            }

            while(particleToCreate >= 1)
            {
                particleToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
            
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = 20 + Particle.random.Next(LifeMin, LifeMax);
            particle.X = X;
            particle.Y = Y;

            var direction = Direction + (double)Particle.random.Next(Spreading) - Spreading/2;
            var speed = 1 + Particle.random.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = 2 + Particle.random.Next(RadiusMin, RadiusMax);
        }

        public virtual void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }

        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;
            return particle;
        }
    }
}
