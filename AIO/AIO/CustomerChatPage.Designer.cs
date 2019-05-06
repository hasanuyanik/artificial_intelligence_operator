namespace AIO
{
    partial class CustomerChatPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.messageScreenListBox = new System.Windows.Forms.ListBox();
            this.sendBtn = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AIO.Properties.Resources.smallLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO.Properties.Resources.closeBtn4;
            this.closeBtn.Location = new System.Drawing.Point(652, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AIO.Properties.Resources.messageScreen1;
            this.pictureBox2.Image = global::AIO.Properties.Resources.messageScreen;
            this.pictureBox2.Location = new System.Drawing.Point(147, 62);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(533, 369);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // messageScreenListBox
            // 
            this.messageScreenListBox.BackColor = System.Drawing.Color.Black;
            this.messageScreenListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageScreenListBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageScreenListBox.ForeColor = System.Drawing.Color.White;
            this.messageScreenListBox.FormattingEnabled = true;
            this.messageScreenListBox.ItemHeight = 26;
            this.messageScreenListBox.Location = new System.Drawing.Point(152, 80);
            this.messageScreenListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageScreenListBox.Name = "messageScreenListBox";
            this.messageScreenListBox.Size = new System.Drawing.Size(520, 338);
            this.messageScreenListBox.TabIndex = 4;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Black;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Image = global::AIO.Properties.Resources.btn23;
            this.sendBtn.Location = new System.Drawing.Point(475, 433);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(205, 62);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "SEND";
            this.sendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageTextBox.ForeColor = System.Drawing.Color.Silver;
            this.messageTextBox.Location = new System.Drawing.Point(148, 436);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(321, 52);
            this.messageTextBox.TabIndex = 7;
            this.messageTextBox.Text = "MESSAGE";
            this.messageTextBox.Enter += new System.EventHandler(this.messageTextBox_Enter);
            this.messageTextBox.Leave += new System.EventHandler(this.messageTextBox_Leave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomerChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO.Properties.Resources.bg6;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.messageScreenListBox);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerChatPage";
            this.Text = "CustomerChatPage";
            this.Load += new System.EventHandler(this.CustomerChatPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox messageScreenListBox;
        private System.Windows.Forms.Label sendBtn;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}