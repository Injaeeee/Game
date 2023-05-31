
namespace TheGreatWizardAdventure
{
    partial class GuideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideForm));
            this.Guidepanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Guidepanel
            // 
            this.Guidepanel.Location = new System.Drawing.Point(12, 12);
            this.Guidepanel.Name = "Guidepanel";
            this.Guidepanel.Size = new System.Drawing.Size(1014, 315);
            this.Guidepanel.TabIndex = 27;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(12, 333);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(155, 41);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 26;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.Location = new System.Drawing.Point(871, 333);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(155, 41);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartButton.TabIndex = 25;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.Location = new System.Drawing.Point(710, 333);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(155, 41);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextButton.TabIndex = 24;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 386);
            this.ControlBox = false;
            this.Controls.Add(this.Guidepanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NextButton);
            this.Name = "GuideForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.GuideForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.PictureBox StartButton;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Panel Guidepanel;
    }
}