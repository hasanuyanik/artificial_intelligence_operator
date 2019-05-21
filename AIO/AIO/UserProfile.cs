using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AIO
{
    public partial class UserProfile : Form
    {
        Thread th;
        public UserProfile()
        {
            InitializeComponent();

            

            nickLabel.Text = Customer.Nick;
            moneylabel.Text = Customer.Money;
            

        }

     

        private void AioChatBtn_Click(object sender, EventArgs e)
        {
            CustomerChatPage chat = new CustomerChatPage();
            chat.Show();
            this.Hide();
        }

        private void PaymentListBtn_Click(object sender, EventArgs e)
        {
            PaymentList PymList = new PaymentList();
            PymList.Show();
            this.Hide();

        }

        private void ProfileUpdateBtn_Click(object sender, EventArgs e)
        {
            Form update = new ProfileUpdate();
            update.Show();
            this.Hide();
        }

        private void RemoveAccountBtn_Click(object sender, EventArgs e)
        {
            string token = Customer.Token;
            string authority = AppAuthority.Authority;
            

            AccountWebService.accountPortTypeClient servisaccount = new AccountWebService.accountPortTypeClient();

            var HesapSilme = servisaccount.deleteAccount(Customer.Token,AppAuthority.Authority);

            if (HesapSilme == "0") 
            {
                MessageBox.Show("Delete Failed!");



            }
            else if (HesapSilme == "1")
            {
                MessageBox.Show("Delete Successfull!");

                
                th = new Thread(openingIndex);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                Application.Exit();



            }







        }
        private void openingIndex()
        {
            Application.Run(new Index());
        }



        private void UserProfile_Load(object sender, EventArgs e)
        {
            // Güncel Money değeri için

            AccountWebService.accountPortTypeClient soap = new AccountWebService.accountPortTypeClient();

            string money = soap.updatedFetchSessionData(Customer.Nick, Customer.Token);

            if (money != "0")
            {
                Customer.Money = money;
                
            }

            // Güncel Money değeri için
        }

        private void nickLabel_Click(object sender, EventArgs e)
        {

        }

        private void Moneylabel_Click(object sender, EventArgs e)
        {

        }
    }
}
