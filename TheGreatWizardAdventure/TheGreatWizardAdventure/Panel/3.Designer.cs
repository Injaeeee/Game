
namespace TheGreatWizardAdventure.Panel
{
    partial class _3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3));
            this.label1 = new System.Windows.Forms.Label();
            this.visibilityTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftlabel = new System.Windows.Forms.Label();
            this.rightlabel = new System.Windows.Forms.Label();
            this.monster1 = new System.Windows.Forms.PictureBox();
            this.Bolt2 = new System.Windows.Forms.PictureBox();
            this.Bolt = new System.Windows.Forms.PictureBox();
            this.magician2 = new System.Windows.Forms.PictureBox();
            this.magician = new System.Windows.Forms.PictureBox();
            this.monster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bolt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magician2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(152, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "얼음마법";
            // 
            // visibilityTimer
            // 
            this.visibilityTimer.Tick += new System.EventHandler(this.visibilityTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(647, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "화염마법";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(235, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "좌,우클릭으로 속성에 상성인 몬스터를 처치할 수 있습니다";
            // 
            // leftlabel
            // 
            this.leftlabel.AutoSize = true;
            this.leftlabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftlabel.Location = new System.Drawing.Point(38, 192);
            this.leftlabel.Name = "leftlabel";
            this.leftlabel.Size = new System.Drawing.Size(76, 24);
            this.leftlabel.TabIndex = 27;
            this.leftlabel.Text = "좌클릭!";
            // 
            // rightlabel
            // 
            this.rightlabel.AutoSize = true;
            this.rightlabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightlabel.Location = new System.Drawing.Point(521, 194);
            this.rightlabel.Name = "rightlabel";
            this.rightlabel.Size = new System.Drawing.Size(76, 24);
            this.rightlabel.TabIndex = 28;
            this.rightlabel.Text = "우클릭!";
            // 
            // monster1
            // 
            this.monster1.BackColor = System.Drawing.Color.Transparent;
            this.monster1.Image = ((System.Drawing.Image)(resources.GetObject("monster1.Image")));
            this.monster1.Location = new System.Drawing.Point(789, 205);
            this.monster1.Margin = new System.Windows.Forms.Padding(2);
            this.monster1.Name = "monster1";
            this.monster1.Size = new System.Drawing.Size(207, 108);
            this.monster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.monster1.TabIndex = 32;
            this.monster1.TabStop = false;
            // 
            // Bolt2
            // 
            this.Bolt2.BackColor = System.Drawing.Color.Transparent;
            this.Bolt2.Image = ((System.Drawing.Image)(resources.GetObject("Bolt2.Image")));
            this.Bolt2.Location = new System.Drawing.Point(614, 218);
            this.Bolt2.Margin = new System.Windows.Forms.Padding(2);
            this.Bolt2.Name = "Bolt2";
            this.Bolt2.Size = new System.Drawing.Size(171, 95);
            this.Bolt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bolt2.TabIndex = 30;
            this.Bolt2.TabStop = false;
            // 
            // Bolt
            // 
            this.Bolt.BackColor = System.Drawing.Color.Transparent;
            this.Bolt.Image = ((System.Drawing.Image)(resources.GetObject("Bolt.Image")));
            this.Bolt.Location = new System.Drawing.Point(128, 218);
            this.Bolt.Margin = new System.Windows.Forms.Padding(2);
            this.Bolt.Name = "Bolt";
            this.Bolt.Size = new System.Drawing.Size(171, 95);
            this.Bolt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bolt.TabIndex = 29;
            this.Bolt.TabStop = false;
            // 
            // magician2
            // 
            this.magician2.BackColor = System.Drawing.Color.Transparent;
            this.magician2.Image = global::TheGreatWizardAdventure.Properties.Resources.마법사오른쪽스텐딩;
            this.magician2.Location = new System.Drawing.Point(515, 220);
            this.magician2.Margin = new System.Windows.Forms.Padding(2);
            this.magician2.Name = "magician2";
            this.magician2.Size = new System.Drawing.Size(95, 95);
            this.magician2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magician2.TabIndex = 24;
            this.magician2.TabStop = false;
            // 
            // magician
            // 
            this.magician.BackColor = System.Drawing.Color.Transparent;
            this.magician.Image = global::TheGreatWizardAdventure.Properties.Resources.마법사오른쪽스텐딩;
            this.magician.Location = new System.Drawing.Point(29, 218);
            this.magician.Margin = new System.Windows.Forms.Padding(2);
            this.magician.Name = "magician";
            this.magician.Size = new System.Drawing.Size(95, 95);
            this.magician.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magician.TabIndex = 23;
            this.magician.TabStop = false;
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.Image = global::TheGreatWizardAdventure.Properties.Resources.불몬스터왼쪽스텐딩_;
            this.monster.Location = new System.Drawing.Point(303, 205);
            this.monster.Margin = new System.Windows.Forms.Padding(2);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(208, 108);
            this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.monster.TabIndex = 31;
            this.monster.TabStop = false;
            // 
            // _3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monster1);
            this.Controls.Add(this.Bolt2);
            this.Controls.Add(this.Bolt);
            this.Controls.Add(this.rightlabel);
            this.Controls.Add(this.leftlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magician2);
            this.Controls.Add(this.magician);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monster);
            this.Name = "_3";
            this.Size = new System.Drawing.Size(1014, 315);
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bolt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magician2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox magician;
        private System.Windows.Forms.PictureBox magician2;
        private System.Windows.Forms.Timer visibilityTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label leftlabel;
        private System.Windows.Forms.Label rightlabel;
        private System.Windows.Forms.PictureBox Bolt;
        private System.Windows.Forms.PictureBox Bolt2;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.PictureBox monster1;
    }
}
