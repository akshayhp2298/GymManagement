using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
      
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(UsernametextBox.Text=="BigBFitnessstudio36" && PasswordtextBox.Text == "bfs36@36")
            {
                masterLayout form = new masterLayout();
                form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect!");
            }
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
