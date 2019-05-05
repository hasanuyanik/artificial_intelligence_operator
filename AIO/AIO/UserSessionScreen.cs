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
    public partial class UserSessionScreen : Form
    {
        Thread th;
        static int ticks;
        public UserSessionScreen()
        {
            InitializeComponent();

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width - 402, Screen.PrimaryScreen.WorkingArea.Size.Height - 73);

            nickLabel.Text = Customer.Nick;
            moneyLabel.Text = Customer.Money+" AIO Money";

            

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            AccountWebService.accountPortTypeClient soap = new AccountWebService.accountPortTypeClient();
            
            var logout = soap.logoutAccount(Customer.Nick,Customer.Token,AppAuthority.Authority);

            if (logout == "1")
            {

            }
            else if(logout == "0") {
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

        private void UserSessionScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void nickLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void moneyLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;



            AccountWebService.accountPortTypeClient soap = new AccountWebService.accountPortTypeClient();

            string money = soap.updatedFetchSessionData(Customer.Nick, Customer.Token);


            if (money != "0")
            {

                Customer.Money = money;

            }

            moneyLabel.Text = Customer.Money + " AIO Money";
        }
           
            
    }
}
