namespace RunnigAverageValeriaV
{
    partial class frmRunningAverage
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
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblLeave = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCondition.Location = new System.Drawing.Point(-4, 36);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(219, 50);
            this.lblCondition.TabIndex = 0;
            this.lblCondition.Text = "    Enter a number\r\n between 0 and 100";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtAnswer.Location = new System.Drawing.Point(237, 46);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(56, 40);
            this.txtAnswer.TabIndex = 1;
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeave.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblLeave.Location = new System.Drawing.Point(12, 97);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(185, 16);
            this.lblLeave.TabIndex = 2;
            this.lblLeave.Text = "(To end the program press -1)\r\n";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Ivory;
            this.btnCheck.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCheck.Location = new System.Drawing.Point(104, 137);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(93, 35);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAverage.Location = new System.Drawing.Point(53, 198);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(99, 25);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 276);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblCondition);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average by Valeria V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblAverage;
    }
}

