namespace TheGreatWizardAdventure
{
    partial class MenuForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.PLAYBUTTON = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EXITBUTTON = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GuideButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYBUTTON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXITBUTTON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PLAYBUTTON
            // 
            this.PLAYBUTTON.BackColor = System.Drawing.Color.Transparent;
            this.PLAYBUTTON.Image = ((System.Drawing.Image)(resources.GetObject("PLAYBUTTON.Image")));
            this.PLAYBUTTON.Location = new System.Drawing.Point(146, 200);
            this.PLAYBUTTON.Name = "PLAYBUTTON";
            this.PLAYBUTTON.Size = new System.Drawing.Size(422, 107);
            this.PLAYBUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYBUTTON.TabIndex = 1;
            this.PLAYBUTTON.TabStop = false;
            this.PLAYBUTTON.Click += new System.EventHandler(this.START);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // EXITBUTTON
            // 
            this.EXITBUTTON.BackColor = System.Drawing.Color.Transparent;
            this.EXITBUTTON.Image = ((System.Drawing.Image)(resources.GetObject("EXITBUTTON.Image")));
            this.EXITBUTTON.Location = new System.Drawing.Point(146, 470);
            this.EXITBUTTON.Name = "EXITBUTTON";
            this.EXITBUTTON.Size = new System.Drawing.Size(422, 107);
            this.EXITBUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EXITBUTTON.TabIndex = 3;
            this.EXITBUTTON.TabStop = false;
            this.EXITBUTTON.Click += new System.EventHandler(this.EXITBUTTON_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(49, 485);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(62, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(526, 203);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // GuideButton
            // 
            this.GuideButton.BackColor = System.Drawing.Color.Transparent;
            this.GuideButton.Image = ((System.Drawing.Image)(resources.GetObject("GuideButton.Image")));
            this.GuideButton.Location = new System.Drawing.Point(146, 331);
            this.GuideButton.Name = "GuideButton";
            this.GuideButton.Size = new System.Drawing.Size(422, 107);
            this.GuideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GuideButton.TabIndex = 6;
            this.GuideButton.TabStop = false;
            this.GuideButton.Click += new System.EventHandler(this.GuideButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(637, 703);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GuideButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.EXITBUTTON);
            this.Controls.Add(this.PLAYBUTTON);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.PLAYBUTTON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXITBUTTON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PLAYBUTTON;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox EXITBUTTON;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox GuideButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

