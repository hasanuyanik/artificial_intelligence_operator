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
        public UserSessionScreen()
        {
            InitializeComponent();

          

            

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            AccountWebService.accountPortTypeClient soap = new AccountWebService.accountPortTypeClient();

            var CustomerSession = new Customer();
            var AuthorityApp = new AppAuthority();

            var logout = soap.logoutAccount(CustomerSession.Nick,CustomerSession.Token,AuthorityApp.Authority);

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
       
        }

        private void nickLabel_Click(object sender, EventArgs e)
        {
            var newUser = new Customer();
            MessageBox.Show(newUser.Nick);
        }
    }
}
