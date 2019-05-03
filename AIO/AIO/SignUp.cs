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
            string authority = AppAuthority.Authority;
            string nick = nickTextBox.Text;
            string mail = mailTextBox.Text;
            string password = passwordTextBox.Text;
                                


            AccountWebService.accountPortTypeClient YeniWebServis = new AccountWebService.accountPortTypeClient();

            string HesapBilgi = YeniWebServis.createAccount(nick, mail, password, authority);
            if (HesapBilgi == "0")
            {
                MessageBox.Show("Sign Up Failed!");
            }
            else if (HesapBilgi == "1")
            {
                MessageBox.Show("Sign Up Successfull!");
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SignIn form1 = new SignIn();
            form1.Close();
            Index f2 = new Index();
            f2.Show();

            this.Hide();
        }
    }
}
