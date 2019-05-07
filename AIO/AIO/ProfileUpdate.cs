using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIO
{
    public partial class ProfileUpdate : Form
    {
        public ProfileUpdate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate f1 = new ProfileUpdate();
            f1.Close();
            UserProfile f2 = new UserProfile();
            f2.Show();

            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string authority = AppAuthority.Authority;
            string password = passwordTextBox.Text;
            AccountWebService.accountPortTypeClient YeniWebServis = new AccountWebService.accountPortTypeClient();

            string Update = YeniWebServis.updateAccount(password, authority, Customer.Token);
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
            CustomerChatPage f2 = new CustomerChatPage();
            f2.Show();

            this.Hide();
            
        }

        private void paymentListBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate eskiform = new ProfileUpdate();
            eskiform.Close();
            PaymentList yeniform = new PaymentList();
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
