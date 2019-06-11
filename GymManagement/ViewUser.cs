using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GymManagement
{
    
    public partial class ViewUser : Form
    {
        viewClass v = new viewClass();
        string imgloc = "";
        bool i = false;
        int id;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {            
            var select = "SELECT * FROM [dbo].[user]";            
            var ds = v.load_data(select);            
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["occupation"].Visible = false;
            dataGridView1.Columns["gurdian"].Visible = false;
            dataGridView1.Columns["father_name"].Visible = false;
            dataGridView1.Columns["father_occupation"].Visible = false;
            dataGridView1.Columns["official_address"].Visible = false;
            dataGridView1.Columns["tel_no"].Visible = false;
            dataGridView1.Columns["photo"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Name";
            dataGridView1.Columns["doj"].HeaderText = "Join Date";
            dataGridView1.Columns["doj"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns["address"].HeaderText = "Address";
            dataGridView1.Columns["mobile"].HeaderText = "Mobile";
            dataGridView1.Columns["b_group"].HeaderText = "Blood Group";
            dataGridView1.Columns["dob"].HeaderText = "Birthdate";
            dataGridView1.Columns["dob"].DefaultCellStyle.Format = "dd-MM-yyyy";

            dataGridView1.Columns["address"].SortMode= DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["mobile"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["b_group"].SortMode = DataGridViewColumnSortMode.NotSortable;



            //    con.Open();
            //    SqlDataAdapter adpa = new SqlDataAdapter("SELECT * FROM [dbo].[user]", con);
            //    DataSet ds = new System.Data.DataSet();
            //    adpa.Fill(ds, "user");
            //    dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing; //or even better .DisableResizing. Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            //// set it to false if not needed
            //dataGridView1.RowHeadersVisible = false;
            //con.Close();


        }
        private void ViewUser_Load(object sender, EventArgs e)
        {
           
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                
            }

        }

       

        
        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (id != (int)dataGridView1.CurrentRow.Cells["Id"].Value)
                {
                    id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    try
                    {
                        //gets a collection that contains all the rows
                        DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                        //populate the textbox from specific value of the coordinates of column and row.
                        name.Text = row.Cells["name"].Value.ToString();
                        occupation.Text = row.Cells["occupation"].Value.ToString();
                        joinDate.Value = DateTime.Parse(row.Cells["doj"].Value.ToString());
                        address.Text = row.Cells["address"].Value.ToString();
                        guardian.Text = row.Cells["gurdian"].Value.ToString();
                        dob.Value = DateTime.Parse(row.Cells["dob"].Value.ToString());
                        fathername.Text = row.Cells["father_name"].Value.ToString();
                        foccupation.Text = row.Cells["father_occupation"].Value.ToString();
                        bgroup.SelectedText  = row.Cells["b_group"].Value.ToString();
                        oaddress.Text = row.Cells["official_address"].Value.ToString();
                        otelno.Text = row.Cells["tel_no"].Value.ToString();
                        mobile.Text = row.Cells["mobile"].Value.ToString();
                        byte[] img = (byte[])(row.Cells["photo"].Value);
                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                        
                        DataSet ds = v.load_data("SELECT * FROM [dbo].[fees] where user_id=" + id);
                        dataGridView2.DataSource = ds.Tables[0];
                        dataGridView2.Columns["Id"].Visible = false;
                        dataGridView2.Columns["nextpayment"].Visible = false;
                        dataGridView2.Columns["user_id"].Visible = false;
                        dataGridView2.Columns["amount"].HeaderText = "Amount";
                        dataGridView2.Columns["validity"].HeaderText = "Validity";
                        dataGridView2.Columns["fees_date"].HeaderText = "Date";
                        dataGridView2.Columns["expire_date"].HeaderText = "Expires";
                        dataGridView2.Columns["expire_date"].SortMode = DataGridViewColumnSortMode.Automatic;

                        // dataGridView1.Columns["fees_date"].DefaultCellStyle.Format = "dd-MM-yyyy";

                    }
                    catch (Exception ex)
                    {
                        
                    }

                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Trim() == String.Empty || occupation.Text.Trim() == String.Empty || joinDate.Text.Trim() == String.Empty || address.Text.Trim() == String.Empty || guardian.Text.Trim() == String.Empty || dob.Text.Trim() == String.Empty || bgroup.Text.Trim() == String.Empty || fathername.Text.Trim() == String.Empty || foccupation.Text.Trim() == String.Empty || oaddress.Text.Trim() == String.Empty || otelno.Text.Trim() == String.Empty || mobile.Text.Trim() == String.Empty || pictureBox1.Image == null)
                {
                    MessageBox.Show("All Fields are Required");
                }
                else
                {
                    if (i == true)
                    {
                        Byte[] img = null;
                        FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        viewClass v = new viewClass();
                        v.updateDataWI(id, name.Text, occupation.Text, joinDate.Value.ToString("MM-dd-yyyy"), address.Text, guardian.Text, dob.Value.ToString("MM-dd-yyyy"), fathername.Text, foccupation.Text, bgroup.Text, oaddress.Text, otelno.Text, mobile.Text, img);
                        MessageBox.Show("Record updated");
                    }
                    else
                    {

                        v.updateDataWOI(id, name.Text, occupation.Text, joinDate.Value.ToString("MM-dd-yyyy"), address.Text, guardian.Text, dob.Value.ToString("MM-dd-yyyy"), fathername.Text, foccupation.Text, bgroup.Text, oaddress.Text, otelno.Text, mobile.Text);
                        MessageBox.Show("Record updated");
                    }
                }

            }catch(Exception ex)
            {
                
            }
            try { LoadData(); } catch { }
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
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
                        i = true;

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
            catch (Exception ex)
            {
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
