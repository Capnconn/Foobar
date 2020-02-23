using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }
        public Map(string experience, int numWorkout)
        {
            InitializeComponent();
            //string currWorkoutNode = "pictureBox" + experience.Substring(0, 3) + numWorkout;
            if(experience == "beginner")
            {
                if(numWorkout == 0)
                {
                    pictureBoxBeg1.Visible = true;
                } else if(numWorkout == 1)
                {
                    pictureBoxBeg2.Visible = true;
                }
                else if (numWorkout == 2)
                {
                    pictureBoxBeg3.Visible = true;
                }
                else if (numWorkout == 3)
                {
                    pictureBoxBeg4.Visible = true;
                }
            } else
            {
                if (numWorkout == 0)
                {
                    pictureBoxMas1.Visible = true;
                }
                else if (numWorkout == 1)
                {
                    pictureBoxMas2.Visible = true;
                }
                else if (numWorkout == 2)
                {
                    pictureBoxMas3.Visible = true;
                }
                else if (numWorkout == 3)
                {
                    pictureBoxMas4.Visible = true;
                }
            }
        }
        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxGB_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            HomePage returnHome = new HomePage();
            Hide();
            returnHome.ShowDialog();
            Close();
        }
    }
}
