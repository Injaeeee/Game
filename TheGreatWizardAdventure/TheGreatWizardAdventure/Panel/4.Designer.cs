
namespace TheGreatWizardAdventure.Panel
{
    partial class _4
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_4));
            this.label1 = new System.Windows.Forms.Label();
            this.magician = new System.Windows.Forms.PictureBox();
            this.Boss = new System.Windows.Forms.PictureBox();
            this.bossHealthBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clicklabel = new System.Windows.Forms.Label();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.magician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(167, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "보스를 클릭하여 공격 할 수 있으며 보스의 피가 0이 되면 처치할 수 있습니다";
            // 
            // magician
            // 
            this.magician.BackColor = System.Drawing.Color.Transparent;
            this.magician.Image = global::TheGreatWizardAdventure.Properties.Resources.마법사오른쪽스텐딩;
            this.magician.Location = new System.Drawing.Point(348, 220);
            this.magician.Margin = new System.Windows.Forms.Padding(2);
            this.magician.Name = "magician";
            this.magician.Size = new System.Drawing.Size(95, 95);
            this.magician.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magician.TabIndex = 24;
            this.magician.TabStop = false;
            // 
            // Boss
            // 
            this.Boss.BackColor = System.Drawing.Color.Transparent;
            this.Boss.Image = global::TheGreatWizardAdventure.Properties.Resources.Boss반전;
            this.Boss.Location = new System.Drawing.Point(522, 93);
            this.Boss.Margin = new System.Windows.Forms.Padding(2);
            this.Boss.Name = "Boss";
            this.Boss.Size = new System.Drawing.Size(206, 222);
            this.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boss.TabIndex = 25;
            this.Boss.TabStop = false;
            // 
            // bossHealthBar
            // 
            this.bossHealthBar.ForeColor = System.Drawing.Color.Red;
            this.bossHealthBar.Location = new System.Drawing.Point(564, 64);
            this.bossHealthBar.Maximum = 10;
            this.bossHealthBar.Name = "bossHealthBar";
            this.bossHealthBar.Size = new System.Drawing.Size(174, 24);
            this.bossHealthBar.TabIndex = 26;
            this.bossHealthBar.Value = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Clicklabel
            // 
            this.Clicklabel.AutoSize = true;
            this.Clicklabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Clicklabel.Location = new System.Drawing.Point(467, 262);
            this.Clicklabel.Name = "Clicklabel";
            this.Clicklabel.Size = new System.Drawing.Size(116, 37);
            this.Clicklabel.TabIndex = 28;
            this.Clicklabel.Text = "CLICK!";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // _4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clicklabel);
            this.Controls.Add(this.bossHealthBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Boss);
            this.Controls.Add(this.magician);
            this.Controls.Add(this.label1);
            this.Name = "_4";
            this.Size = new System.Drawing.Size(1014, 315);
            this.Load += new System.EventHandler(this._4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox magician;
        private System.Windows.Forms.PictureBox Boss;
        private System.Windows.Forms.ProgressBar bossHealthBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Clicklabel;
        private System.Windows.Forms.Timer progressBarTimer;
    }
}
