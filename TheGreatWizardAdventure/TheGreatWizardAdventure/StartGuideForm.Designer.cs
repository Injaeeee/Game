
namespace TheGreatWizardAdventure
{
    partial class StartGuideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGuideForm));
            this.magician = new System.Windows.Forms.PictureBox();
            this.mark = new System.Windows.Forms.PictureBox();
            this.Boss = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.mark2 = new System.Windows.Forms.PictureBox();
            this.BossAttack = new System.Windows.Forms.Timer(this.components);
            this.Laser = new System.Windows.Forms.PictureBox();
            this.moveMonstersTimer = new System.Windows.Forms.Timer(this.components);
            this.SkipButton = new System.Windows.Forms.PictureBox();
            this.guidebutton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.magician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guidebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // magician
            // 
            this.magician.BackColor = System.Drawing.Color.Transparent;
            this.magician.Image = global::TheGreatWizardAdventure.Properties.Resources.마법사오른쪽걷기;
            this.magician.Location = new System.Drawing.Point(21, 258);
            this.magician.Margin = new System.Windows.Forms.Padding(2);
            this.magician.Name = "magician";
            this.magician.Size = new System.Drawing.Size(95, 95);
            this.magician.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magician.TabIndex = 22;
            this.magician.TabStop = false;
            // 
            // mark
            // 
            this.mark.BackColor = System.Drawing.Color.Transparent;
            this.mark.Image = ((System.Drawing.Image)(resources.GetObject("mark.Image")));
            this.mark.Location = new System.Drawing.Point(458, 178);
            this.mark.Margin = new System.Windows.Forms.Padding(2);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(57, 83);
            this.mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mark.TabIndex = 23;
            this.mark.TabStop = false;
            // 
            // Boss
            // 
            this.Boss.BackColor = System.Drawing.Color.Transparent;
            this.Boss.Image = global::TheGreatWizardAdventure.Properties.Resources.Boss반전;
            this.Boss.Location = new System.Drawing.Point(948, 11);
            this.Boss.Margin = new System.Windows.Forms.Padding(2);
            this.Boss.Name = "Boss";
            this.Boss.Size = new System.Drawing.Size(230, 250);
            this.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boss.TabIndex = 24;
            this.Boss.TabStop = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // mark2
            // 
            this.mark2.BackColor = System.Drawing.Color.Transparent;
            this.mark2.Image = ((System.Drawing.Image)(resources.GetObject("mark2.Image")));
            this.mark2.Location = new System.Drawing.Point(948, 11);
            this.mark2.Margin = new System.Windows.Forms.Padding(2);
            this.mark2.Name = "mark2";
            this.mark2.Size = new System.Drawing.Size(57, 83);
            this.mark2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mark2.TabIndex = 25;
            this.mark2.TabStop = false;
            // 
            // BossAttack
            // 
            this.BossAttack.Tick += new System.EventHandler(this.BossAttack_Tick);
            // 
            // Laser
            // 
            this.Laser.BackColor = System.Drawing.Color.Transparent;
            this.Laser.Image = ((System.Drawing.Image)(resources.GetObject("Laser.Image")));
            this.Laser.Location = new System.Drawing.Point(476, 230);
            this.Laser.Margin = new System.Windows.Forms.Padding(2);
            this.Laser.Name = "Laser";
            this.Laser.Size = new System.Drawing.Size(154, 140);
            this.Laser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Laser.TabIndex = 26;
            this.Laser.TabStop = false;
            // 
            // moveMonstersTimer
            // 
            this.moveMonstersTimer.Tick += new System.EventHandler(this.moveMonstersTimer_Tick);
            // 
            // SkipButton
            // 
            this.SkipButton.BackColor = System.Drawing.Color.Transparent;
            this.SkipButton.Image = ((System.Drawing.Image)(resources.GetObject("SkipButton.Image")));
            this.SkipButton.Location = new System.Drawing.Point(233, 71);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(323, 73);
            this.SkipButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SkipButton.TabIndex = 27;
            this.SkipButton.TabStop = false;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // guidebutton
            // 
            this.guidebutton.BackColor = System.Drawing.Color.Transparent;
            this.guidebutton.Image = ((System.Drawing.Image)(resources.GetObject("guidebutton.Image")));
            this.guidebutton.Location = new System.Drawing.Point(562, 71);
            this.guidebutton.Name = "guidebutton";
            this.guidebutton.Size = new System.Drawing.Size(323, 73);
            this.guidebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guidebutton.TabIndex = 28;
            this.guidebutton.TabStop = false;
            this.guidebutton.Click += new System.EventHandler(this.guidebutton_Click);
            // 
            // StartGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 353);
            this.ControlBox = false;
            this.Controls.Add(this.guidebutton);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.mark2);
            this.Controls.Add(this.Boss);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.magician);
            this.Controls.Add(this.Laser);
            this.Name = "StartGuideForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.StartGuideForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guidebutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox magician;
        private System.Windows.Forms.PictureBox mark;
        private System.Windows.Forms.PictureBox Boss;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.PictureBox mark2;
        private System.Windows.Forms.Timer BossAttack;
        private System.Windows.Forms.PictureBox Laser;
        private System.Windows.Forms.Timer moveMonstersTimer;
        private System.Windows.Forms.PictureBox SkipButton;
        private System.Windows.Forms.PictureBox guidebutton;
    }
}