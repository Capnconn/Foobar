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
    public partial class Account : Form
    {
        FileIO read = new FileIO();
        public static string experience;
        public static string goal;
        public Account()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
        public void ButtonConfirm_Click(object sender, EventArgs e)
        {
            labelCheck.Text = "";
            labelCheckEmpty.Text = "";
            if(radioButtonB.Checked)
            {
                experience = radioButtonB.Text;
            } else if(radioButtonM.Checked)
            {
                experience = radioButtonM.Text;
            }
            if(radioButtonBH.Checked)
            {
                goal = radioButtonBH.Text;
            } else if(radioButtonBM.Checked)
            {
                goal = radioButtonBH.Text;
            }
            if(read.CheckForFile(textBoxUN.Text, textBoxP.Text))
            {
                labelCheck.Text = "Username already in use, please try again.";
            } 
            if (string.IsNullOrEmpty(textBoxFN.Text) || string.IsNullOrEmpty(textBoxLN.Text) || string.IsNullOrEmpty(textBoxUN.Text) || string.IsNullOrEmpty(textBoxP.Text) || string.IsNullOrEmpty(experience) || string.IsNullOrEmpty(goal))
            {
                labelCheckEmpty.Text = "Please fill all fields.";
            }
            if(!(string.IsNullOrEmpty(labelCheck.Text)) || !(string.IsNullOrEmpty(labelCheckEmpty.Text)))
            {
                return;
            }
            HomePage accountInfo = new HomePage(textBoxFN.Text, textBoxLN.Text, textBoxUN.Text, textBoxP.Text, experience, goal);
            accountInfo.ShowDialog();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Login currAcc = new Login();
            currAcc.ShowDialog();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
