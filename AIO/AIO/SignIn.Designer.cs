namespace AIO
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
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nickLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
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
            this.signInBtn.Image = global::AIO.Properties.Resources.bigBtn;
            this.signInBtn.Location = new System.Drawing.Point(365, 320);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(256, 106);
            this.signInBtn.TabIndex = 21;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Image = global::AIO.Properties.Resources.btn32;
            this.signUpBtn.Location = new System.Drawing.Point(17, 414);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(104, 50);
            this.signUpBtn.TabIndex = 20;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.forgotPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(365, 273);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(143, 24);
            this.forgotPasswordLabel.TabIndex = 19;
            this.forgotPasswordLabel.Text = "Forgot Password";
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(377, 220);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(251, 30);
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.Text = "abc123";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // nickTextBox
            // 
            this.nickTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickTextBox.Location = new System.Drawing.Point(375, 135);
            this.nickTextBox.Multiline = true;
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(251, 30);
            this.nickTextBox.TabIndex = 17;
            this.nickTextBox.Text = "Hasan";
            this.nickTextBox.TextChanged += new System.EventHandler(this.nickTextBox_TextChanged);
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordPictureBox.BackgroundImage = global::AIO.Properties.Resources.textbox;
            this.passwordPictureBox.Location = new System.Drawing.Point(369, 214);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(263, 44);
            this.passwordPictureBox.TabIndex = 16;
            this.passwordPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AIO.Properties.Resources.textbox;
            this.pictureBox2.Location = new System.Drawing.Point(369, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 44);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(365, 187);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 24);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password";
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.BackColor = System.Drawing.Color.Transparent;
            this.nickLabel.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickLabel.ForeColor = System.Drawing.Color.White;
            this.nickLabel.Location = new System.Drawing.Point(365, 102);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(44, 24);
            this.nickLabel.TabIndex = 13;
            this.nickLabel.Text = "Nick";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO.Properties.Resources.closeBtn1;
            this.closeBtn.Location = new System.Drawing.Point(647, 15);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AIO.Properties.Resources.middleLogo;
            this.pictureBox1.Location = new System.Drawing.Point(67, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 203);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO.Properties.Resources.bg;
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