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
    public partial class Payment : Form
    {
        public decimal inputValue;
        public decimal inputValue2;
        public decimal inputValue3;
        public decimal inputValue4;
        public decimal inputValue5;
        public decimal inputValue6;
        public decimal price1;
        public decimal price2;
        public decimal price3;
        public decimal price4;
        public decimal price5;
        public decimal price6;
        public double total;
        public string enteredUsername;
        public string customerID;


        public Payment(decimal inputValue, decimal inputValue2, decimal inputValue3, decimal inputValue4, decimal inputValue5, decimal inputValue6, decimal price1, decimal price2, decimal price3, decimal price4, decimal price5, decimal price6, double total, string enteredUsername)
        {
            InitializeComponent();
            this.inputValue = inputValue;
            this.inputValue2 = inputValue2;
            this.inputValue3 = inputValue3;
            this.inputValue4 = inputValue4;
            this.inputValue5 = inputValue5;
            this.inputValue6 = inputValue6;
            this.price1 = price1;
            this.price2 = price2;
            this.price3 = price3;
            this.price4 = price4;
            this.price5 = price5;
            this.price6 = price6;
            this.enteredUsername = enteredUsername;

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            labelQuantity1.Text = inputValue.ToString();
            labelQuantity2.Text = inputValue2.ToString();
            labelQuantity3.Text = inputValue3.ToString();
            labelQuantity4.Text = inputValue4.ToString();
            labelQuantity5.Text = inputValue5.ToString();
            labelQuantity6.Text = inputValue6.ToString();
            labelSubtotal1.Text = price1.ToString();
            labelSubtotal2.Text = price2.ToString();
            labelSubtotal3.Text = price3.ToString();
            labelSubtotal4.Text = price4.ToString();
            labelSubtotal5.Text = price5.ToString();
            labelSubtotal6.Text = price6.ToString();
            decimal total = (price1 + price2 + price3 + price4 + price5 + price6);
            labelTotal.Text = "Total Price is " + total.ToString() + "(RM)";



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void labelQuantity1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
                        sqlCommand.Parameters.AddWithValue("@Username", enteredUsername);

                        // Execute the query and read the result
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.Read()) // Move to the first row in the result set
                        {
                            customerID = reader["CustomerID"].ToString();
                            

                        }
                        else
                        {
                            MessageBox.Show("No customer found with the provided username.");
                        }

                        reader.Close();
                    }


                    string price1AsString = price1.ToString();
                    string price2AsString = price2.ToString();
                    string price3AsString = price3.ToString();
                    string price4AsString = price4.ToString();
                    string price5AsString = price5.ToString();
                    string price6AsString = price6.ToString();



                    if (inputValue > 0)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                        {

                            string status = "NEW";

                            string date = DateTime.Now.ToString();
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[MainRequest] " +
                                                                   "([ServiceID], [Quantity], [CustomerID], [TotalFee], [RequestDate], [Status], [WorkerID]) " +
                                                                   "VALUES (@ServiceID, @Quantity, @CustomerID, @TotalFee, @RequestDate, @Status, @WorkerID)", con))
                            {
                                cmd.Parameters.AddWithValue("@ServiceID", "Q01");
                                cmd.Parameters.AddWithValue("@Quantity", inputValue);
                                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                                cmd.Parameters.AddWithValue("@TotalFee", price1AsString);
                                cmd.Parameters.AddWithValue("@RequestDate", date);
                                cmd.Parameters.AddWithValue("@Status", status);
                                cmd.Parameters.AddWithValue("@WorkerID", DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }


                            this.Close();
                        }


                    }
                    if (inputValue2 > 0)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                        {

                            string status = "NEW";

                            string date = DateTime.Now.ToString();
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[MainRequest] " +
                                                                   "([ServiceID], [Quantity], [CustomerID], [TotalFee], [RequestDate], [Status], [WorkerID]) " +
                                                                   "VALUES (@ServiceID, @Quantity, @CustomerID, @TotalFee, @RequestDate, @Status, @WorkerID)", con))
                            {
                                cmd.Parameters.AddWithValue("@ServiceID", "Q02");
                                cmd.Parameters.AddWithValue("@Quantity", inputValue2);
                                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                                cmd.Parameters.AddWithValue("@TotalFee", price2AsString);
                                cmd.Parameters.AddWithValue("@RequestDate", date);
                                cmd.Parameters.AddWithValue("@Status", status);
                                cmd.Parameters.AddWithValue("@WorkerID", DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }


                            this.Close();
                        }


                    }
                    if (inputValue3 > 0)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                        {

                            string status = "NEW";

                            string date = DateTime.Now.ToString();
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[MainRequest] " +
                                                                   "([ServiceID], [Quantity], [CustomerID], [TotalFee], [RequestDate], [Status], [WorkerID]) " +
                                                                   "VALUES (@ServiceID, @Quantity, @CustomerID, @TotalFee, @RequestDate, @Status, @WorkerID)", con))
                            {
                                cmd.Parameters.AddWithValue("@ServiceID", "Q03");
                                cmd.Parameters.AddWithValue("@Quantity", inputValue3);
                                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                                cmd.Parameters.AddWithValue("@TotalFee", price3AsString);
                                cmd.Parameters.AddWithValue("@RequestDate", date);
                                cmd.Parameters.AddWithValue("@Status", status);
                                cmd.Parameters.AddWithValue("@WorkerID", DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }


                            this.Close();
                        }


                    }
                    if (inputValue4 > 0)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                        {

                            string status = "NEW";

                            string date = DateTime.Now.ToString();
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[MainRequest] " +
                                                                   "([ServiceID], [Quantity], [CustomerID], [TotalFee], [RequestDate], [Status], [WorkerID]) " +
                                                                   "VALUES (@ServiceID, @Quantity, @CustomerID, @TotalFee, @RequestDate, @Status, @WorkerID)", con))
                            {
                                cmd.Parameters.AddWithValue("@ServiceID", "Q04");
                                cmd.Parameters.AddWithValue("@Quantity", inputValue4);
                                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                                cmd.Parameters.AddWithValue("@TotalFee", price4AsString);
                                cmd.Parameters.AddWithValue("@RequestDate", date);
                                cmd.Parameters.AddWithValue("@Status", status);
                                cmd.Parameters.AddWithValue("@WorkerID", DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }

                            this.Close();
                        }


                    }
                    if (inputValue5 > 0)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                        {

                            string status = "NEW";

                            string date = DateTime.Now.ToString();
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[MainRequest] " +
                                                                   "([ServiceID], [Quantity], [CustomerID], [TotalFee], [RequestDate], [Status], [WorkerID]) " +
                                                                   "VALUES (@ServiceID, @Quantity, @CustomerID, @TotalFee, @RequestDate, @Status, @WorkerID)", con))
                            {
                                cmd.Parameters.AddWithValue("@ServiceID", "Q05");
                                cmd.Parameters.AddWithValue("@Quantity", inputValue5);
                                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                                cmd.Parameters.AddWithValue("@TotalFee", price5AsString);
                                cmd.Parameters.AddWithValue("@RequestDate", date);
                                cmd.Parameters.AddWithValue("@Status", status);
                                cmd.Parameters.AddWithValue("@WorkerID", DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }


                            this.Close();
                        }


                    }
                    if (inputValue6 > 0)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True"))
                        {

                            string status = "NEW";

                            string date = DateTime.Now.ToString();
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[MainRequest] " +
                                                                   "([ServiceID], [Quantity], [CustomerID], [TotalFee], [RequestDate], [Status], [WorkerID]) " +
                                                                   "VALUES (@ServiceID, @Quantity, @CustomerID, @TotalFee, @RequestDate, @Status, @WorkerID)", con))
                            {
                                cmd.Parameters.AddWithValue("@ServiceID", "Q06");
                                cmd.Parameters.AddWithValue("@Quantity", inputValue6);
                                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                                cmd.Parameters.AddWithValue("@TotalFee", price6AsString);
                                cmd.Parameters.AddWithValue("@RequestDate", date);
                                cmd.Parameters.AddWithValue("@Status", status);
                                cmd.Parameters.AddWithValue("@WorkerID", DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }

                            this.Close();
                        }


                    }

                    if (inputValue > 0 || inputValue2 > 0 || inputValue3 > 0 || inputValue4 > 0 || inputValue5 > 0 || inputValue6 > 0)
                    {
                        MessageBox.Show("Request Successful!");

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        } 
    }
}
