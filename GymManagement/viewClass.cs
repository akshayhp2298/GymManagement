using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Globalization;

namespace GymManagement
{
    class viewClass
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["gmcs"].ConnectionString);

        
        public void insertData(string name,string occupation, string joinDate,string address, string gurdian, string dob, string fathername, string foccupation, string bgroup, string oaddress, string otelno, string mobile, Byte[] img)
        {
            cn.Open();
            SqlCommand cmd;
            string str= "insert into [dbo].[user](name,occupation,doj,address,gurdian,dob,father_name,father_occupation,official_address,tel_no,mobile,photo,b_group) values(" +
                "'" + name + "','" + occupation + "','" + joinDate + "','" + address + "','" + gurdian + "','" + dob + "','" + fathername + "','" + foccupation + "','" + oaddress + "'," + otelno + "," + mobile + ",@img,'" + bgroup + "')";
            cmd = new SqlCommand(str, cn);
            cmd.Parameters.Add(new SqlParameter("@img", img));
            Console.Write(str);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void updateDataWI(int id,string name, string occupation, string joinDate, string address, string gurdian, string dob, string fathername, string foccupation, string bgroup, string oaddress, string otelno, string mobile, Byte[] img)
        {
            cn.Open();
            SqlCommand cmd;
            string str = "update [dbo].[user] SET name='" + name + "',occupation='" + occupation + "',doj='" + joinDate + "',address='" + address + "',gurdian='" + gurdian + "',dob='" + dob + "',father_name='" + fathername + "',father_occupation='" + foccupation + "',official_address='" + oaddress + "',tel_no=" + otelno + ",mobile=" + mobile + ",photo=@img,b_group = '" + bgroup + "'where Id="+id;
            cmd = new SqlCommand(str, cn);
            cmd.Parameters.Add(new SqlParameter("@img", img));
            Console.Write(str);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void updateDataWOI(int id, string name, string occupation, string joinDate, string address, string gurdian, string dob, string fathername, string foccupation, string bgroup, string oaddress, string otelno, string mobile)
        {
            cn.Open();
            SqlCommand cmd;
            string str = "update [dbo].[user] SET name='" + name + "',occupation='" + occupation + "',doj='" + joinDate + "',address='" + address + "',gurdian='" + gurdian + "',dob='" + dob + "',father_name='" + fathername + "',father_occupation='" + foccupation + "',official_address='" + oaddress + "',tel_no=" + otelno + ",mobile=" + mobile + ",b_group = '" + bgroup + "' where Id=" + id;
            cmd = new SqlCommand(str, cn);
            Console.Write(str);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void feesInsert(int user_id,int amount,int validity,string fees_date,string expire)
        {
            cn.Open();
            SqlCommand cmd;
            string str = "insert into fees values("+user_id+ "," + amount + "," + validity + ",'" + fees_date + "',' ','" + expire + "');";
            cmd = new SqlCommand(str, cn);
             cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void UpdatePaid(string select)
        {
            cn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(select, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataSet load_data(string select)
        {
            if(cn.State.ToString()=="close")
            cn.Open();
            var dataAdapter = new SqlDataAdapter(select, cn);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
            cn.Close();
        }
        public void check()
        {
            string select = "update fees set nextpayment='notpaid' where expire_date <  CONVERT(date, getdate()) and nextpayment!='paid'";
            cn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(select, cn);
            cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}
