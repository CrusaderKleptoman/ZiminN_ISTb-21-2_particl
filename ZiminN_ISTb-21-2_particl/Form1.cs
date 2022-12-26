using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiminN_ISTb_21_2_particl
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for(int i = 0; i < 500; i++)
            {
                var particle = new Particle();
                particle.X = pictureBox1.Image.Width / 2;
                particle.Y = pictureBox1.Image.Height / 2;
                particles.Add(particle);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState();

            using(var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
                Render(g);
            }
            pictureBox1.Invalidate();

        }

        private void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life--;
                if (particle.Life <= 0)
                {
                    particle.Life = 20 + Particle.random.Next(100);
                    particle.X = pictureBox1.Image.Width / 2;
                    particle.Y = pictureBox1.Image.Height / 2;
                    particle.Direction = Particle.random.Next(360);
                    particle.Speed = 1 + Particle.random.Next(10);
                    particle.Radius = 2 + Particle.random.Next(10);
                }
                else
                {
                    var directionInRadius = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadius));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadius));
                }
            }
        }

        private void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }
    }
}
