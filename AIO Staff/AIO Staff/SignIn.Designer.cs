namespace AIO_Staff
{
    partial class SignIn
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
            this.signInBtn = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Label();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nickLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Image = global::AIO_Staff.Properties.Resources.bigBtn1;
            this.signInBtn.Location = new System.Drawing.Point(372, 316);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(256, 106);
            this.signInBtn.TabIndex = 32;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Image = global::AIO_Staff.Properties.Resources.btn3;
            this.signUpBtn.Location = new System.Drawing.Point(24, 410);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(104, 50);
            this.signUpBtn.TabIndex = 31;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.forgotPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(372, 269);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(174, 25);
            this.forgotPasswordLabel.TabIndex = 30;
            this.forgotPasswordLabel.Text = "Forgot Password";
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(384, 216);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(251, 30);
            this.passwordTextBox.TabIndex = 29;
            this.passwordTextBox.Text = "......";
            // 
            // nickTextBox
            // 
            this.nickTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickTextBox.Location = new System.Drawing.Point(382, 131);
            this.nickTextBox.Multiline = true;
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(251, 30);
            this.nickTextBox.TabIndex = 28;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(372, 183);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 25);
            this.passwordLabel.TabIndex = 25;
            this.passwordLabel.Text = "Password";
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.BackColor = System.Drawing.Color.Transparent;
            this.nickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickLabel.ForeColor = System.Drawing.Color.White;
            this.nickLabel.Location = new System.Drawing.Point(372, 98);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(54, 25);
            this.nickLabel.TabIndex = 24;
            this.nickLabel.Text = "Nick";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO_Staff.Properties.Resources.closeBtn1;
            this.closeBtn.Location = new System.Drawing.Point(654, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordPictureBox.Location = new System.Drawing.Point(376, 210);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(263, 44);
            this.passwordPictureBox.TabIndex = 27;
            this.passwordPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(376, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 44);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AIO_Staff.Properties.Resources.middleLogo;
            this.pictureBox1.Location = new System.Drawing.Point(74, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 203);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO_Staff.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nickTextBox);
            this.Controls.Add(this.passwordPictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInBtn;
        private System.Windows.Forms.Label signUpBtn;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nickTextBox;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}