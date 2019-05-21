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
            if (serviceSoap.talk(messageTextBox.Text, token, AppAuthority.Authority) == "0")
                messageScreenListBox.Items.Add("AIO : Bu konuda bilgim yok.");
            else
                messageScreenListBox.Items.Add("AIO : " + (serviceSoap.talk(messageTextBox.Text, token, AppAuthority.Authority)));

        }

        private void aioSendBtn_Click(object sender, EventArgs e)
        {
            if(messageScreenListBox.Items.Count > 0) { 

            for (int i = 0; i < messageScreenListBox.Items.Count - 1; i++) {
                string row = messageScreenListBox.Items[i].ToString();
                var rowSplit = row.Split(':');
                if (rowSplit[0] == Staff.Nick + " ") {
                    var colSplit = rowSplit[1].Split(' ');
                        term = row.Replace(Staff.Nick+" : ","");
                }
            }

                //term = messageScreenListBox.Items[messageScreenListBox.Items.Count - 1].ToString().Replace("AIO : ","");
                string teachStatu = serviceSoap.teach(term, aioMessageTextBox.Text, nick, token, AppAuthority.Authority);
                messageScreenListBox.Items.Add("AIO : " + aioMessageTextBox.Text);
                if (teachStatu == "1")
                {
                    messageScreenListBox.Items.Add("System : Teaching is Successful!");
                }
                else {
                    messageScreenListBox.Items.Add("System : Teaching is Failed!");
                }
                }

        }
    }
}
