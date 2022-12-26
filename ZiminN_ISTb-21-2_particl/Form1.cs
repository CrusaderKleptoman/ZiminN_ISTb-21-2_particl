using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiminN_ISTb_21_2_particl.MyParticle;
using static ZiminN_ISTb_21_2_particl.Particle;

namespace ZiminN_ISTb_21_2_particl
{
    public partial class Form1 : Form
    {
        Emitter emitter;
        public Form1()
        {
            InitializeComponent();

            emitter = new TopEmitter { Width = pictureBox1.Width, GravitationY = 0.25f};

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            emitter.impactPoints.Add(new AntiGravityPoint { X = pictureBox1.Width / 2, Y = pictureBox1.Height / 2 });
            emitter.impactPoints.Add(new GravityPoint { X = (float)(pictureBox1.Width * 0.25), Y = pictureBox1.Height / 2 });

            emitter.impactPoints.Add(new GravityPoint { X = (float)(pictureBox1.Width * 0.75), Y = pictureBox1.Height / 2 });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using(var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }
            pictureBox1.Invalidate();

        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X; emitter.MousePositionY = e.Y;
        }
    }
}
