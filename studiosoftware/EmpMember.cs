using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studiosoftware
{
    public partial class EmpMember : Form
    {
        public EmpMember()
        {
            InitializeComponent();
        }

        public String conString = "Data Source=DESKTOP-VSTC5T9\\SQLSERVER;Initial Catalog=photographyDB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*String fname = txtfname.Text;
                String lname = txtlname.Text;
               
                Int64 m_number = Int64.Parse(txtmnumber.Text);
                String email = txtemail.Text;
                String dob = dateTimePicker1.Text;
                String gender = txtgender.Text;
                String address = richTextBox1.Text;
                String joindate = dateTimePicker2.Text;*/

                SqlConnection con = new SqlConnection(conString);
                /* con.ConnectionString = "Data Source = DESKTOP - VSTC5T9\\SQLSERVER; Initial Catalog = photographyDB; Integrated Security = True ";*/
              
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                String q = "insert into Employee_reg (fname, lname, m_number, email, dob, gender, address, joindate)values('"+ txtfname.Text.ToString()+ "','" + txtlname.Text.ToString() + "','" + txtmnumber.Text.ToString() + "','" + txtemail.Text.ToString() + "','" + dateTimePicker1.Value.ToString() + "','"+ txtgender.Text.ToString()+ "','" + richTextBox1.Text.ToString() + "','" + dateTimePicker2.Value.ToString() + "')";

                SqlCommand cmd = new SqlCommand(q,con);
                /*SqlCommand cmd = new SqlCommand("insert into signup_member (full_name, dob, contact_no, email, district, city, pincode, full_address, member_id) values(@full_name, @dob, @contact_no, @email, @district, @city, @pincode, @full_address, @member_id)", con);*/
                cmd.Connection = con;
                /*cmd.CommandText = "insert into Employee_reg (fname, lname, m_number, email, dob, gender, address, joindate) values(@fname, @lname, @m_number, @email, @dob, @gender, @address, @joindate)";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);*/


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewmembers vm = new viewmembers();
            vm.Show();
        }
    }
}
