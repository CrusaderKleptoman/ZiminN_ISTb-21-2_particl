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
        int miliseconds = 120000;
        List<Emitter> emitters = new List<Emitter>();
        List<RepaintZone> repaintZones = new List<RepaintZone>();
        RepaintZone repaintZone;
        DieZone dieZone;
        
        CircleEmitter circleEmitter;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            

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
                X = pictureBox1.Width / 2,
                Y = pictureBox1.Height / 2 - pictureBox1.Height / 3,

            };
            emitters.Add(this.circleEmitter);

            this.repaintZone = new RepaintZone
            {
                color = Color.Gold,
                Radius = 100,
                X = pictureBox1.Width / 2,
                Y = pictureBox1.Height / 2
            };

            this.dieZone = new DieZone
            {
                Color = Color.Red,
                Radius = 50,
                X = pictureBox1.Width / 2,
                Y = pictureBox1.Height / 2 + pictureBox1.Height / 4
            };

            foreach (var emitter in emitters)
            {
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
            miliseconds -= 40;
            labelTimer.Text = $"Таймер {miliseconds / 1000 / 60}:{miliseconds / 1000 % 60}";
            labelParticleAmount.Text = $"Количество частиц: {particleAmount()}";
            if (miliseconds <= 0)
            {
                timer1.Stop();
                MessageBox.Show(
                    $"Собранные очки = {dieZone.amount}",
                    "Игра закончена");
            }
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelParticleAmount_Click(object sender, EventArgs e)
        {

        }

        private void trackBarLife_Scroll(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.LifeMax = trackBarLife.Value;
                labelParticleMaxLife.Text = $"Максимальная жизнь частиц: {emitter.LifeMax}";
            }
        }

        private void trackBarTic_Scroll(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.ParticlePerTick = trackBarTic.Value;
                labelParticlePerTic.Text = $"Кол-во создаваемых частиц за тик: {emitter.ParticlePerTick}";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBarCircleEmitterDirection_Scroll(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                if(emitter is CircleEmitter)
                {
                    if (trackBarCircleEmitterDirection.Value == 0)
                    { 
                        (emitter as CircleEmitter).DirectionSpeed = ((emitter as CircleEmitter).DirectionSpeed) * (-1);
                        labelCircleEmitterDirection.Text = "Направление кругового эмиттера: против часовой";
                    }
                    else
                    { 
                        (emitter as CircleEmitter).DirectionSpeed = Math.Abs(((emitter as CircleEmitter).DirectionSpeed));
                        labelCircleEmitterDirection.Text = "Направление кругового эмиттера: по часовой";
                    }
                }
            }
        }

        private void trackBarDieZonePosition_Scroll(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                dieZone.X = pictureBox1.Width / 100 * trackBarDieZonePosition.Value;               
            }
            labelDieZonePosition.Text = $"Положение DieZone: {dieZone.X}";
        }

        private void labelDieZonePosition_Click(object sender, EventArgs e)
        {

        }

        private void labelParticlePerTic_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRepaintZonePosition_Scroll(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                repaintZone.X = pictureBox1.Width / 100 * trackBarRepaintZonePosition.Value;
            }
            labelRepaintZonePosition.Text = $"Положение RepaintZone: {repaintZone.X}";
        }
    }
}
