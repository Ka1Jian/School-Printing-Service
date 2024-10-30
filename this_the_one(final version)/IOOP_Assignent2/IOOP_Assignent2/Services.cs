using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignent2
{
    public partial class Services : Form
    {

        public double total;
        public string enteredUsername;
        public string customerID;
        private Request request = new Request();
        
        public Services(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True";


            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = "SELECT CustomerID FROM Customer WHERE Username = @Username";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Username",enteredUsername);

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



                decimal inputValue = numericUpDown1.Value;
                decimal inputValue2 = numericUpDown2.Value;
                decimal inputValue3 = numericUpDown3.Value;
                decimal inputValue4 = numericUpDown4.Value;
                decimal inputValue5 = numericUpDown5.Value;
                decimal inputValue6 = numericUpDown6.Value;
                decimal priceMultiplier = 0.8m; // Make sure to use decimal literal (m) for the multiplier
                decimal priceMultiplier2 = 2.5m;
                decimal priceMultiplier3 = 5m;
                decimal priceMultiplier4 = 15m;
                decimal priceMultiplier5 = 3m;
                decimal priceMultiplier6 = 10m;

                decimal price1 = inputValue * priceMultiplier;
                decimal price2 = inputValue2 * priceMultiplier2;
                decimal price3 = inputValue3 * priceMultiplier3;
                decimal price4 = inputValue4 * priceMultiplier4;
                decimal price5 = inputValue5 * priceMultiplier5;
                decimal price6 = inputValue6 * priceMultiplier6;

                string price1AsString = price1.ToString();
                string price2AsString = price2.ToString();
                string price3AsString = price3.ToString();
                string price4AsString = price4.ToString();
                string price5AsString = price5.ToString();
                string price6AsString = price6.ToString();

                Payment payment1 = new Payment(inputValue, inputValue2, inputValue3, inputValue4, inputValue5, inputValue6, price1, price2, price3, price4, price5, price6,total, enteredUsername);
                payment1.Show();


            
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Quantity1;
            int Quantity2;
            int Quantity3;
            int Quantity4;
            int Quantity5;
            int Quantity6;




            {
                if (int.TryParse(numericUpDown1.Text, out Quantity1)
                    && int.TryParse(numericUpDown2.Text, out Quantity2)
                    && int.TryParse(numericUpDown3.Text, out Quantity3)
                    && int.TryParse(numericUpDown4.Text, out Quantity4)
                    && int.TryParse(numericUpDown5.Text, out Quantity5)
                    && int.TryParse(numericUpDown6.Text, out Quantity6))
                {
                    request.SetQuantities(Quantity1, Quantity2, Quantity3, Quantity4, Quantity5, Quantity6);


                    total = request.calculation();


                    MessageBox.Show("Total Price: " + total, "Total Price");


                }
            }
        }
    }
}
