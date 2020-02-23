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
    public partial class HomePage : Form
    {
        public static string usernameSaved;
        public static string exp;
        FileIO read = new FileIO();
        Login inval = new Login();
        public static string[] begWorkouts = { "Barbell Bench Press", "Leg Extension", "Lat-pulldowns", "Tricep Rope Pushdown" };
        public static string[] advWorkouts = { "Dumbell Bench Press", "Barbell Squats", "Barbell Bent Row", "Skull Crushers" };
        public HomePage()
        {
            InitializeComponent();
            suggestWorkouts(exp);
            labelUsername.Text = "Hello! " + usernameSaved ;
        }
        public HomePage(string username, string password)
        {
            InitializeComponent();
            usernameSaved = username;
            labelUsername.Text = username + "'s Profile";
            string experience = read.RetreiveLevel(username);
            exp = experience;
            suggestWorkouts(experience);
        }
        
        public HomePage(string first, string last, string username, string password, string experience, string goals)
        {
            InitializeComponent();
            usernameSaved = username;
            labelUsername.Text = username + "'s Profile";
            exp = experience;
            FileIO fileWrite = new FileIO(first, last, username, password, experience, goals);
            suggestWorkouts(experience);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelFirst_Click(object sender, EventArgs e)
        {

        }

       // public string fName { get; set; }
        //public string lName { get; set; }
        private void suggestWorkouts(string experience)
        {
            if(experience == "Beginner")
            {
                linkLabelWrkout1.Text = begWorkouts[0];
                linkLabelWrkout2.Text = begWorkouts[1];
                linkLabelWrkout3.Text = begWorkouts[2];
                linkLabelWrkout4.Text = begWorkouts[3];
            } else if(experience == "Master")
            {
                linkLabelWrkout1.Text = advWorkouts[0];
                linkLabelWrkout2.Text = advWorkouts[1];
                linkLabelWrkout3.Text = advWorkouts[2];
                linkLabelWrkout4.Text = advWorkouts[3];
            }
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (exp == "beginning") {
                Description desc = new Description(exp, 0, begWorkouts[0]);
                desc.ShowDialog();
            } else
            {
                Description desc = new Description(exp, 0, advWorkouts[0]);
                desc.ShowDialog();
            }
        }
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (exp == "beginning")
            {
                Description desc = new Description(exp, 1, begWorkouts[1]);
                desc.ShowDialog();
            }
            else
            {
                Description desc = new Description(exp, 1, advWorkouts[1]);
                desc.ShowDialog();
            }
        }
        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (exp == "beginning")
            {
                Description desc = new Description(exp, 2, begWorkouts[2]);
                desc.ShowDialog();
            }
            else
            {
                Description desc = new Description(exp, 2, advWorkouts[2]);
                desc.ShowDialog();
            }
        }
        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (exp == "beginning")
            {
                Description desc = new Description(exp, 3, begWorkouts[3]);
                desc.ShowDialog();
            }
            else
            {
                Description desc = new Description(exp, 3, advWorkouts[3]);
                desc.ShowDialog();
            }
        }

        private void ButtonSignout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            Hide();
            logout.ShowDialog();
            Close();
        }
    }
}
