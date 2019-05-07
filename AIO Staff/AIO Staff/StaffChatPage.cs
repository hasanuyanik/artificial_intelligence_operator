using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AIMLbot;

namespace AIO_Staff
{
    public partial class StaffChatPage : Form
    {
        public StaffChatPage()
        {
            InitializeComponent();
        }

        private void StaffChatPage_Load(object sender, EventArgs e)
        {
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //USER PROFILE ACILACAK;

        }
        bool siyah;
        private void aioMessageTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (aioMessageTextBox.Text == "Example Message")
            {
                aioMessageTextBox.Text = "";
                aioMessageTextBox.ForeColor = Color.Black;
                siyah = true;
            }
        }

        private void aioMessageTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (aioMessageTextBox.Text == "")
            {
                aioMessageTextBox.Text = "Example Message";
                aioMessageTextBox.ForeColor = Color.Silver;
                siyah = false;
            }
        }

        private void messageTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "Message")
            {
                messageTextBox.Text = "";
                messageTextBox.ForeColor = Color.Black;
                siyah = true;
            }
        }

        private void messageTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "")
            {
                messageTextBox.Text = "Message";
                messageTextBox.ForeColor = Color.Silver;
                siyah = false;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            /*Bot AI = new Bot();
            AI.loadSettings();
            AI.loadAIMLFromFiles();
            AI.isAcceptingUserInput = false;
            User myuser = new User("Username Here", AI);
            AI.isAcceptingUserInput = true;
            Request r = new Request(messageTextBox.Text, myuser, AI);
            Result res = AI.Chat(r);
            messageScreenListBox.Text = "AIO : " + res.Output;*/
            messageScreenListBox.Items.Add("ID : " + messageTextBox.Text);
        }

        private void aioSendBtn_Click(object sender, EventArgs e)
        {
            messageScreenListBox.Items.Add("AIO : " + aioMessageTextBox.Text);

        }
    }
}
