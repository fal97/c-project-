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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VSTC5T9\SQLSERVER;Initial Catalog=photographyDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*String name = txtname.Text;
                Int64 phone = Int64.Parse(txtphone.Text);

                String gender = "";

                bool isChecked = radioButton1.Checked;
                if (isChecked)
                {
                    gender = radioButton1.Text;
                }
                else
                {
                    gender = radioButton2.Text;
                }

                String date = dateTimePicker1.Text;
                String address = richTextBox1.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VSTC5T9\\SQLSERVER;Initial Catalog=photographyDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into testing(name, phone, gender, date, address)values('" + name + "', '" + phone + "', '" + gender + "', '" + date + "', '" + address + "')";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Data Saved");*/

                con.Open();
                String query = "insert into testiing(name, phone, gender, date, address)values('" + txtname.Text + "', '" + txtphone.Text + "', '" + comboBox1.Text + "', '" + dateTimePicker1.Text + "', '" + richTextBox1.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
