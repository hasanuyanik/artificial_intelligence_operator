namespace AIO
{
    partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.logo = new System.Windows.Forms.PictureBox();
            this.invoiceInformationListBox = new System.Windows.Forms.ListBox();
            this.invoiceInformationLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.aioChatBtn = new System.Windows.Forms.Label();
            this.profileUpdateBtn = new System.Windows.Forms.Label();
            this.paymentListBtn = new System.Windows.Forms.Label();
            this.profileBtn = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::AIO.Properties.Resources.logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(32, 157);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(175, 203);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // invoiceInformationListBox
            // 
            this.invoiceInformationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.invoiceInformationListBox.FormattingEnabled = true;
            this.invoiceInformationListBox.ItemHeight = 18;
            this.invoiceInformationListBox.Location = new System.Drawing.Point(287, 117);
            this.invoiceInformationListBox.Name = "invoiceInformationListBox";
            this.invoiceInformationListBox.Size = new System.Drawing.Size(387, 184);
            this.invoiceInformationListBox.TabIndex = 1;
            // 
            // invoiceInformationLabel
            // 
            this.invoiceInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.invoiceInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.invoiceInformationLabel.ForeColor = System.Drawing.Color.White;
            this.invoiceInformationLabel.Location = new System.Drawing.Point(284, 91);
            this.invoiceInformationLabel.Name = "invoiceInformationLabel";
            this.invoiceInformationLabel.Size = new System.Drawing.Size(154, 23);
            this.invoiceInformationLabel.TabIndex = 2;
            this.invoiceInformationLabel.Text = "Invoice Information";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = global::AIO.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(653, 28);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // aioChatBtn
            // 
            this.aioChatBtn.BackColor = System.Drawing.Color.Transparent;
            this.aioChatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aioChatBtn.ForeColor = System.Drawing.Color.White;
            this.aioChatBtn.Image = ((System.Drawing.Image)(resources.GetObject("aioChatBtn.Image")));
            this.aioChatBtn.Location = new System.Drawing.Point(14, 437);
            this.aioChatBtn.Name = "aioChatBtn";
            this.aioChatBtn.Size = new System.Drawing.Size(104, 50);
            this.aioChatBtn.TabIndex = 4;
            this.aioChatBtn.Text = "AIO Chat";
            this.aioChatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aioChatBtn.Click += new System.EventHandler(this.aioChatBtn_Click);
            // 
            // profileUpdateBtn
            // 
            this.profileUpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.profileUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profileUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.profileUpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileUpdateBtn.Image")));
            this.profileUpdateBtn.Location = new System.Drawing.Point(124, 437);
            this.profileUpdateBtn.Name = "profileUpdateBtn";
            this.profileUpdateBtn.Size = new System.Drawing.Size(154, 50);
            this.profileUpdateBtn.TabIndex = 5;
            this.profileUpdateBtn.Text = "Profile Update";
            this.profileUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profileUpdateBtn.Click += new System.EventHandler(this.profileUpdateBtn_Click);
            // 
            // paymentListBtn
            // 
            this.paymentListBtn.BackColor = System.Drawing.Color.Transparent;
            this.paymentListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paymentListBtn.ForeColor = System.Drawing.Color.White;
            this.paymentListBtn.Image = ((System.Drawing.Image)(resources.GetObject("paymentListBtn.Image")));
            this.paymentListBtn.Location = new System.Drawing.Point(284, 437);
            this.paymentListBtn.Name = "paymentListBtn";
            this.paymentListBtn.Size = new System.Drawing.Size(154, 50);
            this.paymentListBtn.TabIndex = 6;
            this.paymentListBtn.Text = "Payment List";
            this.paymentListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentListBtn.Click += new System.EventHandler(this.paymentListBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Transparent;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.Location = new System.Drawing.Point(444, 437);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(104, 50);
            this.profileBtn.TabIndex = 7;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Transparent;
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Image = ((System.Drawing.Image)(resources.GetObject("payBtn.Image")));
            this.payBtn.Location = new System.Drawing.Point(520, 331);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(154, 50);
            this.payBtn.TabIndex = 8;
            this.payBtn.Text = "Pay";
            this.payBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.paymentListBtn);
            this.Controls.Add(this.profileUpdateBtn);
            this.Controls.Add(this.aioChatBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.invoiceInformationLabel);
            this.Controls.Add(this.invoiceInformationListBox);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentPage";
            this.Text = "PaymentPage";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ListBox invoiceInformationListBox;
        private System.Windows.Forms.Label invoiceInformationLabel;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label aioChatBtn;
        private System.Windows.Forms.Label profileUpdateBtn;
        private System.Windows.Forms.Label paymentListBtn;
        private System.Windows.Forms.Label profileBtn;
        private System.Windows.Forms.Label payBtn;
    }
}