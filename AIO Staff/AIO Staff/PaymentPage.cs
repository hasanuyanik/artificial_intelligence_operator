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
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void aioChatBtn_Click(object sender, EventArgs e)
        {
            StaffChatPage StaffChat = new StaffChatPage();
            StaffChat.Show();
            this.Hide();
        }

        private void profileUpdateBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate PrfUpdate = new ProfileUpdate();
            PrfUpdate.Show();
            this.Hide();
        }

        private void paymentListBtn_Click(object sender, EventArgs e)
        {
            paymentlist PymList12 = new paymentlist();
            PymList12.Show();
            this.Hide();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            //UserProfile x3234x = new UserProfile();
            //x3234x.Show();
            //this.Hide();
        }
    
    }
}
