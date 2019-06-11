using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Globalization;

namespace GymManagement
{
   
    public partial class addUser : Form
    {
        string imgloc = "";
        public addUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            oaddress.Clear();
            oaddress.Text = address.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                    if (name.Text.Trim() == String.Empty || occupation.Text.Trim() == String.Empty || joinDate.Text.Trim() == String.Empty || address.Text.Trim() == String.Empty || guardian.Text.Trim() == String.Empty || dob.Text.Trim() == String.Empty || bgroup.Text.Trim() == String.Empty || fathername.Text.Trim() == String.Empty || foccupation.Text.Trim() == String.Empty || oaddress.Text.Trim() == String.Empty || otelno.Text.Trim() == String.Empty || mobile.Text.Trim() == String.Empty || pictureBox1.Image==null)
                    {
                        MessageBox.Show("All Fields are Required");
                    }
                    else
                    {
                        Byte[] img = null;
                        FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        viewClass u = new viewClass();
                        u.insertData(name.Text, occupation.Text, joinDate.Value.ToString("MM-dd-yyyy"), address.Text, guardian.Text, dob.Value.ToString("MM-dd-yyyy"), fathername.Text, foccupation.Text, bgroup.Text, oaddress.Text, otelno.Text, mobile.Text, img);
                        MessageBox.Show("record inserted");
                        this.Close();
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.*|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"~\Resources\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iname.Text = opFile.FileName;
                    string folder = @"../../Resources/";
                    path.Text = Path.Combine(folder, Path.GetFileName(iname.Text));
                    pictureBox1.Image = new Bitmap(opFile.OpenFile());
                    imgloc = opFile.FileName.ToString();

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void otelno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

    }
}
