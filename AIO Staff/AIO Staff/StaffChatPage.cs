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
        string nick;
        string token;
        string authority;
        string term = "";
        AIOWebService.aioPortTypeClient serviceSoap = new AIOWebService.aioPortTypeClient();
        public StaffChatPage()
        {
            InitializeComponent();
            nick = Staff.Nick;
            token = Staff.Token;
            authority = Staff.Authority;
        }

        private void StaffChatPage_Load(object sender, EventArgs e)
        {
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            UserProfile userprofile = new UserProfile();
            userprofile.Show();
            this.Close();
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
            AIOWebService.aioPortTypeClient serviceSoap = new AIOWebService.aioPortTypeClient();

            messageScreenListBox.Items.Add(nick + " : " + messageTextBox.Text);

            messageScreenListBox.Items.Add("AIO : " + (serviceSoap.talk(messageTextBox.Text, token, AppAuthority.Authority)));

        }

        private void aioSendBtn_Click(object sender, EventArgs e)
        {
            
            if(messageScreenListBox.Items.Count % 2 == 0)
            {
                messageScreenListBox.Items.Add("AIO : " + aioMessageTextBox.Text);
            }
            else
            {
                term = messageScreenListBox.Items[messageScreenListBox.Items.Count - 1].ToString().Replace("AIO : ","");
                serviceSoap.teach(term, aioMessageTextBox.Text, nick, token, AppAuthority.Authority);
                messageScreenListBox.Items.Add("AIO : " + aioMessageTextBox.Text);

            }

        }
    }
}
