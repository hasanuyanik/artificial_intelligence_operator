namespace AIO_Staff
{
    partial class StaffChatPage
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.aioMessageTextBox = new System.Windows.Forms.TextBox();
            this.aioSendBtn = new System.Windows.Forms.Label();
            this.messageScreenListBox = new System.Windows.Forms.ListBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::AIO_Staff.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(118, 137);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO_Staff.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(658, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // aioMessageTextBox
            // 
            this.aioMessageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.aioMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aioMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aioMessageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.aioMessageTextBox.Location = new System.Drawing.Point(164, 79);
            this.aioMessageTextBox.Name = "aioMessageTextBox";
            this.aioMessageTextBox.Size = new System.Drawing.Size(346, 31);
            this.aioMessageTextBox.TabIndex = 2;
            this.aioMessageTextBox.Text = "Example Message";
            this.aioMessageTextBox.MouseEnter += new System.EventHandler(this.aioMessageTextBox_MouseEnter);
            this.aioMessageTextBox.MouseLeave += new System.EventHandler(this.aioMessageTextBox_MouseLeave);
            // 
            // aioSendBtn
            // 
            this.aioSendBtn.BackColor = System.Drawing.Color.Transparent;
            this.aioSendBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aioSendBtn.ForeColor = System.Drawing.Color.White;
            this.aioSendBtn.Image = global::AIO_Staff.Properties.Resources.btn21;
            this.aioSendBtn.Location = new System.Drawing.Point(533, 68);
            this.aioSendBtn.Name = "aioSendBtn";
            this.aioSendBtn.Size = new System.Drawing.Size(154, 50);
            this.aioSendBtn.TabIndex = 3;
            this.aioSendBtn.Text = "SEND FOR AIO";
            this.aioSendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aioSendBtn.Click += new System.EventHandler(this.aioSendBtn_Click);
            // 
            // messageScreenListBox
            // 
            this.messageScreenListBox.BackColor = System.Drawing.Color.Black;
            this.messageScreenListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageScreenListBox.ForeColor = System.Drawing.Color.White;
            this.messageScreenListBox.FormattingEnabled = true;
            this.messageScreenListBox.Location = new System.Drawing.Point(164, 152);
            this.messageScreenListBox.Name = "messageScreenListBox";
            this.messageScreenListBox.Size = new System.Drawing.Size(507, 273);
            this.messageScreenListBox.TabIndex = 4;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.messageTextBox.Location = new System.Drawing.Point(165, 450);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(346, 31);
            this.messageTextBox.TabIndex = 5;
            this.messageTextBox.Text = "Message";
            this.messageTextBox.MouseEnter += new System.EventHandler(this.messageTextBox_MouseEnter);
            this.messageTextBox.MouseLeave += new System.EventHandler(this.messageTextBox_MouseLeave);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Image = global::AIO_Staff.Properties.Resources.btn21;
            this.sendBtn.Location = new System.Drawing.Point(533, 439);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(154, 50);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "SEND";
            this.sendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AIO_Staff.Properties.Resources.messageScreen;
            this.pictureBox1.Image = global::AIO_Staff.Properties.Resources.messageScreen;
            this.pictureBox1.Location = new System.Drawing.Point(154, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 294);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::AIO_Staff.Properties.Resources.messageTextBox;
            this.label1.Location = new System.Drawing.Point(158, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 46);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::AIO_Staff.Properties.Resources.messageTextBox;
            this.label2.Location = new System.Drawing.Point(158, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 46);
            this.label2.TabIndex = 8;
            // 
            // StaffChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO_Staff.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(706, 509);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageScreenListBox);
            this.Controls.Add(this.aioSendBtn);
            this.Controls.Add(this.aioMessageTextBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffChatPage";
            this.Text = "StaffChatPage";
            this.Load += new System.EventHandler(this.StaffChatPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.TextBox aioMessageTextBox;
        private System.Windows.Forms.Label aioSendBtn;
        private System.Windows.Forms.ListBox messageScreenListBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label sendBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}