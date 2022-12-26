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
            this.trackBarDirection = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.trackBarGraviton1 = new System.Windows.Forms.TrackBar();
            this.labelGraviton1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarGraviton2 = new System.Windows.Forms.TrackBar();
            this.labelGraviton2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraviton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraviton2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarDirection
            // 
            this.trackBarDirection.Location = new System.Drawing.Point(12, 473);
            this.trackBarDirection.Maximum = 359;
            this.trackBarDirection.Name = "trackBarDirection";
            this.trackBarDirection.Size = new System.Drawing.Size(179, 45);
            this.trackBarDirection.TabIndex = 1;
            this.trackBarDirection.Scroll += new System.EventHandler(this.trackBarDirection_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Направление";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(197, 473);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(17, 13);
            this.labelDirection.TabIndex = 3;
            this.labelDirection.Text = "0°";
            // 
            // trackBarGraviton1
            // 
            this.trackBarGraviton1.Location = new System.Drawing.Point(243, 473);
            this.trackBarGraviton1.Maximum = 100;
            this.trackBarGraviton1.Name = "trackBarGraviton1";
            this.trackBarGraviton1.Size = new System.Drawing.Size(179, 45);
            this.trackBarGraviton1.TabIndex = 4;
            this.trackBarGraviton1.Value = 100;
            this.trackBarGraviton1.Scroll += new System.EventHandler(this.trackBarGraviton_Scroll);
            // 
            // labelGraviton1
            // 
            this.labelGraviton1.AutoSize = true;
            this.labelGraviton1.Location = new System.Drawing.Point(428, 473);
            this.labelGraviton1.Name = "labelGraviton1";
            this.labelGraviton1.Size = new System.Drawing.Size(25, 13);
            this.labelGraviton1.TabIndex = 5;
            this.labelGraviton1.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Притяжение гравитона 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackBarGraviton2
            // 
            this.trackBarGraviton2.Location = new System.Drawing.Point(475, 473);
            this.trackBarGraviton2.Maximum = 100;
            this.trackBarGraviton2.Name = "trackBarGraviton2";
            this.trackBarGraviton2.Size = new System.Drawing.Size(179, 45);
            this.trackBarGraviton2.TabIndex = 7;
            this.trackBarGraviton2.Value = 100;
            this.trackBarGraviton2.Scroll += new System.EventHandler(this.trackBarGraviton2_Scroll);
            // 
            // labelGraviton2
            // 
            this.labelGraviton2.AutoSize = true;
            this.labelGraviton2.Location = new System.Drawing.Point(660, 473);
            this.labelGraviton2.Name = "labelGraviton2";
            this.labelGraviton2.Size = new System.Drawing.Size(25, 13);
            this.labelGraviton2.TabIndex = 8;
            this.labelGraviton2.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Притяжение гравитона 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelGraviton2);
            this.Controls.Add(this.trackBarGraviton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGraviton1);
            this.Controls.Add(this.trackBarGraviton1);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarDirection);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraviton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraviton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.TrackBar trackBarGraviton1;
        private System.Windows.Forms.Label labelGraviton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarGraviton2;
        private System.Windows.Forms.Label labelGraviton2;
        private System.Windows.Forms.Label label3;
    }
}

