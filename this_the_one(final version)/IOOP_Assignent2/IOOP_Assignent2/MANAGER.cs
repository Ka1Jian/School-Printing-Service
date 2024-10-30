using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignent2
{
    public partial class MANAGER : Form
    {
        public string _RequestID;
        public int _ID;
        public string _ServiceID;
        public int _Quantity;
        public string _CustomerID;
        public double _TotalFee;
        public DateTime _RequestDate;
        public string _Status;
        public string _WorkerID;
        public string enteredUsername;
        public MANAGER(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PROFILESETTINGS pROFILESETTINGS = new PROFILESETTINGS(enteredUsername);
            pROFILESETTINGS.Show();
        }

        private void MANAGER_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Request view_Request = new View_Request(enteredUsername);
            view_Request.Show();
        }
    }
}
