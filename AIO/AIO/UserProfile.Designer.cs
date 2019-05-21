namespace AIO
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
            this.moneylabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nickLabel = new System.Windows.Forms.Label();
            this.aioChatBtn = new System.Windows.Forms.Label();
            this.profileUpdateBtn = new System.Windows.Forms.Label();
            this.paymentListBtn = new System.Windows.Forms.Label();
            this.removeAccountBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // moneylabel
            // 
            this.moneylabel.BackColor = System.Drawing.Color.Transparent;
            this.moneylabel.Font = new System.Drawing.Font("Arial", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.moneylabel.ForeColor = System.Drawing.SystemColors.Control;
            this.moneylabel.Image = ((System.Drawing.Image)(resources.GetObject("moneylabel.Image")));
            this.moneylabel.Location = new System.Drawing.Point(269, 195);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moneylabel.Size = new System.Drawing.Size(367, 169);
            this.moneylabel.TabIndex = 4;
            this.moneylabel.Text = "5000";
            this.moneylabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moneylabel.Click += new System.EventHandler(this.Moneylabel_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(35, 161);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(175, 203);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.BackColor = System.Drawing.Color.Transparent;
            this.nickLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.nickLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nickLabel.Location = new System.Drawing.Point(396, 79);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(226, 35);
            this.nickLabel.TabIndex = 3;
            this.nickLabel.Text = "HasanUYANIK ";
            this.nickLabel.Click += new System.EventHandler(this.nickLabel_Click);
            // 
            // aioChatBtn
            // 
            this.aioChatBtn.BackColor = System.Drawing.Color.Transparent;
            this.aioChatBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.aioChatBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.aioChatBtn.Image = ((System.Drawing.Image)(resources.GetObject("aioChatBtn.Image")));
            this.aioChatBtn.Location = new System.Drawing.Point(42, 433);
            this.aioChatBtn.Name = "aioChatBtn";
            this.aioChatBtn.Size = new System.Drawing.Size(104, 50);
            this.aioChatBtn.TabIndex = 5;
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
            this.profileUpdateBtn.Location = new System.Drawing.Point(152, 433);
            this.profileUpdateBtn.Name = "profileUpdateBtn";
            this.profileUpdateBtn.Size = new System.Drawing.Size(154, 50);
            this.profileUpdateBtn.TabIndex = 6;
            this.profileUpdateBtn.Text = "Profile Update";
            this.profileUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profileUpdateBtn.Click += new System.EventHandler(this.ProfileUpdateBtn_Click);
            // 
            // paymentListBtn
            // 
            this.paymentListBtn.BackColor = System.Drawing.Color.Transparent;
            this.paymentListBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.paymentListBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.paymentListBtn.Image = ((System.Drawing.Image)(resources.GetObject("paymentListBtn.Image")));
            this.paymentListBtn.Location = new System.Drawing.Point(312, 433);
            this.paymentListBtn.Name = "paymentListBtn";
            this.paymentListBtn.Size = new System.Drawing.Size(154, 50);
            this.paymentListBtn.TabIndex = 7;
            this.paymentListBtn.Text = "Payment List";
            this.paymentListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentListBtn.Click += new System.EventHandler(this.PaymentListBtn_Click);
            // 
            // removeAccountBtn
            // 
            this.removeAccountBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.removeAccountBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.removeAccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeAccountBtn.Image")));
            this.removeAccountBtn.Location = new System.Drawing.Point(472, 433);
            this.removeAccountBtn.Name = "removeAccountBtn";
            this.removeAccountBtn.Size = new System.Drawing.Size(180, 50);
            this.removeAccountBtn.TabIndex = 8;
            this.removeAccountBtn.Text = "Remove Account";
            this.removeAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeAccountBtn.Click += new System.EventHandler(this.RemoveAccountBtn_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.removeAccountBtn);
            this.Controls.Add(this.paymentListBtn);
            this.Controls.Add(this.profileUpdateBtn);
            this.Controls.Add(this.aioChatBtn);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label aioChatBtn;
        private System.Windows.Forms.Label profileUpdateBtn;
        private System.Windows.Forms.Label paymentListBtn;
        private System.Windows.Forms.Label removeAccountBtn;
        private System.Windows.Forms.Label moneylabel;
    }
}