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
    public partial class PaymentList : Form
    {
        public PaymentList()
        {
            InitializeComponent();
        }

        string curItem;
        private void PaymentList_Load(object sender, EventArgs e)
        {
  
            FinancialWebService.financialPortTypeClient serviceSoap = new FinancialWebService.financialPortTypeClient();
            string[] financialList = serviceSoap.getAllInvoiceListSplit(Customer.Nick, Customer.Token, AppAuthority.Authority).Split('|');
            for (int i = 0; i < financialList.Length; i++)
            {
                string[] numara = financialList[i].Split('_');
                Financial.InvoiceId =Convert.ToInt32( numara[0]);
                Financial.Nick =numara[1];
                Financial.Date = numara[2];
                Financial.Time = numara[3];
                Financial.Price = numara[4];
                selectInvolceListbox.Items.Add(Financial.InvoiceId + "  |" + "  " + Financial.Nick+ "  |" +"  "+ Financial.Date + "  |" + "  " + Financial.Time + " DK   |" + "  " + Financial.Price+" AIO MONEY");
       

                selectInvolceListbox.Items.Add("-------------------------------------------------------------------------------------");
                selectInvolceListbox.SelectedIndex = 0;

            }
  
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            UserProfile PymList12312sa = new UserProfile();
            PymList12312sa.Show();
            this.Hide();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {                    
            string[] Harfbul = new string[] { "|" };
            string[] KelimeDizisi = curItem.Split(Harfbul, StringSplitOptions.None);
            Financial.InvoiceId = Convert.ToInt32(KelimeDizisi[0]);
            Financial.Nick=(KelimeDizisi[1]);
            Financial.Date = (KelimeDizisi[2]);
            Financial.Time = (KelimeDizisi[3]);
            Financial.Price = (KelimeDizisi[4]);
            PaymentPage PPage = new PaymentPage();
            PPage.Show();
            this.Hide();
        }

        private void paymentListBtn_Click(object sender, EventArgs e)
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
            UserProfile Profile = new UserProfile();
            Profile.Show();
            this.Hide();
        }

        private void selectInvolceListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
             curItem = selectInvolceListbox.SelectedItem.ToString();
            if (selectInvolceListbox.SelectedIndex % 2 == 1)
               selectInvolceListbox.SelectedIndex = 0;
              
            
        }

        private void aioChatBtn_Click(object sender, EventArgs e)
        {
            CustomerChatPage aiochat = new CustomerChatPage();
            aiochat.Show();
            this.Hide();
        }
    }
}
