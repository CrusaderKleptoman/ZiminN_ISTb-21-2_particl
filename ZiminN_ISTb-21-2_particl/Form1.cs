using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiminN_ISTb_21_2_particl.MyEmitter;
using ZiminN_ISTb_21_2_particl.MyParticle;
using static ZiminN_ISTb_21_2_particl.Particle;

namespace ZiminN_ISTb_21_2_particl
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        List<RepaintZone> repaintZones = new List<RepaintZone>();
        RepaintZone repaintZone;
        DieZone dieZone;
        Emitter emitter;
        CircleEmitter circleEmitter;
        GravityPoint point1;
        GravityPoint point2;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 2,
                SpeedMax = 10,
                ColorFrom = Color.SteelBlue,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlePerTick = 10,
                X = pictureBox1.Width / 4,
                Y = pictureBox1.Height / 2,
            };

            this.circleEmitter = new CircleEmitter
            {
                Direction = 0,
                Spreading = 1,
                SpeedMin = 2,
                SpeedMax = 10,
                ColorFrom = Color.SteelBlue,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlePerTick = 50,
                DirectionSpeed = 5,
                X = pictureBox1.Width / 2 + pictureBox1.Width / 4,
                Y = pictureBox1.Height / 2,

            };
            emitters.Add(this.emitter);
            emitters.Add(this.circleEmitter);

            this.repaintZone = new RepaintZone
            {
                color = Color.Gold,
                Radius = 100,
                X = pictureBox1.Width / 2 + pictureBox1.Width / 4 + 50,
                Y = pictureBox1.Height / 2 + pictureBox1.Height / 4
            };

            this.dieZone = new DieZone
            {
                Color = Color.Red,
                Radius = 50,
                X = pictureBox1.Width / 2,
                Y = pictureBox1.Height / 2 + pictureBox1.Height / 4
            };

            point1 = new GravityPoint
            {
                X = pictureBox1.Width / 2 + 100,
                Y = pictureBox1.Height / 2
            };

            point2 = new GravityPoint
            {
                X = pictureBox1.Width / 2 - 100,
                Y = pictureBox1.Height / 2
            };

            foreach (var emitter in emitters)
            {
                emitter.impactPoints.Add(point1);
                emitter.impactPoints.Add(point2);
                emitter.impactPoints.Add(repaintZone);
                emitter.impactPoints.Add(dieZone);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
            }
            foreach (var emitter in emitters)
            {
                emitter.UpdateState();
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    emitter.Render(g);
                }
            }
            
            labelParticleAmount.Text = $"Количество частиц: {particleAmount()}";
            pictureBox1.Invalidate();

        }

        private int particleAmount()
        {
            int amount = 0;
            foreach (var emitter in emitters)
            {
                foreach (var particle in emitter.particles)
                {
                    if (particle.Life > 0)
                    {
                        amount++;
                    }
                }
                
            }
            return amount;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X; emitter.MousePositionY = e.Y;
            }

            point1.X = e.X;
            point1.Y = e.Y;
        }

        private void trackBarDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = trackBarDirection.Value;
            labelDirection.Text = $"{trackBarDirection.Value}°";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarGraviton_Scroll(object sender, EventArgs e)
        {
            point1.Power = trackBarGraviton1.Value;
            labelGraviton1.Text = $"{trackBarGraviton1.Value}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBarGraviton2_Scroll(object sender, EventArgs e)
        {
            point2.Power = trackBarGraviton2.Value;
            labelGraviton2.Text = $"{trackBarGraviton2.Value}";
        }

        private void labelParticleAmount_Click(object sender, EventArgs e)
        {

        }

        private void trackBarLife_Scroll(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.LifeMax = trackBarLife.Value;
            }
        }

        private void trackBarTic_Scroll(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.ParticlePerTick = trackBarTic.Value;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            dieZone = new DieZone
            {
                Color = Color.Red,
                Radius = 50,
                X = e.X,
                Y = e.Y
            };
            foreach (var emitter in emitters)
            {
                emitter.impactPoints.Add(dieZone);
            }
        }
    }
}
