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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void AioChatBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void PaymentListBtn_Click(object sender, EventArgs e)
        {
            Form payment = new PaymentList();
            payment.Show();
            this.Close();


        }

        private void ProfileUpdateBtn_Click(object sender, EventArgs e)
        {
            Form update = new ProfileUpdate();
            update.Show();
            this.Close();
        }

        private void RemoveAccountBtn_Click(object sender, EventArgs e)
        {
            AccountWebService.accountPortTypeClient servisaccount = new AccountWebService.accountPortTypeClient();

            



        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void nickLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
