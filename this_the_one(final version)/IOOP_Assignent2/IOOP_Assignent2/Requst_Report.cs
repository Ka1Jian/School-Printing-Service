using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignent2
{
    public partial class Requst_Report: Form
    {
        
        private BindingSource bindingSource;
        public Requst_Report()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
            

        }

        private void Requst_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_LOGINDATABASE__1_DataSet.MainRequest' table. You can move, or remove it, as needed.
            this.mainRequestTableAdapter.Fill(this._LOGINDATABASE__1_DataSet.MainRequest);

        }

        private void LoadMonthlyData()
        {
            try
            {
                // Get the selected month from the ComboBox
                string selectedMonthName = comboBox1.SelectedItem.ToString();

                // Convert month name to numeric representation
                int selectedMonth = Array.IndexOf(DateTimeFormatInfo.CurrentInfo.MonthNames, selectedMonthName) + 1;

                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                {
                    connection.Open();

                    // Assuming RequestDate is a datetime column
                    string query = $"SELECT * FROM MainRequest WHERE MONTH(RequestDate) = {selectedMonth}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the RowFilter for the DataView
                            DataView dataView = new DataView(dataTable);
                            bindingSource.DataSource = dataView;
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
            LoadMonthlyData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
