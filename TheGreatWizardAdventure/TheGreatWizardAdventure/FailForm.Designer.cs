
namespace TheGreatWizardAdventure
{
    partial class FailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FailForm));
            this.RetryButton = new System.Windows.Forms.PictureBox();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RetryButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // RetryButton
            // 
            this.RetryButton.BackColor = System.Drawing.Color.Transparent;
            this.RetryButton.Image = ((System.Drawing.Image)(resources.GetObject("RetryButton.Image")));
            this.RetryButton.Location = new System.Drawing.Point(633, 138);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(155, 41);
            this.RetryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RetryButton.TabIndex = 25;
            this.RetryButton.TabStop = false;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.Location = new System.Drawing.Point(633, 185);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(155, 41);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 26;
            this.MenuButton.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(633, 232);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(155, 41);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 27;
            this.CloseButton.TabStop = false;
            // 
            // FailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.RetryButton);
            this.Name = "FailForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.RetryButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RetryButton;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.PictureBox CloseButton;
    }
}