namespace WindowsFormsApp1
{
    partial class Account
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
            this.labelFN = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.labelLN = new System.Windows.Forms.Label();
            this.textBoxUN = new System.Windows.Forms.TextBox();
            this.labelUN = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.labelPW = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.labelE = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonBM = new System.Windows.Forms.RadioButton();
            this.radioButtonBH = new System.Windows.Forms.RadioButton();
            this.labelG = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCheck = new System.Windows.Forms.Label();
            this.labelCheckEmpty = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.ForeColor = System.Drawing.Color.White;
            this.labelFN.Location = new System.Drawing.Point(122, 80);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(116, 25);
            this.labelFN.TabIndex = 0;
            this.labelFN.Text = "First Name";
            this.labelFN.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxFN
            // 
            this.textBoxFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFN.ForeColor = System.Drawing.Color.White;
            this.textBoxFN.Location = new System.Drawing.Point(259, 83);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(116, 30);
            this.textBoxFN.TabIndex = 1;
            // 
            // textBoxLN
            // 
            this.textBoxLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLN.ForeColor = System.Drawing.Color.White;
            this.textBoxLN.Location = new System.Drawing.Point(259, 127);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(116, 30);
            this.textBoxLN.TabIndex = 3;
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLN.ForeColor = System.Drawing.Color.White;
            this.labelLN.Location = new System.Drawing.Point(122, 124);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(115, 25);
            this.labelLN.TabIndex = 2;
            this.labelLN.Text = "Last Name";
            // 
            // textBoxUN
            // 
            this.textBoxUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUN.ForeColor = System.Drawing.Color.White;
            this.textBoxUN.Location = new System.Drawing.Point(259, 172);
            this.textBoxUN.Name = "textBoxUN";
            this.textBoxUN.Size = new System.Drawing.Size(116, 30);
            this.textBoxUN.TabIndex = 5;
            // 
            // labelUN
            // 
            this.labelUN.AutoSize = true;
            this.labelUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUN.ForeColor = System.Drawing.Color.White;
            this.labelUN.Location = new System.Drawing.Point(119, 169);
            this.labelUN.Name = "labelUN";
            this.labelUN.Size = new System.Drawing.Size(119, 25);
            this.labelUN.TabIndex = 4;
            this.labelUN.Text = "User Name";
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP.ForeColor = System.Drawing.Color.White;
            this.textBoxP.Location = new System.Drawing.Point(259, 220);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(116, 30);
            this.textBoxP.TabIndex = 7;
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPW.ForeColor = System.Drawing.Color.White;
            this.labelPW.Location = new System.Drawing.Point(131, 218);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(106, 25);
            this.labelPW.TabIndex = 6;
            this.labelPW.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonM);
            this.panel1.Controls.Add(this.radioButtonB);
            this.panel1.Controls.Add(this.labelE);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(425, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 66);
            this.panel1.TabIndex = 8;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(154, 31);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(99, 29);
            this.radioButtonM.TabIndex = 12;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Master";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(3, 31);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(119, 29);
            this.radioButtonB.TabIndex = 11;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "Beginner";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(64, 3);
            this.labelE.Name = "labelE";
            this.labelE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelE.Size = new System.Drawing.Size(120, 25);
            this.labelE.TabIndex = 10;
            this.labelE.Text = "Experience";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(338, 291);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(127, 39);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonBM);
            this.panel2.Controls.Add(this.radioButtonBH);
            this.panel2.Controls.Add(this.labelG);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(425, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 66);
            this.panel2.TabIndex = 13;
            // 
            // radioButtonBM
            // 
            this.radioButtonBM.AutoSize = true;
            this.radioButtonBM.Location = new System.Drawing.Point(154, 33);
            this.radioButtonBM.Name = "radioButtonBM";
            this.radioButtonBM.Size = new System.Drawing.Size(156, 29);
            this.radioButtonBM.TabIndex = 12;
            this.radioButtonBM.TabStop = true;
            this.radioButtonBM.Text = "Build Muscle";
            this.radioButtonBM.UseVisualStyleBackColor = true;
            // 
            // radioButtonBH
            // 
            this.radioButtonBH.AutoSize = true;
            this.radioButtonBH.Location = new System.Drawing.Point(3, 33);
            this.radioButtonBH.Name = "radioButtonBH";
            this.radioButtonBH.Size = new System.Drawing.Size(151, 29);
            this.radioButtonBH.TabIndex = 11;
            this.radioButtonBH.TabStop = true;
            this.radioButtonBH.Text = "Be Healthier";
            this.radioButtonBH.UseVisualStyleBackColor = true;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(95, 5);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(68, 25);
            this.labelG.TabIndex = 10;
            this.labelG.Text = "Goals";
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(479, 349);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 40);
            this.buttonLogin.TabIndex = 14;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Already have an account?";
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.BackColor = System.Drawing.Color.DarkOrange;
            this.labelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck.ForeColor = System.Drawing.Color.White;
            this.labelCheck.Location = new System.Drawing.Point(375, 333);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(0, 24);
            this.labelCheck.TabIndex = 16;
            // 
            // labelCheckEmpty
            // 
            this.labelCheckEmpty.AutoSize = true;
            this.labelCheckEmpty.BackColor = System.Drawing.Color.DarkOrange;
            this.labelCheckEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckEmpty.ForeColor = System.Drawing.Color.White;
            this.labelCheckEmpty.Location = new System.Drawing.Point(360, 365);
            this.labelCheckEmpty.Name = "labelCheckEmpty";
            this.labelCheckEmpty.Size = new System.Drawing.Size(0, 24);
            this.labelCheckEmpty.TabIndex = 17;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCheckEmpty);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.textBoxUN);
            this.Controls.Add(this.labelUN);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.labelFN);
            this.Name = "Account";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.TextBox textBoxUN;
        private System.Windows.Forms.Label labelUN;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonBM;
        private System.Windows.Forms.RadioButton radioButtonBH;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.Label labelCheckEmpty;
    }
}