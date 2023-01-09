using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiminN_ISTb_21_2_particl.MyParticle
{
    internal class DieZone : IImpactPoint //класс зоны при попадании в которую частицы умирают и увеличивается счётчик зоны
    {
        public Color Color = Color.DarkBlue;
        public int amount = 0;
        public override void ImpactParticle(Particle particle) //метод проверяющий пересечение с частицами и то, перекрашены ли они
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r < Radius / 2)
            {
                if (particle.FromColor == Color.Gold)
                {
                    amount += 5;
                }
                else
                {
                    amount++;
                }
                particle.FromColor = Color.White;
                particle.ToColor = Color.White;
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
