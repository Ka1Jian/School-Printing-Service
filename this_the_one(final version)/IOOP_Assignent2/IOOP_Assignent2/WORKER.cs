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
    public partial class WORKER : Form
    {
        public string enteredUsername;
        public WORKER(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;
        }

        private void WORKER_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignedWork assignedWork = new AssignedWork(enteredUsername); 
            assignedWork.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PROFILESETTINGS pROFILESETTINGS = new PROFILESETTINGS(enteredUsername);
            pROFILESETTINGS.Show();
        }
    }
}
