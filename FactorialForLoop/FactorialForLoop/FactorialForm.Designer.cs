namespace FactorialForLoop
{
    partial class frmFactorial
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
            this.lblAsk = new System.Windows.Forms.Label();
            this.txtUserChoice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Font = new System.Drawing.Font("Impact", 20F);
            this.lblAsk.Location = new System.Drawing.Point(41, 64);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(201, 34);
            this.lblAsk.TabIndex = 0;
            this.lblAsk.Text = "Enter an integer: ";
            // 
            // txtUserChoice
            // 
            this.txtUserChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserChoice.Location = new System.Drawing.Point(264, 60);
            this.txtUserChoice.Name = "txtUserChoice";
            this.txtUserChoice.Size = new System.Drawing.Size(100, 38);
            this.txtUserChoice.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(143, 113);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(143, 200);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstNumbers.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswer.Location = new System.Drawing.Point(119, 317);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(171, 28);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Enter an integer: ";
            // 
            // frmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 390);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtUserChoice);
            this.Controls.Add(this.lblAsk);
            this.Name = "frmFactorial";
            this.Text = "Factorial For Loop by Valeria V";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.TextBox txtUserChoice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblAnswer;
    }
}

