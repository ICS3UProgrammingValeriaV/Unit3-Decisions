namespace RockPaperScissorsValerV
{
    partial class frmRockPaperScissors
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
            this.lblUser = new System.Windows.Forms.Label();
            this.radScissorsUser = new System.Windows.Forms.RadioButton();
            this.radPaperUser = new System.Windows.Forms.RadioButton();
            this.radRockUser = new System.Windows.Forms.RadioButton();
            this.lblComputer = new System.Windows.Forms.Label();
            this.radRockComp = new System.Windows.Forms.RadioButton();
            this.radPaperComp = new System.Windows.Forms.RadioButton();
            this.radScissorsComp = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(167, 34);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User\'s Choice";
            // 
            // radScissorsUser
            // 
            this.radScissorsUser.AutoSize = true;
            this.radScissorsUser.Image = global::RockPaperScissorsValerV.Properties.Resources.Scissors;
            this.radScissorsUser.Location = new System.Drawing.Point(30, 259);
            this.radScissorsUser.Name = "radScissorsUser";
            this.radScissorsUser.Size = new System.Drawing.Size(114, 100);
            this.radScissorsUser.TabIndex = 3;
            this.radScissorsUser.UseVisualStyleBackColor = true;
            this.radScissorsUser.CheckedChanged += new System.EventHandler(this.radScissorsUser_CheckedChanged);
            // 
            // radPaperUser
            // 
            this.radPaperUser.AutoSize = true;
            this.radPaperUser.Image = global::RockPaperScissorsValerV.Properties.Resources.paper;
            this.radPaperUser.Location = new System.Drawing.Point(30, 153);
            this.radPaperUser.Name = "radPaperUser";
            this.radPaperUser.Size = new System.Drawing.Size(114, 100);
            this.radPaperUser.TabIndex = 2;
            this.radPaperUser.UseVisualStyleBackColor = true;
            this.radPaperUser.CheckedChanged += new System.EventHandler(this.radPaperUser_CheckedChanged);
            // 
            // radRockUser
            // 
            this.radRockUser.AutoSize = true;
            this.radRockUser.Image = global::RockPaperScissorsValerV.Properties.Resources.rock3;
            this.radRockUser.Location = new System.Drawing.Point(30, 47);
            this.radRockUser.Name = "radRockUser";
            this.radRockUser.Size = new System.Drawing.Size(114, 100);
            this.radRockUser.TabIndex = 1;
            this.radRockUser.UseVisualStyleBackColor = true;
            this.radRockUser.CheckedChanged += new System.EventHandler(this.radRockUser_CheckedChanged);
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblComputer.Location = new System.Drawing.Point(-6, 0);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(225, 34);
            this.lblComputer.TabIndex = 4;
            this.lblComputer.Text = "Computer\'s Choice";
            // 
            // radRockComp
            // 
            this.radRockComp.AutoSize = true;
            this.radRockComp.Enabled = false;
            this.radRockComp.Image = global::RockPaperScissorsValerV.Properties.Resources.rock3;
            this.radRockComp.Location = new System.Drawing.Point(40, 259);
            this.radRockComp.Name = "radRockComp";
            this.radRockComp.Size = new System.Drawing.Size(114, 100);
            this.radRockComp.TabIndex = 5;
            this.radRockComp.UseVisualStyleBackColor = true;
            // 
            // radPaperComp
            // 
            this.radPaperComp.AutoSize = true;
            this.radPaperComp.Enabled = false;
            this.radPaperComp.Image = global::RockPaperScissorsValerV.Properties.Resources.paper;
            this.radPaperComp.Location = new System.Drawing.Point(40, 47);
            this.radPaperComp.Name = "radPaperComp";
            this.radPaperComp.Size = new System.Drawing.Size(114, 100);
            this.radPaperComp.TabIndex = 6;
            this.radPaperComp.UseVisualStyleBackColor = true;
            // 
            // radScissorsComp
            // 
            this.radScissorsComp.AutoSize = true;
            this.radScissorsComp.Enabled = false;
            this.radScissorsComp.Image = global::RockPaperScissorsValerV.Properties.Resources.Scissors;
            this.radScissorsComp.Location = new System.Drawing.Point(40, 153);
            this.radScissorsComp.Name = "radScissorsComp";
            this.radScissorsComp.Size = new System.Drawing.Size(114, 100);
            this.radScissorsComp.TabIndex = 7;
            this.radScissorsComp.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(170, 415);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 56);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.lblUser);
            this.grbUser.Controls.Add(this.radRockUser);
            this.grbUser.Controls.Add(this.radPaperUser);
            this.grbUser.Controls.Add(this.radScissorsUser);
            this.grbUser.Location = new System.Drawing.Point(35, 40);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(200, 369);
            this.grbUser.TabIndex = 9;
            this.grbUser.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComputer);
            this.groupBox1.Controls.Add(this.radPaperComp);
            this.groupBox1.Controls.Add(this.radScissorsComp);
            this.groupBox1.Controls.Add(this.radRockComp);
            this.groupBox1.Location = new System.Drawing.Point(241, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 369);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbUser);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Valeria V";
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.RadioButton radRockUser;
        private System.Windows.Forms.RadioButton radPaperUser;
        private System.Windows.Forms.RadioButton radScissorsUser;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.RadioButton radRockComp;
        private System.Windows.Forms.RadioButton radPaperComp;
        private System.Windows.Forms.RadioButton radScissorsComp;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

