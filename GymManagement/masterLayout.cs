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
    public partial class masterLayout : Form
    {
        public masterLayout()
        {
            InitializeComponent();
            Dashboard d = new Dashboard();
            d.TopLevel = false;
            maincontent.Controls.Clear();
            maincontent.Controls.Add(d);
            d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Dock = DockStyle.None;
            d.Show();



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUser auser = new addUser();
            auser.TopLevel = false;
            maincontent.Controls.Clear();
            maincontent.Controls.Add(auser);
            auser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            auser.Dock = DockStyle.Fill;
            auser.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewUser vuser = new ViewUser();
            vuser.TopLevel = false;
            maincontent.Controls.Clear();
            maincontent.Controls.Add(vuser);
           
            vuser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            vuser.Dock = DockStyle.Fill;
            vuser.Show();
        }

        

        

        private void maincontent_ControlRemoved(object sender, ControlEventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manageFees f = new manageFees();
            f.TopLevel = false;
            maincontent.Controls.Clear();

            maincontent.Controls.Add(f);
            
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.None;
            
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.TopLevel = false;
            maincontent.Controls.Clear();
            maincontent.Controls.Add(d);
            d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Dock = DockStyle.None;
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewFees d = new ViewFees();
            d.TopLevel = false;
            maincontent.Controls.Clear();
            maincontent.Controls.Add(d);
            d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Dock = DockStyle.None;
            d.Show();

        }
    }
}
