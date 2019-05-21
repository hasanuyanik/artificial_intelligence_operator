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
    public partial class Intro : Form
    {
        int time;
        Thread th;
        public Intro()
        {
            InitializeComponent();
            
            

            timer1.Start();

            
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            if (time == 10) {
                th = new Thread(openingIndex);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
        }

        private void openingIndex()
        {
            Application.Run(new Index());
        }
    }
}
