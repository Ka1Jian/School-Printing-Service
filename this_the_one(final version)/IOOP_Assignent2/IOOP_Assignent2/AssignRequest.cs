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
    public partial class AssignRequest : Form
    {

        string RequestID;
        int ID;
        string ServiceID;
        int Quantity;
        string CustomerID;
        double TotalFee;
        DateTime RequestDate;
        string Status;
        string WorkerID;
        public AssignRequest(string _RequestID, int _ID, string _ServiceID, int _Quantity, string _CustomerID, double _TotalFee, DateTime _RequestDate, string _Status, string _WorkerID)
        {
            InitializeComponent();
            RequestID = _RequestID;
            ID = _ID;
            ServiceID = _ServiceID;
            Quantity = _Quantity;
            CustomerID = _CustomerID;
            TotalFee = _TotalFee;
            RequestDate = _RequestDate;
            Status = _Status;
            WorkerID = _WorkerID;

            tbCustomerID.ReadOnly = true;
            tbdate.Enabled = false;
            tbprice.ReadOnly = true;
            tbQuantity.ReadOnly = true;
            tbServiceID.ReadOnly = true;
            tbStatus.Enabled = false;
        }

        private void AssignRequest_Load(object sender, EventArgs e)
        {
            lbRequestID.Text = RequestID;
            tbServiceID.Text = ServiceID;
            tbQuantity.Text = Quantity.ToString();
            tbCustomerID.Text = CustomerID;
            tbdate.Text = RequestDate.ToString("dd/MM/yyyy");
            tbprice.Text = TotalFee.ToString();
            tbStatus.Text = Status;
            Cbworker.Text = WorkerID;

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-U0G2C08N\MSSQLSERVER01;Initial Catalog=""LOGINDATABASE (1)"";Integrated Security=True");
            conn.Open();


            SqlCommand Workercmd = new SqlCommand("SELECT WorkerID FROM [Worker]", conn);
            SqlDataAdapter Workersda = new SqlDataAdapter(Workercmd);
            DataTable Workerdt = new DataTable("Worker");
            Workersda.Fill(Workerdt);
            Cbworker.DataSource = Workerdt;
            Cbworker.DisplayMember = "WorkerID";
            Cbworker.ValueMember = "WorkerID";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-U0G2C08N\MSSQLSERVER01;Initial Catalog=""LOGINDATABASE (1)"";Integrated Security=True");
            conn.Open();
            var sql = "UPDATE [MainRequest] SET [WorkerID] = @WorkerID WHERE RequestID = @RequestID";
            SqlCommand Updatecmd = new SqlCommand(sql, conn);
            Updatecmd.Parameters.AddWithValue("@RequestID", lbRequestID.Text);

            Updatecmd.Parameters.AddWithValue("@WorkerID", Cbworker.Text);
            Updatecmd.ExecuteNonQuery();
            MessageBox.Show("Worker has been assigned");
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
