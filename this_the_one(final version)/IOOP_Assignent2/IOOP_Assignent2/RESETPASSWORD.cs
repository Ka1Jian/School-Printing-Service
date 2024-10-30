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
    public partial class RESETPASSWORD : Form
    {
        public string enteredUsername;
        public RESETPASSWORD(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;
        }

        private void RESETPASSWORD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text;


            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
            {
                connection.Open();

                string query = "UPDATE tbl_login SET password = @NewPassword WHERE username = @Username ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@Username", enteredUsername);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid old username or password. Update failed.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
