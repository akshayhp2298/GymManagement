using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
            viewClass v = new viewClass();
            v.check();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Visible = false;
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
