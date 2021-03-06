﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AIO_Staff
{
    public partial class UserProfile : Form
    {
        Thread th;

        public UserProfile()
        {
            InitializeComponent();

            nickLabel.Text = Staff.Nick;

        }

        

        private void AioChatBtn_Click(object sender, EventArgs e)
        {
           StaffChatPage chat = new StaffChatPage();
           chat.Show();
           this.Hide();
        }

        private void ProfileUpdateBtn_Click(object sender, EventArgs e)
        {
            Form update = new ProfileUpdate();
            update.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {
            paymentlist PymList = new paymentlist();
            PymList.Show();
            this.Hide();
        }

        private void RemoveAccountBtn_Click(object sender, EventArgs e)
        {
            string token = Staff.Token;
            string authority = AppAuthority.Authority;


            AccountWebService.accountPortTypeClient servisaccount = new AccountWebService.accountPortTypeClient();

            var HesapSilme = servisaccount.deleteAccount(Staff.Token, AppAuthority.Authority);

            if (HesapSilme == "0")
            {
                MessageBox.Show("Delete Failed!");



            }

            else if (HesapSilme == "1")
            {
                MessageBox.Show("Delete Successfull!");

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




    }
}
