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
        string ReturnStatu;
        private void PaymentList_Load(object sender, EventArgs e)
        {
            FinancialWebService.invoicePortTypeClient serviceSoap = new FinancialWebService.invoicePortTypeClient();
            string ReturnStatu = serviceSoap.getAllInvoiceListSplit(Customer.Nick, Customer.Token, AppAuthority.Authority);
            selectInvolceListbox.Items.Add(ReturnStatu);
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ReturnStatu);
        }
    }
}
