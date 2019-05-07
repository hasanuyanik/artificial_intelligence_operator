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
        string curItem;
        private void paymentListBtn_Load(object sender, EventArgs e)
        {
            FinancialWebService.financialPortTypeClient serviceSoap = new FinancialWebService.financialPortTypeClient();
            string[] financialList = serviceSoap.getAllInvoiceListSplit(Staff.Nick, Staff.Token, AppAuthority.Authority).Split('|');
            for (int i = 0; i < financialList.Length; i++)
            {
                string[] numara = financialList[i].Split('_');
                Financial.InvoiceId = numara[0];
                Financial.Nick = numara[1];
                Financial.Date = numara[2];
                Financial.Time = numara[3];
                Financial.Price = numara[4];
                selectInvoiceListbox.Items.Add(Financial.InvoiceId + "  |" + "  " + Financial.Nick + "  |" + "  " + Financial.Date + "  |" + "  " + Financial.Time + " DK   |" + "  " + Financial.Price + " AIO MONEY");


                selectInvoiceListbox.Items.Add("-------------------------------------------------------------------------------------");
                selectInvoiceListbox.SelectedIndex = 0;
            }
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

        private void payBtn_Click(object sender, EventArgs e)
        {
            string[] Harfbul = new string[] { "|" };
            string[] KelimeDizisi = curItem.Split(Harfbul, StringSplitOptions.None);
            Financial.InvoiceId = KelimeDizisi[0];
            Financial.Nick = (KelimeDizisi[1]);
            Financial.Date = (KelimeDizisi[2]);
            Financial.Time = (KelimeDizisi[3]);
            Financial.Price = (KelimeDizisi[4]);
            PaymentPage PPage = new PaymentPage();
            PPage.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            UserProfile PymList12312sa = new UserProfile();
            PymList12312sa.Show();
            this.Hide();
        }

        private void aioChatBtn_Click(object sender, EventArgs e)
        {
            StaffChatPage StaffPage = new StaffChatPage();
            StaffPage.Show();
            this.Hide();
        }

        private void selectInvoiceListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            curItem = selectInvoiceListbox.SelectedItem.ToString();
            if (selectInvoiceListbox.SelectedIndex % 2 == 1)
                selectInvoiceListbox.SelectedIndex = 0;
        }

        private void paymentListBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
