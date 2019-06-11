using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Dashboard : Form
    {
      
        public Dashboard()
        {
            InitializeComponent();
            loaddata();
            loadDataGrid();
        }
        public void loadDataGrid()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "paid";
                button.HeaderText = "Paid";
                button.Text = "Paid";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.dataGridView1.Columns.Add(button);
            }
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Name";
            dataGridView1.Columns["amount"].HeaderText = "Amount";
            dataGridView1.Columns["mobile"].HeaderText = "Mobile";
            dataGridView1.Columns["validity"].HeaderText = "Validity";
            dataGridView1.Columns["fees_date"].HeaderText = "Last Paid";
            dataGridView1.Columns["expire_date"].HeaderText = "Expire Date";
        }
        public void loaddata()
        {
            try
            {
                string sql = "select f.Id,u.name,u.mobile,f.amount,f.validity,CONVERT(char(10),f.fees_date,105) as fees_date,CONVERT(char(10),f.expire_date,105) as expire_date from[dbo].[user] as u,[dbo].[fees] as f where u.Id= f.user_id and f.nextpayment='notpaid';";
                var ds = v.load_data(sql);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                

            }
            catch { }
        }
        viewClass v = new viewClass();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                loaddata();
                
            }
            catch{
               
            }
             



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["paid"].Index)
                {


                    int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    string sql = "update fees set nextpayment='paid' where Id=" + id;
                    v.UpdatePaid(sql);
                    MessageBox.Show("Updated!");
                    loaddata();
                    
                    
                }
            }
            catch { }
        }
    }
}
