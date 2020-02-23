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
    public partial class Description : Form
    {
        public static string[] begWrkouts = { "Lie flat on your back on a bench." +
"Grip the bar with hands just wider than shoulder-width apart, so when you’re at the bottom of your move your hands are directly above your elbows. This allows for maximum force generation." +
" Bring the bar slowly down to your chest as you breathe in." +
" Push up as you breathe out, gripping the bar hard and watching a spot on the ceiling rather than the bar, so you can ensure it travels the same path every time. ",
                                                "Place your hands on the hand bars." +
"Lift the weight while exhaling until your legs are almost straight. Do not lock your knees. Keep your back against the backrest and do not arch your back." +
"Exhale and lower the weight back to starting position." +
"Do three sets of eight to 12 repetitions.",
                                                "Keep your chest tall/bring your chest to the bar." +
"Keep your elbows pointed straight down." +
"Squeeze your lats/think of pulling from your armpits."+
"Lower to your chin or just below." +
"Grab just outside your shoulders or a little wider."+
"Also try using the 'V-grip' handle.",
                                                "Start off standing in front of a cable machine, attaching a rope to the high pulley and grabbing the attachment with an overhand (palms down) grip." +

"Keeping your abs drawn in, back straight and elbows in at your sides, push the rope down towards your thighs." +
"As you push down towards your thighs, split the rope apart at the bottom and isolate the tricep muscle." +
"Hold this position for a count and return back up to the starting position." +
"Repeat for as many reps and sets as desired."};

        public static string[] mstWrkouts = {"Lie on your weights bench, slightly arch your back and put your feet flat on the ground. Take a dumbbell in each hand. Stretch your arms out vertically, bringing the dumbbells together. Remember to pull your shoulders back and contract your pectoral muscles. From this high position, slowly lower the dumbbells down to each side of your chest. Without bouncing back, contract your pecs and press (push) the dumbbells back up, bringing them together as they reach the top (the dumbbells should touch at the end of movement = converging movement).",
                                              "Stand with the bar on your upper-back, and your feet shoulder-width apartSquat down by pushing your knees to the side while moving hips backBreak parallel by Squatting down until your hips are lower than your kneesSquat back up while keeping your knees out and chest upStand with your hips and knees locked at the top",
                                             "Stand with your mid-foot under the bar (medium stance)Bend over and grab the bar (palms down, medium-grip)Unlock your knees while keeping your hips highLift your chest and straighten your backPull the bar against your lower chest",
                                             "Lie down on a bench or the floor holding a pair of dumbbells directly above your chest with your palms facing each other. Your feet should be flat on the floor.Without moving your upper arms, bend your elbows and slowly lower the weights toward the sides of your head. Avoid flaring your elbows.Reverse the move to return to the starting position."};
       public static int currWorkoutNum;
        public Description()
        {
            InitializeComponent();
        }

        public Description(string experience, int decision, string currWorkout)
        {
            currWorkoutNum = decision;
            InitializeComponent();
            if (experience == "Beginner")
            {
                labelWorkout.Text = currWorkout + ":";
                labelExp.Text = experience;
                textBoxDesc.Text = begWrkouts[decision];
            }
            else if (experience == "Master")
            {
                labelWorkout.Text = currWorkout + ":";
                labelExp.Text = experience;
                textBoxDesc.Text = mstWrkouts[decision];
            }
        }

        private void Description_Load(object sender, EventArgs e)
        {
            /*Map m = new Map();
            Hide();
            m.ShowDialog();
            Close();
            */    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage();
            Hide();
            h.ShowDialog();
            Close();
        }
        private void LinkLabelToMap_LinkClicked(object sender, EventArgs e)
        {
            Map showLocation = new Map(labelExp.Text, currWorkoutNum);
            showLocation.ShowDialog();
        }
    }
}
