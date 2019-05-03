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
    
    public partial class Index : Form
    {
        Thread th;
        public Index()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Index_Load(object sender, EventArgs e)
        {
            
        }
    }
}
