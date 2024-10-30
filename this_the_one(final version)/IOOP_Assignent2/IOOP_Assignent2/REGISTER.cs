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

namespace IOOP_Assignent2
{
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.ToLower() != textBox2.Text.ToLower())
            {
                MessageBox.Show("Your Password does not match...");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[tbl_login] 
            ([username]           
            ,[password]
            ,[role])      
        VALUES         
            ('" + textBox1.Text + "','" + textBox2.Text + "','" + "customer" + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Successful!");
                this.Close();




                SqlConnection con2 = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[Customer] 
            ([username]           
            ,[password]
            ,[name])
           VALUES         
            ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "')", con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("Registration Successful!");
                this.Close();



            }
        }

        private void REGISTER_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
