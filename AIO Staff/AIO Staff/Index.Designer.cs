namespace AIO_Staff
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
            this.closeBtn = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO_Staff.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(661, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Image = global::AIO_Staff.Properties.Resources.bigBtn;
            this.signInBtn.Location = new System.Drawing.Point(62, 335);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(256, 106);
            this.signInBtn.TabIndex = 1;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::AIO_Staff.Properties.Resources.bigBtn;
            this.label1.Location = new System.Drawing.Point(389, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::AIO_Staff.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(263, 77);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(180, 203);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::AIO_Staff.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label signInBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
    }
}

