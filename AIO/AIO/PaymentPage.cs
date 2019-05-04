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
            //AIOChat aiochat = new AIOChat();
            //aiochat.show();
            //this.Hide();
        }

        private void profileUpdateBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate PrfUpdate = new ProfileUpdate();
            PrfUpdate.Show();
            this.Hide();
        }

        private void paymentListBtn_Click(object sender, EventArgs e)
        {
            PaymentList PymList = new PaymentList();
            PymList.Show();
            this.Hide();
        }
    }
}
