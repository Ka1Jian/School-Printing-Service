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
    public partial class ADMIN : Form
    {
        public string enteredUsername;
        public ADMIN(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Requst_Report requst_Report = new Requst_Report();
            requst_Report.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            PROFILESETTINGS pROFILESETTINGS = new PROFILESETTINGS(enteredUsername);
            pROFILESETTINGS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMINREGISTERSYSTEM ARS = new ADMINREGISTERSYSTEM();
            ARS.Show();
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Income_Report income_Report = new Income_Report();
            income_Report.Show();
        }
    }
}
