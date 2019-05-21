namespace AIO_Staff
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nickLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.aioChatBtn = new System.Windows.Forms.Label();
            this.profileUpdateBtn = new System.Windows.Forms.Label();
            this.removeAccountBtn = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.BackColor = System.Drawing.Color.Transparent;
            this.nickLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.nickLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nickLabel.Location = new System.Drawing.Point(390, 111);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(226, 35);
            this.nickLabel.TabIndex = 4;
            this.nickLabel.Text = "HasanUYANIK ";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(66, 144);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(175, 203);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // aioChatBtn
            // 
            this.aioChatBtn.BackColor = System.Drawing.Color.Transparent;
            this.aioChatBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.aioChatBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.aioChatBtn.Image = ((System.Drawing.Image)(resources.GetObject("aioChatBtn.Image")));
            this.aioChatBtn.Location = new System.Drawing.Point(38, 431);
            this.aioChatBtn.Name = "aioChatBtn";
            this.aioChatBtn.Size = new System.Drawing.Size(104, 50);
            this.aioChatBtn.TabIndex = 6;
            this.aioChatBtn.Text = "AIO Chat";
            this.aioChatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aioChatBtn.Click += new System.EventHandler(this.AioChatBtn_Click);
            // 
            // profileUpdateBtn
            // 
            this.profileUpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.profileUpdateBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.profileUpdateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.profileUpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileUpdateBtn.Image")));
            this.profileUpdateBtn.Location = new System.Drawing.Point(148, 431);
            this.profileUpdateBtn.Name = "profileUpdateBtn";
            this.profileUpdateBtn.Size = new System.Drawing.Size(154, 50);
            this.profileUpdateBtn.TabIndex = 7;
            this.profileUpdateBtn.Text = "Profile Update";
            this.profileUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profileUpdateBtn.Click += new System.EventHandler(this.ProfileUpdateBtn_Click);
            // 
            // removeAccountBtn
            // 
            this.removeAccountBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.removeAccountBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.removeAccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeAccountBtn.Image")));
            this.removeAccountBtn.Location = new System.Drawing.Point(468, 431);
            this.removeAccountBtn.Name = "removeAccountBtn";
            this.removeAccountBtn.Size = new System.Drawing.Size(180, 50);
            this.removeAccountBtn.TabIndex = 9;
            this.removeAccountBtn.Text = "Remove Account";
            this.removeAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeAccountBtn.Click += new System.EventHandler(this.RemoveAccountBtn_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.c.ForeColor = System.Drawing.SystemColors.Control;
            this.c.Image = ((System.Drawing.Image)(resources.GetObject("c.Image")));
            this.c.Location = new System.Drawing.Point(308, 431);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(154, 50);
            this.c.TabIndex = 10;
            this.c.Text = "Payment List";
            this.c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c.Click += new System.EventHandler(this.C_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.c);
            this.Controls.Add(this.removeAccountBtn);
            this.Controls.Add(this.profileUpdateBtn);
            this.Controls.Add(this.aioChatBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label aioChatBtn;
        private System.Windows.Forms.Label profileUpdateBtn;
        private System.Windows.Forms.Label removeAccountBtn;
        private System.Windows.Forms.Label c;
    }
}