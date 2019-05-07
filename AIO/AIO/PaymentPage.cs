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
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            PaymentList PymList = new PaymentList();
            PymList.Show();
            this.Hide();
        }

        private void aioChatBtn_Click(object sender, EventArgs e)
        {
            CustomerChatPage aiochat = new CustomerChatPage();
            aiochat.Show();
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
            PaymentList PymList12 = new PaymentList();
            PymList12.Show();
            this.Hide();
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            invoiceInformationListBox.Items.Add("Nick :"+Financial.Nick);
            invoiceInformationListBox.Items.Add("Date :" + Financial.Date);
            invoiceInformationListBox.Items.Add("Time :" + Financial.Time);
            invoiceInformationListBox.Items.Add("Price:" + Financial.Price);

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            FinancialWebService.financialPortTypeClient serviceSoap = new FinancialWebService.financialPortTypeClient();
            string Getir = serviceSoap.payTheInvoice(Convert.ToString( Financial.InvoiceId), Customer.Token, AppAuthority.Authority);
            if (Convert.ToInt32( Getir) == 1)
                MessageBox.Show("Payment Successful");
            else
                MessageBox.Show("Payment Failed!");
            //MessageBox.Show(Customer.Token);
            //MessageBox.Show(AppAuthority.Authority);
            //MessageBox.Show(Convert.ToString(Financial.InvoiceId));
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            UserProfile x3234x = new UserProfile();
            x3234x.Show();
            this.Hide();
        }
    }
}
