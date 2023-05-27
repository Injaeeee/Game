namespace TheGreatWizardAdventure.Container
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Characterface = new System.Windows.Forms.PictureBox();
            this.Heart1 = new System.Windows.Forms.PictureBox();
            this.Heart2 = new System.Windows.Forms.PictureBox();
            this.SoundButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Heart3 = new System.Windows.Forms.PictureBox();
            this.magician = new System.Windows.Forms.PictureBox();
            this.leftlaser = new System.Windows.Forms.PictureBox();
            this.RightLaser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Characterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftlaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1451, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1451, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // BackgroundTimer
            // 
            this.BackgroundTimer.Enabled = true;
            this.BackgroundTimer.Interval = 10;
            this.BackgroundTimer.Tick += new System.EventHandler(this.BackgroundTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1016, 371);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // Gametimer
            // 
            this.Gametimer.Tick += new System.EventHandler(this.Gametimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(2059, 38);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(279, 61);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "TimeLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 211);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Characterface
            // 
            this.Characterface.BackColor = System.Drawing.Color.Transparent;
            this.Characterface.Image = ((System.Drawing.Image)(resources.GetObject("Characterface.Image")));
            this.Characterface.Location = new System.Drawing.Point(17, -8);
            this.Characterface.Margin = new System.Windows.Forms.Padding(4);
            this.Characterface.Name = "Characterface";
            this.Characterface.Size = new System.Drawing.Size(141, 140);
            this.Characterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Characterface.TabIndex = 13;
            this.Characterface.TabStop = false;
            this.Characterface.Click += new System.EventHandler(this.Characterface_Click);
            // 
            // Heart1
            // 
            this.Heart1.BackColor = System.Drawing.Color.Transparent;
            this.Heart1.Image = global::TheGreatWizardAdventure.Properties.Resources.full_heart;
            this.Heart1.Location = new System.Drawing.Point(190, 38);
            this.Heart1.Margin = new System.Windows.Forms.Padding(4);
            this.Heart1.Name = "Heart1";
            this.Heart1.Size = new System.Drawing.Size(71, 74);
            this.Heart1.TabIndex = 8;
            this.Heart1.TabStop = false;
            // 
            // Heart2
            // 
            this.Heart2.BackColor = System.Drawing.Color.Transparent;
            this.Heart2.Image = global::TheGreatWizardAdventure.Properties.Resources.half_heart;
            this.Heart2.Location = new System.Drawing.Point(270, 38);
            this.Heart2.Margin = new System.Windows.Forms.Padding(4);
            this.Heart2.Name = "Heart2";
            this.Heart2.Size = new System.Drawing.Size(71, 74);
            this.Heart2.TabIndex = 7;
            this.Heart2.TabStop = false;
            // 
            // SoundButton
            // 
            this.SoundButton.BackColor = System.Drawing.Color.Transparent;
            this.SoundButton.Image = global::TheGreatWizardAdventure.Properties.Resources.Icon_SoundOn;
            this.SoundButton.Location = new System.Drawing.Point(1666, 12);
            this.SoundButton.Name = "SoundButton";
            this.SoundButton.Size = new System.Drawing.Size(54, 49);
            this.SoundButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoundButton.TabIndex = 6;
            this.SoundButton.TabStop = false;
            this.SoundButton.Click += new System.EventHandler(this.SoundButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1726, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(54, 49);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Heart3
            // 
            this.Heart3.BackColor = System.Drawing.Color.Transparent;
            this.Heart3.Image = global::TheGreatWizardAdventure.Properties.Resources.empty_heart;
            this.Heart3.Location = new System.Drawing.Point(245, 25);
            this.Heart3.Name = "Heart3";
            this.Heart3.Size = new System.Drawing.Size(50, 49);
            this.Heart3.TabIndex = 4;
            this.Heart3.TabStop = false;
            // 
            // magician
            // 
            this.magician.BackColor = System.Drawing.Color.Transparent;
            this.magician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.magician.Image = global::TheGreatWizardAdventure.Properties.Resources.마법사오른쪽스텐딩;
            this.magician.Location = new System.Drawing.Point(1171, 526);
            this.magician.Name = "magician";
            this.magician.Size = new System.Drawing.Size(156, 178);
            this.magician.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magician.TabIndex = 0;
            this.magician.TabStop = false;
            // 
            // leftlaser
            // 
            this.leftlaser.BackColor = System.Drawing.Color.Transparent;
            this.leftlaser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftlaser.Image = global::TheGreatWizardAdventure.Properties.Resources.bolt_big;
            this.leftlaser.Location = new System.Drawing.Point(1130, 566);
            this.leftlaser.Name = "leftlaser";
            this.leftlaser.Size = new System.Drawing.Size(234, 119);
            this.leftlaser.TabIndex = 12;
            this.leftlaser.TabStop = false;
            // 
            // RightLaser
            // 
            this.RightLaser.BackColor = System.Drawing.Color.Transparent;
            this.RightLaser.Image = ((System.Drawing.Image)(resources.GetObject("RightLaser.Image")));
            this.RightLaser.Location = new System.Drawing.Point(974, 333);
            this.RightLaser.Margin = new System.Windows.Forms.Padding(2);
            this.RightLaser.Name = "RightLaser";
            this.RightLaser.Size = new System.Drawing.Size(413, 140);
            this.RightLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightLaser.TabIndex = 11;
            this.RightLaser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(240, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1784, 481);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.leftlaser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.Characterface);
            this.Controls.Add(this.Heart1);
            this.Controls.Add(this.Heart2);
            this.Controls.Add(this.SoundButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Heart3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.magician);
            this.Controls.Add(this.RightLaser);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Characterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftlaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox magician;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Heart3;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox SoundButton;
        private System.Windows.Forms.PictureBox Heart2;
        private System.Windows.Forms.PictureBox Heart1;
        private System.Windows.Forms.PictureBox RightLaser;
        private System.Windows.Forms.PictureBox leftlaser;
        private System.Windows.Forms.PictureBox Characterface;
        private System.Windows.Forms.Timer BackgroundTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}