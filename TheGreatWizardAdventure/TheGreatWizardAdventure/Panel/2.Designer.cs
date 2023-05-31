
namespace TheGreatWizardAdventure.Panel
{
    partial class _2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2));
            this.label1 = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.magician = new System.Windows.Forms.PictureBox();
            this.LEFTMOUSE = new System.Windows.Forms.PictureBox();
            this.RIGHTMOUSE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.magician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEFTMOUSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHTMOUSE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "마우스를 좌우로 움직여 마법사를 움직일 수 있습니다";
            // 
            // moveTimer
            // 
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // magician
            // 
            this.magician.BackColor = System.Drawing.Color.Transparent;
            this.magician.Image = global::TheGreatWizardAdventure.Properties.Resources.마법사오른쪽스텐딩;
            this.magician.Location = new System.Drawing.Point(606, 220);
            this.magician.Margin = new System.Windows.Forms.Padding(2);
            this.magician.Name = "magician";
            this.magician.Size = new System.Drawing.Size(95, 95);
            this.magician.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magician.TabIndex = 25;
            this.magician.TabStop = false;
            // 
            // LEFTMOUSE
            // 
            this.LEFTMOUSE.BackColor = System.Drawing.Color.Transparent;
            this.LEFTMOUSE.Image = ((System.Drawing.Image)(resources.GetObject("LEFTMOUSE.Image")));
            this.LEFTMOUSE.Location = new System.Drawing.Point(157, 118);
            this.LEFTMOUSE.Margin = new System.Windows.Forms.Padding(2);
            this.LEFTMOUSE.Name = "LEFTMOUSE";
            this.LEFTMOUSE.Size = new System.Drawing.Size(95, 95);
            this.LEFTMOUSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LEFTMOUSE.TabIndex = 26;
            this.LEFTMOUSE.TabStop = false;
            // 
            // RIGHTMOUSE
            // 
            this.RIGHTMOUSE.BackColor = System.Drawing.Color.Transparent;
            this.RIGHTMOUSE.Image = ((System.Drawing.Image)(resources.GetObject("RIGHTMOUSE.Image")));
            this.RIGHTMOUSE.Location = new System.Drawing.Point(788, 118);
            this.RIGHTMOUSE.Margin = new System.Windows.Forms.Padding(2);
            this.RIGHTMOUSE.Name = "RIGHTMOUSE";
            this.RIGHTMOUSE.Size = new System.Drawing.Size(95, 95);
            this.RIGHTMOUSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RIGHTMOUSE.TabIndex = 27;
            this.RIGHTMOUSE.TabStop = false;
            // 
            // _2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.RIGHTMOUSE);
            this.Controls.Add(this.LEFTMOUSE);
            this.Controls.Add(this.magician);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "_2";
            this.Size = new System.Drawing.Size(1014, 315);
            ((System.ComponentModel.ISupportInitialize)(this.magician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEFTMOUSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHTMOUSE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox magician;
        private System.Windows.Forms.PictureBox LEFTMOUSE;
        private System.Windows.Forms.PictureBox RIGHTMOUSE;
    }
}
