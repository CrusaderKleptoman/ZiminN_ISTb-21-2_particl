namespace ZiminN_ISTb_21_2_particl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarLife = new System.Windows.Forms.TrackBar();
            this.trackBarTic = new System.Windows.Forms.TrackBar();
            this.trackBarCircleEmitterDirection = new System.Windows.Forms.TrackBar();
            this.trackBarDieZonePosition = new System.Windows.Forms.TrackBar();
            this.labelDieZonePosition = new System.Windows.Forms.Label();
            this.labelCircleEmitterDirection = new System.Windows.Forms.Label();
            this.labelParticlePerTic = new System.Windows.Forms.Label();
            this.labelParticleMaxLife = new System.Windows.Forms.Label();
            this.labelRepaintZonePosition = new System.Windows.Forms.Label();
            this.trackBarRepaintZonePosition = new System.Windows.Forms.TrackBar();
            this.labelTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCircleEmitterDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDieZonePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRepaintZonePosition)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarLife
            // 
            this.trackBarLife.Location = new System.Drawing.Point(534, 473);
            this.trackBarLife.Maximum = 100;
            this.trackBarLife.Minimum = 20;
            this.trackBarLife.Name = "trackBarLife";
            this.trackBarLife.Size = new System.Drawing.Size(104, 45);
            this.trackBarLife.TabIndex = 11;
            this.trackBarLife.Value = 100;
            this.trackBarLife.Scroll += new System.EventHandler(this.trackBarLife_Scroll);
            // 
            // trackBarTic
            // 
            this.trackBarTic.Location = new System.Drawing.Point(312, 473);
            this.trackBarTic.Maximum = 100;
            this.trackBarTic.Minimum = 1;
            this.trackBarTic.Name = "trackBarTic";
            this.trackBarTic.Size = new System.Drawing.Size(104, 45);
            this.trackBarTic.TabIndex = 12;
            this.trackBarTic.Value = 50;
            this.trackBarTic.Scroll += new System.EventHandler(this.trackBarTic_Scroll);
            // 
            // trackBarCircleEmitterDirection
            // 
            this.trackBarCircleEmitterDirection.Location = new System.Drawing.Point(19, 549);
            this.trackBarCircleEmitterDirection.Maximum = 1;
            this.trackBarCircleEmitterDirection.Name = "trackBarCircleEmitterDirection";
            this.trackBarCircleEmitterDirection.Size = new System.Drawing.Size(104, 45);
            this.trackBarCircleEmitterDirection.TabIndex = 13;
            this.trackBarCircleEmitterDirection.Value = 1;
            this.trackBarCircleEmitterDirection.Scroll += new System.EventHandler(this.trackBarCircleEmitterDirection_Scroll);
            // 
            // trackBarDieZonePosition
            // 
            this.trackBarDieZonePosition.Location = new System.Drawing.Point(19, 473);
            this.trackBarDieZonePosition.Maximum = 100;
            this.trackBarDieZonePosition.Minimum = 10;
            this.trackBarDieZonePosition.Name = "trackBarDieZonePosition";
            this.trackBarDieZonePosition.Size = new System.Drawing.Size(104, 45);
            this.trackBarDieZonePosition.TabIndex = 14;
            this.trackBarDieZonePosition.Value = 55;
            this.trackBarDieZonePosition.Scroll += new System.EventHandler(this.trackBarDieZonePosition_Scroll);
            // 
            // labelDieZonePosition
            // 
            this.labelDieZonePosition.AutoSize = true;
            this.labelDieZonePosition.Location = new System.Drawing.Point(16, 445);
            this.labelDieZonePosition.Name = "labelDieZonePosition";
            this.labelDieZonePosition.Size = new System.Drawing.Size(133, 13);
            this.labelDieZonePosition.TabIndex = 15;
            this.labelDieZonePosition.Text = "Положение DieZone: 500";
            this.labelDieZonePosition.Click += new System.EventHandler(this.labelDieZonePosition_Click);
            // 
            // labelCircleEmitterDirection
            // 
            this.labelCircleEmitterDirection.AutoSize = true;
            this.labelCircleEmitterDirection.Location = new System.Drawing.Point(12, 521);
            this.labelCircleEmitterDirection.Name = "labelCircleEmitterDirection";
            this.labelCircleEmitterDirection.Size = new System.Drawing.Size(242, 13);
            this.labelCircleEmitterDirection.TabIndex = 16;
            this.labelCircleEmitterDirection.Text = "Направление кругового эмиттера: по часовой";
            // 
            // labelParticlePerTic
            // 
            this.labelParticlePerTic.AutoSize = true;
            this.labelParticlePerTic.Location = new System.Drawing.Point(309, 445);
            this.labelParticlePerTic.Name = "labelParticlePerTic";
            this.labelParticlePerTic.Size = new System.Drawing.Size(203, 13);
            this.labelParticlePerTic.TabIndex = 17;
            this.labelParticlePerTic.Text = "Кол-во создаваемых частиц за тик: 50";
            this.labelParticlePerTic.Click += new System.EventHandler(this.labelParticlePerTic_Click);
            // 
            // labelParticleMaxLife
            // 
            this.labelParticleMaxLife.AutoSize = true;
            this.labelParticleMaxLife.Location = new System.Drawing.Point(531, 445);
            this.labelParticleMaxLife.Name = "labelParticleMaxLife";
            this.labelParticleMaxLife.Size = new System.Drawing.Size(180, 13);
            this.labelParticleMaxLife.TabIndex = 18;
            this.labelParticleMaxLife.Text = "Максимальная жизнь частиц: 100";
            // 
            // labelRepaintZonePosition
            // 
            this.labelRepaintZonePosition.AutoSize = true;
            this.labelRepaintZonePosition.Location = new System.Drawing.Point(149, 445);
            this.labelRepaintZonePosition.Name = "labelRepaintZonePosition";
            this.labelRepaintZonePosition.Size = new System.Drawing.Size(154, 13);
            this.labelRepaintZonePosition.TabIndex = 20;
            this.labelRepaintZonePosition.Text = "Положение RepaintZone: 500";
            // 
            // trackBarRepaintZonePosition
            // 
            this.trackBarRepaintZonePosition.Location = new System.Drawing.Point(152, 473);
            this.trackBarRepaintZonePosition.Maximum = 100;
            this.trackBarRepaintZonePosition.Minimum = 10;
            this.trackBarRepaintZonePosition.Name = "trackBarRepaintZonePosition";
            this.trackBarRepaintZonePosition.Size = new System.Drawing.Size(104, 45);
            this.trackBarRepaintZonePosition.TabIndex = 19;
            this.trackBarRepaintZonePosition.Value = 55;
            this.trackBarRepaintZonePosition.Scroll += new System.EventHandler(this.trackBarRepaintZonePosition_Scroll);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(717, 445);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(64, 13);
            this.labelTimer.TabIndex = 21;
            this.labelTimer.Text = "Таймер 2:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 601);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelRepaintZonePosition);
            this.Controls.Add(this.trackBarRepaintZonePosition);
            this.Controls.Add(this.labelParticleMaxLife);
            this.Controls.Add(this.labelParticlePerTic);
            this.Controls.Add(this.labelCircleEmitterDirection);
            this.Controls.Add(this.labelDieZonePosition);
            this.Controls.Add(this.trackBarDieZonePosition);
            this.Controls.Add(this.trackBarCircleEmitterDirection);
            this.Controls.Add(this.trackBarTic);
            this.Controls.Add(this.trackBarLife);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Сбор очков";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCircleEmitterDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDieZonePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRepaintZonePosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarLife;
        private System.Windows.Forms.TrackBar trackBarTic;
        private System.Windows.Forms.TrackBar trackBarCircleEmitterDirection;
        private System.Windows.Forms.TrackBar trackBarDieZonePosition;
        private System.Windows.Forms.Label labelDieZonePosition;
        private System.Windows.Forms.Label labelCircleEmitterDirection;
        private System.Windows.Forms.Label labelParticlePerTic;
        private System.Windows.Forms.Label labelParticleMaxLife;
        private System.Windows.Forms.Label labelRepaintZonePosition;
        private System.Windows.Forms.TrackBar trackBarRepaintZonePosition;
        private System.Windows.Forms.Label labelTimer;
    }
}

