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
    public partial class Income_Report : Form
    {
        private BindingSource bindingSource;

        public Income_Report()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
        }
     

        private void Income_Report_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMonthlyTotalPrice()
        {
            try
            {
                // Get the current month
                string currentMonth = comboBox1.SelectedItem.ToString();
                int selectedMonth = Array.IndexOf(DateTimeFormatInfo.CurrentInfo.MonthNames, currentMonth) + 1;

                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                {
                    connection.Open();

                    // Assuming RequestDate is a datetime column
                    string query = $"SELECT RequestID,ServiceID,Quantity,TotalFee FROM MainRequest WHERE MONTH(RequestDate) = {selectedMonth}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the BindingSource
                            bindingSource.DataSource = dataTable;

                            // Calculate and display the total earnings
                            decimal totalEarnings = CalculateTotalEarnings(dataTable);
                            label3.Text = $"Total Earnings: {totalEarnings:C}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private decimal CalculateTotalEarnings(DataTable dataTable)
        {
            decimal totalEarnings = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                // Assuming TotalFee is the column in the DataTable
                decimal totalFee = Convert.ToDecimal(row["TotalFee"]);
                totalEarnings += totalFee;
            }

            return totalEarnings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMonthlyTotalPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
