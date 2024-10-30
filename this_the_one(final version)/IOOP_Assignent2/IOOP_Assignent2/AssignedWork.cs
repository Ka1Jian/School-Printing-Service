using IOOP_Assignent2._LOGINDATABASE__1_DataSetTableAdapters;
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
    public partial class AssignedWork : Form
    {
        public string enteredUsername;
        public string workerID;
      
        public AssignedWork(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;
            

        }
        
        public string GetWorkerID(string enteredUsername)
        {
            
            string connectionString = "Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True";
            string workerID = null;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = "SELECT WorkerID FROM Worker WHERE Username = @Username";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Username", enteredUsername);

                        // Execute the query and read the result
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.Read()) // Move to the first row in the result set
                        {
                            workerID = reader["WorkerID"].ToString();
                            MessageBox.Show("WorkerID: " + workerID);
                            return workerID;
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return workerID;
        }

        private void AssignedWork_Load(object sender, EventArgs e)
        {
            MessageBox.Show(enteredUsername);
            workerID = GetWorkerID(enteredUsername);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                {
                    con.Open();

                    // Adjust the SQL query based on your database schema
                    string query = "SELECT * FROM MainRequest WHERE WorkerID = @WorkerID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@WorkerID", workerID);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        // Bind data to DataGridView
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null &&
                    row.Cells[5].Value != null && row.Cells[6].Value != null && row.Cells[7].Value != null)
                {
                    try
                    {
                        WorkDetails work_Details = new WorkDetails(
                        row.Cells[0].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        Convert.ToInt32(row.Cells[3].Value),
                        row.Cells[4].Value.ToString(),
                        Convert.ToDouble(row.Cells[5].Value),
                        (DateTime)row.Cells[6].Value,
                        row.Cells[7].Value.ToString(),
                        row.Cells[8].Value.ToString()
                    );


                        work_Details.ShowDialog();
                        this.mainRequestTableAdapter.FillByWorkerID(this._LOGINDATABASE__1_DataSet.MainRequest, workerID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Data Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected row contains null values. Please ensure the data is complete and try again", "Data error", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            RefreshData();


        }

        private void RefreshData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                {
                    con.Open();

                    // Adjust the SQL query based on your database schema
                    string query = "SELECT * FROM MainRequest WHERE WorkerID = @WorkerID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@WorkerID", workerID);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        // Set the new data source for the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }
    }
}
