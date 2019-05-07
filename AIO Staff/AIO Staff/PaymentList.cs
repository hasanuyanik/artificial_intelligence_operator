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
    public partial class paymentlist : Form
    {
        public paymentlist()
        {
            InitializeComponent();
        }

        private void paymentListBtn_Load(object sender, EventArgs e)
        {

        }

        private void profileUpdateBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate Pupdate = new ProfileUpdate();
            Pupdate.Show();
            this.Hide();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            //UserProfile Profile = new UserProfile();
            //Profile.Show();
            //this.Hide();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            PaymentPage PPage = new PaymentPage();
            PPage.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //UserProfile PymList12312sa = new UserProfile();
            //PymList12312sa.Show();
            //this.Hide();
        }

        private void aioChatBtn_Click(object sender, EventArgs e)
        {
            StaffChatPage StaffPage = new StaffChatPage();
            StaffPage.Show();
            this.Hide();
        }
    }
}
