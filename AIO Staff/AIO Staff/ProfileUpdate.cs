using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIO_Staff
{
    public partial class ProfileUpdate : Form
    {
        public ProfileUpdate()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string authority = AppAuthority.Authority;
            string password = passwordTextBox.Text;
            AccountWebService.accountPortTypeClient YeniWebServis = new AccountWebService.accountPortTypeClient();

            string Update = YeniWebServis.updateAccount(password, Staff.Token, authority);
            if (Update == "0")
            {
                MessageBox.Show("Failed to update!");
            }
            else if (Update == "1")
            {
                MessageBox.Show("Update successfull");
            }
        }

        private void aioChatBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate form1 = new ProfileUpdate();
            form1.Close();
            StaffChatPage f2 = new StaffChatPage();
            f2.Show();

            this.Hide();
        }

        private void paymentListBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate eskiform = new ProfileUpdate();
            eskiform.Close();
           paymentlist yeniform = new paymentlist();
            yeniform.Show();

            this.Hide();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate eskiform1 = new ProfileUpdate();
            eskiform1.Close();
            UserProfile yeniform1 = new UserProfile();
            yeniform1.Show();

            this.Hide();
        }
    }
}
