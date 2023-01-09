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
        public int X; // координата X центра эмиттера
        public int Y; // координата Y центра эмиттера
        public int Direction = 0; // вектор направления в градусах куда эмиттер выпускает частицы
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы
        public int ParticlePerTick = 5; //создаваемые частицы за один тик таймера
        
        public Color ColorFrom = Color.SteelBlue; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Red); // конечный цвет частиц

        public virtual void UpdateState() // метод обновления частиц эмиттера
        {
            int particleToCreate = ParticlePerTick;

            foreach (var particle in particles)
            {
                if (particle.Life <= 0)
                {
                    if (particleToCreate > 0)
                    {
                        particleToCreate -= 1;
                        particle.FromColor = ColorFrom;
                        particle.ToColor = ColorTo;
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

        public virtual void ResetParticle(Particle particle) // метод обновления одной частицы
        {
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;
            particle.Life = Particle.random.Next(LifeMin, LifeMax);
            particle.X = X;
            particle.Y = Y;

            var direction = Direction + (double)Particle.random.Next(Spreading) - Spreading/2;
            var speed = 1 + Particle.random.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = 2 + Particle.random.Next(RadiusMin, RadiusMax);

        }

        public virtual void Render(Graphics g) // метод рисовки графики частиц
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

        public virtual Particle CreateParticle() // метод создания частиц
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;
            return particle;
        }
    }
}
