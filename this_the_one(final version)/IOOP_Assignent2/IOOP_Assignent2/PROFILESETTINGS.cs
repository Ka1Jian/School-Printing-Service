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
    public partial class PROFILESETTINGS : Form
    {
        public string enteredUsername;
        public PROFILESETTINGS(string enteredUsername)
        { 
            InitializeComponent();
            this.enteredUsername = enteredUsername;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RESETPASSWORD resetPasswordForm = new RESETPASSWORD(enteredUsername);

            resetPasswordForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
