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
    public partial class WorkDetails : Form
    {
        private string RequestID;
        private string ServiceID;
        private int Quantity;
        private string CustomerID;
        private double TotalFee;
        private DateTime RequestDate;
        private string Status;
        private string WorkerID;
        

        public WorkDetails(string _RequestID, string _ServiceID, int _Quantity, string _CustomerID, double _TotalFee, DateTime _RequestDate, string _Status, string _WorkerID)
        {
            InitializeComponent();
            RequestID = _RequestID;
            ServiceID = _ServiceID;
            Quantity = _Quantity;
            CustomerID = _CustomerID;
            TotalFee = _TotalFee;
            RequestDate = _RequestDate;
            Status = _Status;
            WorkerID = _WorkerID;

            tbServiceID.ReadOnly = true;
            tbQuantity.ReadOnly = true;
            tbCustomerID.ReadOnly = true;
            tbprice.ReadOnly = true;
            Cbworker.Enabled = false;

            lbRequestID.Text = RequestID;
            tbServiceID.Text = ServiceID;
            tbQuantity.Text = Quantity.ToString();
            tbCustomerID.Text = CustomerID;
            tbdate.Text = RequestDate.ToString("dd/MM/yyyy");
            tbprice.Text = TotalFee.ToString();
            tbStatus.Text = Status;
            Cbworker.Text = WorkerID;

            LoadWorkerIDs();
        }

        private void LoadWorkerIDs()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True");
            conn.Open();

            SqlCommand workerCmd = new SqlCommand("SELECT WorkerID FROM [Worker]", conn);
            SqlDataAdapter workerDa = new SqlDataAdapter(workerCmd);
            DataTable workerDt = new DataTable("Worker");
            workerDa.Fill(workerDt);

            Cbworker.DataSource = workerDt;
            Cbworker.DisplayMember = "WorkerID";
            Cbworker.ValueMember = "WorkerID";

            conn.Close();
        }
        private void UpdateStatus()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U0G2C08N\\MSSQLSERVER01;Initial Catalog=\"LOGINDATABASE (1)\";Integrated Security=True");
                conn.Open();

                var sql = "UPDATE [MainRequest] SET [Status] = @Status WHERE RequestID = @RequestID";
                SqlCommand updateCmd = new SqlCommand(sql, conn);
                updateCmd.Parameters.AddWithValue("@RequestID", RequestID);  // Use the property directly
                updateCmd.Parameters.AddWithValue("@Status", tbStatus.Text);

                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Status has been updated.");
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void WorkDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
