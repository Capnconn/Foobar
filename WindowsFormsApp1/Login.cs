using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        FileIO read = new FileIO();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            labelCheck.Text = "";
            if(!read.CheckForFile(textBoxUsername.Text, textBoxPassword.Text))
            {
                labelCheck.Text = "Username or password is incorrect, please try again.";
                return;
            }
            HomePage userInfo = new HomePage(textBoxUsername.Text, textBoxPassword.Text);
            userInfo.ShowDialog();
        }
        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            Account newAcc = new Account();
            newAcc.ShowDialog();
        }
    }
}
