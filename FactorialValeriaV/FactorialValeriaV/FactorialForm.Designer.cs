namespace FactorialValeriaV
{
    partial class frmFactorial
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInteraction = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lstFactors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInteraction
            // 
            this.lblInteraction.AutoSize = true;
            this.lblInteraction.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInteraction.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblInteraction.Location = new System.Drawing.Point(38, 77);
            this.lblInteraction.Name = "lblInteraction";
            this.lblInteraction.Size = new System.Drawing.Size(191, 34);
            this.lblInteraction.TabIndex = 0;
            this.lblInteraction.Text = "Enter an integer";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserAnswer.Location = new System.Drawing.Point(256, 77);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(82, 38);
            this.txtUserAnswer.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStart.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(156, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 44);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Olive;
            this.lblAnswer.Location = new System.Drawing.Point(161, 318);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(102, 25);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "!Factorial";
            // 
            // lstFactors
            // 
            this.lstFactors.FormattingEnabled = true;
            this.lstFactors.Location = new System.Drawing.Point(72, 204);
            this.lstFactors.Name = "lstFactors";
            this.lstFactors.Size = new System.Drawing.Size(284, 95);
            this.lstFactors.TabIndex = 5;
            // 
            // frmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 385);
            this.Controls.Add(this.lstFactors);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblInteraction);
            this.Name = "frmFactorial";
            this.Text = "Factorial by Valeria V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInteraction;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ListBox lstFactors;
    }
}

