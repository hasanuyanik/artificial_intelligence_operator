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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            SignUp f1 = new SignUp();
            f1.Close();
            Index f2 = new Index();
            f2.Show();

            this.Hide();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            WebServis1.accountPortTypeClient YeniWebServis = new WebServis1.accountPortTypeClient(); 

            string HesapBilgi = YeniWebServis.createAccount(nickTextBox.Text,mailTextBox.Text,pas)
        }
    }
}
