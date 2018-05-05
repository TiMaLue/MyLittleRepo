namespace Platformer
{
    partial class Gameframe
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
            this.GameBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBox
            // 
            this.GameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameBox.Location = new System.Drawing.Point(0, 0);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(185, 159);
            this.GameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameBox.TabIndex = 0;
            this.GameBox.TabStop = false;
            // 
            // Gameframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 159);
            this.Controls.Add(this.GameBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gameframe";
            this.Text = "Gameframe";
            this.Load += new System.EventHandler(this.Gameframe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBox;
    }
}