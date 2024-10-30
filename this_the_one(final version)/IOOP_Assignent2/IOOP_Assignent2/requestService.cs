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
    public partial class requestService : Form
    {
        public string customerID;
        public string enteredUsername;
        public requestService(string enteredUsername)
        {
            InitializeComponent();

            this.enteredUsername = enteredUsername;
        }

        private void requestService_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = "SELECT CustomerID FROM Customer WHERE Username = @Username";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Username", enteredUsername);

                        // Execute the query and read the result
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.Read()) // Move to the first row in the result set
                        {
                            customerID = reader["CustomerID"].ToString();
                            MessageBox.Show("CustomerID: " + customerID);
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the provided username.");
                        }

                        reader.Close();
                    }
                }


                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT * FROM MainRequest WHERE customerID = @CustomerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
