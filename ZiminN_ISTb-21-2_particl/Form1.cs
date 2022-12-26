using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZiminN_ISTb_21_2_particl.Particle;

namespace ZiminN_ISTb_21_2_particl
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState();

            using(var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Black);
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
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    var direction = (double)Particle.random.Next(360);
                    var speed = 1 + Particle.random.Next(10);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

                    particle.Radius = 2 + Particle.random.Next(10);
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y -= particle.SpeedY;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (particles.Count < 500)
                {
                    var particle = new ParticleColorful();
                    particle.FromColor = Color.SteelBlue;
                    particle.ToColor = Color.FromArgb(0, Color.PaleVioletRed);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particles.Add(particle);

                }
                else { break; }
            }
        }

        private void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        private int MousePositionX = 0;
        private int MousePositionY = 0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionX = e.X; MousePositionY = e.Y;
        }
    }
}
