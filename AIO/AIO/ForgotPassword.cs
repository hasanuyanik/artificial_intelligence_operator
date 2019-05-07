using System;
using System.Threading;
using System.Windows.Forms;

namespace AIO
{
    public partial class ForgotPassword : Form
    {
        Thread th;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string authority = AppAuthority.Authority;

            string mail = mailTextBox.Text;
            AccountWebService.accountPortTypeClient soap = new AccountWebService.accountPortTypeClient();


            string forgotPassword = soap.forgotPasswordToMailSend(mail, authority).ToString();

            if (forgotPassword == "0")
            {
                MessageBox.Show("Password operation failed!");
            }
            else
            {
                var loginReturn = forgotPassword.Split('_');


                Customer.Token = loginReturn[0];
                Customer.Nick = loginReturn[1];
                Customer.Money = loginReturn[2];


                MessageBox.Show("Your new password has been sent to your mail. Check your mail.");
                th = new Thread(openingUserProfile);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                th = new Thread(openingUserSessionScreen);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
        }

        private void openingUserSessionScreen()
        {
            Application.Run(new UserSessionScreen());
        }

        private void openingUserProfile()
        {
            Application.Run(new UserProfile()); 
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(openingSignIn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openingSignIn()
        {
            Application.Run(new SignIn());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(openingIndex);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openingIndex()
        {
            Application.Run(new Index());
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(openingSignUp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openingSignUp()
        {
            Application.Run(new SignUp());
        }
    }
}

