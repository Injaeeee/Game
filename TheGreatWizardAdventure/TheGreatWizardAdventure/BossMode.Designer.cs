
namespace TheGreatWizardAdventure
{
    partial class BossMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BossMode));
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.magician = new System.Windows.Forms.PictureBox();
            this.Characterface = new System.Windows.Forms.PictureBox();
            this.Heart1 = new System.Windows.Forms.PictureBox();
            this.Heart2 = new System.Windows.Forms.PictureBox();
            this.SoundButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Heart3 = new System.Windows.Forms.PictureBox();
            this.Boss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.magician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Characterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).BeginInit();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // magician
            // 
            this.magician.BackColor = System.Drawing.Color.Transparent;
            this.magician.Image = global::TheGreatWizardAdventure.Properties.Resources.마법사오른쪽스텐딩;
            this.magician.Location = new System.Drawing.Point(816, 367);
            this.magician.Margin = new System.Windows.Forms.Padding(2);
            this.magician.Name = "magician";
            this.magician.Size = new System.Drawing.Size(109, 119);
            this.magician.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magician.TabIndex = 21;
            this.magician.TabStop = false;
            // 
            // Characterface
            // 
            this.Characterface.BackColor = System.Drawing.Color.Transparent;
            this.Characterface.Image = ((System.Drawing.Image)(resources.GetObject("Characterface.Image")));
            this.Characterface.Location = new System.Drawing.Point(12, 3);
            this.Characterface.Name = "Characterface";
            this.Characterface.Size = new System.Drawing.Size(99, 93);
            this.Characterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Characterface.TabIndex = 20;
            this.Characterface.TabStop = false;
            // 
            // Heart1
            // 
            this.Heart1.BackColor = System.Drawing.Color.Transparent;
            this.Heart1.Image = global::TheGreatWizardAdventure.Properties.Resources.full_heart;
            this.Heart1.Location = new System.Drawing.Point(133, 33);
            this.Heart1.Name = "Heart1";
            this.Heart1.Size = new System.Drawing.Size(50, 49);
            this.Heart1.TabIndex = 19;
            this.Heart1.TabStop = false;
            // 
            // Heart2
            // 
            this.Heart2.BackColor = System.Drawing.Color.Transparent;
            this.Heart2.Image = global::TheGreatWizardAdventure.Properties.Resources.half_heart;
            this.Heart2.Location = new System.Drawing.Point(189, 33);
            this.Heart2.Name = "Heart2";
            this.Heart2.Size = new System.Drawing.Size(50, 49);
            this.Heart2.TabIndex = 18;
            this.Heart2.TabStop = false;
            // 
            // SoundButton
            // 
            this.SoundButton.BackColor = System.Drawing.Color.Transparent;
            this.SoundButton.Image = global::TheGreatWizardAdventure.Properties.Resources.Icon_SoundOn;
            this.SoundButton.Location = new System.Drawing.Point(1666, 20);
            this.SoundButton.Name = "SoundButton";
            this.SoundButton.Size = new System.Drawing.Size(54, 49);
            this.SoundButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoundButton.TabIndex = 17;
            this.SoundButton.TabStop = false;
            this.SoundButton.Click += new System.EventHandler(this.SoundButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1726, 20);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(54, 49);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 16;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Heart3
            // 
            this.Heart3.BackColor = System.Drawing.Color.Transparent;
            this.Heart3.Image = global::TheGreatWizardAdventure.Properties.Resources.empty_heart;
            this.Heart3.Location = new System.Drawing.Point(245, 33);
            this.Heart3.Name = "Heart3";
            this.Heart3.Size = new System.Drawing.Size(50, 49);
            this.Heart3.TabIndex = 15;
            this.Heart3.TabStop = false;
            // 
            // Boss
            // 
            this.Boss.BackColor = System.Drawing.Color.Transparent;
            this.Boss.Image = global::TheGreatWizardAdventure.Properties.Resources.Boss반전;
            this.Boss.Location = new System.Drawing.Point(1449, 89);
            this.Boss.Margin = new System.Windows.Forms.Padding(2);
            this.Boss.Name = "Boss";
            this.Boss.Size = new System.Drawing.Size(271, 286);
            this.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boss.TabIndex = 22;
            this.Boss.TabStop = false;
            this.Boss.Click += new System.EventHandler(this.Boss_Click);
            // 
            // BossMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 481);
            this.ControlBox = false;
            this.Controls.Add(this.magician);
            this.Controls.Add(this.Characterface);
            this.Controls.Add(this.Heart1);
            this.Controls.Add(this.Heart2);
            this.Controls.Add(this.SoundButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Heart3);
            this.Controls.Add(this.Boss);
            this.Name = "BossMode";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.BossMode_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BossMode_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.magician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Characterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Characterface;
        private System.Windows.Forms.PictureBox Heart1;
        private System.Windows.Forms.PictureBox Heart2;
        private System.Windows.Forms.PictureBox SoundButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox Heart3;
        private System.Windows.Forms.PictureBox magician;
        private System.Windows.Forms.PictureBox Boss;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Timer timer1;
    }
}