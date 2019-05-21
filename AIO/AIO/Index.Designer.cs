﻿namespace AIO
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.logo = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::AIO.Properties.Resources.logo1;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(262, 87);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(180, 203);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(661, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Image = global::AIO.Properties.Resources.bigBtn;
            this.signInBtn.Location = new System.Drawing.Point(73, 341);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(256, 106);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Image = global::AIO.Properties.Resources.bigBtn;
            this.signUpBtn.Location = new System.Drawing.Point(382, 341);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(256, 106);
            this.signUpBtn.TabIndex = 3;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label signInBtn;
        private System.Windows.Forms.Label signUpBtn;
    }
}

