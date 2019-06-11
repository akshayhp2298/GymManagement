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
    public partial class ViewFees : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["gmcs"].ConnectionString);
        int id=0;
        public void Load_data(string select)
        {
            try
            {
                viewClass v = new viewClass();
                DataSet ds = v.load_data(select);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["amount"].HeaderText = "Amount";
                dataGridView1.Columns["fees_date"].HeaderText = "Paid Date";
                dataGridView1.Columns["expire_date"].HeaderText = "Expires Date";
                dataGridView1.Columns["validity"].HeaderText = "Validity";
                dataGridView1.Columns["mobile"].HeaderText = "Mobile";
               
                dataGridView1.Columns["name"].HeaderText = "Name";
            }
            catch { }
           
        }
        public ViewFees()
        {
            InitializeComponent();
        }
        private void user_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (id != (int)user_id.SelectedValue)
                {
                    id = (int)user_id.SelectedValue;
                    var select = "SELECT u.name,u.mobile,f.amount,f.validity,CONVERT(char(10),f.fees_date,105) as fees_date,CONVERT(char(10),f.expire_date,105) as expire_date FROM [dbo].[user] as u,[dbo].[fees] as f where u.Id=f.user_id and f.user_id=" + id;
                    Load_data(select);
                }
            }catch(Exception ex)
            {

            }
        }

        private void ViewFees_Load(object sender, EventArgs e)
        {
            viewClass v = new viewClass();
            DataSet ds = v.load_data("SELECT Id,name from [dbo].[user]");
            if (ds.Tables[0].Rows.Count > 0)
            {
                user_id.DataSource = ds.Tables[0];
                user_id.DisplayMember = "name";
                user_id.ValueMember = "Id";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var select = "SELECT u.name,u.mobile,f.amount,f.validity,CONVERT(char(10),f.fees_date,105) as fees_date,CONVERT(char(10),f.expire_date,105) as expire_date  FROM [dbo].[user] as u,[dbo].[fees] as f where u.Id=f.user_id";
            Load_data(select);

        }
    }
}
