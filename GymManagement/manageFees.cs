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
    public partial class manageFees : Form
    {
        public manageFees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["gmcs"].ConnectionString);

        

        private void manageFees_Load(object sender, EventArgs e)
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
            if (amount.Text == "" || validity.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                try
                {
                    viewClass v = new viewClass();
                    int i = Int32.Parse( validity.Text.ToString());
                    DateTime expire = dateTimePicker1.Value.AddMonths(i);
                    v.feesInsert((int)user_id.SelectedValue, Int32.Parse(amount.Text.ToString()), Int32.Parse(validity.Text.ToString()), dateTimePicker1.Value.ToString("MM-dd-yyyy"),expire.ToString("MM-dd-yyyy"));
                    amount.Clear();
                    validity.Clear();
                    v.check();
                    MessageBox.Show("Record Inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }




        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
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
