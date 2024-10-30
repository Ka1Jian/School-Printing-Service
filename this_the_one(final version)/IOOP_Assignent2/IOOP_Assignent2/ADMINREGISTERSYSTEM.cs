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
    public partial class ADMINREGISTERSYSTEM : Form
    {
        String role;

        public ADMINREGISTERSYSTEM()
        {
            InitializeComponent();
        }

        private void ADMINREGISTERSYSTEM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString() != textBox2.Text.ToString())
            {
                MessageBox.Show("Your Password does not match...");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[tbl_login] 
            ([username]           
            ,[password]
            ,[role])      
        VALUES         
            ('" + textBox1.Text + "','" + textBox2.Text + "','" + role + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Successful!");
                this.Close();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            role = "Admin";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            role = "worker";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            role = "manager";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
