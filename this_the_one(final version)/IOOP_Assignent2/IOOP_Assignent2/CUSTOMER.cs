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
    public partial class CUSTOMER : Form
    {
      
        public string enteredUsername;
        public CUSTOMER(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Services services = new Services(enteredUsername); // Create an instance of Form2
            services.Show(); // Show Form2
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            requestService requestService = new requestService(enteredUsername);
            requestService.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PROFILESETTINGS pROFILESETTINGS = new PROFILESETTINGS(enteredUsername);
            pROFILESETTINGS.Show();
        }

        private void CUSTOMER_Load(object sender, EventArgs e)
        {

        }
    }
}
