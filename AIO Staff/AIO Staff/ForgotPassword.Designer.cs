﻿namespace AIO_Staff
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.signUpBtn = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.signInBtn = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.middlelogo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlelogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Image = global::AIO_Staff.Properties.Resources.btn31;
            this.signUpBtn.Location = new System.Drawing.Point(170, 438);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(104, 50);
            this.signUpBtn.TabIndex = 44;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Black;
            this.sendBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendBtn.BackgroundImage")));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendBtn.Location = new System.Drawing.Point(360, 241);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(259, 65);
            this.sendBtn.TabIndex = 43;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // mailTextBox
            // 
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTextBox.Location = new System.Drawing.Point(373, 177);
            this.mailTextBox.Multiline = true;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(235, 22);
            this.mailTextBox.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AIO_Staff.Properties.Resources.textbox4;
            this.pictureBox2.Location = new System.Drawing.Point(360, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 45);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signInBtn.ForeColor = System.Drawing.Color.Transparent;
            this.signInBtn.Image = global::AIO_Staff.Properties.Resources.btn31;
            this.signInBtn.Location = new System.Drawing.Point(19, 438);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(104, 50);
            this.signInBtn.TabIndex = 40;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.BackColor = System.Drawing.Color.Transparent;
            this.mailLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailLabel.ForeColor = System.Drawing.Color.Transparent;
            this.mailLabel.Location = new System.Drawing.Point(356, 129);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(48, 24);
            this.mailLabel.TabIndex = 39;
            this.mailLabel.Text = "Mail";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO_Staff.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(658, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 38;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // middlelogo1
            // 
            this.middlelogo1.BackColor = System.Drawing.Color.Transparent;
            this.middlelogo1.Image = global::AIO_Staff.Properties.Resources.logo;
            this.middlelogo1.Location = new System.Drawing.Point(80, 132);
            this.middlelogo1.Name = "middlelogo1";
            this.middlelogo1.Size = new System.Drawing.Size(175, 203);
            this.middlelogo1.TabIndex = 37;
            this.middlelogo1.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.middlelogo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlelogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label signInBtn;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.PictureBox middlelogo1;
    }
}