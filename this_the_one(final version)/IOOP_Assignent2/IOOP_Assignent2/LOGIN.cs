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
    public partial class LOGIN : Form
    {
        
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            textBox1.Text = "customer1";
            textBox2.Text = "123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;

            RESETPASSWORD otherForm = new RESETPASSWORD(enteredUsername);
            requestService requestService = new requestService(enteredUsername);
            AssignedWork assignedWork = new AssignedWork(enteredUsername);
            



            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the username");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from tbl_login where username = @username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {



                        MessageBox.Show("Log In Successfully!!!");
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            string role = reader["role"].ToString();
                            if (role == "Admin")
                            {

                                MessageBox.Show("Welcome Admin");
                                ADMIN aDMIN = new ADMIN(enteredUsername);
                                aDMIN.Show();


                            }
                            if (role == "customer")
                            {
                                MessageBox.Show("Welcome !");
                                CUSTOMER aCUSTOMER = new CUSTOMER(enteredUsername);
                                aCUSTOMER.Show();
                            }
                            if (role == "manager")
                            {
                                MessageBox.Show("Welcome Manager");
                                MANAGER aMANAGER = new MANAGER(enteredUsername);
                                aMANAGER.Show();
                            }
                            if (role == "worker")
                            {
                                MessageBox.Show("Welcome Worker");
                                WORKER aWORKER = new WORKER(enteredUsername);
                                aWORKER.Show();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("username or password incorrect...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REGISTER rEGISTER = new REGISTER();
            rEGISTER.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
