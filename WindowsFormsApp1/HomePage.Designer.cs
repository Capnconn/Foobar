﻿namespace WindowsFormsApp1
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelExercises = new System.Windows.Forms.Label();
            this.linkLabelWrkout1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelWrkout2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelWrkout3 = new System.Windows.Forms.LinkLabel();
            this.linkLabelWrkout4 = new System.Windows.Forms.LinkLabel();
            this.buttonSignout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(59, 34);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(111, 39);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Hello!";
            this.labelUsername.Click += new System.EventHandler(this.labelFirst_Click);
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExercises.ForeColor = System.Drawing.Color.White;
            this.labelExercises.Location = new System.Drawing.Point(274, 88);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(223, 25);
            this.labelExercises.TabIndex = 2;
            this.labelExercises.Text = "Suggested Exercises:";
            // 
            // linkLabelWrkout1
            // 
            this.linkLabelWrkout1.AutoSize = true;
            this.linkLabelWrkout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWrkout1.ForeColor = System.Drawing.Color.White;
            this.linkLabelWrkout1.LinkColor = System.Drawing.Color.White;
            this.linkLabelWrkout1.Location = new System.Drawing.Point(334, 156);
            this.linkLabelWrkout1.Name = "linkLabelWrkout1";
            this.linkLabelWrkout1.Size = new System.Drawing.Size(110, 25);
            this.linkLabelWrkout1.TabIndex = 3;
            this.linkLabelWrkout1.TabStop = true;
            this.linkLabelWrkout1.Text = "linkLabel1";
            this.linkLabelWrkout1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // linkLabelWrkout2
            // 
            this.linkLabelWrkout2.AutoSize = true;
            this.linkLabelWrkout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWrkout2.ForeColor = System.Drawing.Color.White;
            this.linkLabelWrkout2.LinkColor = System.Drawing.Color.White;
            this.linkLabelWrkout2.Location = new System.Drawing.Point(334, 201);
            this.linkLabelWrkout2.Name = "linkLabelWrkout2";
            this.linkLabelWrkout2.Size = new System.Drawing.Size(110, 25);
            this.linkLabelWrkout2.TabIndex = 4;
            this.linkLabelWrkout2.TabStop = true;
            this.linkLabelWrkout2.Text = "linkLabel2";
            this.linkLabelWrkout2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // linkLabelWrkout3
            // 
            this.linkLabelWrkout3.AutoSize = true;
            this.linkLabelWrkout3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWrkout3.ForeColor = System.Drawing.Color.White;
            this.linkLabelWrkout3.LinkColor = System.Drawing.Color.White;
            this.linkLabelWrkout3.Location = new System.Drawing.Point(334, 249);
            this.linkLabelWrkout3.Name = "linkLabelWrkout3";
            this.linkLabelWrkout3.Size = new System.Drawing.Size(110, 25);
            this.linkLabelWrkout3.TabIndex = 5;
            this.linkLabelWrkout3.TabStop = true;
            this.linkLabelWrkout3.Text = "linkLabel3";
            this.linkLabelWrkout3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
            // 
            // linkLabelWrkout4
            // 
            this.linkLabelWrkout4.AutoSize = true;
            this.linkLabelWrkout4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWrkout4.ForeColor = System.Drawing.Color.White;
            this.linkLabelWrkout4.LinkColor = System.Drawing.Color.White;
            this.linkLabelWrkout4.Location = new System.Drawing.Point(334, 296);
            this.linkLabelWrkout4.Name = "linkLabelWrkout4";
            this.linkLabelWrkout4.Size = new System.Drawing.Size(110, 25);
            this.linkLabelWrkout4.TabIndex = 6;
            this.linkLabelWrkout4.TabStop = true;
            this.linkLabelWrkout4.Text = "linkLabel4";
            this.linkLabelWrkout4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
            // 
            // buttonSignout
            // 
            this.buttonSignout.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignout.ForeColor = System.Drawing.Color.White;
            this.buttonSignout.Location = new System.Drawing.Point(670, 12);
            this.buttonSignout.Name = "buttonSignout";
            this.buttonSignout.Size = new System.Drawing.Size(118, 39);
            this.buttonSignout.TabIndex = 7;
            this.buttonSignout.Text = "Sign Out";
            this.buttonSignout.UseVisualStyleBackColor = false;
            this.buttonSignout.Click += new System.EventHandler(this.ButtonSignout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignout);
            this.Controls.Add(this.linkLabelWrkout4);
            this.Controls.Add(this.linkLabelWrkout3);
            this.Controls.Add(this.linkLabelWrkout2);
            this.Controls.Add(this.linkLabelWrkout1);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.labelUsername);
            this.Name = "HomePage";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.LinkLabel linkLabelWrkout1;
        private System.Windows.Forms.LinkLabel linkLabelWrkout2;
        private System.Windows.Forms.LinkLabel linkLabelWrkout3;
        private System.Windows.Forms.LinkLabel linkLabelWrkout4;
        private System.Windows.Forms.Button buttonSignout;
    }
}