﻿namespace Platformer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.FullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(67, 37);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(50, 19);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Location = new System.Drawing.Point(67, 60);
            this.ButtonQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(50, 24);
            this.ButtonQuit.TabIndex = 1;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // FullscreenCheckBox
            // 
            this.FullscreenCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FullscreenCheckBox.AutoSize = true;
            this.FullscreenCheckBox.Location = new System.Drawing.Point(60, 88);
            this.FullscreenCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullscreenCheckBox.Name = "FullscreenCheckBox";
            this.FullscreenCheckBox.Size = new System.Drawing.Size(65, 23);
            this.FullscreenCheckBox.TabIndex = 2;
            this.FullscreenCheckBox.Text = "Fullscreen";
            this.FullscreenCheckBox.UseVisualStyleBackColor = true;
            this.FullscreenCheckBox.CheckedChanged += new System.EventHandler(this.FullscreenCheckBox_CheckedChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(31, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(123, 26);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Platformer";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 122);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FullscreenCheckBox);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.CheckBox FullscreenCheckBox;
        private System.Windows.Forms.Label NameLabel;
    }
}

