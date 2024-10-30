using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignent2
{
    public partial class View_Request : Form
    {
        public string customerID;
        public View_Request(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void View_Request_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_LOGINDATABASE__1_DataSet.MainRequest' table. You can move, or remove it, as needed.
            this.mainRequestTableAdapter.Fill(this._LOGINDATABASE__1_DataSet.MainRequest);

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
                        AssignRequest assign_Request = new AssignRequest(
                            row.Cells[0].Value.ToString(),
                            Convert.ToInt32(row.Cells[1].Value), // Use Convert.ToInt32 for simplicity
                            row.Cells[2].Value.ToString(),
                            Convert.ToInt32(row.Cells[3].Value), // Use Convert.ToInt32 for simplicity
                            row.Cells[4].Value.ToString(),
                            Convert.ToDouble(row.Cells[5].Value), // Use Convert.ToDouble for simplicity
                            (DateTime)row.Cells[6].Value,
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString()
                        );

                        assign_Request.ShowDialog();
                        this.mainRequestTableAdapter.Fill(this._LOGINDATABASE__1_DataSet.MainRequest);
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

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
