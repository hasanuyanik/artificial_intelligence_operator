namespace AIO_Staff
{
    partial class ProfileUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileUpdate));
            this.middlelogo = new System.Windows.Forms.PictureBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Label();
            this.aioChatBtn = new System.Windows.Forms.Label();
            this.paymentListBtn = new System.Windows.Forms.Label();
            this.profileBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.middlelogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // middlelogo
            // 
            this.middlelogo.BackColor = System.Drawing.Color.Transparent;
            this.middlelogo.BackgroundImage = global::AIO_Staff.Properties.Resources.middleLogo2;
            this.middlelogo.Location = new System.Drawing.Point(50, 85);
            this.middlelogo.Name = "middlelogo";
            this.middlelogo.Size = new System.Drawing.Size(175, 203);
            this.middlelogo.TabIndex = 1;
            this.middlelogo.TabStop = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(410, 98);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 23);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AIO_Staff.Properties.Resources.textbox7;
            this.pictureBox1.Location = new System.Drawing.Point(413, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 44);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(418, 130);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(251, 30);
            this.passwordTextBox.TabIndex = 19;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.saveBtn.ForeColor = System.Drawing.Color.Transparent;
            this.saveBtn.Image = global::AIO_Staff.Properties.Resources.middleBtn;
            this.saveBtn.Location = new System.Drawing.Point(419, 196);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(257, 62);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // aioChatBtn
            // 
            this.aioChatBtn.BackColor = System.Drawing.Color.Transparent;
            this.aioChatBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.aioChatBtn.ForeColor = System.Drawing.Color.Transparent;
            this.aioChatBtn.Image = global::AIO_Staff.Properties.Resources.btn3;
            this.aioChatBtn.Location = new System.Drawing.Point(12, 447);
            this.aioChatBtn.Name = "aioChatBtn";
            this.aioChatBtn.Size = new System.Drawing.Size(104, 50);
            this.aioChatBtn.TabIndex = 21;
            this.aioChatBtn.Text = "AIO Chat";
            this.aioChatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aioChatBtn.Click += new System.EventHandler(this.aioChatBtn_Click);
            // 
            // paymentListBtn
            // 
            this.paymentListBtn.BackColor = System.Drawing.Color.Transparent;
            this.paymentListBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.paymentListBtn.ForeColor = System.Drawing.Color.Transparent;
            this.paymentListBtn.Image = global::AIO_Staff.Properties.Resources.btn2;
            this.paymentListBtn.Location = new System.Drawing.Point(122, 447);
            this.paymentListBtn.Name = "paymentListBtn";
            this.paymentListBtn.Size = new System.Drawing.Size(154, 50);
            this.paymentListBtn.TabIndex = 22;
            this.paymentListBtn.Text = "Payment List";
            this.paymentListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentListBtn.Click += new System.EventHandler(this.paymentListBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Transparent;
            this.profileBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.profileBtn.ForeColor = System.Drawing.Color.Transparent;
            this.profileBtn.Image = global::AIO_Staff.Properties.Resources.btn3;
            this.profileBtn.Location = new System.Drawing.Point(282, 447);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(104, 50);
            this.profileBtn.TabIndex = 23;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO_Staff.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(659, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 24;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ProfileUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO_Staff.Properties.Resources.bg5;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.paymentListBtn);
            this.Controls.Add(this.aioChatBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.middlelogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileUpdate";
            this.Text = "ProfileUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.middlelogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox middlelogo;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label saveBtn;
        private System.Windows.Forms.Label aioChatBtn;
        private System.Windows.Forms.Label paymentListBtn;
        private System.Windows.Forms.Label profileBtn;
        private System.Windows.Forms.Label closeBtn;
    }
}